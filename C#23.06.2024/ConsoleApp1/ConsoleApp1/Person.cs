using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Person
    {
        public string Name;
        //private int Age;
        public int BirthYear;
        private int _currentYear = 2024;
        public int Age
                
        {
            get
            {
                return _currentYear-BirthYear;
            }
        }

        public Address address;


        public virtual void DisplayPersonInfo()
        {
            Console.WriteLine("Name :" + Name);
            //Console.WriteLine("Age :" + GetAge());
            Console.WriteLine("Age :" + Age);
            Console.WriteLine("Adress :" + address);
        }

        
        /*public void SetAge(int val)
        {
            if (val >= 0)
            {
                Age = val;
            } else
            {
                Console.WriteLine(" age cannot be set to a negative number");
            }
        }*/

       /* public int GetAge() 
        {
            return Age;
        }*/

    }
}
