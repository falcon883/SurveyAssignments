using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public class Secretary : Employee
    {
        private string empID;

        // Default Constructor
        public Secretary() : base()
        {
            empID = "";
        }

        // Parameterized Constructor
        public Secretary(string firstName, string lastName, string empID,
                        string department, string street, string city, string telephone)
            : base(firstName, lastName, street, city, telephone, department)
        {
            this.empID = empID;
        }

        // Property
        public string EmpID { get => empID; set => empID = value; }

        public override string ToString()
        {
            return $"Secretary\nEmployee ID: {empID}\n" + base.ToString();
        }
    }
}
