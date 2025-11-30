package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.EditText;
import android.widget.Button;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AlertDialog;
import androidx.appcompat.app.AppCompatActivity;
import androidx.cardview.widget.CardView;

import com.example.myapplication.data.model.RespostaTicketDTO; // NOVO
import com.example.myapplication.data.model.StatusUpdateDTO;
import com.example.myapplication.data.model.TicketResponseDTO;
import com.example.myapplication.data.remote.RetrofitClient;
import com.example.myapplication.utils.SessionManager;
import com.google.android.material.floatingactionbutton.ExtendedFloatingActionButton;
import com.google.android.material.floatingactionbutton.FloatingActionButton;

import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class DetalhesTicketActivity extends AppCompatActivity {

    private TextView tvHeaderTitulo, tvStatus, tvPrioridade, tvTituloFull, tvDescricao, tvData, tvTecnico, tvResposta;
    private CardView cardResposta;

    // NOVOS COMPONENTES PARA RESPOSTA
    private CardView cardInputResposta;
    private EditText edtResposta;
    private Button btnConcluir;

    private FloatingActionButton fabExcluir;
    private ExtendedFloatingActionButton fabAtender;

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

        // NOVOS VÍNCULOS
        cardInputResposta = findViewById(R.id.cardInputResposta);
        edtResposta = findViewById(R.id.edtRespostaTecnico);
        btnConcluir = findViewById(R.id.btnConcluirChamado);

        fabExcluir = findViewById(R.id.fabExcluirTicket);
        fabAtender = findViewById(R.id.fabAtenderTicket);
    }

    private void carregarDetalhes(long id) {
        String token = "Bearer " + session.getToken();
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
        tvData.setText("📅 " + t.getDataCriacao());
        tvStatus.setText(t.getStatus());
        tvPrioridade.setText(t.getPrioridade());

        if (t.getNomeTecnico() != null) {
            tvTecnico.setText("👤 Atribuído a: " + t.getNomeTecnico());
        } else {
            tvTecnico.setText("👤 Aguardando técnico...");
        }

        // Card de Resposta (Leitura)
        if (t.getRespostaTecnico() != null && !t.getRespostaTecnico().isEmpty()) {
            cardResposta.setVisibility(View.VISIBLE);
            tvResposta.setText(t.getRespostaTecnico());
        } else {
            cardResposta.setVisibility(View.GONE);
        }

        // --- LÓGICA DE BOTÕES E INPUTS ---
        String perfil = session.getPerfil();
        String meuNome = session.getUsername(); // Nome do usuário logado



        // Reseta visibilidade
        fabExcluir.setVisibility(View.GONE);
        fabAtender.setVisibility(View.GONE);
        cardInputResposta.setVisibility(View.GONE);

        if ("ROLE_TECNICO".equals(perfil)) {
            // --- TÉCNICO ---
            if ("PENDENTE".equalsIgnoreCase(t.getStatus())) {
                // Pode pegar o chamado
                fabAtender.setVisibility(View.VISIBLE);
                fabAtender.setOnClickListener(v -> atenderChamado());
            }
            else if ("EM_ANDAMENTO".equalsIgnoreCase(t.getStatus())) {
                // Verifica se é o dono do chamado
                boolean souDono = t.getNomeTecnico() != null && t.getNomeTecnico().equalsIgnoreCase(meuNome);

                if (souDono) {
                    // Mostra campo para responder e concluir
                    cardInputResposta.setVisibility(View.VISIBLE);
                    btnConcluir.setOnClickListener(v -> {
                        String resp = edtResposta.getText().toString();
                        if (!resp.trim().isEmpty()) {
                            enviarRespostaFinal(resp);
                        } else {
                            Toast.makeText(this, "Escreva a solução!", Toast.LENGTH_SHORT).show();
                        }
                    });
                }
            }
        }
        else {
            // --- CLIENTE ---
            if ("PENDENTE".equalsIgnoreCase(t.getStatus())) {
                fabExcluir.setVisibility(View.VISIBLE);
                fabExcluir.setOnClickListener(v -> confirmarExclusao());
            }
        }
    }

    // --- AÇÕES ---

    private void atenderChamado() {
        String token = "Bearer " + session.getToken();
        StatusUpdateDTO body = new StatusUpdateDTO("EM_ANDAMENTO");
        RetrofitClient.getService().atualizarStatus(token, ticketIdAtual, body).enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    Toast.makeText(DetalhesTicketActivity.this, "Chamado assumido!", Toast.LENGTH_SHORT).show();
                    voltarParaHome();
                }
            }
            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                Toast.makeText(DetalhesTicketActivity.this, "Erro de rede", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void enviarRespostaFinal(String texto) {
        String token = "Bearer " + session.getToken();
        RespostaTicketDTO body = new RespostaTicketDTO(texto);
        RetrofitClient.getService().responderTicket(token, ticketIdAtual, body).enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    Toast.makeText(DetalhesTicketActivity.this, "Chamado concluído!", Toast.LENGTH_LONG).show();
                    voltarParaHome();
                } else {
                    Toast.makeText(DetalhesTicketActivity.this, "Erro: " + response.code(), Toast.LENGTH_SHORT).show();
                }
            }
            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                Toast.makeText(DetalhesTicketActivity.this, "Erro de rede", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void confirmarExclusao() {
        new AlertDialog.Builder(this)
                .setTitle("Excluir Ticket")
                .setMessage("Tem certeza que deseja excluir?")
                .setPositiveButton("Sim", (dialog, which) -> excluirTicketAPI())
                .setNegativeButton("Não", null)
                .show();
    }

    private void excluirTicketAPI() {
        String token = "Bearer " + session.getToken();
        RetrofitClient.getService().excluirTicket(token, ticketIdAtual).enqueue(new Callback<Void>() {
            @Override
            public void onResponse(Call<Void> call, Response<Void> response) {
                if (response.isSuccessful()) {
                    Toast.makeText(DetalhesTicketActivity.this, "Excluído!", Toast.LENGTH_SHORT).show();
                    voltarParaHome();
                }
            }
            @Override
            public void onFailure(Call<Void> call, Throwable t) {
                Toast.makeText(DetalhesTicketActivity.this, "Erro de rede", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void voltarParaHome() {
        Intent intent = new Intent(DetalhesTicketActivity.this, HomeActivity.class);
        intent.addFlags(Intent.FLAG_ACTIVITY_CLEAR_TOP | Intent.FLAG_ACTIVITY_NEW_TASK);
        startActivity(intent);
        finish();
    }
}