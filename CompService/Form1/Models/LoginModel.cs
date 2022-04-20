using Form1.Supporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.Models
{
    class LoginModel : ILoginModel
    {
        public User LoginMethod(string login, string password)
        {
            if (login == CurrentUser.admin.Login && password == CurrentUser.admin.Password)
                return CurrentUser.admin;
            CurrentUser.User = Core.Context.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
            return CurrentUser.User;
        }
    }
}
