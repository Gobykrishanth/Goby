package com.example.Employee.controllers;

import com.example.Employee.entities.EmployeeEntity;
import com.example.Employee.repositories.EmployeeRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.core.io.Resource;
import org.springframework.core.io.ResourceLoader;
import org.springframework.web.bind.annotation.*;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import java.io.IOException;
import java.util.List;
import java.util.Objects;

@RestController
public class EmployeeController {

    @Autowired
    private EmployeeRepository employeeRepository;

    @Autowired
    private ResourceLoader resourceLoader;


    @PostMapping("/save")
    public EmployeeEntity saveEmployee(@RequestBody EmployeeEntity emp){
        employeeRepository.save(emp);
        return emp;
    }
    @PostMapping("/employee")
    public String  saveEmployeeFromXml() throws ParserConfigurationException, IOException, SAXException {
        Resource resource = resourceLoader.getResource("classpath:" + "Employee.xml");

        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
        DocumentBuilder builder = factory.newDocumentBuilder();
        Document document = builder.parse(resource.getInputStream());
        NodeList empNodes = document.getElementsByTagName("employee");


        for (int i = 0; i < empNodes.getLength(); i++) {
            Element empElement = (Element) empNodes.item(i);
            String name = empElement.getElementsByTagName("name").item(0).getTextContent();
            String position = empElement.getElementsByTagName("position").item(0).getTextContent();
            String department = empElement.getElementsByTagName("department").item(0).getTextContent();

            EmployeeEntity employeeEntity = new EmployeeEntity();
            employeeEntity.setDepartment(department);
            employeeEntity.setPosition(position);
            employeeEntity.setName(name);


            if(!Objects.equals(position, "Quality Engineer")){
                employeeRepository.save(employeeEntity);
            }
        }
        return "Done";
    }

    @GetMapping("/filter")
    public List<EmployeeEntity> filterByPosition (){
        List<EmployeeEntity> empList = employeeRepository.findByPosition("Quality Engineer");
        return empList;
    }


}
