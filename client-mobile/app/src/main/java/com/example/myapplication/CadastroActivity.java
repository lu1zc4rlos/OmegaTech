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

        edtNascimento.addTextChangedListener(criarMascaraData(edtNascimento));

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

            //Valida a Data (Futuro/Passado/Formato)
            if (!isDataValida(dataInput)) {
                edtNascimento.setError("Data inválida!");
                edtNascimento.requestFocus();
                return; // Para aqui
            }

            // Valida a Força da Senha
            if (!isSenhaForte(senha)) {
                edtSenha.setError("Senha fraca! Use:\n- Maiúscula\n- Minúscula\n- Número\n- Símbolo (@#$...)");
                edtSenha.requestFocus();
                return; // Para aqui
            }

            //Converter Data (DD/MM/AAAA -> YYYY-MM-DD)
            String dataFormatada = converterDataParaApi(dataInput);
            if (dataFormatada == null) {
                Toast.makeText(this, "Data inválida. Use dia/mês/ano (Ex: 20/05/1999)", Toast.LENGTH_LONG).show();
                return;
            }


            realizarCadastro(nome, email, senha, dataFormatada);
        });

    }

    private boolean isSenhaForte(String senha) {
        if (senha.length() < 8) return false;

        // Regex que exige pelo menos um de cada grupo
        String regex = "^(?=.*[0-9])(?=.*[a-z])(?=.*[A-Z])(?=.*[@#$%^&+=!]).{8,}$";

        // Se quiser algo mais simples (sem regex complexo), podemos fazer checks manuais,
        // mas o regex acima é o padrão de indústria.
        return senha.matches(regex);
    }

    // Método auxiliar para criar a máscara de data (DD/MM/AAAA)
    private android.text.TextWatcher criarMascaraData(final EditText editText) {
        return new android.text.TextWatcher() {
            boolean isUpdating;
            String old = "";
            @Override
            public void onTextChanged(CharSequence s, int start, int before, int count) {
                String str = s.toString().replaceAll("[^\\d]", ""); // Remove tudo que não é número
                String mascara = "";

                if (isUpdating) {
                    old = str;
                    isUpdating = false;
                    return;
                }

                int i = 0;
                // Formato: ##/##/####
                // O Java vai inserindo as barras automaticamente enquanto o usuário digita
                if (str.length() > 2 && str.length() <= 4) {
                    mascara = str.substring(0, 2) + "/" + str.substring(2);
                } else if (str.length() > 4) {
                    mascara = str.substring(0, 2) + "/" + str.substring(2, 4) + "/" + str.substring(4);
                } else {
                    mascara = str;
                }

                isUpdating = true;
                editText.setText(mascara);
                editText.setSelection(mascara.length()); // Mantém o cursor no final
            }

            @Override
            public void beforeTextChanged(CharSequence s, int start, int count, int after) {}

            @Override
            public void afterTextChanged(android.text.Editable s) {}
        };
    }

    // Verifica se a data é válida e não é futura
    private boolean isDataValida(String dataTexto) {
        try {
            // Define o formato esperado
            java.text.SimpleDateFormat sdf = new java.text.SimpleDateFormat("dd/MM/yyyy");
            sdf.setLenient(false); // Não aceita dia 32, mês 13, etc.

            java.util.Date dataInserida = sdf.parse(dataTexto);
            java.util.Date hoje = new java.util.Date();

            // Verifica se é futuro
            if (dataInserida.after(hoje)) {
                return false;
            }

            // Verifica se é muito antigo (ex: ano 1930)
            java.util.Calendar limiteAntigo = java.util.Calendar.getInstance();
            limiteAntigo.set(1931, 0, 1);
            if (dataInserida.before(limiteAntigo.getTime())) {
                return false;
            }

            return true;
        } catch (Exception e) {
            return false; // Deu erro ao ler a data (formato errado)
        }
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
                    String perfil = response.body().getPerfil();

                    // Salva sessão e vai pra Home
                    SessionManager session = new SessionManager(CadastroActivity.this);
                    session.saveSession(token, usuario, email, perfil);

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