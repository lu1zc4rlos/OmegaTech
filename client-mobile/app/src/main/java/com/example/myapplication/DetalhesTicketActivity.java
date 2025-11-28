package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.cardview.widget.CardView;
import com.example.myapplication.data.model.TicketResponseDTO;
import com.example.myapplication.data.remote.RetrofitClient;
import com.example.myapplication.utils.SessionManager;
import com.google.android.material.floatingactionbutton.FloatingActionButton;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class DetalhesTicketActivity extends AppCompatActivity {

    private TextView tvHeaderTitulo, tvStatus, tvPrioridade, tvTituloFull, tvDescricao, tvData, tvTecnico, tvResposta;
    private CardView cardResposta;
    private FloatingActionButton fabExcluir; // Botão Novo
    private SessionManager session;
    private Long ticketIdAtual;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_detalhes_ticket);

        session = new SessionManager(this);
        vincularViews();

        findViewById(R.id.btnVoltarDetalhe).setOnClickListener(v -> finish());

        ticketIdAtual = getIntent().getLongExtra("TICKET_ID", -1);
        if (ticketIdAtual != -1) {
            carregarDetalhes(ticketIdAtual);
        } else {
            Toast.makeText(this, "Erro ao carregar ticket", Toast.LENGTH_SHORT).show();
            finish();
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
        fabExcluir = findViewById(R.id.fabExcluirTicket); // Vínculo do botão
    }

    private void carregarDetalhes(long id) {
        String token = "Bearer " + session.getToken();
        // ATENÇÃO: Use a classe DTO que seu backend retorna
        RetrofitClient.getService().getTicketDetalhe(token, id).enqueue(new Callback<TicketResponseDTO>() {
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
                Toast.makeText(DetalhesTicketActivity.this, "Erro de conexão", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void preencherTela(TicketResponseDTO t) {
        tvHeaderTitulo.setText("Ticket #" + t.getId());
        tvTituloFull.setText(t.getTituloFormatado());
        tvDescricao.setText(t.getDescricao());
        tvData.setText("📅 Criado em: " + t.getDataCriacao());
        tvStatus.setText(t.getStatus());
        tvPrioridade.setText(t.getPrioridade());

        if (t.getNomeTecnico() != null) {
            tvTecnico.setText("👤 Atribuído a: " + t.getNomeTecnico());
        } else {
            tvTecnico.setText("👤 Aguardando técnico...");
        }

        // Resposta do Técnico
        if (t.getRespostaTecnico() != null && !t.getRespostaTecnico().isEmpty()) {
            cardResposta.setVisibility(View.VISIBLE);
            tvResposta.setText(t.getRespostaTecnico());
        } else {
            cardResposta.setVisibility(View.GONE);
        }

        // --- LÓGICA DO BOTÃO EXCLUIR ---
        // Se o status for PENDENTE, mostra o botão. Caso contrário, esconde.
        if ("PENDENTE".equalsIgnoreCase(t.getStatus())) {
            fabExcluir.setVisibility(View.VISIBLE);
            fabExcluir.setOnClickListener(v -> confirmarExclusao());
        } else {
            fabExcluir.setVisibility(View.GONE);
        }
    }

    private void confirmarExclusao() {
        new AlertDialog.Builder(this)
                .setTitle("Excluir Ticket")
                .setMessage("Tem certeza que deseja excluir este chamado?")
                .setPositiveButton("Excluir", (dialog, which) -> excluirTicketAPI())
                .setNegativeButton("Cancelar", null)
                .show();
    }

    private void excluirTicketAPI() {
        String token = "Bearer " + session.getToken();
        RetrofitClient.getService().excluirTicket(token, ticketIdAtual).enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    Toast.makeText(DetalhesTicketActivity.this, "Ticket excluído com sucesso!", Toast.LENGTH_SHORT).show();

                    // Redireciona para a Home e limpa a pilha para forçar atualização da lista
                    Intent intent = new Intent(DetalhesTicketActivity.this, HomeActivity.class);
                    intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_NEW_TASK);
                    startActivity(intent);
                    finish();
                } else {
                    Toast.makeText(DetalhesTicketActivity.this, "Erro ao excluir: " + response.code(), Toast.LENGTH_SHORT).show();
                }
            }
            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                Toast.makeText(DetalhesTicketActivity.this, "Erro de rede", Toast.LENGTH_SHORT).show();
            }
        });
    }
}