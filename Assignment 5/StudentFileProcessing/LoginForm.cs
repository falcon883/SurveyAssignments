using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentFileProcessing
{
    public partial class LoginForm : Form
    {
        private const string VALID_USERNAME = "admin";
        private const string VALID_PASSWORD = "password123";

        public bool IsAuthenticated { get; private set; }

        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == VALID_USERNAME && txtPassword.Text == VALID_PASSWORD)
            {
                IsAuthenticated = true;
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            IsAuthenticated = false;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
