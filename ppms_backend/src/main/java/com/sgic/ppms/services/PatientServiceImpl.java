package com.sgic.ppms.services;

import org.slf4j.Logger;
import org.slf4j.LoggerFactory;
import org.springframework.beans.BeanUtils;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import com.sgic.ppms.dto.ChildDetailDto;
import com.sgic.ppms.entities.ChildDetail;
import com.sgic.ppms.repositories.ChildRepository;

@Service
public class PatientServiceImpl implements PatientService {


	private final Logger logger = LoggerFactory.getLogger(PatientServiceImpl.class);
	
	@Autowired
	ChildRepository childRepository;

	@Override
	public void saveChildDetail(ChildDetailDto childDetail) {
		ChildDetail childDteailEntity=new ChildDetail();
		BeanUtils.copyProperties(childDetail, childDteailEntity);
		childRepository.save(childDteailEntity);
	}

}
