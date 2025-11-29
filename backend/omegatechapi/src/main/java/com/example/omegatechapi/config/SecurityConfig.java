package com.example.omegatechapi.config;

import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.http.HttpMethod;
import org.springframework.security.authentication.AuthenticationProvider;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.config.http.SessionCreationPolicy;
import org.springframework.security.web.SecurityFilterChain;
import org.springframework.security.web.authentication.UsernamePasswordAuthenticationFilter;

@Configuration
@EnableWebSecurity
@RequiredArgsConstructor
public class SecurityConfig {

    private final JwtAuthenticationFilter jwtAuthFilter;
    private final AuthenticationProvider authenticationProvider;

    @Autowired
    private CustomAuthenticationEntryPoint customAuthenticationEntryPoint;

    @Bean
    public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception {
        http
                .csrf(csrf -> csrf.disable()) // Desativa CSRF (para API REST)
                .authorizeHttpRequests(auth -> auth
                        // 🔓 Libera login
                        .requestMatchers("/usuarios/login").permitAll()
                        // 🔓 Libera cadastro
                        .requestMatchers("/usuarios/cadastro").permitAll()
                        // 🔓 Libera troca de senha
                        .requestMatchers(HttpMethod.PUT, "/usuarios/alterar_senha").permitAll()
                        // 🔓 Libera troca de senha por código
                        .requestMatchers(HttpMethod.POST, "/usuarios/solicitar_codigo").permitAll()
                        // 🔓 Libera validação de código
                        .requestMatchers(HttpMethod.POST, "/usuarios/validar_codigo").permitAll()
                        // 🔓 Libera troca de senha
                        .requestMatchers(HttpMethod.PUT, "/usuarios/resetar_senha").permitAll()
                        // 🔓 Libera mensagens
                        .requestMatchers(HttpMethod.POST, "/chat/mensagem").permitAll()
                        // 🔓 Libera criar ticket
                        .requestMatchers(HttpMethod.POST, "/tickets/criar").permitAll()
                        // 🔓 Libera buscar ticket
                        .requestMatchers(HttpMethod.GET, "/tickets/meus").permitAll()
                        // 🔓 Libera atualização do status do ticket
                        .requestMatchers(HttpMethod.PUT, "/tickets/status").permitAll()
                        // 🔓 Libera resposta do tecnico
                        .requestMatchers(HttpMethod.PUT, "/tickets/resposta").permitAll()
                        // 🔓 Libera deletar ticket
                        .requestMatchers(HttpMethod.DELETE, "/tickets/deletar").permitAll()
                        // 🔓 Libera cadastro de tecnico
                        .requestMatchers(HttpMethod.POST, "/admin/cadastro").permitAll()
                        // 🔓 Libera busca de tecnicos
                        .requestMatchers(HttpMethod.GET, "/admin/tecnicos").permitAll()
                        // 🔓 Libera busca de tickets respondidos
                        .requestMatchers(HttpMethod.GET, "/admin/respondidos").permitAll()

                        // 🔒 O resto precisa de token JWT
                        .anyRequest().authenticated()
                )
                .authenticationProvider(authenticationProvider)
                .addFilterBefore(jwtAuthFilter, UsernamePasswordAuthenticationFilter.class)

                .exceptionHandling(exception -> exception
                .authenticationEntryPoint(customAuthenticationEntryPoint)
        );

        return http.build();
    }


}
