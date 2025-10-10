package com.example.omegatechapi.model;
import jakarta.persistence.Entity;
import lombok.Data;

@Data
@Entity

public class CriarTecnicoRequest {
    private String nome;
    private String email;
    private String senhaInicial;
    private String especialidade;
}
