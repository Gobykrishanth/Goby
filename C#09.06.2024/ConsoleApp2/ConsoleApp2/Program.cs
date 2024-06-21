using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

            //DateTime currentDate = DateTime.Now;
            //FormatDate(currentDate);

            //AuthenticateUser(username: "Carlito", password: "Carlito123");
            //AuthenticateUser(username: "Carlito", password: "Carlito123", question: "Whats Your Favourit Fruit", answer: "Apple");


            //SendEmail();

            //CalculateDiscount();
            //CalculateDiscount1();
            //CalculateDiscount2();

            //UploadFile(filePath: "example.txt", fileDescreption: "This is an example file.", 
            //    timestamp: DateTime.Now);


            //ProcessPayment(amount: 1001.30, Method: 1);

            //RegisterUser(name: "Kamal", Password: "123", Email: "Kamal@ymail.com", PhoneNumber: 0112233444);

            //DateTime date = DateTime.Now.Date;
            //ReserveBook(userID: 001, bookID: 001, date);

            //DateTime date = DateTime.Now.Date;
            //GenerateReport(report:"Sales", date);


            //GetWeatherForecast("Colombo",5);

            //CalculateTax(1000, 10.0);


            //DateTime date = DateTime.Now.Date;
            //BookTicket(date);

            //OrderFood(" no onions");

            BookTravel();

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


        static double CalculateArea(double num1, double num2)
        {
            return num1 * num2;
        }

        static double CalculateArea(double num1)
        {
            return num1 * num1;
        }

        static double ConvertTemperature(double Fahrenheit)
        {
            return (9 / 5) * (Fahrenheit - 32);
        }


        static int ConvertTemperature(int Celsius)
        {
            return Celsius * 5 / 9 + 32;
        }


        static void AddToCart(string name, int quantity)
        {
            Console.WriteLine($"Product Name : {name} \n Quantiy : {quantity}");
        }

        static void AddToCart(string name, int quantity, double price)
        {
            double total = quantity * price;
            Console.WriteLine($"Product Name : {name} \n Quantiy : {quantity} \n Total price : {total} LKR");
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

        static void CalculateDistance(double x1, double x2, double y1, double y2)
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



        //Question 15
        static void FormatDate(DateTime date)
        {
            date = date.ToUniversalTime();
            Console.WriteLine(date.ToString());
        }




        //Question 16
        static void AuthenticateUser(String username, String password)
        {
            Console.Write($"Enter Username :");
            string inputUsername = Console.ReadLine();
            Console.Write($"Enter Password :");
            string inputPassword = Console.ReadLine();
            if (inputUsername == username && inputPassword == password)
            {
                Console.WriteLine("Authentication was successful");
            }
            else
            {
                Console.WriteLine("Authentication was not successful");
            }
        }



        static void AuthenticateUser(String username, String password, String question, String answer)
        {
            Console.Write($"Enter Username :");
            string inputUsername = Console.ReadLine();
            Console.Write($"Enter Password :");
            string inputPassword = Console.ReadLine();
            Console.Write($"{question} :");
            string inputAnswer = Console.ReadLine();
            if (inputUsername == username && inputPassword == password && inputAnswer == answer)
            {
                Console.WriteLine("Authentication was successful");
            }
            else
            {
                Console.WriteLine("Authentication was not successful");
            }
        }



        //Question 17
        static void SendEmail()
        {
            Console.Write("Enter email adress :");
            string emailAdress = Console.ReadLine();
            Console.WriteLine("Type your Message");
            string message = Console.ReadLine();
        }

        // static void SendEmail()
        // {
        //       Console.Write("Enter email adress :");
        //     string emailAdress = Console.ReadLine();
        //      Console.WriteLine("Type your Message");
        //     string message = Console.ReadLine();
        //     Console.Write("CC :");
        //     string cc = Console.ReadLine();
        // }

        //Question 18
        static void CalculateDiscount()
        {
            Console.WriteLine("Choose from bellow \n............................\n" +
                " 1. Shirt - 500.00 LKR \n 2 T-Shirt - 750.00 LKR \n 3. Denim - 999.00 LKR");
            int choice = Convert.ToInt32(Console.ReadLine());
            double price = 0;
            double discountRate = 0.1;


            switch (choice)
            {
                case 1:
                    price = 500.00;
                    break;
                case 2:
                    price = 750.00;
                    break;
                case 3:
                    price = 999.00;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, or 3.");
                    break;
            }
            Console.Write("Enter Quantity : ");
            int quantity = Convert.ToInt32(Console.ReadLine());

            double totalPrice = price * quantity;
            double discountAmount = totalPrice * discountRate;
            double discountPrice = totalPrice - discountAmount;

            Console.WriteLine($"Original Price: {totalPrice} LKR");
            Console.WriteLine($"Discount amount (10%) : {discountPrice} LKR");
        }

        static void CalculateDiscount1()
        {
            double shirtPrice = 500.00;
            double t_shirtPrice = 750.00;
            double denimPrice = 999.00;
            double discountRate = 0.1;

            Console.WriteLine("Enter The Quantity For Each Item \n" +
                ".........................................");

            Console.Write("Shirt Each 500.00LKR :");
            int shirtQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("T-Shirt Each 750.00LKR :");
            int t_shirtQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Denim Each 999.00LKR :");
            int denimQuantity = Convert.ToInt32(Console.ReadLine());


            double shirtTotal = shirtPrice * shirtQuantity;
            double t_shirtTotal = t_shirtPrice * t_shirtQuantity;
            double denimTotal = denimPrice * denimQuantity;

            double totalPrice = shirtTotal + t_shirtTotal + denimTotal;
            double discountAmount = totalPrice * discountRate;
            double discountPrice = totalPrice - discountAmount;

            Console.WriteLine($"\n\nSummary \n ................");
            Console.WriteLine($"Shirt Total :{shirtTotal} LKR \n" +
                $"T-Shirt Total :{t_shirtTotal} LKR \n" +
                $"Denim Total : {denimTotal} LKR");
            Console.WriteLine("......................");
            Console.WriteLine($"Original Price : {totalPrice} lKR");
            Console.WriteLine("......................");
            Console.WriteLine("\n\n\n");
            Console.WriteLine("----------------------");
            Console.WriteLine($"Discount Amount (10%) : -{discountAmount} LKR");
            Console.WriteLine($"Discounted Total Price : {discountPrice} LKR");
            Console.WriteLine("----------------------");

        }

        static void CalculateDiscount2()
        {
            double shirtPrice = 500.00;
            double t_shirtPrice = 750.00;
            double denimPrice = 999.00;

            Console.WriteLine("Enter The Quantity For Each Item \n" +
                ".........................................");

            Console.Write("Shirt Each 500.00LKR :");
            int shirtQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("T-Shirt Each 750.00LKR :");
            int t_shirtQuantity = Convert.ToInt32(Console.ReadLine());
            Console.Write("Denim Each 999.00LKR :");
            int denimQuantity = Convert.ToInt32(Console.ReadLine());

            double shirtTotal = shirtPrice * shirtQuantity;
            double t_shirtTotal = t_shirtPrice * t_shirtQuantity;
            double denimTotal = denimPrice * denimQuantity;

            double totalPrice = shirtTotal + t_shirtTotal + denimTotal;

            double discountRate = 0.1;
            double flatDiscount = 100.00;


            CalculateDiscount(totalPrice, discountRate);
            CalculateDiscount(totalPrice, flatDiscount, true);

            Console.WriteLine($"\n\nSummary \n ................");
            Console.WriteLine($"Shirt Total :{shirtTotal} LKR \n" +
                $"T-Shirt Total :{t_shirtTotal} LKR \n" +
                $"Denim Total : {denimTotal} LKR");
            Console.WriteLine("......................");
            Console.WriteLine($"Original Price : {totalPrice} LKR");
        }

        static void CalculateDiscount(double totalPrice, double discountRate)
        {
            double discountAmount = totalPrice * discountRate;
            double discountPrice = totalPrice - discountAmount;

            Console.WriteLine("----------------------");
            Console.WriteLine($"Discount Amount ({discountRate * 100}%) : -{discountAmount} LKR");
            Console.WriteLine($"Discounted Total Price : {discountPrice} LKR");
            Console.WriteLine("----------------------");
        }

        static void CalculateDiscount(double totalPrice, double discountAmount, bool isFlat)
        {
            if (isFlat)
            {
                double discountPrice = totalPrice - discountAmount;

                Console.WriteLine("----------------------");
                Console.WriteLine($"Flat Discount Amount : -{discountAmount} LKR");
                Console.WriteLine($"Discounted Total Price : {discountPrice} LKR");
                Console.WriteLine("----------------------");
            }
            else
            {
                CalculateDiscount(totalPrice, discountAmount);
            }

        }


        //Question 19

        static void UploadFile(String filePath)
        {
            if (filePath == null)
            {
                Console.WriteLine("Invalid file path.");
            }
            else
            {
                Console.WriteLine($"Uploading file: {filePath}");
            }

        }

        static void UploadFile(String filePath, String fileDescreption, DateTime timestamp)
        {
            if (filePath == null)
            {
                Console.WriteLine("Invalid file path.");
            }
            else
            {
                Console.WriteLine($"Uploading file: {filePath}");
                Console.WriteLine($"Description: {fileDescreption}");
                Console.WriteLine($"Upload Timestamp: {timestamp}");
            }

        }

        //Question 20




        static void ProcessPayment(double amount, int Method)
        {
            Console.Write("Enter payment amount :");
            int paymentAmount = Convert.ToInt32(Console.ReadLine());
            int paymentInput = Method;

            string paymentMethod;

            switch (Method)
            {
                case 1:
                    paymentMethod = "credit card";
                    Console.Write("Enter Card Number: ");
                    string cardNumber = Console.ReadLine();
                    Console.WriteLine($"Payment Amount :{paymentAmount}");
                    Console.WriteLine($"Payment method: {paymentMethod}");
                    Console.WriteLine($"Card Number: {cardNumber}");
                    break;
                case 2:
                    paymentMethod = "PayPal";
                    Console.Write("Enter PayPal ID: ");
                    string paypalID = Console.ReadLine();
                    Console.WriteLine($"Payment Amount :{paymentAmount}");
                    Console.WriteLine($"Payment method: {paymentMethod}");
                    Console.WriteLine($"PayPal ID: {paypalID}");
                    break;
                default:
                    Console.WriteLine("Wrong Entry");
                    return;
            }
        }
        //Question 21
        static bool RegisterUser(String name, String Password)
        {
            Console.Write("Enter User Name :");
            string userName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Password :");
            string password = Convert.ToString(Console.ReadLine());

            if (userName == name && password == Password)
            {
                Console.WriteLine("registration was successful");
                return true;
            }
            else
            {
                Console.WriteLine("registration was not successful");
                return false;
            }
        }

        static bool RegisterUser(String name, String Password, String Email, int PhoneNumber)
        {
            Console.Write("Enter User Name :");
            string userName = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Password :");
            string password = Convert.ToString(Console.ReadLine());
            Console.Write("Enter Email: ");
            string inputEmail = Console.ReadLine();
            Console.Write("Enter Phone Number: ");
            int inputPhoneNumber = int.Parse(Console.ReadLine());


            if (userName == name && Password == password && inputEmail == Email && inputPhoneNumber == PhoneNumber)
            {
                Console.WriteLine("registration was successful");
                return true;
            }
            else
            {
                Console.WriteLine("registration was not successful");
                return false;
            }
        }

        //Question 22
        static bool ReserveBook(int userID, int bookID)
        {
            Console.Write("Enter User ID :");
            int inputUser = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book ID :");
            int inputBook = Convert.ToInt32(Console.ReadLine());


            if (inputUser == userID && inputBook == bookID)
            {
                Console.WriteLine("reservation was successful");
                return true;
            }
            else
            {
                Console.WriteLine("reservation was Unsuccessful");
                return false;
            }

        }

        static bool ReserveBook(int userID, int bookID, DateTime date)
        {
            Console.Write("Enter User ID :");
            int inputUser = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter Book ID :");
            int inputBook = Convert.ToInt32(Console.ReadLine());



            if (inputUser == userID && inputBook == bookID)
            {
                Console.WriteLine($"Reservation for User ID {userID} and Book ID {bookID} on {date.ToShortDateString()} was successful");

                return true;
            }
            else
            {
                Console.WriteLine("reservation was Unsuccessful");
                return false;
            }

        }

        //Question 23
        static void GenerateReport(string report)
        {
            Console.WriteLine("Enter 1 for Sales report 2 for Sales inventory");
            int reportType = Convert.ToInt32(Console.ReadLine());
            
            switch (reportType)
            {
                case 1:
                    Console.WriteLine("Sales report details");
                    break;

                case 2:
                    Console.WriteLine("inventory report details");
                    break;
                default:
                    Console.WriteLine("Invalid report type. Please specify either \"sales\" or \"inventory\"");
                    break;

            }

        }

        static void GenerateReport(string report, DateTime date)
        {
            Console.WriteLine("Enter 1 for Sales report 2 for Sales inventory");
            int reportType = Convert.ToInt32(Console.ReadLine());

            switch (reportType)
            {
                case 1:
                    Console.WriteLine($"Sales report details {date}");
                    Console.WriteLine(report);
                    break;

                case 2:
                    Console.WriteLine($"inventory report details {date}");
                    break;
                default:
                    Console.WriteLine("Invalid report type. Please specify either \"sales\" or \"inventory\"");
                    break;

            }

        }

        //Question 25

        static void GetWeatherForecast(String city)
        {
            Console.WriteLine("Enter City Name");
            string cityName = Convert.ToString(Console.ReadLine());

            if (cityName == city)
            {
                Console.WriteLine("Weather forecast for " + city + ":");          
                Console.WriteLine("Sunny with occasional clouds");
            }
            else
            {
                Console.WriteLine("City not supported or recognized.");
            }

        }

        static void GetWeatherForecast(String city, int days)
        {
            Console.WriteLine("Enter City Name");
            string cityName = Convert.ToString(Console.ReadLine());

            if (cityName == city)
            {
                Console.WriteLine("Weather forecast for " + city + "for the next" + days + "days" +":");
                Console.WriteLine("Sunny with occasional clouds");
            }
            else
            {
                Console.WriteLine("City not supported or recognized.");
            }

        }


        //Question 26
        static void CalculateTax(double Incm)
        {
            Console.WriteLine("Enter Your Income");
            double Income =  Convert.ToDouble(Console.ReadLine());
            double tax = 0.1;
            double taxAmount = Income * tax;
            Console.WriteLine($"Your tax amount :{taxAmount}");

        }

        static void CalculateTax(double Incm, double defaultTaxRate)
        {
            Console.WriteLine("Enter Your Income");
            double Income = Convert.ToDouble(Console.ReadLine());
            double tax = 0.2;
            double taxAmount = Income * tax;
            //double defaultTaxRate = 10.0);
            //Console.WriteLine($"Your tax amount :{taxAmount}");

            if (taxAmount > 100)
            {
                Console.WriteLine($"Your tax amount :{Income + defaultTaxRate}");
            } else {
                Console.WriteLine($"Your tax amount :{Income + taxAmount}");
            }
        }

        //Question 27
        static void BookTicket()
        {
            Console.WriteLine($"Enter movie name :");
            string movieName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("number of tickets :");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"movie name :{movieName}");
            Console.WriteLine($"number of tickets :{tickets}");
        }


        static void BookTicket(DateTime date)
        {
            Console.WriteLine($"Enter movie name :");
            string movieName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("number of tickets :");
            int tickets = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"movie name :{movieName}");
            Console.WriteLine($"number of tickets :{tickets}");
            Console.WriteLine($"Date :{date}");
        }



        //Question 28
        static void OrderFood()
        {
            Console.WriteLine($"Enter food name :");
            string foodName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Quantity :");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"food name :{foodName}");
            Console.WriteLine($"Quantity :{quantity}");
        }


        static void OrderFood(String specialRequest)
        {
            Console.WriteLine($"Enter food name :");
            string foodName = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Quantity :");
            int quantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"food name :{foodName}");
            Console.WriteLine($"Quantity :{quantity}");
            Console.WriteLine($"Special Request : { specialRequest}");
        }

        // Question 29
        static void BookTravel()
        {
            Console.Write($"destination :");
            string destination = Convert.ToString(Console.ReadLine());
            Console.Write($"travel date :");
            string travel = Convert.ToString(Console.ReadLine());


            Console.WriteLine($"destination :{destination}");
            Console.WriteLine($"travel date :{travel}");
        }


    }

}


