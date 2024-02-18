package com.example.Employee.entities;

public class TestFunction {

    private String department;

    public void setDepartment(String depValue, int age){
        if(age<50){
            department = depValue;
        }
    }

    public String getDepartment(){
        return department;
    }

}
