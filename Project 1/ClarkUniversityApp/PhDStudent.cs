using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClarkUniversityApp
{
    public class PhDStudent : Student
    {
        private string id;
        private string phDAdvisor;
        private string dissertation;

        // Default Constructor
        public PhDStudent() : base()
        {
            id = "";
            phDAdvisor = "";
            dissertation = "";
        }

        // Parameterized Constructor
        public PhDStudent(string firstName, string lastName, string id,
                         double test1, double test2, string phDAdvisor,
                         string dissertation, string street, string city, string telephone)
            : base(firstName, lastName, street, city, telephone, test1, test2)
        {
            this.id = id;
            this.phDAdvisor = phDAdvisor;
            this.dissertation = dissertation;
        }

        // Properties
        public string Id { get => id; set => id = value; }
        public string PhDAdvisor { get => phDAdvisor; set => phDAdvisor = value; }
        public string Dissertation { get => dissertation; set => dissertation = value; }

        // ComputeGrade: 0.3 * test1 + 0.7 * test2
        public override double ComputeGrade()
        {
            return 0.3 * test1 + 0.7 * test2;
        }

        public override string ToString()
        {
            return $"PhD Student\nID: {id}\nAdvisor: {phDAdvisor}\nDissertation: {dissertation}\n" + base.ToString();
        }
    }
}
