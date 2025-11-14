namespace Assignment2
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button testDoublesButton;
        private System.Windows.Forms.Button testStringsButton;
        private System.Windows.Forms.Button testStudentsButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label instructionLabel;

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
            this.testDoublesButton = new System.Windows.Forms.Button();
            this.testStringsButton = new System.Windows.Forms.Button();
            this.testStudentsButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.instructionLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // titleLabel
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.titleLabel.Location = new System.Drawing.Point(20, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(460, 30);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Call by Value vs Call by Reference Demo";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // instructionLabel
            this.instructionLabel.Location = new System.Drawing.Point(20, 60);
            this.instructionLabel.Name = "instructionLabel";
            this.instructionLabel.Size = new System.Drawing.Size(460, 40);
            this.instructionLabel.TabIndex = 1;
            this.instructionLabel.Text = "Click the buttons below to test swap methods.\nResults will be displayed in message boxes.";
            this.instructionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // testDoublesButton
            this.testDoublesButton.Location = new System.Drawing.Point(50, 120);
            this.testDoublesButton.Name = "testDoublesButton";
            this.testDoublesButton.Size = new System.Drawing.Size(150, 50);
            this.testDoublesButton.TabIndex = 2;
            this.testDoublesButton.Text = "Test Double Swaps";
            this.testDoublesButton.UseVisualStyleBackColor = true;
            this.testDoublesButton.Click += new System.EventHandler(this.testDoublesButton_Click);

            // testStringsButton
            this.testStringsButton.Location = new System.Drawing.Point(220, 120);
            this.testStringsButton.Name = "testStringsButton";
            this.testStringsButton.Size = new System.Drawing.Size(150, 50);
            this.testStringsButton.TabIndex = 3;
            this.testStringsButton.Text = "Test String Swaps";
            this.testStringsButton.UseVisualStyleBackColor = true;
            this.testStringsButton.Click += new System.EventHandler(this.testStringsButton_Click);

            // testStudentsButton
            this.testStudentsButton.Location = new System.Drawing.Point(135, 190);
            this.testStudentsButton.Name = "testStudentsButton";
            this.testStudentsButton.Size = new System.Drawing.Size(150, 50);
            this.testStudentsButton.TabIndex = 4;
            this.testStudentsButton.Text = "Test Student Swaps";
            this.testStudentsButton.UseVisualStyleBackColor = true;
            this.testStudentsButton.Click += new System.EventHandler(this.testStudentsButton_Click);

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 280);
            this.Controls.Add(this.testStudentsButton);
            this.Controls.Add(this.testStringsButton);
            this.Controls.Add(this.testDoublesButton);
            this.Controls.Add(this.instructionLabel);
            this.Controls.Add(this.titleLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Swap Demo - Call by Value vs Call by Reference";
            this.ResumeLayout(false);
        }
    }
}
