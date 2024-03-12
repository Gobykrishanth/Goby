package com.sgic.ppms.controller;

import com.sgic.ppms.entities.BirthHistory;
import com.sgic.ppms.entities.HistoryOfPresentingComplaint;
import com.sgic.ppms.services.HistoryOfPresentingComplaintService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/vi/historyOfPresentingComplaint")
public class HistoryOfPresentingComplaintController {

    @Autowired
    HistoryOfPresentingComplaintService historyOfPresentingComplaintService;

    @RequestMapping(value="/create", method= RequestMethod.POST)
    public HistoryOfPresentingComplaint createHistoryOfPresentingComplaint(@RequestBody HistoryOfPresentingComplaint historyOfPresentingComplaint) {
        return historyOfPresentingComplaintService.createHistoryOfPresentingComplaint(historyOfPresentingComplaint);
    }
    @RequestMapping(value="/get/{id}", method=RequestMethod.GET)
    public HistoryOfPresentingComplaint getHistoryOfPresentingComplaintById(@PathVariable Long id) {
        return historyOfPresentingComplaintService.getHistoryOfPresentingComplaintById(id);
    }
    @RequestMapping(value="/delete/{id}", method=RequestMethod.DELETE)
    public void deleteHistoryOfPresentingComplaint(@PathVariable(value = "id") Long id) {
        historyOfPresentingComplaintService.deleteHistoryOfPresentingComplaint(id);
    }
    @RequestMapping(value="/update/{id}", method=RequestMethod.PUT)
    public HistoryOfPresentingComplaint updateHistoryOfPresentingComplaint(@PathVariable(value = "id") Long id, @RequestBody HistoryOfPresentingComplaint historyOfPresentingComplaintDetails) {
        return historyOfPresentingComplaintService.updateHistoryOfPresentingComplaint(id, historyOfPresentingComplaintDetails);
    }

}
