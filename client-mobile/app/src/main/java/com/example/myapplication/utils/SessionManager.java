package com.example.myapplication.utils;

import android.content.Context;
import android.content.SharedPreferences;

public class SessionManager {
    private static final String PREF_NAME = "OmegaTechSession";
    private static final String KEY_TOKEN = "auth_token";
    private static final String KEY_USERNAME = "username";
    private static final String KEY_EMAIL = "user_email";
    private static final String KEY_PERFIL = "user_perfil";

    private SharedPreferences prefs;
    private SharedPreferences.Editor editor;
    private Context context;

    public SessionManager(Context context) {
        this.context = context;
        prefs = context.getSharedPreferences(PREF_NAME, Context.MODE_PRIVATE);
        editor = prefs.edit();
    }

    /**
     * Salva a sessão do usuário após login
     */
    public void saveSession(String token, String nome, String email, String perfil) {
        editor.putString(KEY_TOKEN, token);
        editor.putString(KEY_USERNAME, nome);
        editor.putString(KEY_EMAIL, email);   // <--- CORREÇÃO: Agora salva o email
        editor.putString(KEY_PERFIL, perfil); // <--- Salva o perfil
        editor.apply();
    }

    /**
     * Recupera o Token
     */
    public String getToken() {
        return prefs.getString(KEY_TOKEN, null);
    }

    /**
     * Recupera o Nome
     */
    public String getUsername() {
        return prefs.getString(KEY_USERNAME, null);
    }

    /**
     * Recupera o Email (NOVO)
     */
    public String getEmail() {
        return prefs.getString(KEY_EMAIL, null);
    }

    /**
     * Recupera o Perfil (NOVO - Essencial para a lógica de técnico)
     */
    public String getPerfil() {
        return prefs.getString(KEY_PERFIL, "ROLE_CLIENTE"); // Padrão seguro
    }

    /**
     * Limpa os dados (Logout)
     */
    public void clearSession() {
        editor.clear();
        editor.apply();
    }
}