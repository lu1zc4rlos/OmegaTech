package com.example.omegatechapi.service;

import com.example.omegatechapi.model.Usuario;
import com.example.omegatechapi.repository.usuarioRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class usuarioService {

    @Autowired
    private usuarioRepository usuarioRepository;

    public List<Usuario> buscarTodosOsUsuarios() {
        // Aqui que vai a lógica de negócio.
        // Por enquanto, vou buscar todos do banco.
        return usuarioRepository.findAll();
    }

    public Usuario salvarUsuario(Usuario usuario) {
        // Lógica para salvar um novo usuário
        // Ex: validar se o email já existe, criptografar a senha, etc.
        return usuarioRepository.save(usuario);
    }
}

