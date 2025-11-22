package com.example.omegatechapi.service;

import java.security.Principal;

public class AuthService {
    public static Long extractUserId(Principal principal) {
        if (principal == null) {
            throw new SecurityException("Principal de autenticação não encontrado. Acesso não permitido.");
        }

        String userIdStr = principal.getName();

        if (userIdStr == null || userIdStr.isEmpty()) {
            throw new SecurityException("ID do usuário (Subject) está ausente no token.");
        }

        try {
            // Esta linha converte a String (ID) para Long
            return Long.parseLong(userIdStr);
        } catch (NumberFormatException e) {
            // Lança uma exceção específica se o Subject for, por exemplo, um email.
            throw new NumberFormatException("O Subject do token ('" + userIdStr + "') não é um ID numérico. Verifique a configuração do JWT Subject.");
        }
    }
}
