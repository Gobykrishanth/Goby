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
            Person person = new Person();
            person.Name = "Tesla";
            //person.Age = 10;
            person.SetAge(-10);
            person.SetAge(10);
            person.DisplayPersonInfo();


            Student student = new Student();
            student.Name = "jhasjlk";
            student.SetAge(20);
            student.StudentID = 123456;
            student.DisplayPersonInfo();

            Student student1 = new Student(12);
            student1.DisplayPersonInfo();

            Student student2 = new Student("Ana", 12, 0023);
            student2.DisplayPersonInfo();

            GraduateStudent graduateStudent = new GraduateStudent();
            graduateStudent.DisplayPersonInfo();

        }

        
    }
}
