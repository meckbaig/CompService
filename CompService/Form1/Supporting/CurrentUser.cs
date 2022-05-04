using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompService.Supporting
{
    public static class CurrentUser
    {
        public static Customer CustomerUser { get; set; }
        public static Master MasterUser { get; set; }

        public readonly static User admin = new User { Login = "meckbaig", Password = "MeckbAdmin" }; 
    }
}
