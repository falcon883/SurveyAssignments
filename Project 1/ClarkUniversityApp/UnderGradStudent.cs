using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public class UnderGradStudent : Student
    {
        private string id;

        // Default Constructor
        public UnderGradStudent() : base()
        {
            id = "";
        }

        // Parameterized Constructor
        public UnderGradStudent(string firstName, string lastName, string id,
                               double test1, double test2, string street, string city, string telephone)
            : base(firstName, lastName, street, city, telephone, test1, test2)
        {
            this.id = id;
        }

        // Property
        public string Id { get => id; set => id = value; }

        // ComputeGrade: 0.45 * test1 + 0.55 * test2
        public override double ComputeGrade()
        {
            return 0.45 * test1 + 0.55 * test2;
        }

        public override string ToString()
        {
            return $"Undergraduate Student\nID: {id}\n" + base.ToString();
        }
    }
}
