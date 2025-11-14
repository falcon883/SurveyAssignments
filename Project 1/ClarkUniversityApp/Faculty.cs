using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public class Faculty : Employee
    {
        private string empID;
        private string rank;

        // Default Constructor
        public Faculty() : base()
        {
            empID = "";
            rank = "";
        }

        // Parameterized Constructor
        public Faculty(string firstName, string lastName, string empID,
                      string department, string rank, string street, string city, string telephone)
            : base(firstName, lastName, street, city, telephone, department)
        {
            this.empID = empID;
            this.rank = rank;
        }

        // Properties
        public string EmpID { get => empID; set => empID = value; }
        public string Rank { get => rank; set => rank = value; }

        public override string ToString()
        {
            return $"Faculty\nEmployee ID: {empID}\nRank: {rank}\n" + base.ToString();
        }
    }
}
