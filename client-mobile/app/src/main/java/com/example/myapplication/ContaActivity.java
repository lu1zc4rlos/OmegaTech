package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.widget.LinearLayout;
import android.widget.TextView;
import androidx.appcompat.app.AppCompatActivity;
import com.example.myapplication.utils.SessionManager;

public class ContaActivity extends AppCompatActivity {

    private SessionManager session;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_conta);

        session = new SessionManager(this);

        // 1. VINCULAR
        TextView tvNome = findViewById(R.id.tvNomeConta);
        TextView tvIniciais = findViewById(R.id.tvIniciaisConta);
        // TextView tvEmail = findViewById(R.id.tvEmailConta); // REMOVIDO
        LinearLayout btnSair = findViewById(R.id.btnSairConta);

        // 2. PREENCHER DADOS
        String nome = session.getUsername(); // Pega apenas o nome salvo
        tvNome.setText(nome != null ? nome : "Usuário");

        // Não precisamos mais setar o email
        // tvEmail.setText(session.getEmail());

        // Lógica de Iniciais
        tvIniciais.setText(obterIniciais(nome));

        // 3. AÇÃO DE VOLTAR
        findViewById(R.id.btnVoltarConta).setOnClickListener(v -> finish());

        // 4. AÇÃO DE SAIR
        btnSair.setOnClickListener(v -> {
            session.clearSession();

            // Limpa toda a pilha e volta pro Login
            Intent intent = new Intent(ContaActivity.this, MainActivity.class);
            intent.setFlags(Intent.FLAG_ACTIVITY_NEW_TASK | Intent.FLAG_ACTIVITY_CLEAR_TASK);
            startActivity(intent);
            finish();
        });
    }

    private String obterIniciais(String nomeCompleto) {
        if (nomeCompleto == null || nomeCompleto.trim().isEmpty()) return "US";
        String[] partes = nomeCompleto.trim().split("\\s+");
        if (partes.length == 1) {
            // Se o nome for curto (ex: "A"), evita erro de substring
            int letras = Math.min(2, partes[0].length());
            return partes[0].substring(0, letras).toUpperCase();
        }
        // Pega 1ª letra do primeiro nome + 1ª letra do último nome
        String inicial1 = partes[0].substring(0, 1);
        String inicial2 = partes[partes.length - 1].substring(0, 1);
        return (inicial1 + inicial2).toUpperCase();
    }
}