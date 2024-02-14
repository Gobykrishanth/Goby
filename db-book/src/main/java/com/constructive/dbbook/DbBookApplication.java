package com.constructive.dbbook;

import Entity.Bookentity;
import Respository.Bookrespository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.boot.CommandLineRunner;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;

@SpringBootApplication
public class DbBookApplication implements CommandLineRunner {

	@Autowired
	Bookrespository Bookrespository;
	public static void main(String[] args) {
		SpringApplication.run(DbBookApplication.class, args);
	}
	@Override
	public void run(String...args) {

		Bookentity BookentityOne = new Bookentity
				("To Kill a Mockingbird","Harper Lee","Fiction","1960");
		Bookentity BookentityTwo = new Bookentity
				("1984","George Orwell","Dystopian Fiction","1949");
		Bookentity BookentityThree = new Bookentity
				("The Catcher in the Rye","J.D. Salinger","Coming-of-age Fiction","1960");
		Bookentity BookentityFour = new Bookentity
				("Pride and Prejudice","Jane Austen","Romance","1813");
		Bookentity BookentityFive = new Bookentity
				("The Lord of the Rings","J.R.R. Tolkien","Fantasy","1954");

		Bookrespository.save(BookentityOne);
		Bookrespository.save(BookentityTwo);
		Bookrespository.save(BookentityThree);
		Bookrespository.save(BookentityFour);
		Bookrespository.save(BookentityFive);

		Bookrespository.findByTitle("To Kill a Mockingbird"). forEach(
				val -> System.out.println(val));
		Bookrespository.findByAuthor("J.D. Salinger"). forEach(
				val -> System.out.println(val));
		Bookrespository.findByCategory("Romance"). forEach(
				val -> System.out.println(val));
		Bookrespository.findByYear("1954"). forEach(
				val -> System.out.println(val));
		Bookrespository.findById(3). ifPresent(
				val -> System.out.println(val));
	}
}
