package com.example.omegatechapi.service;

import com.example.omegatechapi.model.ChatResponse;
import com.example.omegatechapi.model.TipoResposta;
import com.example.omegatechapi.model.Usuario;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Value;
import com.example.omegatechapi.repository.ChatRepository;
import org.springframework.http.HttpEntity;
import org.springframework.http.HttpMethod;
import org.springframework.http.MediaType;
import org.springframework.http.ResponseEntity;
import org.springframework.stereotype.Service;
import org.springframework.web.client.RestTemplate;

import org.springframework.http.HttpHeaders;
import java.time.LocalDate;
import java.util.HashMap;
import java.util.List;
import java.util.Map;

@Service
@RequiredArgsConstructor
public class ChatService {
    private final ChatRepository chamadoRepository;


    @Value("${openai.api.key}")
    private String openAiApiKey;

    private static final String OPENAI_URL = "https://api.openai.com/v1/chat/completions";

    public ChatResponse processarMensagem(String mensagem, Usuario usuario) {
        Long usuarioId = usuario.getId();
        ChatResponse response = new ChatResponse();
        response.setTimestamp(LocalDate.now());

        try {
            // 🔹 1. Verificar se é uma pergunta sobre chamados
            if (ehConsultaDeChamado(mensagem)) {
                Object dados = consultarChamado(mensagem, usuario.getId());

                response.setTipo(TipoResposta.CONSULTA_BD);
                response.setDados(dados);
                response.setResposta(gerarResumoGPT(mensagem, dados));
            }
            else {
                // 🔹 2. Caso contrário, apenas responder com GPT
                String respostaGPT = enviarParaOpenAI(mensagem);
                response.setTipo(TipoResposta.GPT);
                response.setResposta(respostaGPT);
            }

        } catch (Exception e) {
            response.setTipo(TipoResposta.ERRO);
            response.setResposta("Erro ao processar: " + e.getMessage());
        }

        return response;
    }

    // ----------------------------------------------------------------------------------------

    private boolean ehConsultaDeChamado(String mensagem) {
        String texto = mensagem.toLowerCase();

        return texto.contains("chamado") ||
                texto.contains("ticket") ||
                texto.contains("atendimento");
    }

    private Object consultarChamado(String mensagem, Long usuarioId) {
        // ⚙️ Aqui você pode analisar o tipo de pergunta:
        String texto = mensagem.toLowerCase();

        if (texto.contains("último") || texto.contains("ultimo"))
            return chamadoRepository.findUltimoChamadoPorUsuario(usuarioId);
        else if (texto.contains("todos") || texto.contains("meus"))
            return chamadoRepository.findChamadosPorUsuario(usuarioId);
        else
            return chamadoRepository.findChamadosRecentes(usuarioId);
    }

    // ----------------------------------------------------------------------------------------

    private String gerarResumoGPT(String pergunta, Object dados) {
        String prompt = "Resuma em uma frase amigável a resposta do banco para a pergunta: '"
                + pergunta + "'.\n\nDados: " + dados.toString();

        return enviarParaOpenAI(prompt);
    }

    private String enviarParaOpenAI(String prompt) {
        RestTemplate restTemplate = new RestTemplate();

        Map<String, Object> body = new HashMap<>();
        body.put("model", "gpt-4o-mini");
        body.put("messages", List.of(
                Map.of("role", "system", "content", "Você é um assistente virtual especializado em suporte técnico da empresa OmegaTech. \n" +
                        "Seu papel é ajudar os usuários com dúvidas relacionadas a problemas técnicos, status de chamados, suporte a sistemas, falhas, erros e demais questões relacionadas ao atendimento técnico.\n" +
                        "\n" +
                        "Regras de conduta:\n" +
                        "- Responda **apenas** perguntas que estejam dentro do contexto de suporte técnico. \n" +
                        "- Se o usuário fizer uma pergunta fora desse escopo (como curiosidades, piadas, opiniões, assuntos pessoais, política, etc.), responda educadamente que você foi projetado apenas para auxiliar em suporte técnico.\n" +
                        "- Utilize um tom profissional, empático e objetivo.\n" +
                        "- Se o usuário perguntar sobre dados específicos (como \"qual foi meu último chamado?\"), utilize os dados fornecidos pela API para formular uma resposta clara.\n" +
                        "- Se os dados não estiverem disponíveis, diga que não há informações no momento.\n" +
                        "- Nunca invente informações, nunca crie números de protocolo ou respostas genéricas que possam induzir ao erro.\n" +
                        "\n" +
                        "Seu objetivo é ser preciso, educado e técnico.\n"),
                Map.of("role", "user", "content", prompt)
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

            return "Não encontrei nenhuma informação relevante.";
        } catch (Exception e) {
            return "Erro ao conectar à OpenAI: " + e.getMessage();
        }
    }
}
