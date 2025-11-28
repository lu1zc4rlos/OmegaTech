package com.example.myapplication.utils;

import android.content.Context;
import android.content.SharedPreferences;

public class SessionManager {
    private static final String PREF_NAME = "OmegaTechSession";
    private static final String KEY_TOKEN = "auth_token";
    private static final String KEY_USERNAME = "username";
    private static final String KEY_EMAIL = "user_email";

    private SharedPreferences prefs;
    private SharedPreferences.Editor editor;
    private Context context;

    public SessionManager(Context context) {
        this.context = context;
        // MODE_PRIVATE: Apenas o seu app pode ler esse arquivo. Outros apps não têm acesso.
        prefs = context.getSharedPreferences(PREF_NAME, Context.MODE_PRIVATE);
        editor = prefs.edit();
    }

    /**
     * Salva a sessão do usuário após login
     */

    public void saveSession(String token, String username) {
        editor.putString(KEY_TOKEN, token);
        editor.putString(KEY_USERNAME, username);
        editor.apply(); // "apply" salva em background, "commit" trava a tela. Use apply.
    }

    /**
     * Recupera o Token para usar nas chamadas de API (Tickets, Chat, etc)
     */
    public String getToken() {
        return prefs.getString(KEY_TOKEN, null);
    }

    /**
     * Recupera o nome do usuário
     */
    public String getUsername() {
        return prefs.getString(KEY_USERNAME, null);
    }

    /**
     * Limpa os dados (Logout)
     */
    public void clearSession() {
        editor.clear();
        editor.apply();
    }
}