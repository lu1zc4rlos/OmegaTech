package com.example.omegatechapi.service;

import com.example.omegatechapi.model.*;
import com.example.omegatechapi.repository.TicketRepository;
import com.example.omegatechapi.repository.UsuarioRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.http.HttpEntity;
import org.springframework.http.HttpMethod;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestTemplate;
import jakarta.transaction.Transactional;

import org.springframework.http.HttpHeaders;
import java.time.LocalDate;
import java.util.Arrays;
import java.util.HashMap;
import java.util.List;
import java.util.Map;
import java.util.stream.Collectors;

@Service
@RequiredArgsConstructor
public class TicketService {

    private final TicketRepository ticketRepository;
    private final UsuarioRepository usuarioRepository;

    @Value("${openai.api.key}")
    private String openAiApiKey;

    private static final String OPENAI_URL = "https://api.openai.com/v1/chat/completions";
    public void criarTicket(String mensagem, Usuario usuario) {

        TicketClassificado detalhesIA = classificarTicketComIA(mensagem);

        Ticket novoTicket = new Ticket();

        novoTicket.setDescricao(mensagem);
        novoTicket.setCliente(usuario);
        novoTicket.setDataCriacao(LocalDate.now());

        novoTicket.setStatus(Status.PENDENTE);
        novoTicket.setTitulo(detalhesIA.titulo);
        novoTicket.setPrioridade(detalhesIA.prioridade);

        ticketRepository.save(novoTicket);

    }

    private TicketClassificado classificarTicketComIA(String mensagem) {
        try {
            String systemPrompt = "Você é um classificador de tickets de TI. Analise a mensagem do usuário."
                    + " Você DEVE responder APENAS com duas palavras separadas por vírgula."
                    + " A primeira palavra deve ser um 'TipoProblema' da lista: " + Arrays.toString(TipoProblema.values())
                    + " A segunda palavra deve ser uma 'Prioridade' da lista: " + Arrays.toString(Prioridade.values())
                    + " Exemplo de resposta: COMPUTADOR_TRAVANDO,ALTA";

            String respostaIA = enviarParaOpenAI(systemPrompt, mensagem);

            String[] partes = respostaIA.trim().split(",");

            if (partes.length == 2) {
                TipoProblema titulo = TipoProblema.valueOf(partes[0].trim());
                Prioridade prioridade = Prioridade.valueOf(partes[1].trim());
                return new TicketClassificado(titulo, prioridade);
            }
        } catch (Exception e) {
            System.err.println("Erro ao classificar com IA: " + e.getMessage());
        }

        return new TicketClassificado(TipoProblema.SOLICITACAO_DE_ATENDIMENTO_REMOTO, Prioridade.MEDIA);
    }

    private static class TicketClassificado {
        TipoProblema titulo;
        Prioridade prioridade;

        TicketClassificado(TipoProblema titulo, Prioridade prioridade) {
            this.titulo = titulo;
            this.prioridade = prioridade;
        }
    }

    private String enviarParaOpenAI(String systemPrompt, String userPrompt) {
        RestTemplate restTemplate = new RestTemplate();

        Map<String, Object> body = new HashMap<>();
        body.put("model", "gpt-4o-mini"); // Modelo rápido e barato
        body.put("temperature", 0.0); // 0.0 para respostas diretas
        body.put("messages", List.of(
                Map.of("role", "system", "content", systemPrompt),
                Map.of("role", "user", "content", userPrompt)
        ));

        HttpHeaders headers = new HttpHeaders();
        headers.setContentType(MediaType.APPLICATION_JSON);
        headers.setBearerAuth(openAiApiKey);

        HttpEntity<Map<String, Object>> request = new HttpEntity<>(body, headers);

        try {
            ResponseEntity<Map> response = restTemplate.exchange(
                    OPENAI_URL,
                    HttpMethod.POST,
                    request,
                    Map.class
            );

            List<Map<String, Object>> choices = (List<Map<String, Object>>) response.getBody().get("choices");
            if (choices != null && !choices.isEmpty()) {
                Map<String, Object> message = (Map<String, Object>) choices.get(0).get("message");
                return message.get("content").toString().trim();
            }

            return "";
        } catch (Exception e) {
            System.err.println("Erro ao conectar à OpenAI: " + e.getMessage());
            throw e;
        }
    }

    public List<TicketResponseDTO> findTicketsByUserIdAndStatus(Long userId, String statusFilter) {

        Usuario usuario = usuarioRepository.findById(userId)
                .orElseThrow(() -> new RuntimeException("Usuário não encontrado na busca de tickets."));

        boolean isTecnico = usuario.getPerfil().equals(Perfil.ROLE_TECNICO);

        List<Ticket> tickets;
        String cleanedStatus = (statusFilter != null) ? statusFilter.trim().toUpperCase() : null;

        if (cleanedStatus == null || cleanedStatus.isEmpty() || cleanedStatus.equals("TODOS")) {

            if (isTecnico) {
                tickets = ticketRepository.findAll();
            } else {
                tickets = ticketRepository.findByClienteId(userId);
            }

        } else {
            try {
                Status statusEnum = convertToStatus(cleanedStatus);

                if (isTecnico) {
                    tickets = ticketRepository.findByStatus(statusEnum);
                } else {
                    tickets = ticketRepository.findByClienteIdAndStatus(userId, statusEnum);
                }

            } catch (IllegalArgumentException e) {
                System.err.println("Filtro de Status inválido: " + cleanedStatus);
                return List.of();
            }
        }

        return tickets.stream()
                .map(this::toDto)
                .collect(Collectors.toList());
    }

