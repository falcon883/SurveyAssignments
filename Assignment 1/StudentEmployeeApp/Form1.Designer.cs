namespace StudentApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnComputeGrade = new System.Windows.Forms.Button();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnComputePay = new System.Windows.Forms.Button();
            this.txtPayRate = new System.Windows.Forms.TextBox();
            this.txtHoursWorked = new System.Windows.Forms.TextBox();
            this.txtEmpID = new System.Windows.Forms.TextBox();
            this.txtEmpLastName = new System.Windows.Forms.TextBox();
            this.txtEmpFirstName = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnComputeGrade);
            this.groupBox1.Controls.Add(this.txtTest2);
            this.groupBox1.Controls.Add(this.txtTest1);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.txtLastName);
            this.groupBox1.Controls.Add(this.txtFirstName);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(40, 25);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(467, 345);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Information";
            // 
            // btnComputeGrade
            // 
            this.btnComputeGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnComputeGrade.Location = new System.Drawing.Point(160, 283);
            this.btnComputeGrade.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComputeGrade.Name = "btnComputeGrade";
            this.btnComputeGrade.Size = new System.Drawing.Size(160, 43);
            this.btnComputeGrade.TabIndex = 10;
            this.btnComputeGrade.Text = "Compute Grade";
            this.btnComputeGrade.UseVisualStyleBackColor = false;
            this.btnComputeGrade.Click += new System.EventHandler(this.btnComputeGrade_Click);
            // 
            // txtTest2
            // 
            this.txtTest2.Location = new System.Drawing.Point(200, 234);
            this.txtTest2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTest2.Name = "txtTest2";
            this.txtTest2.Size = new System.Drawing.Size(159, 22);
            this.txtTest2.TabIndex = 4;
            // 
            // txtTest1
            // 
            this.txtTest1.Location = new System.Drawing.Point(200, 185);
            this.txtTest1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTest1.Name = "txtTest1";
            this.txtTest1.Size = new System.Drawing.Size(159, 22);
            this.txtTest1.TabIndex = 3;
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(200, 135);
            this.txtID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(159, 22);
            this.txtID.TabIndex = 2;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(200, 86);
            this.txtLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(159, 22);
            this.txtLastName.TabIndex = 1;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(200, 37);
            this.txtFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(159, 22);
            this.txtFirstName.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 238);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Test 2 Score:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 188);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Test 1 Score:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 139);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Last Name:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "First Name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnComputePay);
            this.groupBox2.Controls.Add(this.txtPayRate);
            this.groupBox2.Controls.Add(this.txtHoursWorked);
            this.groupBox2.Controls.Add(this.txtEmpID);
            this.groupBox2.Controls.Add(this.txtEmpLastName);
            this.groupBox2.Controls.Add(this.txtEmpFirstName);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(560, 25);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(467, 345);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Employee Information";
            // 
            // btnComputePay
            // 
            this.btnComputePay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnComputePay.ForeColor = System.Drawing.Color.White;
            this.btnComputePay.Location = new System.Drawing.Point(160, 283);
            this.btnComputePay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnComputePay.Name = "btnComputePay";
            this.btnComputePay.Size = new System.Drawing.Size(160, 43);
            this.btnComputePay.TabIndex = 10;
            this.btnComputePay.Text = "Compute Pay";
            this.btnComputePay.UseVisualStyleBackColor = false;
            this.btnComputePay.Click += new System.EventHandler(this.btnComputePay_Click);
            // 
            // txtPayRate
            // 
            this.txtPayRate.Location = new System.Drawing.Point(200, 234);
            this.txtPayRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPayRate.Name = "txtPayRate";
            this.txtPayRate.Size = new System.Drawing.Size(159, 22);
            this.txtPayRate.TabIndex = 9;
            // 
            // txtHoursWorked
            // 
            this.txtHoursWorked.Location = new System.Drawing.Point(200, 185);
            this.txtHoursWorked.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtHoursWorked.Name = "txtHoursWorked";
            this.txtHoursWorked.Size = new System.Drawing.Size(159, 22);
            this.txtHoursWorked.TabIndex = 8;
            // 
            // txtEmpID
            // 
            this.txtEmpID.Location = new System.Drawing.Point(200, 135);
            this.txtEmpID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpID.Name = "txtEmpID";
            this.txtEmpID.Size = new System.Drawing.Size(159, 22);
            this.txtEmpID.TabIndex = 7;
            // 
            // txtEmpLastName
            // 
            this.txtEmpLastName.Location = new System.Drawing.Point(200, 86);
            this.txtEmpLastName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpLastName.Name = "txtEmpLastName";
            this.txtEmpLastName.Size = new System.Drawing.Size(159, 22);
            this.txtEmpLastName.TabIndex = 6;
            // 
            // txtEmpFirstName
            // 
            this.txtEmpFirstName.Location = new System.Drawing.Point(200, 37);
            this.txtEmpFirstName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmpFirstName.Name = "txtEmpFirstName";
            this.txtEmpFirstName.Size = new System.Drawing.Size(159, 22);
            this.txtEmpFirstName.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(40, 238);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 16);
            this.label10.TabIndex = 4;
            this.label10.Text = "Pay Rate ($/hr):";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 188);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 16);
            this.label9.TabIndex = 3;
            this.label9.Text = "Hours Worked:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(40, 139);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 16);
            this.label8.TabIndex = 2;
            this.label8.Text = "Employee ID:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 90);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Last Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "First Name:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 406);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Student & Employee Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnComputeGrade;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnComputePay;
        private System.Windows.Forms.TextBox txtPayRate;
        private System.Windows.Forms.TextBox txtHoursWorked;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtEmpLastName;
        private System.Windows.Forms.TextBox txtEmpFirstName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}