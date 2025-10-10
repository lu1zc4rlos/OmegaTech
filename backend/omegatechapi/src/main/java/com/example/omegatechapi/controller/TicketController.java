package com.example.omegatechapi.controller;

/*

A Lógica da Arquitetura REST
Em uma API REST bem-organizada, os controllers são agrupados pelo recurso que eles manipulam, não pela tecnologia que usam internamente.

Para gerenciar usuários, temos a UsuarioController.

Para gerenciar autenticação, temos a AuthController.

Portanto, para gerenciar tickets, teremos uma TicketController.

O fato de você usar a OpenAI é um detalhe de implementação da sua lógica de negócio. O cliente (frontend) não precisa saber disso; ele só precisa saber que está enviando uma mensagem para criar um ticket.

Como a Estrutura Ficaria
Você adicionaria novas classes à sua arquitetura, seguindo o padrão que já estabelecemos:

1. Um novo DTO: CriarTicketIaRequest.java
Para receber a mensagem do usuário de forma segura.

Java

// Pacote: com.seusistema.dto
public class CriarTicketIaRequest {
    private String mensagem;

    // Getter e Setter
}
2. O Novo Controller: TicketController.java
Este será o ponto de entrada para todas as operações relacionadas a tickets.

Java

// Pacote: com.seusistema.controllers
@RestController
@RequestMapping("/api/tickets") // Todos os endpoints aqui começarão com /api/tickets
public class TicketController {

    @Autowired
    private TicketService ticketService;


     * Endpoint para criar um novo ticket a partir de uma mensagem de usuário,
     * utilizando IA para análise.

@PostMapping("/ia") // URL final: POST /api/tickets/ia
public ResponseEntity<?> criarTicketViaIA(
        @RequestBody CriarTicketIaRequest request,
        @AuthenticationPrincipal Usuario usuarioLogado) { // Pega o usuário que está fazendo a requisição

    if (request.getMensagem() == null || request.getMensagem().isBlank()) {
        return ResponseEntity.badRequest().body("A mensagem não pode estar vazia.");
    }

    // Delega toda a lógica complexa para a camada de serviço
    Ticket novoTicket = ticketService.criarTicketComIa(request.getMensagem(), usuarioLogado);

    return ResponseEntity.status(201).body(novoTicket);
}

// --- Outros endpoints para tickets poderiam vir aqui ---
// Ex: GET /api/tickets/{id} -> para buscar um ticket
// Ex: GET /api/tickets -> para listar os tickets do usuário logado
}
        3. A Lógica na Camada de Serviço
A mágica toda acontece nos serviços. O controller permanece simples.

a) TicketService.java (Novo)
Este serviço orquestra a criação do ticket.

        Java

// Pacote: com.seusistema.services
@Service
public class TicketService {

    @Autowired
    private TicketRepository ticketRepository;

    @Autowired
    private OpenAiService openAiService; // Um novo serviço para falar com a OpenAI

    public Ticket criarTicketComIa(String mensagem, Usuario autor) {
        // 1. Chama o serviço da OpenAI para analisar a mensagem
        AnaliseIaResponse analise = openAiService.analisarMensagemParaTicket(mensagem);

        // 2. Cria a entidade Ticket com os dados retornados pela IA
        Ticket novoTicket = new Ticket();
        novoTicket.setTitulo(analise.getTituloSugerido()); // Ex: "Problema com a impressora"
        novoTicket.setDescricao(mensagem);
        novoTicket.setPrioridade(analise.getPrioridadeSugerida()); // Ex: "ALTA"
        novoTicket.setCategoria(analise.getCategoriaSugerida()); // Ex: "HARDWARE"
        novoTicket.setUsuario(autor); // Associa o ticket ao usuário que o criou
        novoTicket.setStatus(StatusTicket.ABERTO);

        // 3. Salva no banco de dados
        return ticketRepository.save(novoTicket);
    }
}
b) OpenAiService.java (Novo)
É uma excelente prática isolar a comunicação com APIs externas em suas próprias classes.

Java

// Pacote: com.seusistema.services
@Service
public class OpenAiService {

    // (Configuração do cliente HTTP para a API da OpenAI viria aqui)

    public AnaliseIaResponse analisarMensagemParaTicket(String mensagem) {
        // 1. Monta o "prompt" para a OpenAI
        String prompt = "Analise a seguinte solicitação de suporte de um usuário e extraia um título curto, uma categoria (SOFTWARE, HARDWARE, REDES) e uma prioridade (BAIXA, MEDIA, ALTA). Retorne um JSON com os campos 'titulo', 'categoria' e 'prioridade'. Mensagem do usuário: \"" + mensagem + "\"";

        // 2. Faz a chamada para a API da OpenAI
        // String respostaJson = ... faz a chamada HTTP ...

        // 3. Converte a resposta JSON da OpenAI para um objeto AnaliseIaResponse
        // AnaliseIaResponse analise = ... converte o JSON ...

        // 4. Retorna o objeto com os dados estruturados
        return analise;
    }
}
(Você também precisaria criar a classe AnaliseIaResponse para mapear a resposta da IA).

Resumo do Fluxo
Requisição: POST para /api/tickets/ia com a mensagem.

        TicketController recebe, valida e chama o TicketService.

TicketService chama o OpenAiService.

OpenAiService conversa com a OpenAI e retorna dados estruturados (título, categoria, etc.).

TicketService usa esses dados para criar um objeto Ticket.

TicketService usa o TicketRepository para salvar o ticket no banco.

A resposta de sucesso volta para o usuário.

Essa arquitetura é limpa, organizada e muito fácil de dar manutenção.

 */

public class TicketController {
}
