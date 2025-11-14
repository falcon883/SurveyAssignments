using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public class PartTimeFaculty : Employee
    {
        private string ssNum;

        // Default Constructor
        public PartTimeFaculty() : base()
        {
            ssNum = "";
        }

        // Parameterized Constructor
        public PartTimeFaculty(string firstName, string lastName, string ssNum,
                              string department, string street, string city, string telephone)
            : base(firstName, lastName, street, city, telephone, department)
        {
            this.ssNum = ssNum;
        }

        // Property
        public string SsNum { get => ssNum; set => ssNum = value; }

        public override string ToString()
        {
            return $"Part-Time Faculty\nSSN: {ssNum}\n" + base.ToString();
        }
    }
}
