package com.sgic.ppms.services;


import com.sgic.ppms.entities.BirthHistory;
import com.sgic.ppms.entities.HistoryOfPresentingComplaint;
import com.sgic.ppms.repositories.BirthHistoryRepository;
import com.sgic.ppms.repositories.HistoryOfPresentingComplaintRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.DataRetrievalFailureException;
import org.springframework.stereotype.Service;

@Service
public class HistoryOfPresentingComplaintService {

    @Autowired
    HistoryOfPresentingComplaintRepository historyOfPresentingComplaintRepository;

    //CREATE
    public HistoryOfPresentingComplaint createHistoryOfPresentingComplaint(HistoryOfPresentingComplaint historyOfPresentingComplaint) {
        return historyOfPresentingComplaintRepository.save(historyOfPresentingComplaint);
    }
    // READ
    public HistoryOfPresentingComplaint getHistoryOfPresentingComplaintById(Long id) {
        HistoryOfPresentingComplaint historyOfPresentingComplaint = historyOfPresentingComplaintRepository.findById(id)
                .orElse(null);
        if (historyOfPresentingComplaint == null) {
            throw new DataRetrievalFailureException("Birth history not found with id: " + id);
        }
        return historyOfPresentingComplaint;
    }
    //DELETE
    public void deleteHistoryOfPresentingComplaint(Long id) {
        historyOfPresentingComplaintRepository.deleteById(id);
    }

    //UPDATE
    public HistoryOfPresentingComplaint updateHistoryOfPresentingComplaint(Long id, HistoryOfPresentingComplaint HistoryOfPresentingComplaintDetails) {
        HistoryOfPresentingComplaint historyOfPresentingComplaint = historyOfPresentingComplaintRepository.findById(id).get();
        historyOfPresentingComplaint.setInsertComplaintHistory(HistoryOfPresentingComplaintDetails.getInsertComplaintHistory());
        historyOfPresentingComplaint.setDuration(HistoryOfPresentingComplaintDetails.getDuration());

        return historyOfPresentingComplaintRepository.save(historyOfPresentingComplaint);
    }
}

