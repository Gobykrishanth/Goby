using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        public int StudentID;
        public List<Course> courses;

       
        public override void DisplayPersonInfo()
        {
            Console.WriteLine("Name: " + Name);
            //Console.WriteLine(" Age: " + GetAge());
            Console.WriteLine("Age : "+ Age);    
            Console.WriteLine("Student ID: " + StudentID);

            

            if (courses != null && courses.Count > 0)
            {
                Console.WriteLine("Courses:");
                foreach (var course in courses)
                {
                    Console.WriteLine("- " + course.CourseName);
                }
            }
        }

        public Student()
        {

        }

        public Student(int studentID)
        {
            StudentID = studentID;
        }

        /*public Student(string Name, int Age , int studentID)
        {
            base.Name = Name;
            base.SetAge(Age);
            StudentID = studentID;
        }*/

        public Student(string Name, int BirthYear, int studentID)
        {
            base.Name = Name;
            base.BirthYear = BirthYear;
            StudentID = studentID;
        }


        public virtual void Study()
        {
            Console.WriteLine("Student Stdying...");
        }
    }
}
