package com.sgic.ppms.entities;

import java.io.Serializable;

import jakarta.persistence.Entity;
import jakarta.persistence.Id;
import jakarta.persistence.Table;
import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
@Entity
@Table(name = "patient")
public class ChildDetail implements Serializable {
	
	private static final long serialVersionUID = 1L;

	@Id
	private Long childId;
	private String firstName;
	private String lastName;
	private String gender;
	private String emailId;
	private String phoneNo;
	private String bhtNo;


}
