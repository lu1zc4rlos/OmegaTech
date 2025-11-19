package com.example.omegatechapi.controller;

import com.example.omegatechapi.model.ChatResponse;
import com.example.omegatechapi.model.MensagemRequest;
import com.example.omegatechapi.model.Usuario;
import com.example.omegatechapi.service.ChatService;
import com.example.omegatechapi.service.TicketService;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.security.core.annotation.AuthenticationPrincipal;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/tickets")
@RequiredArgsConstructor

public class TicketController {

    @Autowired
    private final TicketService ticketService;

    @PostMapping("/criar")
    public ResponseEntity<Void> criarTicket(
            @RequestBody MensagemRequest request,
            @AuthenticationPrincipal Usuario usuarioAutenticado) {

        ticketService.criarTicket(request.getMensagem(),usuarioAutenticado);
        return ResponseEntity.ok().build();
    }
}
