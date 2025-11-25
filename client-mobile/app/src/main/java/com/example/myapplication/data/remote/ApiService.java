package com.example.myapplication.data.remote;

import com.example.myapplication.data.model.AlterarSenhaRequest;
import com.example.myapplication.data.model.CadastroRequest;
import com.example.myapplication.data.model.LoginRequest;
import com.example.myapplication.data.model.LoginResponse;
import com.example.myapplication.data.model.ResetarSenhaRequest;
import com.example.myapplication.data.model.SolicitarCodigoRequest;
import com.example.myapplication.data.model.ValidarCodigoRequest;

import retrofit2.Call;
import retrofit2.http.Body;
import retrofit2.http.POST;
import retrofit2.http.PUT;

public interface ApiService {

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