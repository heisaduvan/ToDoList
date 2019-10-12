using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo
{
    class Password
    {
        public string pass = null;
        public string confirmPass = null;
        public Password(string pass, string confirmPass)
        {
            this.pass = pass;
            this.confirmPass = confirmPass;
        }
        public Boolean confirm()
        {
            if (pass == confirmPass)
                return true;
            return false;
        }
    }
}
