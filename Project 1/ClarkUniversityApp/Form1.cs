using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClarkUniversityApp
{
    public partial class Form1 : Form
    {
        private List<Person> universityMembers;

        public Form1()
        {
            InitializeComponent();
            universityMembers = new List<Person>();
        }

        private void CmbPersonType_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlSpecificFields.Controls.Clear();
            int yPos = 10;
            int spacing = 35;

            if (cmbPersonType.SelectedItem == null) return;

            string selectedType = cmbPersonType.SelectedItem.ToString() ?? "";

            switch (selectedType)
            {
                case "Part-Time Student":
                    AddLabel(pnlSpecificFields, "SSN:", 10, yPos);
                    txtSSN = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Test 1:", 10, yPos);
                    txtTest1 = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Test 2:", 10, yPos);
                    txtTest2 = AddTextBox(pnlSpecificFields, 120, yPos);
                    break;

                case "Undergraduate Student":
                    AddLabel(pnlSpecificFields, "Student ID:", 10, yPos);
                    txtID = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Test 1:", 10, yPos);
                    txtTest1 = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Test 2:", 10, yPos);
                    txtTest2 = AddTextBox(pnlSpecificFields, 120, yPos);
                    break;

                case "Graduate Student":
                    AddLabel(pnlSpecificFields, "Student ID:", 10, yPos);
                    txtID = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Test 1:", 10, yPos);
                    txtTest1 = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Test 2:", 10, yPos);
                    txtTest2 = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Thesis:", 10, yPos);
                    txtThesis = AddTextBox(pnlSpecificFields, 120, yPos);
                    break;

                case "PhD Student":
                    AddLabel(pnlSpecificFields, "Student ID:", 10, yPos);
                    txtID = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Test 1:", 10, yPos);
                    txtTest1 = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Test 2:", 10, yPos);
                    txtTest2 = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Advisor:", 10, yPos);
                    txtAdvisor = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Dissertation:", 10, yPos);
                    txtDissertation = AddTextBox(pnlSpecificFields, 120, yPos);
                    break;

                case "Lab Manager":
                    AddLabel(pnlSpecificFields, "Employee ID:", 10, yPos);
                    txtEmpID = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Department:", 10, yPos);
                    txtDepartment = AddTextBox(pnlSpecificFields, 120, yPos);
                    break;

                case "Faculty":
                    AddLabel(pnlSpecificFields, "Employee ID:", 10, yPos);
                    txtEmpID = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Department:", 10, yPos);
                    txtDepartment = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Rank:", 10, yPos);
                    txtRank = AddTextBox(pnlSpecificFields, 120, yPos);
                    break;

                case "Part-Time Faculty":
                    AddLabel(pnlSpecificFields, "SSN:", 10, yPos);
                    txtSSN = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Department:", 10, yPos);
                    txtDepartment = AddTextBox(pnlSpecificFields, 120, yPos);
                    break;

                case "Secretary":
                    AddLabel(pnlSpecificFields, "Employee ID:", 10, yPos);
                    txtEmpID = AddTextBox(pnlSpecificFields, 120, yPos);
                    yPos += spacing;
                    AddLabel(pnlSpecificFields, "Department:", 10, yPos);
                    txtDepartment = AddTextBox(pnlSpecificFields, 120, yPos);
                    break;
            }
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (cmbPersonType.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a person type.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string firstName = txtFirstName.Text.Trim();
                string lastName = txtLastName.Text.Trim();
                string street = txtStreet.Text.Trim();
                string city = txtCity.Text.Trim();
                string telephone = txtTelephone.Text.Trim();

                if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                {
                    MessageBox.Show("First Name and Last Name are required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Person? person = null;
                string selectedType = cmbPersonType.SelectedItem?.ToString() ?? "";

                switch (selectedType)
                {
                    case "Part-Time Student":
                        if (txtSSN != null && txtTest1 != null && txtTest2 != null)
                        {
                            person = new PartTimeStudent(firstName, lastName, txtSSN.Text,
                                double.Parse(txtTest1.Text), double.Parse(txtTest2.Text),
                                street, city, telephone);
                        }
                        break;

                    case "Undergraduate Student":
                        if (txtID != null && txtTest1 != null && txtTest2 != null)
                        {
                            person = new UnderGradStudent(firstName, lastName, txtID.Text,
                                double.Parse(txtTest1.Text), double.Parse(txtTest2.Text),
                                street, city, telephone);
                        }
                        break;

                    case "Graduate Student":
                        if (txtID != null && txtTest1 != null && txtTest2 != null && txtThesis != null)
                        {
                            person = new GradStudent(firstName, lastName, txtID.Text,
                                double.Parse(txtTest1.Text), double.Parse(txtTest2.Text),
                                txtThesis.Text, street, city, telephone);
                        }
                        break;

                    case "PhD Student":
                        if (txtID != null && txtTest1 != null && txtTest2 != null &&
                            txtAdvisor != null && txtDissertation != null)
                        {
                            person = new PhDStudent(firstName, lastName, txtID.Text,
                                double.Parse(txtTest1.Text), double.Parse(txtTest2.Text),
                                txtAdvisor.Text, txtDissertation.Text, street, city, telephone);
                        }
                        break;

                    case "Lab Manager":
                        if (txtEmpID != null && txtDepartment != null)
                        {
                            person = new LabManager(firstName, lastName, txtEmpID.Text,
                                txtDepartment.Text, street, city, telephone);
                        }
                        break;

                    case "Faculty":
                        if (txtEmpID != null && txtDepartment != null && txtRank != null)
                        {
                            person = new Faculty(firstName, lastName, txtEmpID.Text,
                                txtDepartment.Text, txtRank.Text, street, city, telephone);
                        }
                        break;

                    case "Part-Time Faculty":
                        if (txtSSN != null && txtDepartment != null)
                        {
                            person = new PartTimeFaculty(firstName, lastName, txtSSN.Text,
                                txtDepartment.Text, street, city, telephone);
                        }
                        break;

                    case "Secretary":
                        if (txtEmpID != null && txtDepartment != null)
                        {
                            person = new Secretary(firstName, lastName, txtEmpID.Text,
                                txtDepartment.Text, street, city, telephone);
                        }
                        break;
                }

                if (person != null)
                {
                    universityMembers.Add(person);
                    UpdateOutput();
                    ClearFields();
                    MessageBox.Show("Person added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding person: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void BtnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void ClearFields()
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtStreet.Clear();
            txtCity.Clear();
            txtTelephone.Clear();

            foreach (Control ctrl in pnlSpecificFields.Controls)
            {
                if (ctrl is TextBox textBox)
                    textBox.Clear();
            }
        }

        private void UpdateOutput()
        {
            txtOutput.Clear();
            txtOutput.AppendText($"Total University Members: {universityMembers.Count}\r\n");
            txtOutput.AppendText(new string('=', 80) + "\r\n\r\n");

            foreach (Person person in universityMembers)
            {
                txtOutput.AppendText(person.ToString());
                txtOutput.AppendText("\r\n" + new string('-', 80) + "\r\n\r\n");
            }
        }

        private void AddLabel(Panel panel, string text, int x, int y)
        {
            Label lbl = new Label
            {
                Text = text,
                Location = new Point(x, y),
                Size = new Size(100, 20)
            };
            panel.Controls.Add(lbl);
        }

        private TextBox AddTextBox(Panel panel, int x, int y)
        {
            TextBox txt = new TextBox
            {
                Location = new Point(x, y),
                Size = new Size(260, 20)
            };
            panel.Controls.Add(txt);
            return txt;
        }
    }
}