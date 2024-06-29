using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Teacher
    {
        public string Name;
        public string Subject;

        public Teacher(string name, string subject)
        {
            Name = name;
            Subject = subject;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Teacher Name: {Name}, Subject: {Subject}");
        }
    }
}
