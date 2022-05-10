using CompService.Presenters;
using CompService.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService
{
    public partial class RegistrationForm : Form, IRegistrationView
    {
        RegistrationPresenter presenter;
        public RegistrationForm()
        {
            InitializeComponent();
            presenter = new RegistrationPresenter(this); 
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }

        private void LoginTextBox_Validating(object sender, CancelEventArgs e)
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

        private void PasswordTextBox_TextChanged(object sender, EventArgs e)
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

        private void RepeatPasswordTextBox_TextChanged(object sender, EventArgs e)
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

        private void RegistrationButton_Click(object sender, EventArgs e)
        {
            presenter.RegistrationMethod(loginTextBox.Text, passwordTextBox.Text, repeatPasswordTextBox.Text);
            tabControl.SelectedTab = infoPage;
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                presenter.RegistrationMethod(loginTextBox.Text, passwordTextBox.Text, repeatPasswordTextBox.Text);
                tabControl.SelectedTab = infoPage;
            }
        }

        private void FinishRegistrationButton_Click(object sender, EventArgs e)
        {
            presenter.AddInformation(fullNameTextBox.Text, phoneNumberTextBox.Text);
            tabControl.SelectedTab = infoPage;
            this.Close();
        }

        private void RegistrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
    }
}
