package com.example.myapplication;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.LinearLayout;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import com.example.myapplication.data.model.ResetarSenhaRequest;
import com.example.myapplication.data.model.SolicitarCodigoRequest;
import com.example.myapplication.data.model.ValidarCodigoRequest;
import com.example.myapplication.data.remote.RetrofitClient;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class ResetarSenhaActivity extends AppCompatActivity {

    // Layouts das etapas
    private LinearLayout layoutEmail, layoutCodigo, layoutSenha;
    private TextView tvTitulo;

    // Campos
    private EditText edtEmail, edtCodigo, edtNovaSenha, edtConfirmar;

    // Botões
    private Button btnEnviar, btnValidar, btnFinalizar;

    // Variáveis temporárias para guardar dados entre as etapas
    private String emailGuardado = "";
    private String codigoGuardado = "";

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_resetar_senha);

        inicializarComponentes();

        // --- ETAPA 1: Enviar Email ---
        btnEnviar.setOnClickListener(v -> {
            String email = edtEmail.getText().toString().trim();
            if (email.isEmpty()) {
                Toast.makeText(this, "Digite o e-mail", Toast.LENGTH_SHORT).show();
                return;
            }
            enviarCodigoAPI(email);
        });

        // --- ETAPA 2: Validar Código ---
        btnValidar.setOnClickListener(v -> {
            String codigo = edtCodigo.getText().toString().trim();
            if (codigo.isEmpty()) {
                Toast.makeText(this, "Digite o código", Toast.LENGTH_SHORT).show();
                return;
            }
            validarCodigoAPI(codigo);
        });

        // --- ETAPA 3: Mudar Senha ---
        btnFinalizar.setOnClickListener(v -> {
            String senha = edtNovaSenha.getText().toString();
            String confirma = edtConfirmar.getText().toString();

            if (senha.isEmpty() || confirma.isEmpty()) {
                Toast.makeText(this, "Preencha as senhas", Toast.LENGTH_SHORT).show();
                return;
            }
            if (!senha.equals(confirma)) {
                Toast.makeText(this, "As senhas não conferem", Toast.LENGTH_SHORT).show();
                return;
            }

            resetarSenhaAPI(senha);
        });
    }

    // --- CHAMADAS API ---
    private void enviarCodigoAPI(String email) {
        // Cria o objeto de requisição
        SolicitarCodigoRequest req = new SolicitarCodigoRequest(email);


        RetrofitClient.getService().solicitarCodigo(req).enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    // SUCESSO (200 OK)
                    emailGuardado = email; // Salva o email para as próximas etapas
                    Toast.makeText(ResetarSenhaActivity.this, "Código enviado! Verifique seu email.", Toast.LENGTH_LONG).show();

                    // Muda a tela para a etapa 2
                    layoutEmail.setVisibility(View.GONE);
                    layoutCodigo.setVisibility(View.VISIBLE);
                } else {
                    // ERRO (Aqui vamos descobrir a verdade)
                    int codigoErro = response.code();
                    String corpoErro = "";
                    try {
                        if (response.errorBody() != null) {
                            corpoErro = response.errorBody().string();
                        }
                    } catch (Exception e) {
                        corpoErro = "Erro desconhecido";
                    }

                    // MOSTRA NA TELA PARA VOCÊ VER
                    Toast.makeText(ResetarSenhaActivity.this, "Erro API: " + codigoErro, Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                // Erro de internet/cabo
                Toast.makeText(ResetarSenhaActivity.this, "Sem conexão: " + t.getMessage(), Toast.LENGTH_SHORT).show();
                t.printStackTrace();
            }
        });
    }


    private void validarCodigoAPI(String codigo) {
        ValidarCodigoRequest req = new ValidarCodigoRequest(emailGuardado, codigo);
        RetrofitClient.getService().validarCodigo(req).enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    codigoGuardado = codigo; // Guarda para usar depois
                    Toast.makeText(ResetarSenhaActivity.this, "Código Validado!", Toast.LENGTH_SHORT).show();

                    // Avança para Etapa 3 (Muda título e layout)
                    tvTitulo.setText("ALTERAR SENHA");
                    layoutCodigo.setVisibility(View.GONE);
                    layoutSenha.setVisibility(View.VISIBLE);
                } else {
                    Toast.makeText(ResetarSenhaActivity.this, "Código Inválido.", Toast.LENGTH_SHORT).show();
                }
            }
            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                Toast.makeText(ResetarSenhaActivity.this, "Erro de rede.", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void resetarSenhaAPI(String novaSenha) {
        ResetarSenhaRequest req = new ResetarSenhaRequest(emailGuardado, codigoGuardado, novaSenha);
        RetrofitClient.getService().resetarSenhaComCodigo(req).enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    Toast.makeText(ResetarSenhaActivity.this, "Senha alterada com sucesso!", Toast.LENGTH_LONG).show();
                    finish(); // Volta para o Login
                } else {
                    Toast.makeText(ResetarSenhaActivity.this, "Erro ao alterar senha.", Toast.LENGTH_SHORT).show();
                }
            }
            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                Toast.makeText(ResetarSenhaActivity.this, "Erro de rede.", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void inicializarComponentes() {
        tvTitulo = findViewById(R.id.tvTituloRecuperacao);

        layoutEmail = findViewById(R.id.layoutEtapa1_Email);
        layoutCodigo = findViewById(R.id.layoutEtapa2_Codigo);
        layoutSenha = findViewById(R.id.layoutEtapa3_Senha);

        edtEmail = findViewById(R.id.edtRecuperarEmail);
        edtCodigo = findViewById(R.id.edtCodigoVerificacao);
        edtNovaSenha = findViewById(R.id.edtNovaSenhaRecuperacao);
        edtConfirmar = findViewById(R.id.edtConfirmarSenhaRecuperacao);

        btnEnviar = findViewById(R.id.btnEnviarCodigo);
        btnValidar = findViewById(R.id.btnValidarCodigo);
        btnFinalizar = findViewById(R.id.btnFinalizarRecuperacao);
    }
}