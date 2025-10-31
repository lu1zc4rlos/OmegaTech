package com.example.omegatechapi.model;

import lombok.Data;

@Data
public class AlterarSenhaRequest {
    private String email;
    private String senhaAtual;
    private String novaSenha;

}
