using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public abstract class Person
    {
        protected string firstName;
        protected string lastName;
        protected string street;
        protected string city;
        protected string telephone;

        // Default Constructor
        public Person()
        {
            firstName = "";
            lastName = "";
            street = "";
            city = "";
            telephone = "";
        }

        // Parameterized Constructor
        public Person(string firstName, string lastName, string street, string city, string telephone)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.street = street;
            this.city = city;
            this.telephone = telephone;
        }

        // Properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Street { get => street; set => street = value; }
        public string City { get => city; set => city = value; }
        public string Telephone { get => telephone; set => telephone = value; }

        public override string ToString()
        {
            return $"Name: {firstName} {lastName}\nAddress: {street}, {city}\nTelephone: {telephone}";
        }
    }
}
