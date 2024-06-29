using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Department
    {
        public string Name;
        public List<Teacher> teachers;

        public Department(string name, List<Teacher> teachers)
        {
            Name = name;
            this.teachers = teachers;
        }

        public void AddTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void DisplayTeachers()
        {
            Console.WriteLine($"Teachers in the {Name} department:");
            foreach (var teacher in teachers)
            {
                teacher.DisplayInfo();
            }
        }
    }
}
