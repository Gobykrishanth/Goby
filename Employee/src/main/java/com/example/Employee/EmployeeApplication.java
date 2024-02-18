package com.example.Employee;

import com.example.Employee.controllers.EmployeeController;
import com.example.Employee.entities.TestFunction;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class EmployeeApplication {

	public static void main(String[] args) {

		SpringApplication.run(EmployeeApplication.class, args);
		EmployeeController employeeController = new EmployeeController();
		String wel = employeeController.welcome();
		System.out.println(wel);

		TestFunction myObject1  = new TestFunction();
		myObject1.setDepartment("Apple", 10);
		System.out.println(myObject1.getDepartment());


		TestFunction myObject2 = new TestFunction();
		myObject2.setDepartment("woodapple", 100);
		System.out.println(myObject2.getDepartment());


	}

}
