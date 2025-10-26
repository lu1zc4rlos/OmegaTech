package com.example.omegatechapi.service;

import io.jsonwebtoken.Claims;
import io.jsonwebtoken.Jwts;
import io.jsonwebtoken.SignatureAlgorithm;
import io.jsonwebtoken.io.Decoders;
import io.jsonwebtoken.security.Keys;
import lombok.Data;
import org.springframework.beans.factory.annotation.Value;
import org.springframework.security.core.userdetails.UserDetails;
import org.springframework.stereotype.Service;

import java.security.Key;
import java.util.Date;
import java.util.HashMap;
import java.util.Map;
import java.util.function.Function;

@Data
@Service
public class JwtService {

    // 1. Injeta a chave secreta do application.properties
    @Value("${application.security.jwt.secret-key}")
    private String secretKey;

    // 2. Injeta o tempo de expiração do application.properties
    @Value("${application.security.jwt.expiration-ms}")
    private long expirationMs;


    public String gerarToken(UserDetails userDetails) {
        // Você pode adicionar "claims" extras (dados) ao token se quiser
        Map<String, Object> extraClaims = new HashMap<>();
        // ex: extraClaims.put("nome", usuario.getNomeCompleto());

        return Jwts.builder()
                .setClaims(extraClaims) // Adiciona os claims extras
                .setSubject(userDetails.getUsername()) // Define o "dono" do token (geralmente email ou ID)
                .setIssuedAt(new Date(System.currentTimeMillis())) // Data de criação
                .setExpiration(new Date(System.currentTimeMillis() + expirationMs)) // Data de expiração
                .signWith(getSigningKey(), SignatureAlgorithm.HS256) // Assina o token com a chave
                .compact(); // Constrói o token como uma String
    }

    /**
     * Verifica se um token é válido para um determinado usuário.
     * (Isso será usado por um Filtro de Segurança, não pelo AuthService)
     */
    public boolean isTokenValid(String token, UserDetails userDetails) {
        final String username = extractUsername(token); // Pega o usuário de dentro do token
        // Verifica se o usuário do token é o mesmo que está logando
        // E se o token não expirou
        return (username.equals(userDetails.getUsername())) && !isTokenExpired(token);
    }

    /**
     * Extrai o "Subject" (username/email) de dentro do token.
     */
    public String extractUsername(String token) {
        return extractClaim(token, Claims::getSubject);
    }

    // ----- MÉTODOS PRIVADOS AUXILIARES -----

    /**
     * Verifica se o token expirou.
     */
    private boolean isTokenExpired(String token) {
        return extractExpiration(token).before(new Date());
    }

    /**
     * Extrai a data de expiração do token.
     */
    private Date extractExpiration(String token) {
        return extractClaim(token, Claims::getExpiration);
    }

    public <T> T extractClaim(String token, Function<Claims, T> claimsResolver) {
        final Claims claims = extractAllClaims(token);
        return claimsResolver.apply(claims);
    }

    /**
     * Decodifica o token e extrai todas as informações (claims) dele.
     */
    private Claims extractAllClaims(String token) {
        return Jwts.parser()
        //parserBuilder
                .setSigningKey(getSigningKey()) // Usa a chave para verificar a assinatura
                .build()
                .parseClaimsJws(token) // Decodifica e valida
                .getBody(); // Pega o "corpo" (os claims)
    }

    /**
     * Converte a chave secreta (String em Base64) em um objeto Key criptográfico.
     */
    private Key getSigningKey() {
        byte[] keyBytes = Decoders.BASE64.decode(secretKey);
        return Keys.hmacShaKeyFor(keyBytes);
    }
}