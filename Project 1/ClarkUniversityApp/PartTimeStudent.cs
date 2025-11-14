using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public class PartTimeStudent : Student
    {
        private string ssNum;

        // Default Constructor
        public PartTimeStudent() : base()
        {
            ssNum = "";
        }

        // Parameterized Constructor
        public PartTimeStudent(string firstName, string lastName, string ssNum,
                              double test1, double test2, string street, string city, string telephone)
            : base(firstName, lastName, street, city, telephone, test1, test2)
        {
            this.ssNum = ssNum;
        }

        // Property
        public string SsNum { get => ssNum; set => ssNum = value; }

        // ComputeGrade: 0.4 * test1 + 0.6 * test2
        public override double ComputeGrade()
        {
            return 0.4 * test1 + 0.6 * test2;
        }

        public override string ToString()
        {
            return $"Part-Time Student\nSSN: {ssNum}\n" + base.ToString();
        }
    }
}
