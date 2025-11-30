package com.example.myapplication.data.model;

import com.google.gson.annotations.SerializedName;

public class LoginResponse {

    @SerializedName("token")
    private String token;

    @SerializedName("username")
    private String username;

    @SerializedName("perfil") // <--- NOVO: Tem que bater com o backend
    private String perfil;

    public String getToken() { return token; }
    public String getUsername() { return username; }
    public String getPerfil() { return perfil; } // <--- Getter
}