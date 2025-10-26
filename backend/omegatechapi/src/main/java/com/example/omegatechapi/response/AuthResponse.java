package com.example.omegatechapi.response;

import lombok.Data;

@Data

public class AuthResponse{

    private String token;
    private String username;

    public AuthResponse(String username, String token) {
        this.username = username;
        this.token = token;
    }
}
