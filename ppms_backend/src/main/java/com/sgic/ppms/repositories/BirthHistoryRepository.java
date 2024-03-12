package com.sgic.ppms.repositories;

import com.sgic.ppms.entities.BirthHistory;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface BirthHistoryRepository extends JpaRepository<BirthHistory, Long> {
}