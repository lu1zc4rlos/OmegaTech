package com.example.myapplication; // MANTENHA O SEU PACOTE ORIGINAL AQUI

// 1. IMPORTS (Resolvem os erros de "Cannot resolve symbol Toast/Log/Bundle")
import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import com.example.myapplication.data.model.LoginRequest;
import com.example.myapplication.data.model.LoginResponse;
import com.example.myapplication.data.remote.RetrofitClient;
import com.example.myapplication.utils.SessionManager;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class MainActivity extends AppCompatActivity {

    // 2. DECLARAÇÃO DE VARIÁVEIS GLOBAIS (Resolvem erro "Cannot resolve symbol edtEmail")
    // Elas precisam estar aqui fora para serem vistas por toda a classe
    private EditText edtEmail;
    private EditText edtSenha;
    private Button btnLogin;

    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        // 3. INICIALIZAÇÃO (Vincula o Java com o XML)
        edtEmail = findViewById(R.id.username);
        edtSenha = findViewById(R.id.password);
        btnLogin = findViewById(R.id.loginButton);

        // 1. Encontre o CheckBox (verifique se o ID bate com o XML)
        CheckBox chkMostrarSenha = findViewById(R.id.chkMostrarSenhaLogin);

// 2. Adicione o ouvinte de mudança de estado
        chkMostrarSenha.setOnCheckedChangeListener((buttonView, isChecked) -> {

            // A. Salva onde o cursor está antes de mudar o tipo
            int cursor = edtSenha.getSelectionEnd();

            if (isChecked) {
                // MOSTRAR: Remove a máscara de senha
                edtSenha.setInputType(android.text.InputType.TYPE_TEXT_VARIATION_VISIBLE_PASSWORD);
            } else {
                // ESCONDER: Aplica Texto Normal + Variação Senha (Bolinhas)
                // O operador "|" soma as duas propriedades
                edtSenha.setInputType(android.text.InputType.TYPE_CLASS_TEXT | android.text.InputType.TYPE_TEXT_VARIATION_PASSWORD);
            }

            // B. Restaura o cursor para a posição original
            // (Se o cursor for válido, ou seja, maior ou igual a 0)
            if (cursor >= 0) {
                edtSenha.setSelection(cursor);
            }
        });


        TextView tvTrocarSenha = findViewById(R.id.tvTrocarSenha);

        // 2. Configure o clique
        tvTrocarSenha.setOnClickListener(v -> {
            // Cria a intenção de abrir a tela de Alterar Senha
            Intent intent = new Intent(MainActivity.this, AlterarSenhaActivity.class);
            startActivity(intent);
        });

        Button btnIrParaCadastro = findViewById(R.id.btnCadastrar);

        btnIrParaCadastro.setOnClickListener(v -> {
            android.content.Intent intent = new android.content.Intent(MainActivity.this, CadastroActivity.class);
            startActivity(intent);
        });

        btnLogin.setOnClickListener(v -> {
            String email = edtEmail.getText().toString();
            String senha = edtSenha.getText().toString();

            if (email.isEmpty() || senha.isEmpty()) {
                Toast.makeText(this, "Preencha todos os campos", Toast.LENGTH_SHORT).show();
                return;
            }

            // Chama o método que está definido lá embaixo
            realizarLogin(email, senha);
        });
    }

    // 4. O MÉTODO DE LOGIN (Resolve o erro "Cannot resolve method realizarLogin")
    // Ele tem que estar FORA do onCreate, mas DENTRO da class MainActivity
    private void realizarLogin(String email, String senha) {
        LoginRequest request = new LoginRequest(email, senha);

        RetrofitClient.getService().login(request).enqueue(new Callback<LoginResponse>() {
            @Override
            public void onResponse(Call<LoginResponse> call, Response<LoginResponse> response) {
                if (response.isSuccessful() && response.body() != null) {
                    String token = response.body().getToken();
                    String usuario = response.body().getUsername();

                    // 1. Instancia o Gerenciador e salva os dados
                    SessionManager session = new SessionManager(MainActivity.this);
                    session.saveSession(token, usuario);

                    // 2. Feedback visual rápido
                    Toast.makeText(MainActivity.this, "Bem-vindo, " + usuario, Toast.LENGTH_SHORT).show();

                    // 3. Inicia a próxima tela
                    Intent intent = new Intent(MainActivity.this, HomeActivity.class);
                    startActivity(intent);

                    // 4. IMPORTANTE: "Mata" a tela de login
                    // Se o usuário apertar "Voltar" na Home, ele sai do app, mas não volta pro Login.
                    finish();

                } else {
                    // ... (código de erro continua igual)
                    Log.e("API_TEST", "Erro: " + response.code());
                    Toast.makeText(MainActivity.this, "Login falhou: " + response.code(), Toast.LENGTH_SHORT).show();
                }
            }

            @Override
            public void onFailure(Call<LoginResponse> call, Throwable t) {
                Log.e("API_TEST", "Falha: " + t.getMessage());
                Toast.makeText(MainActivity.this, "Falha: " + t.getMessage(), Toast.LENGTH_LONG).show();
            }
        });
    }
}