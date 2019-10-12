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
    public partial class FormUserInterface : Form
    {
        public int userID;
        public FormUserInterface()
        {
            InitializeComponent();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
            Environment.Exit(0);
        }
        private void BtnMinimized_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        private void BtnLearning_MouseEnter(object sender, EventArgs e)
        {
            learning1.BringToFront();
        }
        private void BtnBooks_MouseEnter(object sender, EventArgs e)
        {
            books1.BringToFront();
        }
        private void BtnTargets_MouseEnter(object sender, EventArgs e)
        {
            targets1.BringToFront();
        }
        private void BtnIdeas_MouseEnter(object sender, EventArgs e)
        {
            ideas1.BringToFront();
        }
        int mouseX,mouseY;
        bool moveForm = false;
        private void topPanel_MouseUp(object sender, MouseEventArgs e)
        {
            moveForm = false;
        }
        private void topPanel_MouseDown(object sender, MouseEventArgs e)
        {
            moveForm = true;
            mouseX = e.X;
            mouseY = e.Y;
        }

        private void BtnHidePanel_Click(object sender, EventArgs e)
        {
            btnHidePanel.Visible = false;
            btnHidePanel.Visible = false;
            btnOpenPanel.Visible = true;
            btnOpenPanel.Enabled = true;
            panelLeft.Width = 70;
            pictureBoxLogo.Hide();
        }

        private void BtnOpenPanel_Click(object sender, EventArgs e)
        {
            btnHidePanel.Visible = true;
            btnHidePanel.Visible = true;
            btnOpenPanel.Visible = false;
            btnOpenPanel.Enabled = false;
            panelLeft.Width = 270;
            pictureBoxLogo.Show();
        }

        private void topPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveForm)
            {
                this.SetDesktopLocation(MousePosition.X - mouseX, MousePosition.Y - mouseY);
            }
        }
    }
}
