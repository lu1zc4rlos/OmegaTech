package com.example.omegatechapi.model;

import lombok.Data;

import java.time.LocalDateTime;

@Data
public class TecnicoResponseDTO {
    private Long id;
    private String nome;
    private String matricula;
    private String email;
    private LocalDateTime dataCriacao;
}
