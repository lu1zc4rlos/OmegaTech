package com.example.myapplication.UI; // Ajuste seu pacote

import android.content.Context;
import android.view.Gravity;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.LinearLayout;
import android.widget.TextView;
import androidx.annotation.NonNull;
import androidx.core.content.ContextCompat;
import androidx.recyclerview.widget.RecyclerView;

import com.example.myapplication.R;
import com.example.myapplication.data.model.ChatMessage;
import java.util.List;

public class ChatAdapter extends RecyclerView.Adapter<ChatAdapter.ChatViewHolder> {

    private List<ChatMessage> listaMensagens;
    private Context context;

    public ChatAdapter(Context context, List<ChatMessage> listaMensagens) {
        this.context = context;
        this.listaMensagens = listaMensagens;
    }

    @NonNull
    @Override
    public ChatViewHolder onCreateViewHolder(@NonNull ViewGroup parent, int viewType) {
        // Cria a visualização do item (infla o XML)
        View view = LayoutInflater.from(parent.getContext())
                .inflate(R.layout.item_chat_message, parent, false);
        return new ChatViewHolder(view);
    }

    @Override
    public void onBindViewHolder(@NonNull ChatViewHolder holder, int position) {
        ChatMessage msg = listaMensagens.get(position);

        holder.tvMensagem.setText(msg.getTexto());

        // Lógica Visual: Se sou eu (Direita + Roxo), se é Bot (Esquerda + Cinza)
        if (msg.isUsuario()) {
            holder.container.setGravity(Gravity.END); // Alinha à direita
            holder.tvMensagem.setBackgroundTintList(
                    ContextCompat.getColorStateList(context, R.color.primary_purple)
            );
        } else {
            holder.container.setGravity(Gravity.START); // Alinha à esquerda
            holder.tvMensagem.setBackgroundTintList(
                    ContextCompat.getColorStateList(context, R.color.card_bg)
            );
        }
    }

    @Override
    public int getItemCount() {
        return listaMensagens.size();
    }

    // Classe interna que guarda as referências dos componentes (Cache)
    public static class ChatViewHolder extends RecyclerView.ViewHolder {
        TextView tvMensagem;
        LinearLayout container;

        public ChatViewHolder(@NonNull View itemView) {
            super(itemView);
            tvMensagem = itemView.findViewById(R.id.tvConteudoMensagem);
            container = itemView.findViewById(R.id.containerLinhaChat);
        }
    }
}