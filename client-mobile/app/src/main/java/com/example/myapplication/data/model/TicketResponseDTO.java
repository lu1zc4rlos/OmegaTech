package com.example.myapplication.data.model;
import com.google.gson.annotations.SerializedName;
public class TicketResponseDTO {
    @SerializedName("id")
    private Long id;

    @SerializedName("titulo")
    private String titulo; // Ex: "COMPUTADOR_TRAVANDO"

    @SerializedName("resposta") // O DTO do backend manda "resposta" (minúsculo)
    private String respostaTecnico;

    @SerializedName("nomeTecnico") // O DTO do backend manda "nomeTecnico"
    private String nomeTecnico;

    @SerializedName("descricao")
    private String descricao;

    @SerializedName("status")
    private String status; // Ex: "PENDENTE"

    @SerializedName("prioridade")
    private String prioridade; // Ex: "URGENTE"

    @SerializedName("dataCriacao")
    private String dataCriacao;

    // Helper para formatar o texto feio "COMPUTADOR_TRAVANDO" para "Computador Travando"
    public String getTituloFormatado() {
        if (titulo == null) return "Sem Título";
        return titulo.replace("_", " ");
    }

    public Long getId() {return id;}
    public String getRespostaTecnico() { return respostaTecnico;}
    public String getNomeTecnico() {return nomeTecnico;}
    public String getStatus() { return status != null ? status : "PENDENTE"; }
    public String getPrioridade() { return prioridade != null ? prioridade : "BAIXA"; }
    public String getDescricao() { return descricao; }
    public String getDataCriacao() { return dataCriacao; }
}
