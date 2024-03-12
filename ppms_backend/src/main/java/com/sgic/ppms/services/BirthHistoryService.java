package com.sgic.ppms.services;

import com.sgic.ppms.entities.BirthHistory;
import com.sgic.ppms.repositories.BirthHistoryRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.dao.DataRetrievalFailureException;
import org.springframework.stereotype.Service;


@Service
public class BirthHistoryService {

    @Autowired
    BirthHistoryRepository birthHistoryRepository;

    //CREATE
    public BirthHistory createBirthHistory(BirthHistory birthHistory) {
        return birthHistoryRepository.save(birthHistory);
    }
    // READ
    public BirthHistory getBirthHistoryById(Long id) {
        BirthHistory birthHistory = birthHistoryRepository.findById(id)
                .orElse(null);
        if (birthHistory == null) {
            throw new DataRetrievalFailureException("Birth history not found with id: " + id);
        }
        return birthHistory;
    }
    //DELETE
    public void deleteBirthHistory(Long id) {
        birthHistoryRepository.deleteById(id);
    }

    //UPDATE
    public BirthHistory updateBirthHistory(Long id, BirthHistory BirthHistoryDetails) {
        BirthHistory birthHistory = birthHistoryRepository.findById(id).get();
        birthHistory.setAntenatalHistory(BirthHistoryDetails.getAntenatalHistory());
        birthHistory.setBirthWeight(BirthHistoryDetails.getBirthWeight());
        birthHistory.setPostnatalHistory(BirthHistoryDetails.getPostnatalHistory());
        birthHistory.setModeOfDelivery(BirthHistoryDetails.getModeOfDelivery());
        birthHistory.setGestationalAge(BirthHistoryDetails.getGestationalAge());

        return birthHistoryRepository.save(birthHistory);
    }
}
