using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.Supporting
{
    public static class CurrentUser
    {
        public static User User { get; set; }
        public readonly static User admin = new User { Login = "meckbaig", Password = "MeckbAdmin" }; 
    }
}
