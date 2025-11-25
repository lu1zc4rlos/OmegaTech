/*
package com.example.omegatechapi.service;

import com.example.omegatechapi.model.*;
import com.example.omegatechapi.repository.TokenRecuperacaoRepository;
import com.example.omegatechapi.repository.UsuarioRepository;
import com.example.omegatechapi.response.AuthResponse;
import jakarta.persistence.EntityNotFoundException;
import jakarta.transaction.Transactional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.authentication.BadCredentialsException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.Optional;
import java.util.Random;

@Service
public class UsuarioService {

    @Autowired
    private final UsuarioRepository usuarioRepository;
    private final JwtService jwtService;

    @Autowired
    private PasswordEncoder passwordEncoder;

    @Autowired
    private EmailService emailService;

    @Autowired
    private TokenRecuperacaoRepository tokenRepository;

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

    @Transactional
    public void solicitarCodigoRecuperacao(String email) {
        Usuario usuario = usuarioRepository.findByEmail(email)
                .orElseThrow(() -> new EntityNotFoundException("Email não encontrado"));

        // Gerar dados novos
        String codigo = String.format("%06d", new Random().nextInt(999999));
        LocalDateTime expiracao = LocalDateTime.now().plusMinutes(10);

        // 1. Verifica se JÁ EXISTE um token (Upsert Strategy)
        Optional<TokenRecuperacao> tokenExistenteOpt = tokenRepository.findByUsuarioId(usuario.getId());

        TokenRecuperacao tokenParaSalvar;

        if (tokenExistenteOpt.isPresent()) {
            // CENÁRIO A: O usuário já pediu antes (como o Pedro).
            // Nós RECICLAMOS o registro existente. O ID do banco continua o mesmo.
            tokenParaSalvar = tokenExistenteOpt.get();
            tokenParaSalvar.setCodigo(codigo);
            tokenParaSalvar.setDataExpiracao(expiracao);
            tokenParaSalvar.setValidado(false); // Importante resetar isso!
        } else {
            // CENÁRIO B: Primeira vez pedindo.
            // Criamos um objeto novo.
            tokenParaSalvar = new TokenRecuperacao(codigo, expiracao, usuario);
        }

        // O .save() é inteligente: se o objeto tem ID, ele faz UPDATE. Se não tem, faz INSERT.
        tokenRepository.save(tokenParaSalvar);

        emailService.enviarEmailCodigo(email, codigo);
    }

    @Transactional
    public void validarCodigoRecuperacao(ValidarCodigo dto) {

        TokenRecuperacao token = tokenRepository.findByCodigo(dto.getCodigo())
                .orElseThrow(() -> new BadCredentialsException("Código inválido."));

        if (!token.getUsuario().getEmail().equals(dto.getEmail())) {
            throw new BadCredentialsException("Código inválido para este email.");
        }

        if (token.getDataExpiracao().isBefore(LocalDateTime.now())) {
            tokenRepository.delete(token);
            throw new BadCredentialsException("Código expirado. Peça um novo.");
        }

        if (token.isValidado()) {
            throw new BadCredentialsException("Código já utilizado.");
        }

        token.setValidado(true);
        token.setDataExpiracao(LocalDateTime.now().plusMinutes(5));

        tokenRepository.save(token);
    }
    @Transactional
    public void resetarSenhaComCodigo(ResetarSenhaComCodigo dto) {

        System.out.println("Email recebido: " + dto.getEmail());
        System.out.println("Código recebido: " + dto.getCodigo());

        TokenRecuperacao token = tokenRepository.findByCodigo(dto.getCodigo())
                .orElseThrow(() -> new BadCredentialsException("Código inválido ou não encontrado."));

        if (!token.getUsuario().getEmail().equalsIgnoreCase(dto.getEmail().trim())) {
            throw new BadCredentialsException("Código ou Email inválidos.");
        }

        if (!token.isValidado()) {
            throw new BadCredentialsException("Código não foi validado previamente.");
        }

        if (token.getDataExpiracao().isBefore(LocalDateTime.now())) {
            tokenRepository.delete(token);
            throw new BadCredentialsException("Sessão para troca de senha expirou. Peça um novo código.");
        }

        Usuario usuario = token.getUsuario();

        usuario.setSenha(passwordEncoder.encode(dto.getNovaSenha()));
        usuarioRepository.save(usuario);

        tokenRepository.delete(token);

        try {
            emailService.enviarEmailTrocaDeSenha(usuario.getEmail());
        } catch (Exception e) {
            System.err.println("Erro ao agendar envio de e-mail: " + e.getMessage());
        }
    }



}
*/
package com.example.omegatechapi.service;

