package com.sgic.ppms.controller;


import com.sgic.ppms.entities.BirthHistory;
import com.sgic.ppms.services.BirthHistoryService;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.web.bind.annotation.*;

@RestController
@RequestMapping("/api/vi/birthHistory")
public class BirthHistoryController {

    @Autowired
    BirthHistoryService birthHistoryService;

    @RequestMapping(value="/create", method=RequestMethod.POST)
    public BirthHistory createBirthHistory(@RequestBody BirthHistory birthHistory) {
        return birthHistoryService.createBirthHistory(birthHistory);
    }
    @RequestMapping(value="/get/{id}", method=RequestMethod.GET)
    public BirthHistory getBirthHistoryById(@PathVariable Long id) {
        return birthHistoryService.getBirthHistoryById(id);
    }
    @RequestMapping(value="/delete/{id}", method=RequestMethod.DELETE)
    public void deleteBirthHistory(@PathVariable(value = "id") Long id) {
        birthHistoryService.deleteBirthHistory(id);
    }

    @RequestMapping(value="/update/{id}", method=RequestMethod.PUT)
    public BirthHistory updateBirthHistory(@PathVariable(value = "id") Long id, @RequestBody BirthHistory birthHistoryDetails) {
        return birthHistoryService.updateBirthHistory(id, birthHistoryDetails);
    }
}
