using CompService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService.Views
{
    public partial class RecoveryForm : TemplateForm
    {
        public RecoveryForm()
        {
            InitializeComponent();
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }
        Customer currentCustomer;
        public void ConfirmButton_Click(object sender, EventArgs e)
        {
            currentCustomer = Core.Context.Customers.FirstOrDefault(c => c.User.Login == loginTextBox.Text &&
                                                                    c.FullName == fullNameTextBox.Text &&
                                                                    c.PhoneNumber == phoneNumberTextBox.Text);
            if (currentCustomer != null)
            {
                tabControl.SelectedTab = newPasswordTabPage;
            }
            else
                MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public void ChangePasswordButton_Click(object sender, EventArgs e)
        {
            if (passwordTextBox.Text != "" && passwordTextBox.Text == repeatPasswordTextBox.Text && passwordTextBox.Text.Length > 4)
            {
                if (currentCustomer.User.Password != passwordTextBox.Text)
                {
                    currentCustomer.User.Password = passwordTextBox.Text;
                    Core.Context.SaveChanges();
                    MessageBox.Show("Пароль успешно изменён", "Успешно!", MessageBoxButtons.OK);
                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Close();
                }
                else
                    MessageBox.Show("Пароль не может совпадать с используемым", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                MessageBox.Show("Проверьте правильность ввода пароля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RecoveryForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
            }
        }
    }
}
