using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class FormSignin : Form
    {
        public bool triggerCheckNullTextBox = true;
        Database database = new Database();

        public FormSignin()
        {
            InitializeComponent();
            
        }

        private void lblClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }

        private void LabelNewAccount_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormSignup f2 = new FormSignup();
            f2.Show();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            restartTextBoxesStar();
            checkTextBoxes();
            if (triggerCheckNullTextBox)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;
                Users user = new Users(username,password);
                database.connect();
                if (database.validationUser(user))
                {
                    FormUserInterface f1 = new FormUserInterface();
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("User email address or password is not correct.");
                }
                database.close();
            }
            else
            {
                MessageBox.Show("User email address or password cannot be empty.");
            }
        }
        private void checkTextBoxes()
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                labelEmailStar.Visible = true;
                triggerCheckNullTextBox = false;
            }
            if (String.IsNullOrEmpty(txtPassword.Text))
            {
                labelPasswordStar.Visible = true;
                triggerCheckNullTextBox = false;
            }
        }
        private void restartTextBoxesStar()
        {
            triggerCheckNullTextBox = true;
            labelEmailStar.Visible = false;
            labelPasswordStar.Visible = false;
        }
    }
}