import com.example.omegatechapi.model.*;
import com.example.omegatechapi.repository.TokenRecuperacaoRepository;
import com.example.omegatechapi.repository.UsuarioRepository;
import com.example.omegatechapi.response.AuthResponse;
import jakarta.persistence.EntityNotFoundException;
import jakarta.transaction.Transactional;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.security.authentication.BadCredentialsException;
import org.springframework.security.crypto.password.PasswordEncoder;
import org.springframework.stereotype.Service;

import java.time.LocalDateTime;
import java.util.Random;

@Service
public class UsuarioService {

    @Autowired
    private final UsuarioRepository usuarioRepository;
    private final JwtService jwtService;

    @Autowired
    private PasswordEncoder passwordEncoder;

    @Autowired
    private EmailService emailService;

    @Autowired
    private TokenRecuperacaoRepository tokenRepository;

    public UsuarioService(UsuarioRepository usuarioRepository, JwtService jwtService) {
        this.usuarioRepository = usuarioRepository;
        this.jwtService = jwtService;
    }

    // --- Fluxo de Login ---
    public AuthResponse loginUsuario(Usuario request) {
        Usuario usuario = usuarioRepository.findByEmail(request.getEmail())
                .orElseThrow(() -> new RuntimeException("Usuário não encontrado"));

        if (!passwordEncoder.matches(request.getSenha(), usuario.getSenha())) {
            throw new RuntimeException("Senha incorreta");
        }

        String token = jwtService.gerarToken(usuario);

        return new AuthResponse(usuario.getNome(), token, usuario.getPerfil().toString());
    }

    // --- Fluxo de Cadastro ---
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

        String token = jwtService.gerarToken(usuarioSalvo);


        try {
            emailService.enviarEmailDeBoasVindas(usuarioSalvo.getEmail(), usuarioSalvo.getNome());
        } catch (Exception e) {
            System.err.println("Erro ao agendar envio de e-mail: " + e.getMessage());
        }

        return new AuthResponse(usuarioSalvo.getNome(), token, novoUsuario.getPerfil().toString());
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

    @Transactional
    public void solicitarCodigoRecuperacao(String email) {
        Usuario usuario = usuarioRepository.findByEmail(email)
                .orElseThrow(() -> new EntityNotFoundException("Email não encontrado"));

        tokenRepository.findByUsuarioId(usuario.getId()).ifPresent(tokenRepository::delete);

        String codigo = String.format("%06d", new Random().nextInt(999999));

        LocalDateTime expiracao = LocalDateTime.now().plusMinutes(10);

        TokenRecuperacao novoToken = new TokenRecuperacao(codigo, expiracao, usuario);
        tokenRepository.save(novoToken);

        emailService.enviarEmailCodigo(email, codigo);
    }

    @Transactional
    public void validarCodigoRecuperacao(ValidarCodigo dto) {

        TokenRecuperacao token = tokenRepository.findByCodigo(dto.getCodigo())
                .orElseThrow(() -> new BadCredentialsException("Código inválido."));

        if (!token.getUsuario().getEmail().equals(dto.getEmail())) {
            throw new BadCredentialsException("Código inválido para este email.");
        }

        if (token.getDataExpiracao().isBefore(LocalDateTime.now())) {
            tokenRepository.delete(token);
            throw new BadCredentialsException("Código expirado. Peça um novo.");
        }

        if (token.isValidado()) {
            throw new BadCredentialsException("Código já utilizado.");
        }

        token.setValidado(true);
        token.setDataExpiracao(LocalDateTime.now().plusMinutes(5));

        tokenRepository.save(token);
    }
    @Transactional
    public void resetarSenhaComCodigo(ResetarSenhaComCodigo dto) {

        System.out.println("Email recebido: " + dto.getEmail());
        System.out.println("Código recebido: " + dto.getCodigo());

        TokenRecuperacao token = tokenRepository.findByCodigo(dto.getCodigo())
                .orElseThrow(() -> new BadCredentialsException("Código inválido ou não encontrado."));

        if (!token.getUsuario().getEmail().equalsIgnoreCase(dto.getEmail().trim())) {
            throw new BadCredentialsException("Código ou Email inválidos.");
        }

        if (!token.isValidado()) {
            throw new BadCredentialsException("Código não foi validado previamente.");
        }

        if (token.getDataExpiracao().isBefore(LocalDateTime.now())) {
            tokenRepository.delete(token);
            throw new BadCredentialsException("Sessão para troca de senha expirou. Peça um novo código.");
        }

        Usuario usuario = token.getUsuario();

        usuario.setSenha(passwordEncoder.encode(dto.getNovaSenha()));
        usuarioRepository.save(usuario);

        tokenRepository.delete(token);

        try {
            emailService.enviarEmailTrocaDeSenha(usuario.getEmail());
        } catch (Exception e) {
            System.err.println("Erro ao agendar envio de e-mail: " + e.getMessage());
        }
    }
}


