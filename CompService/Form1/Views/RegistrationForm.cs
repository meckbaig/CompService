using Form1.Presenters;
using Form1.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class RegistrationForm : Form, IRegistrationView
    {
        RegistrationPresenter presenter;
        public RegistrationForm()
        {
            InitializeComponent();
            presenter = new RegistrationPresenter(this);
        }

        private void loginTextBox_Validating(object sender, CancelEventArgs e)
        {
            if (String.IsNullOrEmpty(loginTextBox.Text))
            {
                regErrorProvider.SetError(loginTextBox, "Введите логин");
            }
            else if (loginTextBox.Text.Length < 5 || loginTextBox.Text.Length > 30)
            {
                regErrorProvider.SetError(loginTextBox, "Логин должен быть длиной от 5 до 30 символов");
            }
            else
            {
                regErrorProvider.Clear();
            }
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(passwordTextBox.Text))
            {
                regErrorProvider.SetError(passwordTextBox, "Не введен пароль!");
            }
            else if(passwordTextBox.Text.Length < 5 || passwordTextBox.Text.Length > 30)
            {
                regErrorProvider.SetError(passwordTextBox, "Пароль должен быть длиной от 5 до 30 символов");
            }
            else
            {
                regErrorProvider.Clear();
            }
        }

        private void repeatPasswordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (repeatPasswordTextBox.Text != passwordTextBox.Text)
            {
                regErrorProvider.SetError(repeatPasswordTextBox, "Пароли не совпадают");
            }
            else
            {
                regErrorProvider.Clear();
            }
        }
        private void registrationButton_Click(object sender, EventArgs e)
        {
            presenter.RegistrationMethod(loginTextBox.Text, passwordTextBox.Text, repeatPasswordTextBox.Text);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                presenter.RegistrationMethod(loginTextBox.Text, passwordTextBox.Text, repeatPasswordTextBox.Text);
        }
    }
}
