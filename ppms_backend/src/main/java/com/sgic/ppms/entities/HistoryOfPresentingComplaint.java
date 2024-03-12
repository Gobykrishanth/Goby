package com.sgic.ppms.entities;

import jakarta.persistence.*;

import java.time.LocalDate;



@Entity
@Table(name = "historyOfPresentingComplaint")
public class HistoryOfPresentingComplaint {

    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private long id;
    private long admitId;
    private String insertComplaintHistory;
    private LocalDate duration;

    public String getInsertComplaintHistory() {
        return insertComplaintHistory;
    }

    public void setInsertComplaintHistory(String insertComplaintHistory) {
        this.insertComplaintHistory = insertComplaintHistory;
    }

    public LocalDate getDuration() {
        return duration;
    }

    public void setDuration(LocalDate duration) {
        this.duration = duration;
    }
}