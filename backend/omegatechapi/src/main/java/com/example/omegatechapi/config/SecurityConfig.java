/*package com.example.omegatechapi.config;

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


}*/

package com.example.omegatechapi.config;

import lombok.RequiredArgsConstructor;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.context.annotation.Bean;
import org.springframework.context.annotation.Configuration;
import org.springframework.http.HttpMethod;
import org.springframework.security.authentication.AuthenticationProvider;
import org.springframework.security.config.annotation.web.builders.HttpSecurity;
import org.springframework.security.config.annotation.web.configuration.EnableWebSecurity;
import org.springframework.security.web.SecurityFilterChain;
import org.springframework.security.web.authentication.UsernamePasswordAuthenticationFilter;
import org.springframework.web.cors.CorsConfiguration;
import org.springframework.web.cors.CorsConfigurationSource;
import org.springframework.web.cors.UrlBasedCorsConfigurationSource;
import org.springframework.beans.factory.annotation.Value;

import java.util.Arrays;
import java.util.List;

@Configuration
@EnableWebSecurity
@RequiredArgsConstructor
public class SecurityConfig {

    private final JwtAuthenticationFilter jwtAuthFilter;
    private final AuthenticationProvider authenticationProvider;

    @Autowired
    private CustomAuthenticationEntryPoint customAuthenticationEntryPoint;

    //@Value("${api.security.cors.origins}")
    private String allowedOrigins="http://localhost:5173";

    @Bean
    public SecurityFilterChain securityFilterChain(HttpSecurity http) throws Exception {
        http
                // 1. Configuração Explicita do CORS ligada ao Bean lá embaixo
                .cors(cors -> cors.configurationSource(corsConfigurationSource()))
                .csrf(csrf -> csrf.disable())
                .authorizeHttpRequests(auth -> auth
                        // 2. Libera o Preflight (OPTIONS) para qualquer rota
                        .requestMatchers(HttpMethod.OPTIONS, "/**").permitAll()

                        // Rotas Públicas
                        .requestMatchers("/usuarios/login", "/auth/login").permitAll()
                        .requestMatchers("/usuarios/cadastro").permitAll()
                        // ... suas outras rotas ...
                        .requestMatchers(HttpMethod.PUT, "/usuarios/alterar_senha").permitAll()
                        .requestMatchers(HttpMethod.POST, "/usuarios/solicitar_codigo").permitAll()
                        .requestMatchers(HttpMethod.POST, "/usuarios/validar_codigo").permitAll()
                        .requestMatchers(HttpMethod.PUT, "/usuarios/resetar_senha").permitAll()
                        .requestMatchers(HttpMethod.POST, "/chat/mensagem").permitAll()
                        .requestMatchers(HttpMethod.POST, "/tickets/criar").permitAll()
                        .requestMatchers(HttpMethod.GET, "/tickets/meus").permitAll()
                        .requestMatchers(HttpMethod.PUT, "/tickets/status").permitAll()
                        .requestMatchers(HttpMethod.PUT, "/tickets/resposta").permitAll()
                        .requestMatchers(HttpMethod.DELETE, "/tickets/deletar").permitAll()

                        // O resto precisa de token
                        .anyRequest().authenticated()
                )
                .authenticationProvider(authenticationProvider)
                .addFilterBefore(jwtAuthFilter, UsernamePasswordAuthenticationFilter.class)
                .exceptionHandling(exception -> exception
                        .authenticationEntryPoint(customAuthenticationEntryPoint)
                );

        return http.build();
    }

    @Bean
    public CorsConfigurationSource corsConfigurationSource() {
        CorsConfiguration configuration = new CorsConfiguration();

        // 3. Permite qualquer origem (Apenas para dev, facilita muito)
        // Se der erro, troque "*" por "http://localhost:5173"
        configuration.setAllowedOrigins(Arrays.asList(allowedOrigins.split(",")));

        configuration.setAllowedMethods(Arrays.asList("GET", "POST", "PUT", "DELETE", "OPTIONS", "HEAD"));
        configuration.setAllowedHeaders(Arrays.asList("Authorization", "Content-Type", "x-auth-token"));
        configuration.setAllowCredentials(true);

        UrlBasedCorsConfigurationSource source = new UrlBasedCorsConfigurationSource();
        source.registerCorsConfiguration("/**", configuration);
        return source;
    }
}
