package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.ProgressBar;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;

import com.example.myapplication.data.model.MensagemRequest;
import com.example.myapplication.data.remote.RetrofitClient;
import com.example.myapplication.utils.SessionManager;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class NovoTicketActivity extends AppCompatActivity {

    private EditText edtDescricao;
    private Button btnCriar;
    private ProgressBar progressBar;
    private SessionManager session;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_novo_ticket);

        session = new SessionManager(this);

        edtDescricao = findViewById(R.id.edtDescricaoTicket);
        btnCriar = findViewById(R.id.btnCriarTicket);
        progressBar = findViewById(R.id.progressNovoTicket);

        btnCriar.setOnClickListener(v -> {
            String descricao = edtDescricao.getText().toString().trim();
            if (descricao.isEmpty()) {
                Toast.makeText(this, "Descreva o problema!", Toast.LENGTH_SHORT).show();
                return;
            }
            criarTicketAPI(descricao);
        });
    }

    private void criarTicketAPI(String descricao) {
        progressBar.setVisibility(View.VISIBLE);
        btnCriar.setEnabled(false); // Evita duplo clique

        String token = "Bearer " + session.getToken();
        MensagemRequest request = new MensagemRequest(descricao);

        RetrofitClient.getService().criarTicket(token, request).enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                progressBar.setVisibility(View.GONE);
                btnCriar.setEnabled(true);

                if (response.isSuccessful()) {
                    Toast.makeText(NovoTicketActivity.this, "Chamado criado com sucesso!", Toast.LENGTH_LONG).show();
                    // Em vez de apenas finish(), forçamos a ida para a Home
                    Intent intent = new Intent(NovoTicketActivity.this, HomeActivity.class);
                    // Essas flags limpam a pilha e garantem que o onCreate/onResume da Home rode de novo
                    intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_NEW_TASK);
                    startActivity(intent);
                    finish();
                } else {
                    Toast.makeText(NovoTicketActivity.this, "Erro ao criar: " + response.code(), Toast.LENGTH_SHORT).show();
                }
            }

            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                progressBar.setVisibility(View.GONE);
                btnCriar.setEnabled(true);
                Toast.makeText(NovoTicketActivity.this, "Erro de rede.", Toast.LENGTH_SHORT).show();
            }
        });
    }
}