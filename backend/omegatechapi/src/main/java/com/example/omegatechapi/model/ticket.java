package com.example.omegatechapi.model;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;
import lombok.Data;
import java.time.LocalDate;

@Data
@Entity

public class ticket {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)

    public String Resposta;
    public String ID;
    public String Titulo;
    public String Cliente;
    public String Prioridade;
    public String Tempo;
    public String Status;
    public String Descricao;
    public LocalDate DataCriacao;
    public int UsuarioId;
}
