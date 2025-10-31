package com.example.omegatechapi.controller;

import com.example.omegatechapi.model.AlterarSenhaRequest;
import com.example.omegatechapi.model.Usuario;
import com.example.omegatechapi.response.AuthResponse;
import com.example.omegatechapi.service.UsuarioService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/usuarios")

public class UsuarioController {

    @Autowired
    private final UsuarioService usuarioService;

    public UsuarioController(UsuarioService usuarioService) {
        this.usuarioService = usuarioService;
    }

    @PostMapping("/login")
    public ResponseEntity<AuthResponse> login(@RequestBody Usuario usuario){
        AuthResponse response = usuarioService.loginUsuario(usuario);
        return ResponseEntity.ok(response);
    }

    @PostMapping("/cadastro")
    public ResponseEntity<AuthResponse> cadastro(@RequestBody Usuario usuario){
        AuthResponse response = usuarioService.cadastrarNovoUsuario(usuario);
        return ResponseEntity.status(HttpStatus.CREATED).body(response);
    }

    @PutMapping("alterar_senha")
    public ResponseEntity<Void> alterarSenha(@RequestBody AlterarSenhaRequest request) {
        usuarioService.alterarSenha(request);
        return ResponseEntity.ok().build();
    }
}
