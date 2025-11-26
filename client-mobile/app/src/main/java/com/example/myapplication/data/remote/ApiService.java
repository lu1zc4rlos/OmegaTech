package com.example.myapplication.data.remote;

import com.example.myapplication.data.model.AlterarSenhaRequest;
import com.example.myapplication.data.model.CadastroRequest;
import com.example.myapplication.data.model.ChatResponse;
import com.example.myapplication.data.model.LoginRequest;
import com.example.myapplication.data.model.LoginResponse;
import com.example.myapplication.data.model.MensagemRequest;
import com.example.myapplication.data.model.ResetarSenhaRequest;
import com.example.myapplication.data.model.SolicitarCodigoRequest;
import com.example.myapplication.data.model.ValidarCodigoRequest;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.Header;
import retrofit2.http.POST;
import retrofit2.http.PUT;

public interface ApiService {

    @POST("chat/mensagem")
    Call<ChatResponse> enviarMensagemChat(@Body MensagemRequest request);
    // OBS: O Token JWT é injetado automaticamente se você estiver usando um Interceptor de Auth,
    // MAS como ainda não configuramos um interceptor global, teremos que passar o token no header
    // ou configurar o cliente.

    // SOLUÇÃO MAIS SIMPLES PARA AGORA:
    // Vamos assumir que você vai adicionar o token manualmente no header
    @POST("chat/mensagem")
    Call<ChatResponse> enviarMensagemChat(@Header("Authorization") String token, @Body MensagemRequest request);

    @POST("usuarios/login") // Caminho exato
    Call<LoginResponse> login(@Body LoginRequest request);

    @POST("usuarios/cadastro")
    Call<LoginResponse> cadastrar(@Body CadastroRequest request);

    @PUT("usuarios/alterar_senha")
    Call<Void> alterarSenha(@Body AlterarSenhaRequest request);

    @POST("usuarios/solicitar_codigo")
    Call<Void> solicitarCodigo(@Body SolicitarCodigoRequest request);

    @POST("usuarios/validar_codigo")
    Call<Void> validarCodigo(@Body ValidarCodigoRequest request);

    @PUT("usuarios/resetar_senha")
    Call<Void> resetarSenhaComCodigo(@Body ResetarSenhaRequest request);
}