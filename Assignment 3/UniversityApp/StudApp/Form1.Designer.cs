namespace StudApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.GroupBox gbStudentType;
        private System.Windows.Forms.RadioButton rbPartTime;
        private System.Windows.Forms.RadioButton rbUnderGrad;
        private System.Windows.Forms.RadioButton rbGrad;
        private System.Windows.Forms.RadioButton rbPhD;
        private System.Windows.Forms.GroupBox gbBasicInfo;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.Label lblSSN;
        private System.Windows.Forms.TextBox txtSSN;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.GroupBox gbTestScores;
        private System.Windows.Forms.Label lblTest1;
        private System.Windows.Forms.TextBox txtTest1;
        private System.Windows.Forms.Label lblTest2;
        private System.Windows.Forms.TextBox txtTest2;
        private System.Windows.Forms.GroupBox gbAddress;
        private System.Windows.Forms.Label lblStreet;
        private System.Windows.Forms.TextBox txtStreet;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.GroupBox gbSpecialFields;
        private System.Windows.Forms.Label lblThesis;
        private System.Windows.Forms.TextBox txtThesis;
        private System.Windows.Forms.Label lblAdvisor;
        private System.Windows.Forms.TextBox txtAdvisor;
        private System.Windows.Forms.Label lblDissertation;
        private System.Windows.Forms.TextBox txtDissertation;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.ListBox lstStudents;
        private System.Windows.Forms.Label lblGrade;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblTotalStudents;

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
            // Initialize all controls first
            this.gbStudentType = new System.Windows.Forms.GroupBox();
            this.rbPartTime = new System.Windows.Forms.RadioButton();
            this.rbUnderGrad = new System.Windows.Forms.RadioButton();
            this.rbGrad = new System.Windows.Forms.RadioButton();
            this.rbPhD = new System.Windows.Forms.RadioButton();
            this.gbBasicInfo = new System.Windows.Forms.GroupBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblLastName = new System.Windows.Forms.Label();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.lblSSN = new System.Windows.Forms.Label();
            this.txtSSN = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.gbTestScores = new System.Windows.Forms.GroupBox();
            this.lblTest1 = new System.Windows.Forms.Label();
            this.txtTest1 = new System.Windows.Forms.TextBox();
            this.lblTest2 = new System.Windows.Forms.Label();
            this.txtTest2 = new System.Windows.Forms.TextBox();
            this.lblGrade = new System.Windows.Forms.Label();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.gbAddress = new System.Windows.Forms.GroupBox();
            this.lblStreet = new System.Windows.Forms.Label();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.gbSpecialFields = new System.Windows.Forms.GroupBox();
            this.lblThesis = new System.Windows.Forms.Label();
            this.txtThesis = new System.Windows.Forms.TextBox();
            this.lblAdvisor = new System.Windows.Forms.Label();
            this.txtAdvisor = new System.Windows.Forms.TextBox();
            this.lblDissertation = new System.Windows.Forms.Label();
            this.txtDissertation = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.lstStudents = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblTotalStudents = new System.Windows.Forms.Label();

            this.gbStudentType.SuspendLayout();
            this.gbBasicInfo.SuspendLayout();
            this.gbTestScores.SuspendLayout();
            this.gbAddress.SuspendLayout();
            this.gbSpecialFields.SuspendLayout();
            this.SuspendLayout();

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 750);
            this.Text = "Clark University Student Management System";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;

            // gbStudentType
            this.gbStudentType.Controls.Add(this.rbPartTime);
            this.gbStudentType.Controls.Add(this.rbUnderGrad);
            this.gbStudentType.Controls.Add(this.rbGrad);
            this.gbStudentType.Controls.Add(this.rbPhD);
            this.gbStudentType.Location = new System.Drawing.Point(12, 12);
            this.gbStudentType.Size = new System.Drawing.Size(200, 120);
            this.gbStudentType.Text = "Student Type";

            // Radio buttons for student type
            this.rbPartTime.AutoSize = true;
            this.rbPartTime.Location = new System.Drawing.Point(15, 25);
            this.rbPartTime.Size = new System.Drawing.Size(95, 21);
            this.rbPartTime.Text = "Part-Time";
            this.rbPartTime.UseVisualStyleBackColor = true;
            this.rbPartTime.CheckedChanged += new System.EventHandler(this.StudentType_CheckedChanged);

            this.rbUnderGrad.AutoSize = true;
            this.rbUnderGrad.Location = new System.Drawing.Point(15, 45);
            this.rbUnderGrad.Size = new System.Drawing.Size(115, 21);
            this.rbUnderGrad.Text = "Undergraduate";
            this.rbUnderGrad.UseVisualStyleBackColor = true;
            this.rbUnderGrad.Checked = true;
            this.rbUnderGrad.CheckedChanged += new System.EventHandler(this.StudentType_CheckedChanged);

            this.rbGrad.AutoSize = true;
            this.rbGrad.Location = new System.Drawing.Point(15, 65);
            this.rbGrad.Size = new System.Drawing.Size(80, 21);
            this.rbGrad.Text = "Graduate";
            this.rbGrad.UseVisualStyleBackColor = true;
            this.rbGrad.CheckedChanged += new System.EventHandler(this.StudentType_CheckedChanged);

            this.rbPhD.AutoSize = true;
            this.rbPhD.Location = new System.Drawing.Point(15, 85);
            this.rbPhD.Size = new System.Drawing.Size(56, 21);
            this.rbPhD.Text = "PhD";
            this.rbPhD.UseVisualStyleBackColor = true;
            this.rbPhD.CheckedChanged += new System.EventHandler(this.StudentType_CheckedChanged);

            // gbBasicInfo
            this.gbBasicInfo.Controls.Add(this.lblFirstName);
            this.gbBasicInfo.Controls.Add(this.txtFirstName);
            this.gbBasicInfo.Controls.Add(this.lblLastName);
            this.gbBasicInfo.Controls.Add(this.txtLastName);
            this.gbBasicInfo.Controls.Add(this.lblSSN);
            this.gbBasicInfo.Controls.Add(this.txtSSN);
            this.gbBasicInfo.Controls.Add(this.lblID);
            this.gbBasicInfo.Controls.Add(this.txtID);
            this.gbBasicInfo.Location = new System.Drawing.Point(230, 12);
            this.gbBasicInfo.Size = new System.Drawing.Size(300, 140);
            this.gbBasicInfo.Text = "Basic Information";

            // Basic Info Controls
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 25);
            this.lblFirstName.Text = "First Name:";
            this.txtFirstName.Location = new System.Drawing.Point(100, 22);
            this.txtFirstName.Size = new System.Drawing.Size(180, 22);

            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 55);
            this.lblLastName.Text = "Last Name:";
            this.txtLastName.Location = new System.Drawing.Point(100, 52);
            this.txtLastName.Size = new System.Drawing.Size(180, 22);

            this.lblSSN.AutoSize = true;
            this.lblSSN.Location = new System.Drawing.Point(15, 85);
            this.lblSSN.Text = "SSN:";
            this.txtSSN.Location = new System.Drawing.Point(100, 82);
            this.txtSSN.Size = new System.Drawing.Size(180, 22);
            this.txtSSN.Visible = false;
            this.lblSSN.Visible = false;

            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(15, 115);
            this.lblID.Text = "Student ID:";
            this.txtID.Location = new System.Drawing.Point(100, 112);
            this.txtID.Size = new System.Drawing.Size(180, 22);

            // gbTestScores
            this.gbTestScores.Controls.Add(this.lblTest1);
            this.gbTestScores.Controls.Add(this.txtTest1);
            this.gbTestScores.Controls.Add(this.lblTest2);
            this.gbTestScores.Controls.Add(this.txtTest2);
            this.gbTestScores.Controls.Add(this.lblGrade);
            this.gbTestScores.Controls.Add(this.txtGrade);
            this.gbTestScores.Location = new System.Drawing.Point(550, 12);
            this.gbTestScores.Size = new System.Drawing.Size(250, 140);
            this.gbTestScores.Text = "Test Scores";

            this.lblTest1.AutoSize = true;
            this.lblTest1.Location = new System.Drawing.Point(15, 25);
            this.lblTest1.Text = "Test 1:";
            this.txtTest1.Location = new System.Drawing.Point(80, 22);
            this.txtTest1.Size = new System.Drawing.Size(150, 22);

            this.lblTest2.AutoSize = true;
            this.lblTest2.Location = new System.Drawing.Point(15, 55);
            this.lblTest2.Text = "Test 2:";
            this.txtTest2.Location = new System.Drawing.Point(80, 52);
            this.txtTest2.Size = new System.Drawing.Size(150, 22);

            this.lblGrade.AutoSize = true;
            this.lblGrade.Location = new System.Drawing.Point(15, 85);
            this.lblGrade.Text = "Grade:";
            this.txtGrade.Location = new System.Drawing.Point(80, 82);
            this.txtGrade.Size = new System.Drawing.Size(150, 22);
            this.txtGrade.ReadOnly = true;
            this.txtGrade.BackColor = System.Drawing.Color.LightGray;

            // gbAddress
            this.gbAddress.Controls.Add(this.lblStreet);
            this.gbAddress.Controls.Add(this.txtStreet);
            this.gbAddress.Controls.Add(this.lblCity);
            this.gbAddress.Controls.Add(this.txtCity);
            this.gbAddress.Controls.Add(this.lblTelephone);
            this.gbAddress.Controls.Add(this.txtTelephone);
            this.gbAddress.Location = new System.Drawing.Point(12, 170);
            this.gbAddress.Size = new System.Drawing.Size(400, 120);
            this.gbAddress.Text = "Address Information";

            this.lblStreet.AutoSize = true;
            this.lblStreet.Location = new System.Drawing.Point(15, 25);
            this.lblStreet.Text = "Street:";
            this.txtStreet.Location = new System.Drawing.Point(100, 22);
            this.txtStreet.Size = new System.Drawing.Size(280, 22);

            this.lblCity.AutoSize = true;
            this.lblCity.Location = new System.Drawing.Point(15, 55);
            this.lblCity.Text = "City:";
            this.txtCity.Location = new System.Drawing.Point(100, 52);
            this.txtCity.Size = new System.Drawing.Size(280, 22);

            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(15, 85);
            this.lblTelephone.Text = "Telephone:";
            this.txtTelephone.Location = new System.Drawing.Point(100, 82);
            this.txtTelephone.Size = new System.Drawing.Size(280, 22);

            // gbSpecialFields
            this.gbSpecialFields.Controls.Add(this.lblThesis);
            this.gbSpecialFields.Controls.Add(this.txtThesis);
            this.gbSpecialFields.Controls.Add(this.lblAdvisor);
            this.gbSpecialFields.Controls.Add(this.txtAdvisor);
            this.gbSpecialFields.Controls.Add(this.lblDissertation);
            this.gbSpecialFields.Controls.Add(this.txtDissertation);
            this.gbSpecialFields.Location = new System.Drawing.Point(430, 170);
            this.gbSpecialFields.Size = new System.Drawing.Size(370, 120);
            this.gbSpecialFields.Text = "Special Fields";

            this.lblThesis.AutoSize = true;
            this.lblThesis.Location = new System.Drawing.Point(15, 25);
            this.lblThesis.Text = "Thesis:";
            this.txtThesis.Location = new System.Drawing.Point(100, 22);
            this.txtThesis.Size = new System.Drawing.Size(250, 22);
            this.txtThesis.Visible = false;
            this.lblThesis.Visible = false;

            this.lblAdvisor.AutoSize = true;
            this.lblAdvisor.Location = new System.Drawing.Point(15, 55);
            this.lblAdvisor.Text = "PhD Advisor:";
            this.txtAdvisor.Location = new System.Drawing.Point(100, 52);
            this.txtAdvisor.Size = new System.Drawing.Size(250, 22);
            this.txtAdvisor.Visible = false;
            this.lblAdvisor.Visible = false;

            this.lblDissertation.AutoSize = true;
            this.lblDissertation.Location = new System.Drawing.Point(15, 85);
            this.lblDissertation.Text = "Dissertation:";
            this.txtDissertation.Location = new System.Drawing.Point(100, 82);
            this.txtDissertation.Size = new System.Drawing.Size(250, 22);
            this.txtDissertation.Visible = false;
            this.lblDissertation.Visible = false;

            // Buttons
            this.btnAdd.Location = new System.Drawing.Point(12, 310);
            this.btnAdd.Size = new System.Drawing.Size(100, 30);
            this.btnAdd.Text = "Add Student";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnClear.Location = new System.Drawing.Point(130, 310);
            this.btnClear.Size = new System.Drawing.Size(100, 30);
            this.btnClear.Text = "Clear Form";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.btnShowAll.Location = new System.Drawing.Point(250, 310);
            this.btnShowAll.Size = new System.Drawing.Size(100, 30);
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);

            // Search functionality
            this.lblSearch.AutoSize = true;
            this.lblSearch.Location = new System.Drawing.Point(370, 318);
            this.lblSearch.Text = "Search:";

            this.txtSearch.Location = new System.Drawing.Point(420, 315);
            this.txtSearch.Size = new System.Drawing.Size(150, 22);

            this.btnSearch.Location = new System.Drawing.Point(580, 310);
            this.btnSearch.Size = new System.Drawing.Size(80, 30);
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);

            this.btnDelete.Location = new System.Drawing.Point(670, 310);
            this.btnDelete.Size = new System.Drawing.Size(100, 30);
            this.btnDelete.Text = "Delete Selected";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.lblTotalStudents.AutoSize = true;
            this.lblTotalStudents.Location = new System.Drawing.Point(12, 660);
            this.lblTotalStudents.Text = "Total Students: 0";
            this.lblTotalStudents.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);

            // ListBox for displaying students
            this.lstStudents.Location = new System.Drawing.Point(12, 360);
            this.lstStudents.Size = new System.Drawing.Size(1160, 290);
            this.lstStudents.HorizontalScrollbar = true;

            // Add controls to form
            this.Controls.Add(this.gbStudentType);
            this.Controls.Add(this.gbBasicInfo);
            this.Controls.Add(this.gbTestScores);
            this.Controls.Add(this.gbAddress);
            this.Controls.Add(this.gbSpecialFields);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.lblSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.lstStudents);
            this.Controls.Add(this.lblTotalStudents);

            this.gbStudentType.ResumeLayout(false);
            this.gbStudentType.PerformLayout();
            this.gbBasicInfo.ResumeLayout(false);
            this.gbBasicInfo.PerformLayout();
            this.gbTestScores.ResumeLayout(false);
            this.gbTestScores.PerformLayout();
            this.gbAddress.ResumeLayout(false);
            this.gbAddress.PerformLayout();
            this.gbSpecialFields.ResumeLayout(false);
            this.gbSpecialFields.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}