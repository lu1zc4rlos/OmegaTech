package com.example.myapplication.data.model;
import com.google.gson.annotations.SerializedName;

public class LoginRequest {
    @SerializedName("email") // Nome exato do campo no JSON/Backend
    private String email;

    @SerializedName("senha")
    private String password;

    public LoginRequest(String email, String password) {
        this.email = email;
        this.password = password;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getPassword() {
        return password;
    }

    public void setPassword(String password) {
        this.password = password;
    }
}
