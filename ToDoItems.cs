using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToDo
{
    public partial class ToDoItems : UserControl
    {
        public ToDoItems()
        {
            InitializeComponent();
        }
        public ToDoItems(string text)
        {
            InitializeComponent();
            lblTask.Text = text;
        }

        private void BunifuImageButton1_Click(object sender, EventArgs e)
        {
        }
    }
}
