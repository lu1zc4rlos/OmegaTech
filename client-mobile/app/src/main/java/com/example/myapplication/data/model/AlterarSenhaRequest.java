package com.example.myapplication.data.model;

import com.google.gson.annotations.SerializedName;

public class AlterarSenhaRequest {

    @SerializedName("email")
    private String email;

    // AQUI ESTAVA O RISCO: Confirmamos que é "senhaAtual" e não "senhaAntiga"
    @SerializedName("senhaAtual")
    private String senhaAtual;

    @SerializedName("novaSenha")
    private String novaSenha;

    public AlterarSenhaRequest(String email, String senhaAtual, String novaSenha) {
        this.email = email;
        this.senhaAtual = senhaAtual;
        this.novaSenha = novaSenha;
    }

    // Getters e Setters (Opcionais se você não for ler os dados de volta, mas boa prática ter)
    public String getEmail() { return email; }
    public String getSenhaAtual() { return senhaAtual; }
    public String getNovaSenha() { return novaSenha; }
}