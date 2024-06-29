using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           /* Person person = new Person();
            person.Name = "Tesla";
            person.Age = 10;
            person.SetAge(-10);
            person.SetAge(10);
            person.DisplayPersonInfo();
           */

            /*Student student = new Student();
            student.Name = "Banana";
            student.SetAge(20);
            student.StudentID = 123456;
            student.DisplayPersonInfo();*/

            Student student1 = new Student(12);
            student1.DisplayPersonInfo();

            Student student2 = new Student("Ana", 12, 0023);
            student2.DisplayPersonInfo();

            GraduateStudent graduateStudent = new GraduateStudent();
            graduateStudent.DisplayPersonInfo();

            Student student3 = new Student("Gali", 1999, 2000);
            student3.DisplayPersonInfo();

            Course course1 = new Course("Biology");
            Course course2 = new Course("Chemistry");
            Course course3 = new Course("Physics");

            Student student4 = new Student("Kamal", 2010,102);
            student4.courses=new List<Course>();
            student4.courses.Add(course1);
            student4.courses.Add(course2);
            student4.courses.Add(course3);
            student4.DisplayPersonInfo();


            Address address = new Address("123", "Main St", "Springfield", "IL", "12345", "USA");

            Person person = new Person();
            person.Name = "John Doe";
            person.BirthYear = 1990;
            person.address = address;

            person.DisplayPersonInfo();

        }

        
    }
}
