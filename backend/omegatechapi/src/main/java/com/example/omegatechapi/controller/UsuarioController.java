package com.example.omegatechapi.controller;

import com.example.omegatechapi.model.Usuario;
import com.example.omegatechapi.service.usuarioService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;

@RestController
@RequestMapping("/usuarios")

/* Este controller cuidaria das ações que um usuário logado pode fazer em relação à sua própria conta.

Lógica Mapeada da BLL: Parte do UsuarioBLL.cs.

Endpoints que ele conteria:

GET /api/usuarios/me: Para buscar os dados do próprio usuário logado.

PUT /api/usuarios/me: Para o usuário atualizar seus próprios dados (nome, senha, etc.). */

public class UsuarioController {

    @Autowired
    private usuarioService usuarioService;

    @GetMapping
    public ResponseEntity<List<Usuario>> listarTodos() {
        List<Usuario> usuarios = usuarioService.buscarTodosOsUsuarios();
        return ResponseEntity.ok(usuarios); // Retorna status 200 OK e a lista de usuários
    }

    @PostMapping
    public ResponseEntity<Usuario> criarUsuario(@RequestBody Usuario usuario) {
        Usuario novoUsuario = usuarioService.salvarUsuario(usuario);
        return ResponseEntity.status(201).body(novoUsuario); // Retorna status 201 Created
    }
}
