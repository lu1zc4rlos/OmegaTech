package com.example.omegatechapi.service;

import com.example.omegatechapi.model.*;
import com.example.omegatechapi.repository.TicketRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.http.HttpEntity;
import org.springframework.http.HttpMethod;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestTemplate;

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

    public List<TicketResponseDTO> findTicketsByUserIdAndStatus(Long clienteId, String statusFilter) {

        List<Ticket> tickets;

        String cleanedStatus = (statusFilter != null) ? statusFilter.trim().toUpperCase() : null;

        if (cleanedStatus == null || cleanedStatus.isEmpty() || cleanedStatus.equals("todos")) {
            tickets = ticketRepository.findByClienteId(clienteId);
        } else {
            try {
                Status statusEnum = convertToStatus(cleanedStatus);
                tickets = ticketRepository.findByClienteIdAndStatus(clienteId, statusEnum);

            } catch (IllegalArgumentException e) {
                System.err.println("Filtro de Status inválido: " + cleanedStatus);
                return List.of();
            }        }

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

}

