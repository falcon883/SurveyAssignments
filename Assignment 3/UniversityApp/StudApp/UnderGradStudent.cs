using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudApp
{
    internal class UnderGradStudent : Student
    {
        private int id;

        public UnderGradStudent() : base() { }

        public UnderGradStudent(string fName, string lName, int id, int t1, int t2,
            string street, string city, string telephone)
            : base(fName, lName, t1, t2, street, city, telephone)
        {
            this.id = id;
        }

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        // ONLY implements the average calculation
        protected override double CalculateAverage()
        {
            return 0.45 * test1 + 0.55 * test2;
        }

        public override string ToString()
        {
            return $"[Undergraduate] {firstName} {lastName} (ID: {id}) - Tests: {test1}/{test2} - Grade: {ComputeGrade()} - {street}, {city} - Tel: {telephone}";
        }
    }
}