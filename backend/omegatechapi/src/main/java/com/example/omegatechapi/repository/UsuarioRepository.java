package com.example.omegatechapi.repository;

import com.example.omegatechapi.model.TokenRecuperacao;
import com.example.omegatechapi.model.Usuario;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.data.jpa.repository.Query;
import org.springframework.data.repository.query.Param;
import org.springframework.stereotype.Repository;

import java.util.Optional;


@Repository
public interface UsuarioRepository extends JpaRepository<Usuario, Long> {
    Optional<Usuario> findByEmail(String email);

    Optional<Usuario> findById(Long id);

    boolean existsByEmail(String email);
    @Query("SELECT u FROM Usuario u WHERE u.id = :id")
    Optional<Usuario> findByUserId(@Param("id") Long id);
}
