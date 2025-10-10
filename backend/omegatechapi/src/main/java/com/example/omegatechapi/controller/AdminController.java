package com.example.omegatechapi.controller;

/*
Este é um novo controller, dedicado a ações que apenas administradores podem realizar. É uma ótima prática para organizar e proteger seus endpoints.

Lógica Mapeada da BLL: Parte do UsuarioBLL.cs e novas lógicas.

Endpoints que ele conteria:

POST /api/admin/tecnicos: O endpoint que já projetamos para criar um novo técnico. Ele recebe o CriarTecnicoRequest e chama o usuarioService.criarTecnico().

GET /api/admin/usuarios: Para listar todos os usuários do sistema.

DELETE /api/admin/usuarios/{id}: Para deletar um usuário.

PUT /api/admin/usuarios/{id}/perfil: Para alterar o perfil de um usuário (promover para técnico ou admin).
 */
public class AdminController {
}
