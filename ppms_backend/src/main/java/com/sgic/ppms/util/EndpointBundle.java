package com.sgic.ppms.util;

public class EndpointBundle {
	public static final String BASE_URL="api/v1/";
	public static final String CREATE_CHILD_API = BASE_URL+"child-detail";
	public static final String ETHNICITY = BASE_URL+"ethnicity";
	public static final String CHILD = "child";


	//encaptulate constructor to restrict modification from outside
	private EndpointBundle() {
	}
}
