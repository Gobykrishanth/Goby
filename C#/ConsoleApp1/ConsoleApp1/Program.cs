using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
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
            //Calculater();
            //Q14();
            //Q15();
            //Q16();
            //Q17();
            //Q18();
            //Q19();
            Q20();



            Console.ReadLine();
        }

        static void Q2()
        {
            Console.WriteLine("Hello, World!");
        }


        static void Q3()
        {
            Console.WriteLine("whats your name?");
            String name = Console.ReadLine();
            Console.WriteLine($"Hi {name}, Welcome to C# Console app");
        }

        static void Q4()
        {
            Console.WriteLine("Enter First Number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double sum = num1 + num2;
            Console.WriteLine($"sum of two number is {sum}");
        }



        static void Q5()
        {
            Console.WriteLine("Enter temperature in Celsius");
            double celcius = Convert.ToDouble(Console.ReadLine());
            int Fahrenheit = Convert.ToInt32((celcius * 9 / 5 + 32));
            Console.WriteLine($"{Fahrenheit} F");
        }


        static void Q6()
        {
            Console.WriteLine("Enter a Number to check Odd or Even");
            int num = Convert.ToInt32(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine($"{num} is Odd");
            }
            else
            {
                Console.WriteLine($"{num} is Even");
            }
        }

        static void Calculater()
        {
            Console.WriteLine("Enter a number");
            double num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter Arithmatic Operator (+ , - , * , /)");
            String symbol = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter another number");
            double num2 = Convert.ToDouble(Console.ReadLine());
            double result = 0;

            switch (symbol)
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Add is {result}");
                    break;

                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Subtract is {result}");
                    break;

                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Multiply is {result}");
                    break;

                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Divide is {result}");
                    break;

                default:
                    Console.WriteLine($"use alowed symbols (+ , - , * , /) only ");
                    break;
            }
        }


        static void Q14()
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool isPrime = true;
            if (num <= 1)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{num} is a prime number");
            }
            else
            {
                Console.WriteLine($"{num} is not a prime number");
            }
        }


        static void Q15()
        {
            Console.WriteLine("Enter a non-negative integer");
            int num = Convert.ToInt32(Console.ReadLine());
            int factorial = 1;
            if (num < 0)
            {
                Console.WriteLine("It;s a negative integer");
            }
            else if (num == 0)
            {
                Console.WriteLine("Enter a valid nmber 0<");
            }
            else
            {
                for (int i = 1; i <= num; i++)
                {
                    factorial = factorial * i;
                }
                Console.WriteLine($"The Factorial of {num} is {factorial}");
            }
        }


        static void Q16()
        {
            Console.WriteLine("Enter a sentence to calculate vowels");
            String sentence = Console.ReadLine();
            String vowels = "AEIOUaeiou";
            int vowelCount = 0;

            for (int i = 0; i < sentence.Length; i++)
            {
                if (vowels.IndexOf(sentence[i]) >= 0)
                {
                    vowelCount = vowelCount + 1;
                }
            }
            Console.WriteLine($"The number of vowels in the sentence is {vowelCount}");
        }

        static void Q17()
        {
            Random random = new Random();
            int targetNumber = random.Next(1, 101);
            Console.WriteLine(targetNumber);
            int guess;
            int attempts = 0;

            do
            {
                guess = Convert.ToInt32(Console.ReadLine());
                attempts = attempts + 1;

                if (guess < targetNumber)
                {
                    Console.WriteLine($"Too low, Try Again!");
                }
                else if (guess < targetNumber)
                {
                    Console.WriteLine($"Too High, Try Again!");
                }
                else
                {
                    Console.WriteLine($"Wow! you guessed the {targetNumber}");
                }
            }
            while (guess != targetNumber);
        }



        static void Q18()
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"Multiplication table for {number}:");

            for (int i = 1; i <= 15; i++)
            {
                int result = number * i;
                Console.WriteLine($"{number} * {i} = {result}");
            }
        }


        static void Q19()
        {
            Console.WriteLine("Enter a string:");
            string inputString = Console.ReadLine();

            Console.WriteLine("Enter a character:");
            char character = Convert.ToChar(Console.ReadLine());

            int count = 0;

            foreach (char c in inputString)
            {
                if (c == character)
                {
                    count = count +1;
                }
            }

            Console.WriteLine($"The character '{character}' occurs {count} times in the string.");
        }


        static void Q20()
        {
            Console.WriteLine("Enter the first number:");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int gcd = FindGCD(num1, num2);

            Console.WriteLine($"The Greatest Common Divisor (GCD) of {num1} and {num2} is {gcd}");
        }

        static int FindGCD(int a, int b)
        {
            while (b != 0)
            {
                int temp = b;
                b = a % b;
                a = temp;
            }

            return a;
        }
    }
}
