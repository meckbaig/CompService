using CompService.Models;
using CompService.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService.Presenters
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
                model.ParceCustomer(login, password);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void AddInformation(string fullName, string phoneNumber)
        {
            try
            {
                model.AddInformation(fullName, phoneNumber);
                MessageBox.Show("Регистрация завершена", "Успешно!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
