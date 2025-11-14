using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudApp
{
    internal class GradStudent : Student
    {
        private int id;
        private string thesis;

        public GradStudent() : base() { }

        public GradStudent(string fName, string lName, int id, int t1, int t2, string thesis,
            string street, string city, string telephone)
            : base(fName, lName, t1, t2, street, city, telephone)
        {
            this.id = id;
            this.thesis = thesis;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Thesis
        {
            get { return thesis; }
            set { thesis = value; }
        }

        // ONLY implements the average calculation
        protected override double CalculateAverage()
        {
            return 0.35 * test1 + 0.65 * test2;
        }

        public override string ToString()
        {
            return $"[Graduate] {firstName} {lastName} (ID: {id}) - Thesis: '{thesis}' - Tests: {test1}/{test2} - Grade: {ComputeGrade()} - {street}, {city} - Tel: {telephone}";
        }
    }
}