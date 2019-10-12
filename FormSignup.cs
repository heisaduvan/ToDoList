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
    public partial class FormSignup : Form
    {
        Database database = new Database();
        public bool triggerCheckNullTextBox = true;
        public FormSignup()
        {
            InitializeComponent();
        }
        private void LabelClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
        private void LabelSignin_Click(object sender, EventArgs e)
        {
            this.Close();
            FormSignin f1 = new FormSignin();
            f1.Show();
        }
        private void BtnLogin_Click(object sender, EventArgs e)
        {
            restartTextBoxesStart();
            checkTextBoxes();
            string name = txtUsername.Text;
            string surname = txtUserSurname.Text;
            string email = txtUserEmail.Text;
            Password password = new Password(txtUserPassword.Text, txtUserConfirmPassword.Text);
            if (triggerCheckNullTextBox)
            {
                if (password.confirm())
                {
                    labelDontMatch.Visible = false;
                    Users user = new Users(name, surname, email, password.pass);
                    database.connect();
                    if (database.checkSignupEmail(user.email))
                    {
                        database.insert(user);
                        database.close();
                        MessageBox.Show("Welcome to ToDoList. You can start to enter your task. :)");
                        this.Close();
                        FormSignin f1 = new FormSignin();
                        f1.Show();
                    }
                    else
                    {
                        forgetPassword();
                    }
                    database.close();
                }
                else
                {
                    labelDontMatch.Visible = true;
                }
            }
            else
            {
                MessageBox.Show("Fill in the blanks.");
            }
        }
        public void forgetPassword()
        {
            // To do --> şifremi unuttum paneli yapılacak.
            MessageBox.Show("If you forgot your password.");
        }
        public void checkTextBoxes()
        {
            if (String.IsNullOrEmpty(txtUsername.Text))
            {
                labelNameStar.Visible = true;
                triggerCheckNullTextBox = false;
            }
            if (String.IsNullOrEmpty(txtUserSurname.Text))
            {
                triggerCheckNullTextBox = false;
                labelSurnameStar.Visible = true;
            }
            if (String.IsNullOrEmpty(txtUserEmail.Text))
            {
                triggerCheckNullTextBox = false;
                labelEmailStar.Visible = true;
            }
            if (String.IsNullOrEmpty(txtUserPassword.Text))
            {
                triggerCheckNullTextBox = false;
                labelPasswordStar.Visible = true;
            }
            if (String.IsNullOrEmpty(txtUserConfirmPassword.Text))
            {
                triggerCheckNullTextBox = false;
                labelConfirmStar.Visible = true;
            }
        }
        public void restartTextBoxesStart()
        {
            triggerCheckNullTextBox = true;
            labelNameStar.Visible = false;
            labelSurnameStar.Visible = false;
            labelEmailStar.Visible = false;
            labelPasswordStar.Visible = false;
            labelConfirmStar.Visible = false;
        }

    }
}
