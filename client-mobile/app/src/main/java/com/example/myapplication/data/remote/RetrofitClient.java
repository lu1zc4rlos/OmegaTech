
package com.example.myapplication.data.remote; // Ajuste seu pacote

import com.example.myapplication.data.remote.ApiService;
import com.google.gson.Gson;
import com.google.gson.GsonBuilder;

import retrofit2.Retrofit;
import retrofit2.converter.gson.GsonConverterFactory;

public class RetrofitClient {

    // Se estiver no emulador: 10.0.2.2
    // Se estiver no celular físico: IP do seu PC
    private static final String BASE_URL = "http://192.168.0.66:8080/";

    private static Retrofit retrofit = null;

    public static ApiService getService() {
        if (retrofit == null) {

            retrofit = new Retrofit.Builder()
                    .baseUrl(BASE_URL)
                    // Mude de .create() para .create(gson) se for usar a configuração acima,
                    // mas por enquanto, tente apenas o padrão com as anotações:
                    .addConverterFactory(GsonConverterFactory.create())
                    .build();
        }
        return retrofit.create(ApiService.class);
    }
}