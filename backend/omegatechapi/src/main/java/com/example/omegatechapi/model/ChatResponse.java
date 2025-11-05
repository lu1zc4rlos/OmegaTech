package com.example.omegatechapi.model;

import lombok.Data;

import java.time.LocalDate;

@Data
public class ChatResponse {
    private String Resposta;
    private TipoResposta Tipo;
    private Object Dados;
    private LocalDate Timestamp;
}
