package com.example.omegatechapi.response;

import lombok.Data;

@Data

public class AuthResponse{

    private String token;
    private String username;
    private String perfil;

    public AuthResponse(String username, String token, String perfil) {
        this.username = username;
        this.token = token;
        this.perfil = perfil;
    }
}
