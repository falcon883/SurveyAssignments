namespace ClarkUniversityApp
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblPersonType = new System.Windows.Forms.Label();
            this.cmbPersonType = new System.Windows.Forms.ComboBox();
            this.pnlCommonFields = new System.Windows.Forms.Panel();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblStreet = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.pnlSpecificFields = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblOutput = new System.Windows.Forms.Label();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.pnlCommonFields.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblTitle.Location = new System.Drawing.Point(20, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(368, 26);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Clark University Application";
            // 
            // lblPersonType
            // 
            this.lblPersonType.AutoSize = true;
            this.lblPersonType.Location = new System.Drawing.Point(20, 70);
            this.lblPersonType.Name = "lblPersonType";
            this.lblPersonType.Size = new System.Drawing.Size(111, 13);
            this.lblPersonType.TabIndex = 1;
            this.lblPersonType.Text = "Select Person Type:";
            // 
            // cmbPersonType
            // 
            this.cmbPersonType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPersonType.FormattingEnabled = true;
            this.cmbPersonType.Items.AddRange(new object[] {
            "Part-Time Student",
            "Undergraduate Student",
            "Graduate Student",
            "PhD Student",
            "Lab Manager",
            "Faculty",
            "Part-Time Faculty",
            "Secretary"});
            this.cmbPersonType.Location = new System.Drawing.Point(180, 67);
            this.cmbPersonType.Name = "cmbPersonType";
            this.cmbPersonType.Size = new System.Drawing.Size(200, 21);
            this.cmbPersonType.TabIndex = 2;
            this.cmbPersonType.SelectedIndexChanged += new System.EventHandler(this.CmbPersonType_SelectedIndexChanged);
            // 
            // pnlCommonFields
            // 
            this.pnlCommonFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlCommonFields.Controls.Add(this.txtTelephone);
            this.pnlCommonFields.Controls.Add(this.txtCity);
            this.pnlCommonFields.Controls.Add(this.txtStreet);
            this.pnlCommonFields.Controls.Add(this.txtLastName);
            this.pnlCommonFields.Controls.Add(this.txtFirstName);
            this.pnlCommonFields.Controls.Add(this.lblTelephone);
            this.pnlCommonFields.Controls.Add(this.lblCity);
            this.pnlCommonFields.Controls.Add(this.lblStreet);
            this.pnlCommonFields.Controls.Add(this.lblLastName);
            this.pnlCommonFields.Controls.Add(this.lblFirstName);
            this.pnlCommonFields.Location = new System.Drawing.Point(20, 110);
            this.pnlCommonFields.Name = "pnlCommonFields";
            this.pnlCommonFields.Size = new System.Drawing.Size(420, 200);
            this.pnlCommonFields.TabIndex = 3;
            // 
            // txtTelephone
            // 
            this.txtTelephone.Location = new System.Drawing.Point(120, 150);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(280, 20);
            this.txtTelephone.TabIndex = 9;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(120, 115);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(280, 20);
            this.txtCity.TabIndex = 8;
            // 
            // txtStreet
            // 
            this.txtStreet.Location = new System.Drawing.Point(120, 80);
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.Size = new System.Drawing.Size(280, 20);
            this.txtStreet.TabIndex = 7;
            // 
            // txtLastName
            // 
            this.txtLastName.Location = new System.Drawing.Point(120, 45);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(280, 20);
            this.txtLastName.TabIndex = 6;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Location = new System.Drawing.Point(120, 10);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(280, 20);
            this.txtFirstName.TabIndex = 5;
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(10, 153);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(61, 13);
            this.lblTelephone.TabIndex = 4;
            this.lblTelephone.Text = "Telephone:";
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(10, 118);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(27, 13);
            this.lblCity.TabIndex = 3;
            this.lblCity.Text = "City:";
            // 
            // lblStreet
            // 
            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(10, 83);
            this.lblStreet.Name = "lblStreet";
            this.lblStreet.Size = new System.Drawing.Size(38, 13);
            this.lblStreet.TabIndex = 2;
            this.lblStreet.Text = "Street:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(10, 48);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(61, 13);
            this.lblLastName.TabIndex = 1;
            this.lblLastName.Text = "Last Name:";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(10, 13);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(60, 13);
            this.lblFirstName.TabIndex = 0;
            this.lblFirstName.Text = "First Name:";
            // 
            // pnlSpecificFields
            // 
            this.pnlSpecificFields.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlSpecificFields.Location = new System.Drawing.Point(460, 110);
            this.pnlSpecificFields.Name = "pnlSpecificFields";
            this.pnlSpecificFields.Size = new System.Drawing.Size(400, 200);
            this.pnlSpecificFields.TabIndex = 4;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.LightGreen;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(20, 330);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 35);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add Person";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.LightCoral;
            this.btnClear.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.btnClear.Location = new System.Drawing.Point(160, 330);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 35);
            this.btnClear.TabIndex = 6;
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblOutput.Location = new System.Drawing.Point(20, 380);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(152, 16);
            this.lblOutput.TabIndex = 7;
            this.lblOutput.Text = "University Members:";
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 9F);
            this.txtOutput.Location = new System.Drawing.Point(20, 410);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(840, 230);
            this.txtOutput.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.pnlSpecificFields);
            this.Controls.Add(this.pnlCommonFields);
            this.Controls.Add(this.cmbPersonType);
            this.Controls.Add(this.lblPersonType);
            this.Controls.Add(this.lblTitle);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clark University Management System";
            this.pnlCommonFields.ResumeLayout(false);
            this.pnlCommonFields.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblPersonType;
        private System.Windows.Forms.ComboBox cmbPersonType;
        private System.Windows.Forms.Panel pnlCommonFields;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Panel pnlSpecificFields;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.TextBox txtOutput;

        // Dynamic fields created at runtime
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtEmpID;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.TextBox txtThesis;
        private System.Windows.Forms.TextBox txtAdvisor;
        private System.Windows.Forms.TextBox txtDissertation;
        private System.Windows.Forms.TextBox txtDepartment;
        private System.Windows.Forms.TextBox txtRank;
    }
}