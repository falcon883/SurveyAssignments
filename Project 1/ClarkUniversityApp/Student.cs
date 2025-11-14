using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public abstract class Student : Person
    {
        protected double test1;
        protected double test2;

        // Default Constructor
        public Student() : base()
        {
            test1 = 0.0;
            test2 = 0.0;
        }

        // Parameterized Constructor
        public Student(string firstName, string lastName, string street, string city,
                      string telephone, double test1, double test2)
            : base(firstName, lastName, street, city, telephone)
        {
            this.test1 = test1;
            this.test2 = test2;
        }

        // Properties
        public double Test1 { get => test1; set => test1 = value; }
        public double Test2 { get => test2; set => test2 = value; }

        // Abstract method to be implemented by derived classes
        public abstract double ComputeGrade();

        public override string ToString()
        {
            return base.ToString() + $"\nTest 1: {test1}, Test 2: {test2}\nGrade: {ComputeGrade():F2}";
        }
    }
}