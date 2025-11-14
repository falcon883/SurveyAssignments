namespace OnlineStoreApp
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabSearchById = new System.Windows.Forms.TabPage();
            this.txtResultById = new System.Windows.Forms.TextBox();
            this.lblResultById = new System.Windows.Forms.Label();
            this.btnSearchById = new System.Windows.Forms.Button();
            this.txtProductId = new System.Windows.Forms.TextBox();
            this.tabSearchByName = new System.Windows.Forms.TabPage();
            this.txtResultByName = new System.Windows.Forms.TextBox();
            this.lblResultByName = new System.Windows.Forms.Label();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.tabSearchByDescription = new System.Windows.Forms.TabPage();
            this.lstResultsByDescription = new System.Windows.Forms.ListBox();
            this.lblResultByDescription = new System.Windows.Forms.Label();
            this.btnSearchByDescription = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.tabSearchByCategory = new System.Windows.Forms.TabPage();
            this.lstResultsByCategory = new System.Windows.Forms.ListBox();
            this.lblResultByCategory = new System.Windows.Forms.Label();
            this.btnSearchByCategory = new System.Windows.Forms.Button();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.tabControl1.SuspendLayout();
            this.tabSearchById.SuspendLayout();
            this.tabSearchByName.SuspendLayout();
            this.tabSearchByDescription.SuspendLayout();
            this.tabSearchByCategory.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabSearchById);
            this.tabControl1.Controls.Add(this.tabSearchByName);
            this.tabControl1.Controls.Add(this.tabSearchByDescription);
            this.tabControl1.Controls.Add(this.tabSearchByCategory);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabSearchById
            // 
            this.tabSearchById.Controls.Add(this.txtResultById);
            this.tabSearchById.Controls.Add(this.lblResultById);
            this.tabSearchById.Controls.Add(this.btnSearchById);
            this.tabSearchById.Controls.Add(this.txtProductId);
            this.tabSearchById.Location = new System.Drawing.Point(4, 24);
            this.tabSearchById.Name = "tabSearchById";
            this.tabSearchById.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchById.Size = new System.Drawing.Size(752, 398);
            this.tabSearchById.TabIndex = 0;
            this.tabSearchById.Text = "Search by ID";
            this.tabSearchById.UseVisualStyleBackColor = true;
            // 
            // txtResultById
            // 
            this.txtResultById.Location = new System.Drawing.Point(20, 80);
            this.txtResultById.Multiline = true;
            this.txtResultById.Name = "txtResultById";
            this.txtResultById.ReadOnly = true;
            this.txtResultById.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultById.Size = new System.Drawing.Size(700, 100);
            this.txtResultById.TabIndex = 3;
            // 
            // lblResultById
            // 
            this.lblResultById.AutoSize = true;
            this.lblResultById.Location = new System.Drawing.Point(20, 60);
            this.lblResultById.Name = "lblResultById";
            this.lblResultById.Size = new System.Drawing.Size(45, 15);
            this.lblResultById.TabIndex = 2;
            this.lblResultById.Text = "Result:";
            // 
            // btnSearchById
            // 
            this.btnSearchById.Location = new System.Drawing.Point(240, 19);
            this.btnSearchById.Name = "btnSearchById";
            this.btnSearchById.Size = new System.Drawing.Size(100, 25);
            this.btnSearchById.TabIndex = 1;
            this.btnSearchById.Text = "Search";
            this.btnSearchById.UseVisualStyleBackColor = true;
            this.btnSearchById.Click += new System.EventHandler(this.btnSearchById_Click);
            // 
            // txtProductId
            // 
            this.txtProductId.Location = new System.Drawing.Point(20, 20);
            this.txtProductId.Name = "txtProductId";
            this.txtProductId.PlaceholderText = "Enter Product ID";
            this.txtProductId.Size = new System.Drawing.Size(200, 23);
            this.txtProductId.TabIndex = 0;
            // 
            // tabSearchByName
            // 
            this.tabSearchByName.Controls.Add(this.txtResultByName);
            this.tabSearchByName.Controls.Add(this.lblResultByName);
            this.tabSearchByName.Controls.Add(this.btnSearchByName);
            this.tabSearchByName.Controls.Add(this.txtProductName);
            this.tabSearchByName.Location = new System.Drawing.Point(4, 24);
            this.tabSearchByName.Name = "tabSearchByName";
            this.tabSearchByName.Padding = new System.Windows.Forms.Padding(3);
            this.tabSearchByName.Size = new System.Drawing.Size(752, 398);
            this.tabSearchByName.TabIndex = 1;
            this.tabSearchByName.Text = "Search by Name";
            this.tabSearchByName.UseVisualStyleBackColor = true;
            // 
            // txtResultByName
            // 
            this.txtResultByName.Location = new System.Drawing.Point(20, 80);
            this.txtResultByName.Multiline = true;
            this.txtResultByName.Name = "txtResultByName";
            this.txtResultByName.ReadOnly = true;
            this.txtResultByName.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResultByName.Size = new System.Drawing.Size(700, 100);
            this.txtResultByName.TabIndex = 3;
            // 
            // lblResultByName
            // 
            this.lblResultByName.AutoSize = true;
            this.lblResultByName.Location = new System.Drawing.Point(20, 60);
            this.lblResultByName.Name = "lblResultByName";
            this.lblResultByName.Size = new System.Drawing.Size(45, 15);
            this.lblResultByName.TabIndex = 2;
            this.lblResultByName.Text = "Result:";
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(240, 19);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(100, 25);
            this.btnSearchByName.TabIndex = 1;
            this.btnSearchByName.Text = "Search";
            this.btnSearchByName.UseVisualStyleBackColor = true;
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(20, 20);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PlaceholderText = "Enter Product Name";
            this.txtProductName.Size = new System.Drawing.Size(200, 23);
            this.txtProductName.TabIndex = 0;
            // 
            // tabSearchByDescription
            // 
            this.tabSearchByDescription.Controls.Add(this.lstResultsByDescription);
            this.tabSearchByDescription.Controls.Add(this.lblResultByDescription);
            this.tabSearchByDescription.Controls.Add(this.btnSearchByDescription);
            this.tabSearchByDescription.Controls.Add(this.txtDescription);
            this.tabSearchByDescription.Location = new System.Drawing.Point(4, 24);
            this.tabSearchByDescription.Name = "tabSearchByDescription";
            this.tabSearchByDescription.Size = new System.Drawing.Size(752, 398);
            this.tabSearchByDescription.TabIndex = 2;
            this.tabSearchByDescription.Text = "Search by Description";
            this.tabSearchByDescription.UseVisualStyleBackColor = true;
            // 
            // lstResultsByDescription
            // 
            this.lstResultsByDescription.FormattingEnabled = true;
            this.lstResultsByDescription.ItemHeight = 15;
            this.lstResultsByDescription.Location = new System.Drawing.Point(20, 80);
            this.lstResultsByDescription.Name = "lstResultsByDescription";
            this.lstResultsByDescription.Size = new System.Drawing.Size(700, 289);
            this.lstResultsByDescription.TabIndex = 3;
            // 
            // lblResultByDescription
            // 
            this.lblResultByDescription.AutoSize = true;
            this.lblResultByDescription.Location = new System.Drawing.Point(20, 60);
            this.lblResultByDescription.Name = "lblResultByDescription";
            this.lblResultByDescription.Size = new System.Drawing.Size(48, 15);
            this.lblResultByDescription.TabIndex = 2;
            this.lblResultByDescription.Text = "Results:";
            // 
            // btnSearchByDescription
            // 
            this.btnSearchByDescription.Location = new System.Drawing.Point(240, 19);
            this.btnSearchByDescription.Name = "btnSearchByDescription";
            this.btnSearchByDescription.Size = new System.Drawing.Size(100, 25);
            this.btnSearchByDescription.TabIndex = 1;
            this.btnSearchByDescription.Text = "Search";
            this.btnSearchByDescription.UseVisualStyleBackColor = true;
            this.btnSearchByDescription.Click += new System.EventHandler(this.btnSearchByDescription_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(20, 20);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.PlaceholderText = "Enter search term";
            this.txtDescription.Size = new System.Drawing.Size(200, 23);
            this.txtDescription.TabIndex = 0;
            // 
            // tabSearchByCategory
            // 
            this.tabSearchByCategory.Controls.Add(this.lstResultsByCategory);
            this.tabSearchByCategory.Controls.Add(this.lblResultByCategory);
            this.tabSearchByCategory.Controls.Add(this.btnSearchByCategory);
            this.tabSearchByCategory.Controls.Add(this.cmbCategory);
            this.tabSearchByCategory.Location = new System.Drawing.Point(4, 24);
            this.tabSearchByCategory.Name = "tabSearchByCategory";
            this.tabSearchByCategory.Size = new System.Drawing.Size(752, 398);
            this.tabSearchByCategory.TabIndex = 3;
            this.tabSearchByCategory.Text = "Search by Category";
            this.tabSearchByCategory.UseVisualStyleBackColor = true;
            // 
            // lstResultsByCategory
            // 
            this.lstResultsByCategory.FormattingEnabled = true;
            this.lstResultsByCategory.ItemHeight = 15;
            this.lstResultsByCategory.Location = new System.Drawing.Point(20, 80);
            this.lstResultsByCategory.Name = "lstResultsByCategory";
            this.lstResultsByCategory.Size = new System.Drawing.Size(700, 289);
            this.lstResultsByCategory.TabIndex = 3;
            // 
            // lblResultByCategory
            // 
            this.lblResultByCategory.AutoSize = true;
            this.lblResultByCategory.Location = new System.Drawing.Point(20, 60);
            this.lblResultByCategory.Name = "lblResultByCategory";
            this.lblResultByCategory.Size = new System.Drawing.Size(48, 15);
            this.lblResultByCategory.TabIndex = 2;
            this.lblResultByCategory.Text = "Results:";
            // 
            // btnSearchByCategory
            // 
            this.btnSearchByCategory.Location = new System.Drawing.Point(240, 19);
            this.btnSearchByCategory.Name = "btnSearchByCategory";
            this.btnSearchByCategory.Size = new System.Drawing.Size(100, 25);
            this.btnSearchByCategory.TabIndex = 1;
            this.btnSearchByCategory.Text = "Search";
            this.btnSearchByCategory.UseVisualStyleBackColor = true;
            this.btnSearchByCategory.Click += new System.EventHandler(this.btnSearchByCategory_Click);
            // 
            // cmbCategory
            // 
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(20, 20);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(200, 23);
            this.cmbCategory.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Online Store - Product Search";
            this.tabControl1.ResumeLayout(false);
            this.tabSearchById.ResumeLayout(false);
            this.tabSearchById.PerformLayout();
            this.tabSearchByName.ResumeLayout(false);
            this.tabSearchByName.PerformLayout();
            this.tabSearchByDescription.ResumeLayout(false);
            this.tabSearchByDescription.PerformLayout();
            this.tabSearchByCategory.ResumeLayout(false);
            this.tabSearchByCategory.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabSearchById;
        private System.Windows.Forms.TextBox txtResultById;
        private System.Windows.Forms.Label lblResultById;
        private System.Windows.Forms.Button btnSearchById;
        private System.Windows.Forms.TextBox txtProductId;
        private System.Windows.Forms.TabPage tabSearchByName;
        private System.Windows.Forms.TextBox txtResultByName;
        private System.Windows.Forms.Label lblResultByName;
        private System.Windows.Forms.Button btnSearchByName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TabPage tabSearchByDescription;
        private System.Windows.Forms.ListBox lstResultsByDescription;
        private System.Windows.Forms.Label lblResultByDescription;
        private System.Windows.Forms.Button btnSearchByDescription;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TabPage tabSearchByCategory;
        private System.Windows.Forms.ListBox lstResultsByCategory;
        private System.Windows.Forms.Label lblResultByCategory;
        private System.Windows.Forms.Button btnSearchByCategory;
        private System.Windows.Forms.ComboBox cmbCategory;
    }
}