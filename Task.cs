using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Task
    {
        Database db = new Database();
        string description;
        string tableName;
        public Task(string text,string table)
        {
            description = text;
            tableName = table;
            db.insertTask(description, tableName);
        }
    }
}
