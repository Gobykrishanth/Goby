using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Address
    {
        private string number;
        private string street;
        private string city;
        private string state;
        private string postalCode;
        private string country;

        public Address(string number, string street, string city, string state, string postalCode, string country)
        {
            this.number = number;
            this.street = street;
            this.city = city;
            this.state = state;
            this.postalCode = postalCode;
            this.country = country;
        }

        public string GetStreet()
        {
            return street;
        }

        public string GetCity()
        {
            return city;
        }

        public string GetState()
        {
            return state;
        }

        public string GetPostalCode()
        {
            return postalCode;
        }

        public string GetCountry()
        {
            return country; 
        }
        public override string ToString()
        {
            return $"{GetStreet()}, {GetCity()}, {GetState()} {GetPostalCode()} ,{GetCountry()}";
        }
    }
}
