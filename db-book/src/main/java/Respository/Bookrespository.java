package Respository;

import Entity.Bookentity;
import org.springframework.data.repository.CrudRepository;

import java.util.List;

public interface Bookrespository extends CrudRepository<Bookentity,Integer>
{
    List<Bookentity> findByTitle (String title);
    List<Bookentity> findByAuthor (String author);
    List<Bookentity> findByCategory (String category);
    List<Bookentity> findByYear (String year);
}
