using System;
using System.Drawing;
using System.Windows.Forms;

namespace Project3
{
    partial class FormAddStudent
    {
        // FormAddStudent.Designer.cs (partial class)
            private System.ComponentModel.IContainer components = null;
            private TextBox txtID;
            private TextBox txtFirstName;
            private TextBox txtLastName;
            private TextBox txtTest1;
            private TextBox txtTest2;
            private ComboBox cmbMajor;
            private RadioButton rbUG;
            private RadioButton rbGRAD;
            private Button btnAdd;
            private Button btnCancel;
            private Label label1;
            private Label label2;
            private Label label3;
            private Label label4;
            private Label label5;
            private Label label6;
            private GroupBox groupBox1;

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
                this.txtID = new TextBox();
                this.txtFirstName = new TextBox();
                this.txtLastName = new TextBox();
                this.txtTest1 = new TextBox();
                this.txtTest2 = new TextBox();
                this.cmbMajor = new ComboBox();
                this.rbUG = new RadioButton();
                this.rbGRAD = new RadioButton();
                this.btnAdd = new Button();
                this.btnCancel = new Button();
                this.label1 = new Label();
                this.label2 = new Label();
                this.label3 = new Label();
                this.label4 = new Label();
                this.label5 = new Label();
                this.label6 = new Label();
                this.groupBox1 = new GroupBox();
                this.groupBox1.SuspendLayout();
                this.SuspendLayout();

                // txtID
                this.txtID.Location = new Point(100, 20);
                this.txtID.Name = "txtID";
                this.txtID.Size = new Size(150, 23);
                this.txtID.TabIndex = 0;

                // txtFirstName
                this.txtFirstName.Location = new Point(100, 50);
                this.txtFirstName.Name = "txtFirstName";
                this.txtFirstName.Size = new Size(150, 23);
                this.txtFirstName.TabIndex = 1;

                // txtLastName
                this.txtLastName.Location = new Point(100, 80);
                this.txtLastName.Name = "txtLastName";
                this.txtLastName.Size = new Size(150, 23);
                this.txtLastName.TabIndex = 2;

                // txtTest1
                this.txtTest1.Location = new Point(100, 110);
                this.txtTest1.Name = "txtTest1";
                this.txtTest1.Size = new Size(150, 23);
                this.txtTest1.TabIndex = 3;

                // txtTest2
                this.txtTest2.Location = new Point(100, 140);
                this.txtTest2.Name = "txtTest2";
                this.txtTest2.Size = new Size(150, 23);
                this.txtTest2.TabIndex = 4;

                // cmbMajor
                this.cmbMajor.DropDownStyle = ComboBoxStyle.DropDownList;
                this.cmbMajor.FormattingEnabled = true;
                this.cmbMajor.Location = new Point(100, 170);
                this.cmbMajor.Name = "cmbMajor";
                this.cmbMajor.Size = new Size(150, 23);
                this.cmbMajor.TabIndex = 5;

                // rbUG
                this.rbUG.AutoSize = true;
                this.rbUG.Checked = true;
                this.rbUG.Location = new Point(6, 22);
                this.rbUG.Name = "rbUG";
                this.rbUG.Size = new Size(41, 19);
                this.rbUG.TabIndex = 0;
                this.rbUG.TabStop = true;
                this.rbUG.Text = "UG";
                this.rbUG.UseVisualStyleBackColor = true;

                // rbGRAD
                this.rbGRAD.AutoSize = true;
                this.rbGRAD.Location = new Point(70, 22);
                this.rbGRAD.Name = "rbGRAD";
                this.rbGRAD.Size = new Size(56, 19);
                this.rbGRAD.TabIndex = 1;
                this.rbGRAD.Text = "GRAD";
                this.rbGRAD.UseVisualStyleBackColor = true;

                // groupBox1
                this.groupBox1.Controls.Add(this.rbGRAD);
                this.groupBox1.Controls.Add(this.rbUG);
                this.groupBox1.Location = new Point(100, 200);
                this.groupBox1.Name = "groupBox1";
                this.groupBox1.Size = new Size(150, 50);
                this.groupBox1.TabIndex = 6;
                this.groupBox1.TabStop = false;
                this.groupBox1.Text = "Student Type";

                // btnAdd
                this.btnAdd.Location = new Point(70, 270);
                this.btnAdd.Name = "btnAdd";
                this.btnAdd.Size = new Size(75, 23);
                this.btnAdd.TabIndex = 7;
                this.btnAdd.Text = "Add Student";
                this.btnAdd.UseVisualStyleBackColor = true;
                this.btnAdd.Click += new EventHandler(this.btnAdd_Click);

                // btnCancel
                this.btnCancel.Location = new Point(160, 270);
                this.btnCancel.Name = "btnCancel";
                this.btnCancel.Size = new Size(75, 23);
                this.btnCancel.TabIndex = 8;
                this.btnCancel.Text = "Cancel";
                this.btnCancel.UseVisualStyleBackColor = true;
                this.btnCancel.Click += new EventHandler(this.btnCancel_Click);

                // Labels
                this.label1.AutoSize = true;
                this.label1.Location = new Point(20, 23);
                this.label1.Name = "label1";
                this.label1.Size = new Size(18, 15);
                this.label1.TabIndex = 9;
                this.label1.Text = "ID";

                this.label2.AutoSize = true;
                this.label2.Location = new Point(20, 53);
                this.label2.Name = "label2";
                this.label2.Size = new Size(64, 15);
                this.label2.TabIndex = 10;
                this.label2.Text = "First Name";

                this.label3.AutoSize = true;
                this.label3.Location = new Point(20, 83);
                this.label3.Name = "label3";
                this.label3.Size = new Size(63, 15);
                this.label3.TabIndex = 11;
                this.label3.Text = "Last Name";

                this.label4.AutoSize = true;
                this.label4.Location = new Point(20, 113);
                this.label4.Name = "label4";
                this.label4.Size = new Size(37, 15);
                this.label4.TabIndex = 12;
                this.label4.Text = "Test 1";

                this.label5.AutoSize = true;
                this.label5.Location = new Point(20, 143);
                this.label5.Name = "label5";
                this.label5.Size = new Size(37, 15);
                this.label5.TabIndex = 13;
                this.label5.Text = "Test 2";

                this.label6.AutoSize = true;
                this.label6.Location = new Point(20, 173);
                this.label6.Name = "label6";
                this.label6.Size = new Size(38, 15);
                this.label6.TabIndex = 14;
                this.label6.Text = "Major";

                // FormAddStudent
                this.AutoScaleDimensions = new SizeF(7F, 15F);
                this.AutoScaleMode = AutoScaleMode.Font;
                this.ClientSize = new Size(284, 311);
                this.Controls.AddRange(new Control[] {
            this.label6, this.label5, this.label4, this.label3, this.label2, this.label1,
            this.btnCancel, this.btnAdd, this.groupBox1, this.cmbMajor, this.txtTest2,
            this.txtTest1, this.txtLastName, this.txtFirstName, this.txtID
        });
                this.Name = "FormAddStudent";
                this.Text = "Add New Student";
                this.Load += new EventHandler(this.FormAddStudent_Load);
                this.groupBox1.ResumeLayout(false);
                this.groupBox1.PerformLayout();
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }
    }