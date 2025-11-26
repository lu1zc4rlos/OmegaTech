package com.example.myapplication;

import android.os.Bundle;
import android.widget.EditText;
import android.widget.ImageButton;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.example.myapplication.UI.ChatAdapter;
import com.example.myapplication.data.model.ChatMessage;
import com.example.myapplication.data.model.ChatResponse;
import com.example.myapplication.data.model.MensagemRequest;
import com.example.myapplication.data.remote.RetrofitClient;
import com.example.myapplication.utils.SessionManager;

import java.util.ArrayList;
import java.util.List;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class OmegaHelpActivity extends AppCompatActivity {

    private RecyclerView recyclerChat;
    private ChatAdapter adapter;
    private List<ChatMessage> listaMensagens;

    private EditText edtMensagem;
    private ImageButton btnEnviar;
    private SessionManager session;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_omega_help);

        session = new SessionManager(this);

        // 1. Configuração do RecyclerView
        recyclerChat = findViewById(R.id.recyclerChat); // <--- VAMOS MUDAR O ID NO XML JÁ JÁ
        listaMensagens = new ArrayList<>();

        // LayoutManager define como a lista aparece (Vertical)
        LinearLayoutManager layoutManager = new LinearLayoutManager(this);
        layoutManager.setStackFromEnd(true); // Começa de baixo pra cima (estilo WhatsApp)
        recyclerChat.setLayoutManager(layoutManager);

        adapter = new ChatAdapter(this, listaMensagens);
        recyclerChat.setAdapter(adapter);

        // 2. Resto das views
        edtMensagem = findViewById(R.id.edtMensagemChat);
        btnEnviar = findViewById(R.id.btnEnviarChat);

        // Mensagem inicial
        adicionarMensagem("Olá! Sou o assistente da OmegaTech. Como posso ajudar?", false);

        btnEnviar.setOnClickListener(v -> {
            String msg = edtMensagem.getText().toString().trim();
            if (!msg.isEmpty()) {
                enviarMensagem(msg);
            }
        });
    }

    private void enviarMensagem(String mensagem) {
        // Adiciona minha mensagem na lista
        adicionarMensagem(mensagem, true);
        edtMensagem.setText("");

        String token = "Bearer " + session.getToken();
        MensagemRequest req = new MensagemRequest(mensagem);

        RetrofitClient.getService().enviarMensagemChat(token, req).enqueue(new Callback<ChatResponse>() {
            @Override
            public void onResponse(Call<ChatResponse> call, Response<ChatResponse> response) {
                if (response.isSuccessful() && response.body() != null) {
                    String respostaBot = response.body().getResposta();
                    adicionarMensagem(respostaBot, false);
                } else {
                    adicionarMensagem("Erro ao processar: " + response.code(), false);
                }
            }

            @Override
            public void onFailure(Call<ChatResponse> call, Throwable t) {
                adicionarMensagem("Sem conexão com o servidor.", false);
            }
        });
    }

    private void adicionarMensagem(String texto, boolean isUsuario) {
        // Adiciona na lista de dados
        listaMensagens.add(new ChatMessage(texto, isUsuario));

        // Avisa o adaptador que tem coisa nova na última posição
        adapter.notifyItemInserted(listaMensagens.size() - 1);

        // Rola a tela para a última mensagem
        recyclerChat.smoothScrollToPosition(listaMensagens.size() - 1);
    }
}