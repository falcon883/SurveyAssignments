using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project3
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem saveStudentDataToolStripMenuItem;  // NEW
        private ToolStripMenuItem processGradesToolStripMenuItem;
        private ToolStripMenuItem addStudentToolStripMenuItem;
        private ToolStripMenuItem displayGradesToolStripMenuItem;
        private DataGridView dataGridView1;
        private OpenFileDialog openFileDialog1;
        private SaveFileDialog saveFileDialog1;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new MenuStrip();
            this.fileToolStripMenuItem = new ToolStripMenuItem();
            this.openToolStripMenuItem = new ToolStripMenuItem();
            this.saveStudentDataToolStripMenuItem = new ToolStripMenuItem();  // NEW
            this.processGradesToolStripMenuItem = new ToolStripMenuItem();
            this.addStudentToolStripMenuItem = new ToolStripMenuItem();
            this.displayGradesToolStripMenuItem = new ToolStripMenuItem();
            this.dataGridView1 = new DataGridView();
            this.openFileDialog1 = new OpenFileDialog();
            this.saveFileDialog1 = new SaveFileDialog();

            // menuStrip1
            this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.fileToolStripMenuItem });

            // fileToolStripMenuItem
            this.fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
                this.openToolStripMenuItem,
                this.saveStudentDataToolStripMenuItem,  // NEW - Added to menu
                this.processGradesToolStripMenuItem,
                this.addStudentToolStripMenuItem,
                this.displayGradesToolStripMenuItem
            });
            this.fileToolStripMenuItem.Text = "File";

            // openToolStripMenuItem
            this.openToolStripMenuItem.Text = "Open Student Data";
            this.openToolStripMenuItem.Click += new EventHandler(this.openToolStripMenuItem_Click);

            // saveStudentDataToolStripMenuItem - NEW
            this.saveStudentDataToolStripMenuItem.Text = "Save Student Data";
            this.saveStudentDataToolStripMenuItem.Click += new EventHandler(this.saveStudentDataToolStripMenuItem_Click);

            // processGradesToolStripMenuItem
            this.processGradesToolStripMenuItem.Text = "Process Grades";
            this.processGradesToolStripMenuItem.Click += new EventHandler(this.processGradesToolStripMenuItem_Click);

            // addStudentToolStripMenuItem
            this.addStudentToolStripMenuItem.Text = "Add Student";
            this.addStudentToolStripMenuItem.Click += new EventHandler(this.addStudentToolStripMenuItem_Click);

            // displayGradesToolStripMenuItem
            this.displayGradesToolStripMenuItem.Text = "Display Grades";
            this.displayGradesToolStripMenuItem.Click += new EventHandler(this.displayGradesToolStripMenuItem_Click);

            // dataGridView1
            this.dataGridView1.Dock = DockStyle.Fill;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;

            // openFileDialog1
            this.openFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // saveFileDialog1
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";

            // MainForm
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.ClientSize = new Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Grade-Student Application";
        }
    }
}