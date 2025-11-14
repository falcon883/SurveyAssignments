using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public class LabManager : Employee
    {
        private string empID;

        // Default Constructor
        public LabManager() : base()
        {
            empID = "";
        }

        // Parameterized Constructor
        public LabManager(string firstName, string lastName, string empID,
                         string department, string street, string city, string telephone)
            : base(firstName, lastName, street, city, telephone, department)
        {
            this.empID = empID;
        }

        // Property
        public string EmpID { get => empID; set => empID = value; }

        public override string ToString()
        {
            return $"Lab Manager\nEmployee ID: {empID}\n" + base.ToString();
        }
    }
}
