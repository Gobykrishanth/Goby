using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PrintHello();

            //GreetUser (name:"Undertaker");

            //Console.WriteLine(CalculateSum (10, 5));

            //PrintMessage(" Hello, World!");
            //PrintMessage();

            //DisplayInfo(name:"Hulk Hogan",age:55);
            //DisplayInfo(name: "Hulk Hogan");

            //OrderCoffee(size:"Large", sugar:3, milk:true);

            //BookFlight(destination: "LHR-Heathrow ", date: "2nd of March 2024", classType: "Econamy");
            //BookFlight("geneva", "1st of April", "1st Class");
            //BookFlight("Katunayaka", "Econamy", "3rd of July");
            //BookFlight(destination: "Hamath", "4th of June 2024", "1st Class");
            //BookFlight(date: "5/2/24", classType: "Econamy", destination: "Doha");

            //Console.WriteLine (Multiply(num1:4,num2:5));
            //Console.WriteLine(Multiply(num1: 4.6, num2: 5.2));
            //Console.WriteLine(Multiply(num1: 7, num2: 8, num3: 13));


            //Display(name:"Batista");
            //Display(12);
            //Display(25.46);


            //double result = CalculateArea(12, 13.69);
            //Console.WriteLine($"Area of a rectangle is {result}");

            //double res = CalculateArea(12);
            //Console.WriteLine($"Area of a square is {res}");

            //double Fahrenheit = ConvertTemperature(65);
            //Console.WriteLine($"{Fahrenheit} Fahrenheit");

            //int Celsius = ConvertTemperature(65);
            //Console.WriteLine($"{Celsius} Celsius");



            //AddToCart(name: "Anchor", quantity: 10);
            //AddToCart(name: "Anchor", quantity: 10, price:912.45);

            //Transfer(accountNumber: 136510, amount: 12253000.50);
            //Transfer(accountNumber: 136510, amount: 12253000.50, 
            // description: "Transfer successed. \n Thank you for Banking with us");


            //CalculateDistance(1, 2, 3, 4);
            //CalculateDistance(1, 2, 6, 4, 5, 6);

            DateTime currentDate = DateTime.Now;
            FormatDate(currentDate);



            Console.ReadLine();
        }

        static void PrintHello()
        {
            Console.WriteLine("Hello, World!");

        }

        static void GreetUser(String name)
        {
            Console.WriteLine($"Hello {name}");
        }

        static int CalculateSum(int num1, int num2)
        {
            return num1 + num2;
        }

        static void PrintMessage(String message = "Good day!")
        {
            Console.WriteLine(message);
        }

        static void DisplayInfo(String name, int age = 25)
        {
            Console.WriteLine($"Name :{name} \n Age :{age}");
        }

        static void OrderCoffee(String size, int sugar, bool milk)
        {
            Console.WriteLine($"Your Order, {size} size of Cofee," +
                $"{sugar} spoon of sugar with {milk} milk is ready....!");
        }

        static void BookFlight(String destination, String date, String classType)
        {
            Console.WriteLine($"Destination :{destination} \n Date :{date} \n ClassType :{classType}");
        }

         static int Multiply(int num1, int num2)
        { 
            return num1 * num2;
        }

         static double Multiply(double num1, double num2)
        {
            return num1 * num2;
        }

         static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        static void Display(String name)
        { 
            Console.WriteLine($"Name : {name}");
        }

        static void Display(int age)
        {
            Console.WriteLine($"Age : {age}"); 
        }


        static void Display(double value)
        {
            Console.WriteLine($"Value :{value}");
        }


        static double CalculateArea (double num1, double num2)
        {
            return  num1 * num2; 
        }

        static double CalculateArea (double num1)
        {
            return num1 * num1;
        }

        static double ConvertTemperature (double Fahrenheit)
        {
            return (9 / 5) * (Fahrenheit - 32);
        }


        static int ConvertTemperature(int Celsius)
        {
            return Celsius * 5/9 +32;
        }


        static void AddToCart (string name, int quantity)
        {
            Console.WriteLine($"Product Name : {name} \n Quantiy : {quantity}");
        }

        static void AddToCart(string name, int quantity, double price)
        {
            double total = quantity* price;
            Console.WriteLine($"Product Name : {name} \n Quantiy : {quantity} \n Total price : {total} LKR" );
        }


        static void Transfer(int accountNumber, double amount)
        {
            Console.WriteLine($"Account Number :{accountNumber} \n Amount : {amount} LKR");
        }

        static void Transfer(int accountNumber, double amount, String description)
        {
            Console.WriteLine($"Account Number :{accountNumber} \n Amount : {amount} LKR " +
                $"\n Description : {description}");
        }

        static void CalculateDistance (double x1, double x2, double y1, double y2)
        {
            double Horizontal = x1 - x2;
            double Vertical = y1 - y2;
            Console.WriteLine($"Horizontal Distance : {Horizontal} \n Vertical Distance : {Vertical}");
        }

        static void CalculateDistance(double x1, double x2, double y1, double y2, double z1, double z2)
        {
            double Horizontal = x1 - x2;
            double Vertical = y1 - y2;
            double Z_axis = z1 - z2;
            Console.WriteLine($"Horizontal Distance : {Horizontal} \n Vertical Distance : {Vertical} \n Z_Axis Distance : {Z_axis}");
        }


        static void FormatDate (DateTime date)
        { 
            date = date.ToUniversalTime(); 
            Console.WriteLine(date.ToString());
        }

      
    }
}
