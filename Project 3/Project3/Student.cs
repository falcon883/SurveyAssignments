using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Project3.Enumerations;

namespace Project3
{
    public class Student
    {
        public string ID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Test1 { get; set; }
        public double Test2 { get; set; }
        public Major Major { get; set; }
        public StudentType Type { get; set; }

        public double CalculateGrade()
        {
            return Type == StudentType.UG
                ? 0.4 * Test1 + 0.6 * Test2
                : 0.5 * Test1 + 0.5 * Test2;
        }

        public string GetGradeLetter()
        {
            double grade = CalculateGrade();
            if (grade >= 90) return "A";
            if (grade >= 80) return "B";
            if (grade >= 70) return "C";
            if (grade >= 60) return "D";
            return "F";
        }

    }
}
