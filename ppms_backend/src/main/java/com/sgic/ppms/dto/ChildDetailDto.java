package com.sgic.ppms.dto;

import javax.validation.constraints.NotBlank;
import javax.validation.constraints.Pattern;

import lombok.Getter;
import lombok.Setter;

@Getter
@Setter
public class ChildDetailDto {

	private String childId;

	@NotBlank
	@Pattern(regexp = "^[A-Za-z]+$", message = "")
	private String firstName;

	@NotBlank
	@Pattern(regexp = "^[A-Za-z]+$", message = "")
	private String lastName;

	@NotBlank
	@Pattern(regexp = "^[A-Za-z]+$", message = "")
	private Integer bhtNo;

	private String gender;
	
	private String emailId;
	
	private String phoneNo;

}
