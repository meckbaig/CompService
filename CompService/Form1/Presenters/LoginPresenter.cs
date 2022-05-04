using CompService.Models;
using CompService.Supporting;
using CompService.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService.Presenters
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
            if (model.CheckConnection())
            {
                var user = model.LoginMethod(login, password);
                if (user == CurrentUser.admin || user?.Role.RoleName == "Master")
                {
                    MainForm adminForm = new MainForm();
                    adminForm.Show();
                    view.Hide();
                }
                else if (user?.Role.RoleName == "User")
                {
                    CustomerForm customerForm = new CustomerForm();
                    customerForm.Show();
                    view.Hide();
                }
                else
                    MessageBox.Show("Проверьте правильность ввода логина и пароля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Проблемы с подключением к БД. \nПопробуйте сменить параметры подключения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ConnectionForm connection = new ConnectionForm();
                connection.Show();
                view.Hide();
            }
        }
    }
}
