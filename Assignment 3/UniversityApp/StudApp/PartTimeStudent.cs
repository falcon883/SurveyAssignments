using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudApp
{
    internal class PartTimeStudent : Student
    {
        private string ssNum;

        public PartTimeStudent() : base() { }

        public PartTimeStudent(string fName, string lName, string ssNum, int t1, int t2,
            string street, string city, string telephone)
            : base(fName, lName, t1, t2, street, city, telephone)
        {
            this.ssNum = ssNum;
        }

        public string SSNum
        {
            get { return ssNum; }
            set { ssNum = value; }
        }

        // ONLY implements the average calculation - specific to this student type
        protected override double CalculateAverage()
        {
            return 0.4 * test1 + 0.6 * test2;
        }

        // No need for CalculateLetterGrade() - inherited from base class
        // No need for ComputeGrade() - inherited template method handles it

        public override string ToString()
        {
            return $"[Part-Time] {firstName} {lastName} (SSN: {ssNum}) - Tests: {test1}/{test2} - Grade: {ComputeGrade()} - {street}, {city} - Tel: {telephone}";
        }
    }
}