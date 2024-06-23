using System;
using System.Xml.Linq;

namespace ConsoleApp1
{
    internal class Student : Person
    {
        public int StudentID;

        public override void DisplayPersonInfo()
        {
            Console.WriteLine("Name: " + Name);
            Console.WriteLine(" Age: " + GetAge());
            Console.WriteLine("Student ID: " + StudentID);
        }

        public Student()
        {

        }

        public Student(int studentID)
        {
            StudentID = studentID;
        }

        public Student(string Name, int Age , int studentID)
        {
            base.Name = Name;
            base.SetAge(Age);
            StudentID = studentID;
        }

        public virtual void Study()
        {
            Console.WriteLine("Student Stdying...");
        }
    }
}
