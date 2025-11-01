package com.example.omegatechapi.model;

import lombok.Data;

@Data
public class ResetarSenhaComCodigo {
    private String email;
    private String codigo;
    private String novaSenha;
}
