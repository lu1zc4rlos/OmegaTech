package com.example.myapplication.data.model;

import com.google.gson.annotations.SerializedName;

public class CadastroRequest {

    @SerializedName("nome")
    private String nome;

    @SerializedName("email")
    private String email;

    @SerializedName("senha")
    private String senha;

    @SerializedName("dataNascimento")
    private String dataNascimento;

    // REMOVIDO: private String perfil;
    // Deixe o Backend decidir qual é o perfil padrão.

    public CadastroRequest(String nome, String email, String senha, String dataNascimento) {
        this.nome = nome;
        this.email = email;
        this.senha = senha;
        this.dataNascimento = dataNascimento;
        // REMOVIDO: this.perfil = "CLIENTE";
    }

    // Getters e Setters (Gere com Alt+Insert)

    public String getDataNascimento() { return dataNascimento; }
    public void setDataNascimento(String dataNascimento) { this.dataNascimento = dataNascimento; }


    public String getNome() { return nome; }
    public void setNome(String nome) { this.nome = nome; }


    public String getEmail() { return email; }
    public void setEmail(String email) { this.email = email; }

    public String getSenha() { return senha; }
    public void setSenha(String senha) { this.senha = senha; }
}