using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    abstract class Shape
    {
        public abstract void CalculateArea();
    }


    // Derived class Rectangle
    class Rectangle : Shape
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public override void CalculateArea()
        {
            double area = width * height;
            Console.WriteLine($"Area of the Rectangle is {area}");
        }
    }


    // Derived class Circle
    class Circle : Shape
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override void CalculateArea()
        {
            double circleArea = radius * radius * Math.PI;
            Console.WriteLine($"Area of the Circle is {circleArea}");
        }


    }
}
