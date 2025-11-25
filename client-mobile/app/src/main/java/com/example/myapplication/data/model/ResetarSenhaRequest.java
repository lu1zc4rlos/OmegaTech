package com.example.myapplication.data.model;

import com.google.gson.annotations.SerializedName;

public class ResetarSenhaRequest {

    @SerializedName("email") // Igual ao C#: "email"
    private String email;

    @SerializedName("codigo") // Igual ao C#: "codigo"
    private String codigo;

    @SerializedName("novaSenha") // Igual ao C#: "novaSenha"
    private String novaSenha;

    public ResetarSenhaRequest(String email, String codigo, String novaSenha) {
        this.email = email;
        this.codigo = codigo;
        this.novaSenha = novaSenha;
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

    public String getNovaSenha() {
        return novaSenha;
    }

    public void setNovaSenha(String novaSenha) {
        this.novaSenha = novaSenha;
    }
}