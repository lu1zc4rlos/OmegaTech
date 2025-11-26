package com.example.myapplication;

import android.os.Bundle;
import android.widget.Toast;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class HomeActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_home);

        // Configurar a Barra de Navegação Inferior
        com.google.android.material.bottomnavigation.BottomNavigationView bottomNav = findViewById(R.id.bottom_nav_container);

        // Corrige o ícone para não ficar tudo de uma cor só (opcional, mas fica mais bonito)
        bottomNav.setItemIconTintList(null);

        bottomNav.setOnItemSelectedListener(item -> {
            int id = item.getItemId();

            if (id == R.id.nav_home) {
                // Já estamos na Home, não faz nada ou recarrega
                return true;
            } else if (id == R.id.nav_omega_help) {
                // Abre o Chat
                android.content.Intent intent = new android.content.Intent(HomeActivity.this, OmegaHelpActivity.class);
                startActivity(intent);
                return true; // Retorna true para marcar o ícone como selecionado
            } else if (id == R.id.nav_tickets) {
                Toast.makeText(this, "Tela de Tickets em construção", Toast.LENGTH_SHORT).show();
                return true;
            } else if (id == R.id.nav_conta) {
                Toast.makeText(this, "Tela de Conta em construção", Toast.LENGTH_SHORT).show();
                return true;
            }

            return false;
        });
    }
}