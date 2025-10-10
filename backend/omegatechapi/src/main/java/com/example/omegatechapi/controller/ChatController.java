/* Lógica Mapeada da BLL: ChatBLL.cs.

Endpoints que ele conteria:

GET /api/chat/{ticketId}/mensagens: Para buscar as mensagens de um chat associado a um ticket.

POST /api/chat/{ticketId}/mensagens: Para um usuário ou técnico enviar uma nova mensagem. */
package com.example.omegatechapi.controller;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/chat")

public class ChatController {
}
