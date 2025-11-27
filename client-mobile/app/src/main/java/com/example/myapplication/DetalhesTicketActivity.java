package com.example.myapplication;

import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;
import androidx.cardview.widget.CardView;

import com.example.myapplication.data.model.TicketResponseDTO;
import com.example.myapplication.data.remote.RetrofitClient;
import com.example.myapplication.utils.SessionManager;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class DetalhesTicketActivity extends AppCompatActivity {

    private TextView tvHeaderTitulo, tvStatus, tvPrioridade, tvTituloFull, tvDescricao, tvData, tvTecnico, tvResposta;
    private CardView cardResposta;
    private SessionManager session;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detalhes_ticket);

        session = new SessionManager(this);
        vincularViews();

        // Botão Voltar
        findViewById(R.id.btnVoltarDetalhe).setOnClickListener(v -> finish());

        // Pegar ID do Ticket
        long ticketId = getIntent().getLongExtra("TICKET_ID", -1);
        if (ticketId != -1) {
            carregarDetalhes(ticketId);
        } else {
            Toast.makeText(this, "Erro ao abrir ticket", Toast.LENGTH_SHORT).show();
            finish();
        }
    }

    private void carregarDetalhes(long id) {
        String token = "Bearer " + session.getToken();
        RetrofitClient.getService().getTicketDetalhe(token, id).enqueue(new Callback<TicketResponseDTO>() { // Usando a classe Ticket mesmo
            @Override
            public void onResponse(Call<TicketResponseDTO> call, Response<TicketResponseDTO> response) {
                if (response.isSuccessful() && response.body() != null) {
                    preencherTela(response.body());
                } else {
                    Toast.makeText(DetalhesTicketActivity.this, "Erro: " + response.code(), Toast.LENGTH_SHORT).show();
                }
            }

            @Override
            public void onFailure(Call<TicketResponseDTO> call, Throwable t) {
                Toast.makeText(DetalhesTicketActivity.this, "Falha de rede", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void preencherTela(TicketResponseDTO t) {
        tvHeaderTitulo.setText("Ticket #" + t.getId());
        tvTituloFull.setText(t.getTituloFormatado());
        tvDescricao.setText(t.getDescricao());
        tvData.setText("📅 Criado em: " + t.getDataCriacao());

        // Técnico
        if (t.getNomeTecnico() != null && !t.getNomeTecnico().isEmpty()) {
            tvTecnico.setText("👤 Atribuído a: " + t.getNomeTecnico());
        } else {
            tvTecnico.setText("👤 Atribuído a: Aguardando técnico...");
        }

        // Status e Cor
        tvStatus.setText(t.getStatus());
        // ... (Lógica de cor igual ao Adapter, pode copiar de lá ou criar um Helper) ...

        // Prioridade
        tvPrioridade.setText(t.getPrioridade());

        // Resposta do Técnico
        if (t.getRespostaTecnico() != null && !t.getRespostaTecnico().isEmpty()) {
            cardResposta.setVisibility(View.VISIBLE);
            tvResposta.setText(t.getRespostaTecnico());
        } else {
            cardResposta.setVisibility(View.GONE);
        }
    }

    private void vincularViews() {
        tvHeaderTitulo = findViewById(R.id.tvHeaderTitulo);
        tvStatus = findViewById(R.id.tvDetalheStatus);
        tvPrioridade = findViewById(R.id.tvDetalhePrioridade);
        tvTituloFull = findViewById(R.id.tvDetalheTituloFull);
        tvDescricao = findViewById(R.id.tvDetalheDescricao);
        tvData = findViewById(R.id.tvDetalheData);
        tvTecnico = findViewById(R.id.tvDetalheTecnico);
        tvResposta = findViewById(R.id.tvTextoResposta);
        cardResposta = findViewById(R.id.cardRespostaTecnico);
    }
}