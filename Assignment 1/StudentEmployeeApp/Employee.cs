namespace StudentApp
{
    internal class Employee
    {
        private string firstName;
        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }

        private string lastName;
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }

        private int empID;
        public int EmpID
        {
            get { return empID; }
            set { empID = value; }
        }

        private double hoursWorked;
        public double HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }

        private double payRate;
        public double PayRate
        {
            get { return payRate; }
            set { payRate = value; }
        }

        private const double STANDARD_WORK_WEEK = 40.0;
        private const double OVERTIME_MULTIPLIER = 1.5;

        public double ComputePay()
        {
            double totalPay = 0;

            if (hoursWorked <= STANDARD_WORK_WEEK)
            {
                // No overtime - regular pay only
                totalPay = hoursWorked * payRate;
            }
            else
            {
                // Overtime calculation
                double overtimeHours = hoursWorked - STANDARD_WORK_WEEK;
                double overtimeRate = payRate * OVERTIME_MULTIPLIER;

                totalPay = (STANDARD_WORK_WEEK * payRate) + (overtimeHours * overtimeRate);
            }

            return totalPay;
        }

        public double ComputeOvertimePay()
        {
            if (hoursWorked > STANDARD_WORK_WEEK)
            {
                double overtimeHours = hoursWorked - STANDARD_WORK_WEEK;
                double overtimeRate = payRate * OVERTIME_MULTIPLIER;
                return overtimeHours * overtimeRate;
            }
            return 0; // No overtime
        }

        public override string ToString()
        {
            double totalPay = ComputePay();
            double overtimePay = ComputeOvertimePay();
            double regularPay = totalPay - overtimePay;

            return $"Employee ID: {EmpID}\n" +
                   $"Name: {FirstName} {LastName}\n" +
                   $"Hours Worked: {HoursWorked}\n" +
                   $"Pay Rate: ${PayRate:F2}/hr\n" +
                   $"Regular Pay: ${regularPay:F2}\n" +
                   $"Overtime Pay: ${overtimePay:F2}\n" +
                   $"Total Pay: ${totalPay:F2}";
        }

    }
}