using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Department mathematicsDepartment = new Department("Mathematics", new List<Teacher>());



            Teacher teacher1 = new Teacher("Ravi Pasur", "Math");
            Teacher teacher2 = new Teacher("Yuvan Shanker Raja", "Physics");
            mathematicsDepartment.AddTeacher(teacher1);
            mathematicsDepartment.AddTeacher(teacher2);
            mathematicsDepartment.DisplayTeachers();

            Teacher teacher3 = new Teacher("D.Imman", "Statistics");
            mathematicsDepartment.AddTeacher(teacher3);
            mathematicsDepartment.DisplayTeachers();
        }
    }
}
