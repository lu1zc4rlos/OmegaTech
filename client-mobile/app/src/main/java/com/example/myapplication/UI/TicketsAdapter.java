package com.example.myapplication.UI; // Ajuste se seu pacote for com.example.myapplication.UI

import android.content.Context;
import android.graphics.Color;
import android.graphics.drawable.GradientDrawable;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;
import androidx.recyclerview.widget.RecyclerView;

// Importando sua classe DTO correta
import com.example.myapplication.R;
import com.example.myapplication.data.model.TicketResponseDTO;

import java.util.List;

public class TicketsAdapter extends RecyclerView.Adapter<TicketsAdapter.TicketViewHolder> {

    private List<TicketResponseDTO> tickets;
    private Context context;
    private OnTicketClickListener listener;

    public interface OnTicketClickListener {
        void onTicketClick(TicketResponseDTO ticket);
    }

    public TicketsAdapter(Context context, List<TicketResponseDTO> tickets, OnTicketClickListener listener) {
        this.context = context;
        this.tickets = tickets;
        this.listener = listener;
    }

    @NonNull
    @Override
    public TicketViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        // Infla o layout de UM item da lista
        View view = LayoutInflater.from(context).inflate(R.layout.item_ticket, parent, false);
        return new TicketViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull TicketViewHolder holder, int position) {
        TicketResponseDTO ticket = tickets.get(position);

        // Preenchendo os dados
        holder.tvTitulo.setText(ticket.getTituloFormatado());
        holder.tvDescricao.setText(ticket.getDescricao());

        // Como não temos um TextView específico de categoria no item_ticket.xml que você mandou antes,
        // podemos usar o título ou ignorar. Se tiver tvTicketCategoria no XML, descomente abaixo:
        holder.tvTitulo.setText(ticket.getTituloFormatado());
        holder.tvDescricao.setText(ticket.getDescricao());
        holder.tvData.setText(ticket.getDataCriacao());

        holder.tvData.setText(ticket.getDataCriacao());

        // Cores
        configurarCoresStatus(holder, ticket.getStatus());
        configurarCoresPrioridade(holder, ticket.getPrioridade());

        // Clique
        holder.itemView.setOnClickListener(v -> {
            if (listener != null) listener.onTicketClick(ticket);
        });
    }

    private void configurarCoresStatus(TicketViewHolder holder, String statusRaw) {
        String status = statusRaw != null ? statusRaw : "PENDENTE";
        holder.tvStatus.setText(status.replace("_", " "));

        int colorBg;
        int colorText;

        if (status.equalsIgnoreCase("PENDENTE") || status.equalsIgnoreCase("ABERTO")) {
            colorBg = ContextCompat.getColor(context, R.color.status_pendente_bg);
            colorText = ContextCompat.getColor(context, R.color.status_pendente_text);
        } else if (status.equalsIgnoreCase("EM_ANDAMENTO") || status.contains("ANDAMENTO")) {
            colorBg = ContextCompat.getColor(context, R.color.status_andamento_bg);
            colorText = ContextCompat.getColor(context, R.color.status_andamento_text);
        } else {
            colorBg = ContextCompat.getColor(context, R.color.status_concluido_bg);
            colorText = ContextCompat.getColor(context, R.color.status_concluido_text);
        }

        GradientDrawable bg = (GradientDrawable) holder.tvStatus.getBackground();
        if (bg != null) bg.setColor(colorBg);
        holder.tvStatus.setTextColor(colorText);
    }

    private void configurarCoresPrioridade(TicketViewHolder holder, String prioridadeRaw) {
        String prioridade = prioridadeRaw != null ? prioridadeRaw : "BAIXA";
        holder.tvPrioridade.setText(prioridade);

        if (prioridade.equalsIgnoreCase("ALTA") || prioridade.equalsIgnoreCase("URGENTE")) {
            GradientDrawable bg = (GradientDrawable) holder.tvPrioridade.getBackground();
            if (bg != null) bg.setColor(Color.parseColor("#4A1F29"));
            holder.tvPrioridade.setTextColor(ContextCompat.getColor(context, R.color.prio_urgente_text));
        } else {
            GradientDrawable bg = (GradientDrawable) holder.tvPrioridade.getBackground();
            if (bg != null) bg.setColor(ContextCompat.getColor(context, R.color.card_bg));
            holder.tvPrioridade.setTextColor(ContextCompat.getColor(context, R.color.text_gray));
        }
    }

    @Override
    public int getItemCount() {
        return tickets.size();
    }

    // --- A CORREÇÃO ESTÁ AQUI ---
    public static class TicketViewHolder extends RecyclerView.ViewHolder {
        TextView tvTitulo, tvDescricao, tvStatus, tvPrioridade, tvData;
        // Removi tvCategoria porque não tem no seu XML

        public TicketViewHolder(@NonNull View itemView) {
            super(itemView);
            tvTitulo = itemView.findViewById(R.id.tvTituloTicket);
            tvDescricao = itemView.findViewById(R.id.tvDescricaoTicket);
            tvStatus = itemView.findViewById(R.id.tvStatusTicket);
            tvPrioridade = itemView.findViewById(R.id.tvPrioridadeTicket);
            tvData = itemView.findViewById(R.id.tvDataTicket);

            // tvCategoria foi removido
        }
    }
}