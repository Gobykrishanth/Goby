using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Q2();
            //Q3();
            //Q4();
            //Q5();
            //Q6();
            //Q7_13_Calculater();
            Q14();
        }

        static void Q2()
        {
            Console.WriteLine("Hello, World!");
            Console.ReadLine();
        }
        static void Q3()
        {
            Console.WriteLine("What is your name");
            string askName = Console.ReadLine();
            Console.WriteLine("Your name is " + askName);
            Console.ReadLine();
        }

        static void Q4()
        {
            Console.WriteLine("Enter First Number");
            int firstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            int total = firstNumber + secondNumber;
            Console.WriteLine("Sum of Two Number is " + total);
            Console.ReadLine();
        }

        static void Q5()
        {
            Console.WriteLine("Enter temperature value in 'Fahrenheit'");
            double fahrenheit = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Celsius is " + (((fahrenheit - 32) * 5) / 9) + "°C");
            Console.ReadLine();
        }

        static void Q6()
        {
            Console.WriteLine("Enter a Number to check 'ODD' & 'EVEN' Number");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.WriteLine("It's an 'Even number'");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("It's an 'Odd number'");
                Console.ReadLine();
            }
        }

        static void Q7_13_Calculater()
        {
            Console.WriteLine("Enter Number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter arithmatic sign (+,-,*,/)");
            string symbol = Console.ReadLine();
            Console.WriteLine("Enter anothner Number");
            double num2 = Convert.ToDouble(Console.ReadLine());
         
            double result = 0;

            switch (symbol) 
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine("Addidtion is " + result);
                    Console.ReadLine();
                    break;

                case "-":
                    result = num2 - num1;
                    Console.WriteLine("Subtract is " + result);
                    Console.ReadLine();
                    break;      

                case "/":
                    result = num1 / num2;
                    Console.WriteLine("Divide is " + result);
                    Console.ReadLine();
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine("Multiply is " + result);
                    Console.ReadLine();
                    break;

                default:
                    Console.WriteLine("Use only +,-,*,/ keys only");
                    Console.ReadLine();
                    break;
            }
        }

        static void Q14() 
        {
            Console.WriteLine("Enter a Number");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 2; i < num/2;  i++)
            {
                if (num % 1 == 0)
                { 
                    Console.WriteLine("Prime");
                    Console.ReadLine();
                } else 
                {
                    Console.WriteLine("Not"); 
                    Console.ReadLine();
                }
            }
            
        }

    }
}
