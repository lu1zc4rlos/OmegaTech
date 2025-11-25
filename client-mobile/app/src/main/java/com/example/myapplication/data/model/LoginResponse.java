package com.example.myapplication.data.model;

import com.google.gson.annotations.SerializedName;

public class LoginResponse {
    @SerializedName("username")
    private String Username;
    @SerializedName("token")
    private String Token;

    public LoginResponse() {}

    public String getUsername() {
        return Username;
    }

    public void setUsername(String username) {
        Username = username;
    }

    public String getToken() {
        return Token;
    }

    public void setToken(String token) {
        Token = token;
    }
}
