using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class GraduateStudent : Student
    {

        public string Subject;
        public override void Study()
        {
            Console.WriteLine("Hi");
          
        }

        public override void DisplayPersonInfo()
        {
            base.Study();
        }

    }
}
