using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public abstract class Employee : Person
    {
        protected string department;

        // Default Constructor
        public Employee() : base()
        {
            department = "";
        }

        // Parameterized Constructor
        public Employee(string firstName, string lastName, string street, string city,
                       string telephone, string department)
            : base(firstName, lastName, street, city, telephone)
        {
            this.department = department;
        }

        // Property
        public string Department { get => department; set => department = value; }

        public override string ToString()
        {
            return base.ToString() + $"\nDepartment: {department}";
        }
    }
}
