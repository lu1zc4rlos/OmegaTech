package com.example.myapplication.data.model;
import com.google.gson.annotations.SerializedName;

public class ChatResponse {
    @SerializedName("resposta") // O texto que o bot respondeu
    private String resposta;

    // Podemos ignorar "tipo" e "dados" por enquanto, só queremos o texto.

    public String getResposta() { return resposta; }

    public void setResposta(String resposta) {
        this.resposta = resposta;
    }
}