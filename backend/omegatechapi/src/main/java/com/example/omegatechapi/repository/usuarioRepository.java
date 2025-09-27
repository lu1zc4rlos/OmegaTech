package com.example.omegatechapi.repository;

import com.example.omegatechapi.model.usuario;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface usuarioRepository extends JpaRepository<usuario, Long> {

}
