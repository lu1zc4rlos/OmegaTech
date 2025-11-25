package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import com.example.myapplication.data.model.CadastroRequest;
import com.example.myapplication.data.model.LoginResponse;
import com.example.myapplication.data.remote.RetrofitClient;
import com.example.myapplication.utils.SessionManager;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class CadastroActivity extends AppCompatActivity {

    private EditText edtNome, edtEmail, edtSenha, edtNascimento;
    private Button btnFinalizar;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_cadastro);

        // 1. Vincular Componentes Visuais
        edtNome = findViewById(R.id.edtNomeCadastro);
        edtEmail = findViewById(R.id.edtEmailCadastro);
        edtSenha = findViewById(R.id.edtSenhaCadastro);
        edtNascimento = findViewById(R.id.edtNascimentoCadastro);
        btnFinalizar = findViewById(R.id.btnFinalizarCadastro);

        // 2. Configurar o Botão
        btnFinalizar.setOnClickListener(v -> {
            String nome = edtNome.getText().toString();
            String email = edtEmail.getText().toString();
            String senha = edtSenha.getText().toString();
            String dataInput = edtNascimento.getText().toString();

            // Validação Simples
            if (nome.isEmpty() || email.isEmpty() || senha.isEmpty() || dataInput.isEmpty()) {
                Toast.makeText(this, "Preencha todos os campos!", Toast.LENGTH_SHORT).show();
                return;
            }

            // 3. Converter Data (DD/MM/AAAA -> YYYY-MM-DD)
            String dataFormatada = converterDataParaApi(dataInput);
            if (dataFormatada == null) {
                Toast.makeText(this, "Data inválida. Use dia/mês/ano (Ex: 20/05/1999)", Toast.LENGTH_LONG).show();
                return;
            }

            realizarCadastro(nome, email, senha, dataFormatada);
        });
    }

    // Função auxiliar para formatar a data
    private String converterDataParaApi(String dataBr) {
        try {
            // Divide a string onde tiver barra "/"
            String[] partes = dataBr.split("/");
            if (partes.length != 3) return null; // Tem que ter dia, mes e ano

            String dia = partes[0];
            String mes = partes[1];
            String ano = partes[2];

            // Monta no formato ISO (Ano-Mes-Dia)
            return ano + "-" + mes + "-" + dia;
        } catch (Exception e) {
            return null;
        }
    }

    private void realizarCadastro(String nome, String email, String senha, String dataNasc) {
        // Cria o objeto de requisição (Perfil já vai como "CLIENTE" dentro dele)
        CadastroRequest request = new CadastroRequest(nome, email, senha, dataNasc);

        // Chama a API
        RetrofitClient.getService().cadastrar(request).enqueue(new Callback<LoginResponse>() {
            @Override
            public void onResponse(Call<LoginResponse> call, Response<LoginResponse> response) {
                if (response.isSuccessful() && response.body() != null) {
                    // SUCESSO!
                    String token = response.body().getToken();
                    String usuario = response.body().getUsername();

                    // Salva sessão e vai pra Home
                    SessionManager session = new SessionManager(CadastroActivity.this);
                    session.saveSession(token, usuario);

                    Toast.makeText(CadastroActivity.this, "Bem-vindo, " + usuario, Toast.LENGTH_LONG).show();

                    Intent intent = new Intent(CadastroActivity.this, HomeActivity.class);
                    // Limpa o histórico para ele não voltar pro cadastro
                    intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
                    startActivity(intent);
                    finish();
                } else {
                    // ERRO (Ex: Email já existe ou dados inválidos)
                    Log.e("CADASTRO", "Erro API: " + response.code());
                    Toast.makeText(CadastroActivity.this, "Falha no cadastro. Código: " + response.code(), Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void onFailure(Call<LoginResponse> call, Throwable t) {
                // ERRO DE CONEXÃO
                Log.e("CADASTRO", "Erro Rede: " + t.getMessage());
                Toast.makeText(CadastroActivity.this, "Sem conexão com o servidor.", Toast.LENGTH_SHORT).show();
            }
        });
    }
}