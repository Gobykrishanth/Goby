package com.example.BookCatlog.repositary;

import com.example.BookCatlog.entity.BookEntity;
import org.springframework.data.jpa.repository.JpaRepository;

import java.util.List;

public interface BookRepositary extends JpaRepository <BookEntity, Long> {
}
