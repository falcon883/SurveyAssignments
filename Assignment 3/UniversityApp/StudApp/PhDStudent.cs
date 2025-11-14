using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudApp
{
    internal class PhDStudent : Student
    {
        private int id;
        private string phDAdvisor;
        private string dissertation;

        public PhDStudent() : base() { }

        public PhDStudent(string fName, string lName, int id, int t1, int t2, string phDAdvisor,
            string dissertation, string street, string city, string telephone)
            : base(fName, lName, t1, t2, street, city, telephone)
        {
            this.id = id;
            this.phDAdvisor = phDAdvisor;
            this.dissertation = dissertation;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string PhDAdvisor
        {
            get { return phDAdvisor; }
            set { phDAdvisor = value; }
        }

        public string Dissertation
        {
            get { return dissertation; }
            set { dissertation = value; }
        }

        //ONLY implements the average calculation
        protected override double CalculateAverage()
        {
            return 0.3 * test1 + 0.7 * test2;
        }

        public override string ToString()
        {
            return $"[PhD] {firstName} {lastName} (ID: {id}) - Advisor: {phDAdvisor} - Dissertation: '{dissertation}' - Tests: {test1}/{test2} - Grade: {ComputeGrade()} - {street}, {city} - Tel: {telephone}";
        }
    }
}