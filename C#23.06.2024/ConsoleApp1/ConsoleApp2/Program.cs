using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 4.2);
            rectangle.CalculateArea();


            Circle circle = new Circle(5.3);
            circle.CalculateArea();
        }
    }
}
