package com.example.myapplication.data.model;

public class ChatMessage {
    private String texto;
    private boolean isUsuario; // true = Eu, false = Bot

    public ChatMessage(String texto, boolean isUsuario) {
        this.texto = texto;
        this.isUsuario = isUsuario;
    }

    public void setUsuario(boolean usuario) {
        isUsuario = usuario;
    }

    public String getTexto() {
        return texto;
    }

    public void setTexto(String texto) {
        this.texto = texto;
    }

    public boolean isUsuario() { return isUsuario; }
}