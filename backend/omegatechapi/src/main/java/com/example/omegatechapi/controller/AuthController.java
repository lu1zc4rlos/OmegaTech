/* Este controller seria o ponto de entrada para tudo relacionado à autenticação.

Lógica Mapeada da BLL: LoginBLL.cs e RecuperarSenhaBLL.cs.

Endpoints (URLs) que ele conteria:

POST /api/auth/login: Para o usuário (qualquer perfil) entrar no sistema. Ele recebe um e-mail e senha, chama o usuarioService.autenticar() e retorna um token de acesso (JWT).

POST /api/auth/recuperar-senha: Recebe um e-mail, chama o usuarioService.iniciarRecuperacaoSenha() que usa o emailService para enviar o link de recuperação.

POST /api/auth/resetar-senha: Recebe o token de recuperação e a nova senha. */
package com.example.omegatechapi.controller;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
@RequestMapping("/auth")
public class AuthController {
}
