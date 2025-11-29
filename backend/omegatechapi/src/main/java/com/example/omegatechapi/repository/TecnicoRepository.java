package com.example.omegatechapi.repository;

import com.example.omegatechapi.model.TecnicoProfile;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface TecnicoRepository extends JpaRepository<TecnicoProfile, Long> {
    boolean existsByMatricula(String matricula);
}
