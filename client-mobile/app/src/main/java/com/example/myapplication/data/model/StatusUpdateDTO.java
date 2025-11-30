package com.example.myapplication.data.model;
import com.google.gson.annotations.SerializedName;

public class StatusUpdateDTO {
    @SerializedName("novoStatus")
    private String novoStatus;

    public StatusUpdateDTO(String novoStatus) {
        this.novoStatus = novoStatus;
    }
}