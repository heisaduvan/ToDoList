using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Users
    {
        public string name, surname,email;
        public string pass;
        public Users (string name, string surname, string email, string pass)
        {
            this.name = name;
            this.surname = surname;
            this.email = email;
            this.pass = pass;
        }
        public Users(string email, string pass)
        {
            this.email = email;
            this.pass = pass;
        }
    }
}
