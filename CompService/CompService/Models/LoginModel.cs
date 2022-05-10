using CompService.Supporting;
using CompService.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService.Models
{
    class LoginModel : ILoginModel
    {
        public bool CheckConnection()
        {
            try
            {
                if (Core.Context.FullOrderInfoes.AsNoTracking().ToList() != null)
                    return true;
                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public User LoginMethod(string login, string password)
        {
            try
            {
                Core.Context.FullOrderInfoes.AsNoTracking().ToList();
                if (login == CurrentUser.admin.Login && password == CurrentUser.admin.Password)
                    return CurrentUser.admin;
                CurrentUser.MasterUser = Core.Context.Masters.FirstOrDefault(c => c.User.Login == login && c.User.Password == password);
                if (CurrentUser.MasterUser == null)
                {
                    CurrentUser.CustomerUser = Core.Context.Customers.FirstOrDefault(c => c.User.Login == login && c.User.Password == password);
                    return CurrentUser.CustomerUser?.User;
                }
                else
                    return CurrentUser.MasterUser?.User;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
