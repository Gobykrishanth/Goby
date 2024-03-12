package com.sgic.ppms.repositories;

import org.springframework.data.jpa.repository.JpaRepository;

import com.sgic.ppms.entities.ChildDetail;

public interface ChildRepository extends JpaRepository<ChildDetail, Long>{

}
