using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Project3.Enumerations;

namespace Project3
{
    public partial class Form1 : Form
    {
        private List<Student> students;
        private string currentGradesFile;

        public Form1()
        {
            InitializeComponent();
            students = new List<Student>();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    students.Clear();
                    string[] lines = File.ReadAllLines(openFileDialog1.FileName);

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] fields = line.Split(',');
                        if (fields.Length >= 7)
                        {
                            Student student = new Student
                            {
                                ID = fields[0].Trim(),
                                FirstName = fields[1].Trim(),
                                LastName = fields[2].Trim(),
                                Test1 = double.Parse(fields[3].Trim()),
                                Test2 = double.Parse(fields[4].Trim()),
                                Major = (Major)Enum.Parse(typeof(Major), fields[5].Trim()),
                                Type = (StudentType)Enum.Parse(typeof(StudentType), fields[6].Trim())
                            };
                            students.Add(student);
                        }
                    }

                    DisplayStudents();
                    MessageBox.Show($"Successfully loaded {students.Count} students.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading file: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        // NEW METHOD: Save student data to file
        private void saveStudentDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No student data available to save.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            saveFileDialog.Title = "Save Student Data File";
            saveFileDialog.FileName = "students.txt";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (Student student in students)
                        {
                            writer.WriteLine($"{student.ID},{student.FirstName},{student.LastName}," +
                                           $"{student.Test1},{student.Test2},{student.Major},{student.Type}");
                        }
                    }

                    MessageBox.Show($"Student data successfully saved to {saveFileDialog.FileName}\n" +
                                  $"Total students saved: {students.Count}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving student data: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void processGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (students.Count == 0)
            {
                MessageBox.Show("No student data available. Please load student data first.",
                    "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveFileDialog1.FileName))
                    {
                        foreach (Student student in students)
                        {
                            // FIXED: Save numeric grade instead of letter grade
                            double grade = student.CalculateGrade();
                            writer.WriteLine($"{student.ID},{student.LastName},{student.Major},{grade:F2}");
                        }
                    }

                    currentGradesFile = saveFileDialog1.FileName;
                    MessageBox.Show($"Grades processed and saved to {saveFileDialog1.FileName}",
                        "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error saving grades: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormAddStudent addForm = new FormAddStudent(students);
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                students.Add(addForm.NewStudent);
                DisplayStudents();
                MessageBox.Show("Student added successfully.", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void displayGradesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // FIXED: Use OpenFileDialog to allow user to select grades file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            openFileDialog.Title = "Select Grades File";

            // Pre-select current grades file if available
            if (!string.IsNullOrEmpty(currentGradesFile) && File.Exists(currentGradesFile))
            {
                openFileDialog.FileName = currentGradesFile;
            }

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    var gradeData = new List<GradeDisplay>();
                    string[] lines = File.ReadAllLines(openFileDialog.FileName);

                    foreach (string line in lines)
                    {
                        if (string.IsNullOrWhiteSpace(line))
                            continue;

                        string[] fields = line.Split(',');
                        if (fields.Length >= 4)
                        {
                            gradeData.Add(new GradeDisplay
                            {
                                ID = fields[0].Trim(),
                                LastName = fields[1].Trim(),
                                Major = fields[2].Trim(),
                                Grade = fields[3].Trim()
                            });
                        }
                    }

                    dataGridView1.DataSource = null;
                    dataGridView1.DataSource = gradeData;
                    MessageBox.Show($"Displaying {gradeData.Count} student grades.", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error reading grades file: {ex.Message}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayStudents()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = students;
        }
    }

    // Helper class for displaying grades
    public class GradeDisplay
    {
        public string ID { get; set; }
        public string LastName { get; set; }
        public string Major { get; set; }
        public string Grade { get; set; }
    }
}