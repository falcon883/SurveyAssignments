using System.Collections;

namespace StudentFileProcessing
{
    public partial class Form1 : Form
    {
        private ArrayList studentsList;

        public Form1()
        {
            InitializeComponent();
            studentsList = new ArrayList();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog
            {
                Filter = "Text Files (*.txt)|*.txt|CSV Files (*.csv)|*.csv|All Files (*.*)|*.*",
                Title = "Select Student Data File"
            };

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    studentsList.Clear();
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] parts = line.Split(',');
                        if (parts.Length == 5)
                        {
                            Student student = new Student
                            {
                                Id = int.Parse(parts[0].Trim()),
                                FirstName = parts[1].Trim(),
                                LastName = parts[2].Trim(),
                                Email = parts[3].Trim(),
                                GPA = double.Parse(parts[4].Trim())
                            };
                            studentsList.Add(student);
                        }
                    }

                    RefreshDataGridView();
                    MessageBox.Show($"Successfully loaded {studentsList.Count} students!",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error loading file: {ex.Message}",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            AddStudentForm addForm = new AddStudentForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                studentsList.Add(addForm.NewStudent);
                RefreshDataGridView();
                MessageBox.Show("Student added successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void RefreshDataGridView()
        {
            dgvStudents.Rows.Clear();
            foreach (Student student in studentsList)
            {
                dgvStudents.Rows.Add(student.Id, student.FirstName,
                    student.LastName, student.Email, student.GPA);
            }
        }
    }
}
