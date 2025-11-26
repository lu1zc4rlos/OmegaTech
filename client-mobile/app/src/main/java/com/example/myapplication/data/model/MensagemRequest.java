package com.example.myapplication.data.model;
import com.google.gson.annotations.SerializedName;

public class MensagemRequest {
    @SerializedName("mensagem")
    private String mensagem;

    public MensagemRequest(String mensagem) { this.mensagem = mensagem; }

    public String getMensagem() {
        return mensagem;
    }

    public void setMensagem(String mensagem) {
        this.mensagem = mensagem;
    }
}
