package com.example.myapplication.data.model;

import com.google.gson.annotations.SerializedName;

public class SolicitarCodigoRequest {
    @SerializedName("email") private String email;
    public SolicitarCodigoRequest(String email) { this.email = email; }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }
}