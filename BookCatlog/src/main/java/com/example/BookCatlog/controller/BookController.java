package com.example.BookCatlog.controller;


import com.example.BookCatlog.entity.BookEntity;
import com.example.BookCatlog.repositary.BookRepositary;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.core.io.Resource;
import org.springframework.core.io.ResourceLoader;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestBody;
import org.springframework.web.bind.annotation.RestController;
import org.w3c.dom.Document;
import org.w3c.dom.Element;
import org.w3c.dom.NodeList;
import org.xml.sax.SAXException;

import javax.xml.parsers.DocumentBuilder;
import javax.xml.parsers.DocumentBuilderFactory;
import javax.xml.parsers.ParserConfigurationException;
import java.io.IOException;

@RestController
public class BookController {


    @Autowired
    private BookRepositary bookRepositary;

    @Autowired
    private ResourceLoader resourceLoader;

    @PostMapping ("/save")
    public BookEntity saveBook(@RequestBody BookEntity book){
        bookRepositary.save(book);
        return book;
    }

    @PostMapping ("/book")
    public String saveBookFromXml() throws ParserConfigurationException, IOException, SAXException {
        Resource resource = resourceLoader.getResource("classpath"+"Book.xml");

        DocumentBuilderFactory factory = DocumentBuilderFactory.newInstance();
        DocumentBuilder builder = factory.newDocumentBuilder();
        Document document = builder.parse(resource.getInputStream());
        NodeList bookNodes = document.getElementsByTagName("book");

        for (int i = 0; i < bookNodes.getLength(); i++) {
            Element bookElement = (Element) bookNodes.item(i);
            String title = bookElement.getElementsByTagName("title").item(0).getTextContent();
            String author = bookElement.getElementsByTagName("author").item(0).getTextContent();
            String year = bookElement.getElementsByTagName("year").item(0).getTextContent();

            BookEntity bookEntity = new BookEntity();
            bookEntity.setTitle(title);
            bookEntity.setAuthor(author);
            bookEntity.setYear(year);

        }
        return "Done";
    }
}

