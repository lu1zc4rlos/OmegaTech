package com.example.myapplication;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.LinearLayout;
import android.widget.ProgressBar;
import android.widget.TextView;
import android.widget.Toast;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

// Importe a classe Ticket correta (a que tem getTituloFormatado)
import com.example.myapplication.UI.TicketsAdapter;
import com.example.myapplication.data.model.TicketResponseDTO;
import com.example.myapplication.data.remote.RetrofitClient;
import com.example.myapplication.utils.SessionManager;
import com.google.android.material.bottomnavigation.BottomNavigationView;
import java.util.ArrayList;
import java.util.List;
import retrofit2.Call;
import retrofit2.Callback;
import retrofit2.Response;

public class HomeActivity extends AppCompatActivity {

    // UI Components
    private RecyclerView recyclerTickets;
    private ProgressBar progressBar;
    private TextView tvSemTickets;
    private android.widget.FrameLayout btnPerfilUsuario;

    // Contadores UI
    private TextView tvCountTotal, tvCountAberto, tvCountAndamento, tvCountConcluido;
    private LinearLayout btnFilterTotal, btnFilterAberto, btnFilterAndamento, btnFilterConcluido;

    // Dados (Usando Ticket, não TicketResponseDTO)
    private TicketsAdapter adapter;
    private List<TicketResponseDTO> listaTicketsExibicao;
    private List<TicketResponseDTO> listaTicketsMaster;
    private SessionManager session;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);

        session = new SessionManager(this);

        // 1. Vínculos
        vincularViews();

        carregarIniciaisUsuario();

        // 2. Configurar RecyclerView
        recyclerTickets.setLayoutManager(new LinearLayoutManager(this));
        listaTicketsExibicao = new ArrayList<>();
        listaTicketsMaster = new ArrayList<>();

        // Configura o Adapter com o Listener de Clique
        adapter = new TicketsAdapter(this, listaTicketsExibicao, ticket -> {
            Intent intent = new Intent(HomeActivity.this, DetalhesTicketActivity.class);
            intent.putExtra("TICKET_ID", ticket.getId());
            startActivity(intent);
        });

        recyclerTickets.setAdapter(adapter);

        // 3. Configurar Cliques nos Filtros
        configurarFiltros();

        // 4. Configurar Navegação e Perfil
        configurarNavegacao();
        btnPerfilUsuario.setOnClickListener(v -> {
            startActivity(new Intent(HomeActivity.this, ContaActivity.class));
        });
    }

    @Override
    protected void onResume() {
        super.onResume();
        carregarTicketsDaApi();
        BottomNavigationView bottomNav = findViewById(R.id.bottomNav);
        if (bottomNav != null) {
            bottomNav.setSelectedItemId(R.id.Nav_home);
        }
    }

    private void carregarTicketsDaApi() {
        progressBar.setVisibility(View.VISIBLE);
        tvSemTickets.setVisibility(View.GONE);

        String token = "Bearer " + session.getToken();

        // Retrofit deve retornar List<Ticket>
        RetrofitClient.getService().getMeusTickets(token).enqueue(new Callback<List<TicketResponseDTO>>() {

            @Override
            public void onResponse(Call<List<TicketResponseDTO>> call, Response<List<TicketResponseDTO>> response) {
                progressBar.setVisibility(View.GONE);
                if (response.isSuccessful() && response.body() != null) {
                    listaTicketsMaster.clear();
                    listaTicketsMaster.addAll(response.body());

                    atualizarContadores();
                    filtrarLista("TODOS");
                } else {
                    Toast.makeText(HomeActivity.this, "Erro: " + response.code(), Toast.LENGTH_SHORT).show();
                }
            }

            @Override
            public void onFailure(Call<List<TicketResponseDTO>> call, Throwable t) {
                progressBar.setVisibility(View.GONE);
                Toast.makeText(HomeActivity.this, "Erro de conexão", Toast.LENGTH_SHORT).show();
            }
        });
    }

    private void atualizarContadores() {
        int total = listaTicketsMaster.size();
        int abertos = 0;
        int andamento = 0;
        int concluidos = 0;

        for (TicketResponseDTO t : listaTicketsMaster) {
            String status = t.getStatus().toUpperCase();
            if (status.contains("PENDENTE") || status.contains("ABERTO")) {
                abertos++;
            } else if (status.contains("ANDAMENTO") || status.contains("ATENDIMENTO")) {
                andamento++;
            } else if (status.contains("CONCLUIDO") || status.contains("FINALIZADO") || status.contains("RESOLVIDO")) {
                concluidos++;
            }
        }

        tvCountTotal.setText(String.valueOf(total));
        tvCountAberto.setText(String.valueOf(abertos));
        tvCountAndamento.setText(String.valueOf(andamento));
        tvCountConcluido.setText(String.valueOf(concluidos));
    }

    private void filtrarLista(String filtro) {
        listaTicketsExibicao.clear();

        if (filtro.equals("TODOS")) {
            listaTicketsExibicao.addAll(listaTicketsMaster);
        } else {
            for (TicketResponseDTO t : listaTicketsMaster) {
                String status = t.getStatus().toUpperCase();

                if (filtro.equals("ABERTO") && (status.contains("PENDENTE") || status.contains("ABERTO"))) {
                    listaTicketsExibicao.add(t);
                } else if (filtro.equals("ANDAMENTO") && (status.contains("ANDAMENTO") || status.contains("ATENDIMENTO"))) {
                    listaTicketsExibicao.add(t);
                } else if (filtro.equals("CONCLUIDO") && (status.contains("CONCLUIDO") || status.contains("RESOLVIDO"))) {
                    listaTicketsExibicao.add(t);
                }
            }
        }

        adapter.notifyDataSetChanged();

        if (listaTicketsExibicao.isEmpty()) {
            tvSemTickets.setVisibility(View.VISIBLE);
            tvSemTickets.setText("Nenhum ticket com status: " + filtro);
        } else {
            tvSemTickets.setVisibility(View.GONE);
        }
    }

    private void configurarFiltros() {
        btnFilterTotal.setOnClickListener(v -> filtrarLista("TODOS"));
        btnFilterAberto.setOnClickListener(v -> filtrarLista("ABERTO"));
        btnFilterAndamento.setOnClickListener(v -> filtrarLista("ANDAMENTO"));
        btnFilterConcluido.setOnClickListener(v -> filtrarLista("CONCLUIDO"));
    }

    private void vincularViews() {
        recyclerTickets = findViewById(R.id.recyclerHomeTickets);
        progressBar = findViewById(R.id.progressBarHome);
        tvSemTickets = findViewById(R.id.tvSemTickets);
        btnPerfilUsuario = findViewById(R.id.btnPerfilUsuario);

        // Filtros
        tvCountTotal = findViewById(R.id.tvCountTotal);
        tvCountAberto = findViewById(R.id.tvCountAberto);
        tvCountAndamento = findViewById(R.id.tvCountAndamento);
        tvCountConcluido = findViewById(R.id.tvCountConcluido);

        btnFilterTotal = findViewById(R.id.cardFilterTotal);
        btnFilterAberto = findViewById(R.id.cardFilterAberto);
        btnFilterAndamento = findViewById(R.id.cardFilterAndamento);
        btnFilterConcluido = findViewById(R.id.cardFilterConcluido);
    }

    private void configurarNavegacao() {
        BottomNavigationView bottomNav = findViewById(R.id.bottomNav);
        bottomNav.setItemIconTintList(null);
        bottomNav.setSelectedItemId(R.id.Nav_home);

        bottomNav.setOnItemSelectedListener(item -> {
            int id = item.getItemId();

            if (id == R.id.Nav_home) {
                return true;
            }

            else if (id == R.id.nav_Omega_help) {
                startActivity(new Intent(this, OmegaHelpActivity.class));
                return true;
            }
            else if (id == R.id.nav_novo) {
                startActivity(new Intent(this, NovoTicketActivity.class));
                return true;
            }

            return false;
        });
    }

    private void carregarIniciaisUsuario() {
        // 1. Recupera o nome salvo no login
        // (Certifique-se que seu SessionManager tem o método getUsername ou getNome)
        // Se não tiver, me avise que ajustamos o SessionManager
        String nomeCompleto = session.getUsername();

        String iniciais = "US"; // Valor padrão (User) caso venha nulo

        if (nomeCompleto != null && !nomeCompleto.trim().isEmpty()) {
            // Divide o nome por espaços
            String[] partes = nomeCompleto.trim().split("\\s+");

            if (partes.length == 1) {
                // Se só tem um nome (Ex: "Pedro") -> Pega as 2 primeiras letras ou a primeira
                iniciais = partes[0].substring(0, Math.min(2, partes[0].length())).toUpperCase();
            } else {
                // Se tem nome e sobrenome (Ex: "Pedro Carvalho") -> Pega P e C
                String primeiraLetra = partes[0].substring(0, 1);
                String ultimaLetra = partes[partes.length - 1].substring(0, 1);
                iniciais = (primeiraLetra + ultimaLetra).toUpperCase();
            }
        }

        // 2. Encontra o TextView que está dentro do FrameLayout do avatar
        TextView tvIniciais = findViewById(R.id.tvIniciaisUsuario);

        // 3. Define o texto
        if (tvIniciais != null) {
            tvIniciais.setText(iniciais);
        }
    }
}