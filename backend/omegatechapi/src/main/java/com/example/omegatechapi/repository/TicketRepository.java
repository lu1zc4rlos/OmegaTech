package com.example.omegatechapi.repository;

import com.example.omegatechapi.model.Status;
import com.example.omegatechapi.model.Ticket;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface TicketRepository extends JpaRepository<Ticket, Long> {
    <S extends Ticket> S save(S entity);

    List<Ticket> findByClienteId(Long clienteId);
    List<Ticket> findByClienteIdAndStatus(Long clienteId, Status status);
    List<Ticket> findByStatus(Status status);
}
