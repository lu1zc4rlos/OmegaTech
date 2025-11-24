package com.example.omegatechapi.controller;

import com.example.omegatechapi.model.MensagemRequest;
import com.example.omegatechapi.model.Ticket;
import com.example.omegatechapi.model.TicketResponseDTO;
import com.example.omegatechapi.model.Usuario;
import com.example.omegatechapi.service.TicketService;
import com.example.omegatechapi.service.AuthService;
import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.security.access.prepost.PreAuthorize;
import org.springframework.security.core.annotation.AuthenticationPrincipal;
import org.springframework.web.bind.annotation.*;

import java.security.Principal;
import java.util.List;

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

    @GetMapping("/meus")
    public ResponseEntity<List<TicketResponseDTO>> getMeusTickets(
            @RequestParam(required = false) String status,
            @AuthenticationPrincipal Usuario usuarioAutenticado) { // Usamos o objeto Usuario completo

        if (usuarioAutenticado == null || usuarioAutenticado.getId() == null) {
            // Salvaguarda: Embora o @PreAuthorize deva evitar isso, é bom verificar.
            return ResponseEntity.status(HttpStatus.UNAUTHORIZED).build();
        }

        // Obtemos o ID Long diretamente do objeto carregado e validado
        Long clienteId = usuarioAutenticado.getId();

        // Passa o ID Long para o Service (que usa findByClienteId)
        List<TicketResponseDTO> tickets = ticketService.findTicketsByUserIdAndStatus(clienteId, status);

        return ResponseEntity.ok(tickets);
    }
}
