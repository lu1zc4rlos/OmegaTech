package com.example.omegatechapi.model;
import lombok.Data;

@Data

public class CriarTecnicoRequest {
    private String nome;
    private String email;
    private String senhaInicial;
    private String especialidade;
}
