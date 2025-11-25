package com.example.myapplication;

import android.os.Bundle;
import android.text.InputType;
import android.widget.Button;
import android.widget.CheckBox;
import android.widget.EditText;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import com.example.myapplication.data.model.AlterarSenhaRequest;
import com.example.myapplication.data.remote.RetrofitClient;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class AlterarSenhaActivity extends AppCompatActivity {

    // Declaração
    private EditText edtEmail, edtSenhaAtual, edtNovaSenha, edtConfirmar;
    private CheckBox chkMostrar;
    private Button btnConfirmar, btnOutraForma;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        // 1. OBRIGATÓRIO: Define o layout antes de buscar IDs
        setContentView(R.layout.activity_alterar_senha);

        // 2. VINCULAÇÃO (Bind) - IDs devem bater com o XML
        edtEmail = findViewById(R.id.edtEmailTroca);
        edtSenhaAtual = findViewById(R.id.edtSenhaAtual);
        edtNovaSenha = findViewById(R.id.edtNovaSenha);
        edtConfirmar = findViewById(R.id.edtConfirmarSenha);
        chkMostrar = findViewById(R.id.chkMostrarSenhas);
        btnConfirmar = findViewById(R.id.btnConfirmarTroca);
        btnOutraForma = findViewById(R.id.btnOutraForma);




        // 3. Lógica do Checkbox (Mostrar/Esconder Senha)
        chkMostrar.setOnCheckedChangeListener((buttonView, isChecked) -> {
            int inputType = isChecked ?
                    InputType.TYPE_TEXT_VARIATION_VISIBLE_PASSWORD :
                    (InputType.TYPE_CLASS_TEXT | InputType.TYPE_TEXT_VARIATION_PASSWORD);

            edtSenhaAtual.setInputType(inputType);
            edtNovaSenha.setInputType(inputType);
            edtConfirmar.setInputType(inputType);

            // Mantém o cursor no final (UX)
            edtSenhaAtual.setSelection(edtSenhaAtual.length());
        });


        //Lógica do botão tentar outra forma

        if (btnOutraForma != null) {
            btnOutraForma.setOnClickListener(v -> {
                // Na sua print, o nome da classe de destino é ResetarSenhaActivity
                android.content.Intent intent = new android.content.Intent(AlterarSenhaActivity.this, ResetarSenhaActivity.class);
                startActivity(intent);
            });
        }



        // 4. Lógica do Botão confirmar
        btnConfirmar.setOnClickListener(v -> {
            String email = edtEmail.getText().toString();
            String atual = edtSenhaAtual.getText().toString();
            String nova = edtNovaSenha.getText().toString();
            String confirma = edtConfirmar.getText().toString();

            // Validação Local (Evita gastar rede à toa)
            if (email.isEmpty() || atual.isEmpty() || nova.isEmpty()) {
                Toast.makeText(this, "Preencha todos os campos", Toast.LENGTH_SHORT).show();
                return;
            }

            if (!nova.equals(confirma)) {
                Toast.makeText(this, "As senhas novas não conferem!", Toast.LENGTH_SHORT).show();
                return;
            }

            // Se passou, chama a API
            realizarTroca(email, atual, nova);
        });
    }

    private void realizarTroca(String email, String atual, String nova) {
        AlterarSenhaRequest request = new AlterarSenhaRequest(email, atual, nova);

        RetrofitClient.getService().alterarSenha(request).enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    Toast.makeText(AlterarSenhaActivity.this, "Sucesso! Senha alterada.", Toast.LENGTH_LONG).show();
                    finish(); // Fecha a tela e volta pro Login
                } else {
                    // Erro 400 ou 401 ou 500
                    Toast.makeText(AlterarSenhaActivity.this, "Falha: " + response.code() + " Verifique os dados e tente novamente.", Toast.LENGTH_LONG).show();
                }
            }

            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                Toast.makeText(AlterarSenhaActivity.this, "Erro de Conexão: " + t.getMessage(), Toast.LENGTH_SHORT).show();
            }
        });
    }
}