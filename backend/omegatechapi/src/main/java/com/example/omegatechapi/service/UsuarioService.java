package com.example.omegatechapi.service;

import com.example.omegatechapi.model.AlterarSenhaRequest;
import com.example.omegatechapi.model.Perfil;
import com.example.omegatechapi.model.Usuario;
import com.example.omegatechapi.repository.UsuarioRepository;
import com.example.omegatechapi.response.AuthResponse;
import jakarta.persistence.EntityNotFoundException;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.authentication.BadCredentialsException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

@Service
public class UsuarioService {

    @Autowired
    private final UsuarioRepository usuarioRepository;
    private final JwtService jwtService;

    @Autowired
    private PasswordEncoder passwordEncoder;

    @Autowired
    private EmailService emailService;

    public UsuarioService(UsuarioRepository usuarioRepository, JwtService jwtService) {
        this.usuarioRepository = usuarioRepository;
        this.jwtService = jwtService;
    }
    public AuthResponse loginUsuario(Usuario request) {
        Usuario usuario = usuarioRepository.findByEmail(request.getEmail())
                .orElseThrow(() -> new RuntimeException("Usuário não encontrado"));

        if (!passwordEncoder.matches(request.getSenha(), usuario.getSenha())) {
            throw new RuntimeException("Senha incorreta");
        }

        String token = jwtService.gerarToken(usuario);

        return new AuthResponse(usuario.getNome(), token);
    }
    public AuthResponse cadastrarNovoUsuario(Usuario request) {

        if (usuarioRepository.existsByEmail(request.getEmail())) {
            throw new RuntimeException("Erro: Este e-mail já está em uso!");
        }

        Usuario novoUsuario = new Usuario();
        novoUsuario.setNome(request.getNome());
        novoUsuario.setEmail(request.getEmail());
        novoUsuario.setDataNascimento(request.getDataNascimento());
        novoUsuario.setSenha(passwordEncoder.encode(request.getSenha()));
        novoUsuario.setPerfil(Perfil.ROLE_CLIENTE);

        Usuario usuarioSalvo = usuarioRepository.save(novoUsuario);

        String token = jwtService.gerarToken(novoUsuario);


        try {
            emailService.enviarEmailDeBoasVindas(usuarioSalvo.getEmail(), usuarioSalvo.getNome());
        } catch (Exception e) {
            System.err.println("Erro ao agendar envio de e-mail: " + e.getMessage());
        }

        return new AuthResponse(usuarioSalvo.getNome(), token);
    }
    public void alterarSenha(AlterarSenhaRequest request) {

        Usuario usuario = usuarioRepository.findByEmail(request.getEmail())
                .orElseThrow(() -> new EntityNotFoundException("Usuário não encontrado com o email: " + request.getEmail()));

        if (!passwordEncoder.matches(request.getSenhaAtual(), usuario.getSenha())) {
            throw new BadCredentialsException("Email ou senha atual incorretos.");
        }

        String novaSenhaCodificada = passwordEncoder.encode(request.getNovaSenha());
        usuario.setSenha(novaSenhaCodificada);

        usuarioRepository.save(usuario);

        try {
            emailService.enviarEmailTrocaDeSenha(usuario.getEmail());
        } catch (Exception e) {
            System.err.println("Erro ao agendar envio de e-mail: " + e.getMessage());
        }
    }
}

