using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public class GradStudent : Student
    {
        private string id;
        private string thesis;

        // Default Constructor
        public GradStudent() : base()
        {
            id = "";
            thesis = "";
        }

        // Parameterized Constructor
        public GradStudent(string firstName, string lastName, string id,
                          double test1, double test2, string thesis,
                          string street, string city, string telephone)
            : base(firstName, lastName, street, city, telephone, test1, test2)
        {
            this.id = id;
            this.thesis = thesis;
        }

        // Properties
        public string Id { get => id; set => id = value; }
        public string Thesis { get => thesis; set => thesis = value; }

        // ComputeGrade: 0.45 * test1 + 0.55 * test2
        public override double ComputeGrade()
        {
            return 0.45 * test1 + 0.55 * test2;
        }

        public override string ToString()
        {
            return $"Graduate Student\nID: {id}\nThesis: {thesis}\n" + base.ToString();
        }
    }
}
