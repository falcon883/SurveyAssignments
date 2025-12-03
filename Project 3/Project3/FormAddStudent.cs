using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project3.Enumerations;

namespace Project3
{
    public partial class FormAddStudent : Form
    {
        // FormAddStudent.cs
        public Student NewStudent { get; private set; }
        private List<Student> existingStudents;

        public FormAddStudent(List<Student> students)
        {
            InitializeComponent();
            existingStudents = students;
        }

        private void FormAddStudent_Load(object sender, EventArgs e)
        {
            // Populate major combobox
            cmbMajor.DataSource = Enum.GetValues(typeof(Major));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate input
                if (string.IsNullOrWhiteSpace(txtID.Text))
                    throw new Exception("ID is required");

                if (string.IsNullOrWhiteSpace(txtFirstName.Text))
                    throw new Exception("First name is required");

                if (string.IsNullOrWhiteSpace(txtLastName.Text))
                    throw new Exception("Last name is required");

                // Check for unique ID
                if (existingStudents.Any(s => s.ID == txtID.Text))
                    throw new Exception("Student ID must be unique");

                // Parse test scores
                if (!double.TryParse(txtTest1.Text, out double test1) || test1 < 0 || test1 > 100)
                    throw new Exception("Test 1 must be a number between 0 and 100");

                if (!double.TryParse(txtTest2.Text, out double test2) || test2 < 0 || test2 > 100)
                    throw new Exception("Test 2 must be a number between 0 and 100");

                // Create new student
                NewStudent = new Student
                {
                    ID = txtID.Text,
                    FirstName = txtFirstName.Text,
                    LastName = txtLastName.Text,
                    Test1 = test1,
                    Test2 = test2,
                    Major = (Major)cmbMajor.SelectedItem,
                    Type = rbUG.Checked ? StudentType.UG : StudentType.GRAD
                };

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
