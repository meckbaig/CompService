using CompService.Models;
using CompService.Supporting;
using CompService.Views;
using System;
using System.Collections.Generic;
using System.IO;
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

        public void LoginMethod()
        {
            try
            {
                var user = model.LoginMethod(view.Login, view.Password);

                if (user == CurrentUser.admin || user?.Role.RoleName == "Master")
                {
                    MainForm adminForm = new MainForm();
                    adminForm.Show();
                    SaveLoginOptions();
                    view.Hide();
                }
                else if (user?.Role.RoleName == "User")
                {
                    CustomerForm customerForm = new CustomerForm();
                    customerForm.Show();
                    SaveLoginOptions();
                    view.Hide();
                }
                else
                    MessageBox.Show("Проверьте правильность ввода логина и пароля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception)
            {
                if (view.Login == CurrentUser.admin.Login && view.Password == CurrentUser.admin.Password)
                {
                    MessageBox.Show("Проблемы с подключением к БД. \nПопробуйте сменить параметры подключения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ConnectionForm connection = new ConnectionForm();
                    connection.Show();
                    view.Hide();
                }
                else
                    MessageBox.Show("Отсутствует подключение к БД. \nОбратитесь к администратору", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void LoadLoginOptions()
        {
            try
            {
                if (File.Exists(Core.loginOptions) && File.ReadAllText(Core.loginOptions) != "")
                {
                    var loginData = StringСryptography.Decrypt(File.ReadAllText(Core.loginOptions)).Split('㊗');
                    view.Login = loginData[0];
                    view.Password = loginData[1];
                    view.SaveOptions = Convert.ToBoolean(loginData[2]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
}
        internal void SaveLoginOptions()
        {
            try
            {
                string loginOptions = "";
                if (view.SaveOptions)
                    loginOptions = $"{view.Login}㊗{view.Password}㊗{view.SaveOptions}";
                File.WriteAllText(Core.loginOptions, StringСryptography.Encrypt(loginOptions));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
