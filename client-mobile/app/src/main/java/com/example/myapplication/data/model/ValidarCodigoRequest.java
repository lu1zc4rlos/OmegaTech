package com.example.myapplication.data.model;

import com.google.gson.annotations.Expose;
import com.google.gson.annotations.SerializedName;

public class ValidarCodigoRequest {

    @SerializedName("email")
    @Expose // <--- FORÇA A SERIALIZAÇÃO
    private String email;

    @SerializedName("codigo")
    @Expose // <--- FORÇA A SERIALIZAÇÃO
    private String codigo;

    public ValidarCodigoRequest(String email, String codigo) {
        this.email = email;
        this.codigo = codigo;
    }

    public String getEmail() {
        return email;
    }

    public void setEmail(String email) {
        this.email = email;
    }

    public String getCodigo() {
        return codigo;
    }

    public void setCodigo(String codigo) {
        this.codigo = codigo;
    }
}