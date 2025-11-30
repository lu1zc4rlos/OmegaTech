package com.example.myapplication.data.model;
import com.google.gson.annotations.SerializedName;

public class RespostaTicketDTO {
    @SerializedName("resposta")
    private String resposta;

    public RespostaTicketDTO(String resposta) {
        this.resposta = resposta;
    }
}