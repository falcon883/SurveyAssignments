namespace StudentApp
{
    internal class Student
    {
        string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        int id;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        int test1;
        public int Test1
        {
            get { return test1; }
            set { test1 = value; }
        }

        int test2;
        public int Test2
        {
            get { return test2; }
            set { test2 = value; }
        }

        public string ComputeGrade()
        {
            double weightedScore = (test1 * 0.6) + (test2 * 0.4);

            if (weightedScore >= 95)
                return "A";
            else if (weightedScore >= 90)
                return "A-";
            else if (weightedScore >= 87)
                return "B+";
            else if (weightedScore >= 83)
                return "B";
            else if (weightedScore >= 80)
                return "B-";
            else if (weightedScore >= 77)
                return "C+";
            else if (weightedScore >= 73)
                return "C";
            else
                return "Fail";
        }

        public override string ToString()
        {
            double weightedScore = (test1 * 0.6) + (test2 * 0.4);
            string grade = ComputeGrade();
            return $"Student ID: {ID}\n" +
                   $"Name: {FirstName} {LastName}\n" +
                   $"Test 1: {Test1}\n" +
                   $"Test 2: {Test2}\n" +
                   $"Average: {weightedScore:F1}\n" +
                   $"Grade: {grade}";
        }

    }
}