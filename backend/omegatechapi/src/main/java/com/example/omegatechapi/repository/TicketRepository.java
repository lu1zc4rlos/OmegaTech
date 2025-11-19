package com.example.omegatechapi.repository;

import com.example.omegatechapi.model.Ticket;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface TicketRepository extends JpaRepository<Ticket, Long> {
    <S extends Ticket> S save(S entity);
}
