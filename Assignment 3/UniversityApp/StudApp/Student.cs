using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudApp
{
    internal abstract class Student
    {
        // Default constructor
        public Student() { }

        // Base constructor
        public Student(string fName, string lName, int t1, int t2, string street, string city, string telephone)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.test1 = t1;
            this.test2 = t2;
            this.street = street;
            this.city = city;
            this.telephone = telephone;
        }

        // PROTECTED fields - accessible by derived classes
        protected string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        protected string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        protected int test1;
        public int Test1
        {
            get { return test1; }
            set { test1 = value; }
        }

        protected int test2;
        public int Test2
        {
            get { return test2; }
            set { test2 = value; }
        }

        protected string street;
        public string Street
        {
            get { return street; }
            set { street = value; }
        }

        protected string city;
        public string City
        {
            get { return city; }
            set { city = value; }
        }

        protected string telephone;
        public string Telephone
        {
            get { return telephone; }
            set { telephone = value; }
        }

        // ABSTRACT method - each student type calculates average differently
        protected abstract double CalculateAverage();

        // SHARED method - all students use same letter grade scale
        protected string CalculateLetterGrade(double average)
        {
            if (average >= 90) return "A+";
            else if (average >= 85) return "A";
            else if (average >= 80) return "B+";
            else if (average >= 75) return "B";
            else if (average >= 70) return "C+";
            else if (average >= 65) return "C";
            else if (average >= 60) return "D";
            else return "F";
        }

        // PUBLIC numeric average (for UI display / reports)
        public double ComputeAverage()
        {
            return CalculateAverage();
        }

        // PUBLIC method - uses Template Method pattern to map numeric to letter
        public string ComputeGrade()
        {
            var average = CalculateAverage();
            return CalculateLetterGrade(average);
        }

        // VIRTUAL method - can be overridden by derived classes
        public override string ToString()
        {
            // Shows both numeric and letter for clarity
            return $"{firstName} {lastName} - Tests: {test1}/{test2} - Grade: {ComputeAverage():0.##} ({ComputeGrade()}) - {street}, {city} - Tel: {telephone}";
        }
    }
}