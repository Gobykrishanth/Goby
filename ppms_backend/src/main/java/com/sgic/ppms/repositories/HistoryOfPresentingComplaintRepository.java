package com.sgic.ppms.repositories;

import com.sgic.ppms.entities.ChildDetail;
import com.sgic.ppms.entities.HistoryOfPresentingComplaint;
import org.springframework.data.jpa.repository.JpaRepository;

public interface HistoryOfPresentingComplaintRepository extends JpaRepository<HistoryOfPresentingComplaint, Long> {
}
