using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudApp
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();

        public Form1()
        {
            InitializeComponent();
            UpdateFieldVisibility();
            UpdateStudentCount();

            // Add event handlers after initialization
            txtTest1.TextChanged += txtTest1_TextChanged;
            txtTest2.TextChanged += txtTest2_TextChanged;
        }

        private void StudentType_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFieldVisibility();
            CalculateGradePolymorphically(); // Uses polymorphism now
        }

        private void UpdateFieldVisibility()
        {
            // Reset all fields visibility
            lblSSN.Visible = txtSSN.Visible = false;
            lblID.Visible = txtID.Visible = true;
            lblThesis.Visible = txtThesis.Visible = false;
            lblAdvisor.Visible = txtAdvisor.Visible = false;
            lblDissertation.Visible = txtDissertation.Visible = false;

            if (rbPartTime.Checked)
            {
                lblSSN.Visible = txtSSN.Visible = true;
                lblID.Visible = txtID.Visible = false;
            }
            else if (rbGrad.Checked)
            {
                lblThesis.Visible = txtThesis.Visible = true;
            }
            else if (rbPhD.Checked)
            {
                lblThesis.Visible = txtThesis.Visible = false;
                lblAdvisor.Visible = txtAdvisor.Visible = true;
                lblDissertation.Visible = txtDissertation.Visible = true;
            }
        }

        private void txtTest1_TextChanged(object sender, EventArgs e)
        {
            CalculateGradePolymorphically();
        }

        private void txtTest2_TextChanged(object sender, EventArgs e)
        {
            CalculateGradePolymorphically();
        }


        private void CalculateGradePolymorphically()
        {
            if (int.TryParse(txtTest1.Text, out int test1) &&
                int.TryParse(txtTest2.Text, out int test2))
            {
                try
                {
                    // Create temporary student object and use polymorphic method
                    Student tempStudent = CreateTempStudentForPreview();
                    if (tempStudent != null)
                    {
                        // Show numeric + letter, e.g. "86.5 (B+)"
                        double avg = tempStudent.ComputeAverage();
                        string letter = tempStudent.ComputeGrade();
                        txtGrade.Text = $"{avg:0.##} ({letter})";
                    }
                }
                catch
                {
                    txtGrade.Text = ""; // If creation fails, clear grade
                }
            }
            else
            {
                txtGrade.Text = "";
            }
        }

        // Factory method for creating temporary student for preview
        private Student CreateTempStudentForPreview()
        {
            if (!int.TryParse(txtTest1.Text, out int test1) ||
                !int.TryParse(txtTest2.Text, out int test2))
                return null;

            // Use placeholder values for preview - we only need test scores for grade calculation
            string tempName = "Preview";
            string tempStreet = "N/A";
            string tempCity = "N/A";
            string tempPhone = "N/A";

            return CreateStudentByType(tempName, tempName, test1, test2, tempStreet, tempCity, tempPhone);
        }

        // Factory method eliminates repetitive type checking
        private Student CreateStudentByType(string firstName, string lastName, int test1, int test2,
            string street, string city, string telephone)
        {
            if (rbPartTime.Checked)
            {
                string ssn = string.IsNullOrEmpty(txtSSN.Text) ? "000-00-0000" : txtSSN.Text.Trim();
                return new PartTimeStudent(firstName, lastName, ssn, test1, test2, street, city, telephone);
            }
            else if (rbUnderGrad.Checked)
            {
                int id = int.TryParse(txtID.Text, out int parsedId) ? parsedId : 0;
                return new UnderGradStudent(firstName, lastName, id, test1, test2, street, city, telephone);
            }
            else if (rbGrad.Checked)
            {
                int id = int.TryParse(txtID.Text, out int parsedId) ? parsedId : 0;
                string thesis = string.IsNullOrEmpty(txtThesis.Text) ? "TBD" : txtThesis.Text.Trim();
                return new GradStudent(firstName, lastName, id, test1, test2, thesis, street, city, telephone);
            }
            else if (rbPhD.Checked)
            {
                int id = int.TryParse(txtID.Text, out int parsedId) ? parsedId : 0;
                string advisor = string.IsNullOrEmpty(txtAdvisor.Text) ? "TBD" : txtAdvisor.Text.Trim();
                string dissertation = string.IsNullOrEmpty(txtDissertation.Text) ? "TBD" : txtDissertation.Text.Trim();
                return new PhDStudent(firstName, lastName, id, test1, test2, advisor, dissertation, street, city, telephone);
            }

            return null;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateInput())
                    return;

                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                int test1 = int.Parse(txtTest1.Text);
                int test2 = int.Parse(txtTest2.Text);
                string street = txtStreet.Text.Trim();
                string city = txtCity.Text.Trim();
                string telephone = txtTelephone.Text.Trim();

                Student student = CreateStudentByType(firstName, lastName, test1, test2, street, city, telephone);

                if (student != null)
                {
                    students.Add(student); // Polymorphic storage
                    lstStudents.Items.Add(student.ToString()); // Polymorphic method call
                    UpdateStudentCount();

                    // Show grade using polymorphic method
                    MessageBox.Show($"Student added successfully!\nGrade: {student.ComputeGrade()}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding student: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool ValidateInput()
        {
            // Common validation
            if (string.IsNullOrWhiteSpace(txtFirstName.Text))
            {
                ShowValidationError("First name is required.", txtFirstName);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLastName.Text))
            {
                ShowValidationError("Last name is required.", txtLastName);
                return false;
            }

            if (!ValidateTestScore(txtTest1.Text, "Test 1", txtTest1) ||
                !ValidateTestScore(txtTest2.Text, "Test 2", txtTest2))
            {
                return false;
            }

            return ValidateStudentTypeSpecificFields();
        }

        private bool ValidateStudentTypeSpecificFields()
        {
            if (rbPartTime.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtSSN.Text))
                {
                    ShowValidationError("SSN is required for part-time students.", txtSSN);
                    return false;
                }
            }
            else // All other types need ID
            {
                if (!int.TryParse(txtID.Text, out _))
                {
                    ShowValidationError("Valid Student ID is required.", txtID);
                    return false;
                }
            }

            if (rbGrad.Checked && string.IsNullOrWhiteSpace(txtThesis.Text))
            {
                ShowValidationError("Thesis title is required for graduate students.", txtThesis);
                return false;
            }

            if (rbPhD.Checked)
            {
                if (string.IsNullOrWhiteSpace(txtAdvisor.Text))
                {
                    ShowValidationError("PhD Advisor is required for PhD students.", txtAdvisor);
                    return false;
                }

                if (string.IsNullOrWhiteSpace(txtDissertation.Text))
                {
                    ShowValidationError("Dissertation title is required for PhD students.", txtDissertation);
                    return false;
                }
            }

            return true;
        }

        // Helper methods to reduce code duplication
        private bool ValidateTestScore(string scoreText, string testName, TextBox textBox)
        {
            if (!int.TryParse(scoreText, out int score) || score < 0 || score > 100)
            {
                ShowValidationError($"{testName} score must be between 0 and 100.", textBox);
                return false;
            }
            return true;
        }

        private void ShowValidationError(string message, Control controlToFocus)
        {
            MessageBox.Show(message, "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            controlToFocus.Focus();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtSSN.Clear();
            txtID.Clear();
            txtTest1.Clear();
            txtTest2.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtTelephone.Clear();
            txtThesis.Clear();
            txtAdvisor.Clear();
            txtDissertation.Clear();
            txtGrade.Clear();
            txtFirstName.Focus();
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            lstStudents.Items.Clear();

            if (students.Count == 0)
            {
                MessageBox.Show("No students have been added yet.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Group and display students
            DisplayStudentsByType<PartTimeStudent>("PART-TIME STUDENTS");
            DisplayStudentsByType<UnderGradStudent>("UNDERGRADUATE STUDENTS");
            DisplayStudentsByType<GradStudent>("GRADUATE STUDENTS");
            DisplayStudentsByType<PhDStudent>("PHD STUDENTS");

            lstStudents.Items.Add($"Total Students: {students.Count}");
            UpdateStudentCount();
        }

        private void DisplayStudentsByType<T>(string header) where T : Student
        {
            var studentsOfType = students.OfType<T>().ToList();
            if (studentsOfType.Count > 0)
            {
                lstStudents.Items.Add($"=== {header} ===");
                foreach (var student in studentsOfType)
                {
                    // Polymorphic call - each student type's ToString() is called
                    // Each student's ComputeGrade() uses the improved template method
                    lstStudents.Items.Add(student.ToString());
                }
                lstStudents.Items.Add("");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(searchTerm))
            {
                MessageBox.Show("Please enter a search term.", "Search", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var searchResults = students.Where(s => s.ToString().ToLower().Contains(searchTerm)).ToList();

            lstStudents.Items.Clear();

            if (!searchResults.Any())
            {
                MessageBox.Show($"No students found matching '{txtSearch.Text}'.", "Search Results", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            foreach (Student student in searchResults)
            {
                // Polymorphic call - each student's custom ToString() method
                lstStudents.Items.Add(student.ToString());
            }

            lstStudents.Items.Add("");
            lstStudents.Items.Add($"Search Results for '{txtSearch.Text}' - {searchResults.Count} match(es) found");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lstStudents.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a student to delete.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string selectedItem = lstStudents.SelectedItem.ToString();

            // Don't allow deletion of header lines or summary lines
            if (selectedItem.StartsWith("===") || selectedItem.StartsWith("Total Students:") ||
                selectedItem.Contains("Search Results") || string.IsNullOrEmpty(selectedItem))
            {
                MessageBox.Show("Please select a valid student record to delete.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Are you sure you want to delete this student record?",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                var studentToRemove = students.FirstOrDefault(s => s.ToString() == selectedItem);
                if (studentToRemove != null)
                {
                    students.Remove(studentToRemove);
                    lstStudents.Items.RemoveAt(lstStudents.SelectedIndex);
                    UpdateStudentCount();
                    MessageBox.Show("Student record deleted successfully.", "Delete Student", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void UpdateStudentCount()
        {
            lblTotalStudents.Text = $"Total Students: {students.Count}";
        }
    }
}