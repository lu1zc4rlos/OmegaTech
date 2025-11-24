package com.example.omegatechapi.service;

import com.example.omegatechapi.repository.UsuarioRepository;
import lombok.RequiredArgsConstructor;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.security.core.userdetails.UserDetailsService;
import org.springframework.security.core.userdetails.UsernameNotFoundException;
import org.springframework.stereotype.Service;
import org.springframework.transaction.annotation.Transactional;

@Service
@RequiredArgsConstructor
public class UserDetailsServiceImpl implements UserDetailsService {

    private final UsuarioRepository usuarioRepository;

    @Override
    @Transactional
    public UserDetails loadUserByUsername(String idOuEmail) throws UsernameNotFoundException {

        // 1. Tenta tratar o valor como ID numérico (que vem do JWT Subject)
        try {
            Long userId = Long.parseLong(idOuEmail);

            // Busca pelo ID
            return usuarioRepository.findByUserId(userId)
                    .orElseThrow(() -> new UsernameNotFoundException("Usuário não encontrado: " + idOuEmail));

        } catch (NumberFormatException e) {
            // 2. Se a conversão falhar (porque é um EMAIL ou String), busca por EMAIL

            // Lógica do Hibernate anterior: where u1_0.email=?
            return usuarioRepository.findByEmail(idOuEmail)
                    .orElseThrow(() -> new UsernameNotFoundException("Usuário não encontrado: " + idOuEmail));
        }
    }
}
