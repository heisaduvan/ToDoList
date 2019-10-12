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
    public partial class Books : UserControl
    {
        string table = "Books";
        public Books()
        {
            InitializeComponent();
            updatePanel();

        }
        int poss = 10;
        public void addItem(string text)
        {
            ToDoItems item = new ToDo.ToDoItems(text);
            item.BackColor = Color.PaleVioletRed;
            panel2.Controls.Add(item);
            item.Top = poss;
            poss = (item.Top + item.Height + 10);
        }
        public void updatePanel()
        {
            panel2.Controls.Clear();
            poss = 10;
            Database db = new Database();
            DataTable dataTable = new DataTable();
            db.connect();
            dataTable = db.getTaskFromDatabase(table);
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                addItem(dataTable.Rows[i][0].ToString());
            }
            db.close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string taskDescription = txtGetTask.Text;
            Task task = new Task(taskDescription, table);
            updatePanel();
            txtGetTask.Text = "";
        }
    }
}
