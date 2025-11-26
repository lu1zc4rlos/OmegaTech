package com.example.omegatechapi.controller;

import com.example.omegatechapi.model.*;
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
            @AuthenticationPrincipal Usuario usuarioAutenticado) {

        if (usuarioAutenticado == null || usuarioAutenticado.getId() == null) {
            return ResponseEntity.status(HttpStatus.UNAUTHORIZED).build();
        }

        Long clienteId = usuarioAutenticado.getId();

        List<TicketResponseDTO> tickets = ticketService.findTicketsByUserIdAndStatus(clienteId, status);

        return ResponseEntity.ok(tickets);
    }
    @PutMapping("/status/{id}")
    @PreAuthorize("hasRole('ROLE_TECNICO')")
    public ResponseEntity<Void> atualizarStatus(
            @PathVariable Long id,
            @RequestBody StatusUpdateDTO request,
            @AuthenticationPrincipal Usuario tecnico) {

        ticketService.atualizarStatus(id, request.getNovoStatus(), tecnico);

        return ResponseEntity.ok().build();
    }
    @GetMapping("/{id}")
    @PreAuthorize("isAuthenticated()")
    public ResponseEntity<TicketResponseDTO> getTicketById(
            @PathVariable Long id,
            @AuthenticationPrincipal Usuario usuarioAutenticado) {

        TicketResponseDTO ticket = ticketService.buscarTicketPorId(id, usuarioAutenticado.getId(), usuarioAutenticado.getPerfil());

        return ResponseEntity.ok(ticket);
    }
    @PutMapping("/resposta/{id}")
    @PreAuthorize("hasRole('ROLE_TECNICO')")
    public ResponseEntity<Void> responderTicket(
            @PathVariable Long id,
            @RequestBody RespostaTicketDTO request,
            @AuthenticationPrincipal Usuario tecnico) {

        ticketService.responderTicket(id, request.getResposta(), tecnico);

        return ResponseEntity.ok().build();
    }
}
