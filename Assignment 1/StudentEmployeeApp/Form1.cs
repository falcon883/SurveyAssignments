using System;
using System.Windows.Forms;

namespace StudentApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComputeGrade_Click(object sender, EventArgs e)
        {

            if (!ValidateStudentInputs())
            {
                ShowErrorMessage("Please fill in all student fields with valid data.");
                return;
            }

            try
            {
                // Read student data
                string fName = txtFirstName.Text;
                string lName = txtLastName.Text;
                int id = int.Parse(txtID.Text);
                int test1 = int.Parse(txtTest1.Text);
                int test2 = int.Parse(txtTest2.Text);

                // Create student object
                Student s1 = new Student();
                s1.FirstName = fName;
                s1.LastName = lName;
                s1.ID = id;
                s1.Test1 = test1;
                s1.Test2 = test2;

                MessageBox.Show(s1.ToString());
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Input error: {ex.Message}");
            }
        }

        private void btnComputePay_Click(object sender, EventArgs e)
        {

            if (!ValidateEmployeeInputs())
            {
                ShowErrorMessage("Please complete all employee fields with valid information.");
                return;
            }

            try
            {
                // Read employee data
                string fName = txtEmpFirstName.Text;
                string lName = txtEmpLastName.Text;
                int empID = int.Parse(txtEmpID.Text);
                double hours = double.Parse(txtHoursWorked.Text);
                double rate = double.Parse(txtPayRate.Text);

                // Create employee object
                Employee emp = new Employee();
                emp.FirstName = fName;
                emp.LastName = lName;
                emp.EmpID = empID;
                emp.HoursWorked = hours;
                emp.PayRate = rate;

                MessageBox.Show(emp.ToString());
            }
            catch (Exception ex)
            {
                ShowErrorMessage($"Input error: {ex.Message}");
            }
        }

        private bool ValidateStudentInputs()
        {
            return !string.IsNullOrWhiteSpace(txtFirstName.Text) &&
                   !string.IsNullOrWhiteSpace(txtLastName.Text) &&
                   !string.IsNullOrWhiteSpace(txtID.Text) &&
                   !string.IsNullOrWhiteSpace(txtTest1.Text) &&
                   !string.IsNullOrWhiteSpace(txtTest2.Text);
        }

        private bool ValidateEmployeeInputs()
        {
            return !string.IsNullOrWhiteSpace(txtEmpFirstName.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmpLastName.Text) &&
                   !string.IsNullOrWhiteSpace(txtEmpID.Text) &&
                   !string.IsNullOrWhiteSpace(txtHoursWorked.Text) &&
                   !string.IsNullOrWhiteSpace(txtPayRate.Text);
        }

        private void ShowErrorMessage(string message)
        {
            MessageBox.Show(message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}