    private Status convertToStatus(String statusStr) throws IllegalArgumentException {
        String upperCaseStatus = statusStr.toUpperCase();

        return Status.valueOf(upperCaseStatus);
    }

    private TicketResponseDTO toDto(Ticket ticket) {
        TicketResponseDTO dto = new TicketResponseDTO();
        dto.setId(ticket.getId());
        dto.setTitulo(ticket.getTitulo() != null ? ticket.getTitulo().toString() : null);
        dto.setDescricao(ticket.getDescricao());
        dto.setDataCriacao(ticket.getDataCriacao());
        dto.setPrioridade(ticket.getPrioridade() != null ? ticket.getPrioridade().toString() : null);
        dto.setStatus(ticket.getStatus() != null ? ticket.getStatus().toString() : null);
        dto.setResposta(ticket.getResposta());

        if (ticket.getCliente() != null) {
            dto.setClienteId(ticket.getCliente().getId());
            dto.setNomeCliente(ticket.getCliente().getNome());
        }

        if (ticket.getTecnicoAtribuido() != null) {
            dto.setTecnicoId(ticket.getTecnicoAtribuido().getId());
            dto.setNomeTecnico(ticket.getTecnicoAtribuido().getNome());
        }

        return dto;
    }
    @Transactional
    public void atualizarStatus(Long ticketId, String novoStatusStr, Usuario tecnico) {

        Ticket ticket = ticketRepository.findById(ticketId)
                .orElseThrow(() -> new RuntimeException("Ticket não encontrado."));

        Status novoStatus = Status.valueOf(novoStatusStr.toUpperCase());

        if (novoStatus == Status.EM_ANDAMENTO) {
            if (ticket.getStatus() != Status.PENDENTE) {
                throw new IllegalArgumentException("Não é possível iniciar um ticket que já está em " + ticket.getStatus());
            }
            // Atribui o ticket ao técnico que está clicando em "Iniciar"
            ticket.setTecnicoAtribuido(tecnico);

        } else if (novoStatus == Status.CONCLUIDO) {
            if (ticket.getStatus() != Status.EM_ANDAMENTO) {
                throw new IllegalArgumentException("Um ticket só pode ser concluído se estiver 'Em Andamento'.");
            }
        } else {
            throw new IllegalArgumentException("Transição de status inválida para: " + novoStatusStr);
        }

        ticket.setStatus(novoStatus);

        ticketRepository.save(ticket);
    }
    public TicketResponseDTO buscarTicketPorId(Long ticketId, Long userId, Perfil perfil) {

        Ticket ticket = ticketRepository.findById(ticketId)
                .orElseThrow(() -> new RuntimeException("Ticket não encontrado."));

        if (perfil.equals(Perfil.ROLE_CLIENTE) && !ticket.getCliente().getId().equals(userId)) {
            throw new SecurityException("Acesso negado. Este ticket não pertence a este cliente.");
        }
        return toDto(ticket);
    }
    @Transactional
    public void responderTicket(Long ticketId, String resposta, Usuario tecnico) {

        Ticket ticket = ticketRepository.findById(ticketId)
                .orElseThrow(() -> new RuntimeException("Ticket não encontrado."));

        if (ticket.getTecnicoAtribuido() == null) {
            ticket.setTecnicoAtribuido(tecnico);

        } else if (!ticket.getTecnicoAtribuido().getId().equals(tecnico.getId())) {
            throw new SecurityException("Ação proibida. Este ticket está em atendimento por outro técnico.");
        }

        if (ticket.getStatus() == Status.CONCLUIDO) {
            throw new IllegalArgumentException("Não é possível responder/concluir um ticket que já está finalizado.");
        }
        if (resposta == null || resposta.trim().isEmpty()) {
            throw new IllegalArgumentException("A resposta do técnico não pode ser vazia.");
        }

        ticket.setResposta(resposta);
        ticket.setStatus(Status.CONCLUIDO);

        ticketRepository.save(ticket);
    }
    @Transactional
    public void excluirTicket(Long ticketId, Long clienteId) {

        Ticket ticket = ticketRepository.findById(ticketId)
                .orElseThrow(() -> new RuntimeException("Ticket não encontrado."));

        if (!ticket.getCliente().getId().equals(clienteId)) {
            throw new SecurityException("Acesso negado. Você não é o dono deste ticket.");
        }

        Status statusAtual = ticket.getStatus();

        if (statusAtual != Status.PENDENTE) {
            throw new IllegalArgumentException("O ticket só pode ser excluído se o status for PENDENTE. Status atual: " + statusAtual);
        }

        ticketRepository.delete(ticket);
    }

}

