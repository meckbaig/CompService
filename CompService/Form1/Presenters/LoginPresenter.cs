using Form1.Models;
using Form1.Supporting;
using Form1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1.Presenters
{
    class LoginPresenter
    {
        ILoginModel model;
        ILoginView view;

        public LoginPresenter(ILoginView view)
        {
            this.model = new LoginModel();
            this.view = view;
        }

        public void LoginMethod(string login, string password)
        {
            var user = model.LoginMethod(login, password);
            if (user == CurrentUser.admin)
            {
                AdminForm adminForm = new AdminForm();
                adminForm.Show();
                view.Hide();
            }
            else if (user != null)
            {
                if (user.Role.RoleName == "Master")
                {
                    MasterForm masterForm = new MasterForm();
                    masterForm.Show();
                    view.Hide();
                }
                if (user.Role.RoleName == "User")
                {
                    CustomerForm customerForm = new CustomerForm();
                    customerForm.Show();
                    view.Hide();
                }
            }
            else
                MessageBox.Show("Проверьте правильность ввода логина и пароля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
