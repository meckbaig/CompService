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
    public partial class LoginForm : Form, ILoginView
    {
        LoginPresenter presenter;
        public LoginForm()
        {
            InitializeComponent();
            presenter = new LoginPresenter(this);
            Core.LoadConnectionData(); 
        }

        private void ToRegistrationButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();
            Hide();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            presenter.LoginMethod(loginTextBox.Text, passwordTextBox.Text);
        }

        private void TextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                presenter.LoginMethod(loginTextBox.Text, passwordTextBox.Text);
        }

        private void ForgotPasswordLabel_Click(object sender, EventArgs e)
        {
            RecoveryForm recoveryForm = new RecoveryForm();
            recoveryForm.Show();
            Hide();
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
