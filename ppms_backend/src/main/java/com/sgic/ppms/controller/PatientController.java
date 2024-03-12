package com.sgic.ppms.controller;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;

import com.sgic.ppms.dto.ChildDetailDto;
import com.sgic.ppms.services.PatientService;
import com.sgic.ppms.util.EndpointBundle;
import com.sgic.ppms.util.ErrorCodes;

@RestController
public class PatientController {


  @Autowired
  ErrorCodes errorMessages;
  
  @Autowired
  PatientService patientService;
  
  private final Logger logger = LoggerFactory.getLogger(PatientController.class);
  
	@PostMapping(value = EndpointBundle.CREATE_CHILD_API)
	public ResponseEntity<?> createEmployee(@RequestBody ChildDetailDto childDetail) {
		patientService.saveChildDetail(childDetail);
		return new ResponseEntity<Object>(HttpStatus.OK);
	}
	

}
