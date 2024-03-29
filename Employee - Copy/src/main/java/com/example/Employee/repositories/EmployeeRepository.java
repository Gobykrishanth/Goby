package com.example.Employee.repositories;

import com.example.Employee.entities.EmployeeEntity;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface EmployeeRepository extends JpaRepository<EmployeeEntity, Long> {
    public List<EmployeeEntity> findByPosition(String position);
}
