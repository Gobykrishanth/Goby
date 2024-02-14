package Entity;

import jakarta.persistence.Entity;
import jakarta.persistence.GeneratedValue;
import jakarta.persistence.GenerationType;
import jakarta.persistence.Id;

@Entity
public class Bookentity {


    @Id
@GeneratedValue(strategy = GenerationType.AUTO)
    private Integer storeID;
    private String title;
    private String author;
    private String category;
    private String year;



    public Bookentity(Integer storeID) {
        this.storeID = storeID;
    }

    public Bookentity(String title, String author, String category, String year) {

        this.title = title;
        this.author = author;
        this.category = category;
        this.year = year;
    }

    @Override
    public String toString() {
        return "Bookentity{" +
                "storeID=" + storeID +
                ", title='" + title + '\'' +
                ", author='" + author + '\'' +
                ", category='" + category + '\'' +
                ", year='" + year + '\'' +
                '}';
    }
    public Integer getStoreID() {
        return storeID;
    }

    public void setStoreID(Integer storeID) {
        this.storeID = storeID;
    }

    public String getTitle() {
        return title;
    }

    public void setTitle(String title) {
        this.title = title;
    }

    public String getAuthor() {
        return author;
    }

    public void setAuthor(String author) {
        this.author = author;
    }

    public String getCategory() {
        return category;
    }

    public void setCategory(String category) {
        this.category = category;
    }

    public String getYear() {
        return year;
    }

    public void setYear(String year) {
        this.year = year;
    }



}
