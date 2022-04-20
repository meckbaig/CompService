using Form1.Models;
using Form1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1.Presenters
{
    class RegistrationPresenter
    {
        IRegistrationModel model;
        IRegistrationView view;

        public RegistrationPresenter(IRegistrationView view)
        {
            this.model = new RegistrationModel();
            this.view = view;
        }

        public void RegistrationMethod(string login, string password, string repeatPassword)
        {
            try
            {
                model.RegistrationMethod(login, password, repeatPassword);
                MessageBox.Show("Регистрация завершена", "Успешно!", MessageBoxButtons.OK);
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                view.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
