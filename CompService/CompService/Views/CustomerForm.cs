using CompService.Presenters;
using CompService.Supporting;
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
    public partial class CustomerForm : TemplateForm, ICustomerView
    {
        CustomerPresenter presenter;
        public CustomerForm()
        {
            InitializeComponent();
            presenter = new CustomerPresenter(this);
        }
        public object SearchData
        {
            set
            {
                ordersGridView.DataSource = value;
            }
        }

        public string FullName
        {
            set
            {
                myFullNameTextBox.Text = value;
            }
            get
            {
                return myFullNameTextBox.Text;
            }
        }
        public string Login
        {
            set
            {
                myLoginTextBox.Text = value;
            }
            get
            {
                return myLoginTextBox.Text;
            }
        }
        public string PhoneNumber
        {
            set
            {
                myPhoneNumberTextBox.Text = value;
            }
            get
            {
                return myPhoneNumberTextBox.Text;
            }
        }
        public string OldPassword
        {
            set
            {
                myOldPasswordTextBox.Text = value;
            }
            get
            {
                return myOldPasswordTextBox.Text;
            }
        }
        public string NewPassword
        {
            set
            {
                myNewPasswordTextBox.Text = value;
            }
            get
            {
                return myNewPasswordTextBox.Text;
            }
        }
        public string RepeatPassword
        {
            set
            {
                repeatPasswordTextBox.Text = value;
            }
            get
            {
                return repeatPasswordTextBox.Text;
            }
        }
        public string DefectDescription
        {
            set
            {
                defectDescriptionTextBox.Text = value;
            }
            get
            {
                return defectDescriptionTextBox.Text;
            }
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            welcomeLabel.Text = $"Добро пожаловать, {CurrentUser.CustomerUser.FullName}!";
        }

        private void MyOrdersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = ordersCustomerTabPage; 
            presenter.SearchOrder(idSearchOrderTextBox.Text,
                                  allowDateCheckBox.Checked,
                                  receiptDateSearchTimePicker.Value,
                                  allowCompletionDateCheckBox.Checked,
                                  completionDateSearchTimePicker.Value,
                                  defectDescriptionSearchTextBox.Text,
                                  serialNumberSearchTextBox.Text,
                                  completedSearchCheckBox.Checked);
        }

        private void AccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = accountCustomerTabPage;
            presenter.ParceMyInfo();
        }

        private void NewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = newOrderTabPage;
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.SearchOrder(idSearchOrderTextBox.Text,
                                     allowDateCheckBox.Checked,
                                     receiptDateSearchTimePicker.Value,
                                     allowCompletionDateCheckBox.Checked,
                                     completionDateSearchTimePicker.Value,
                                     defectDescriptionSearchTextBox.Text,
                                     serialNumberSearchTextBox.Text,
                                     completedSearchCheckBox.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveChanges_Click(object sender, EventArgs e)
        {
            presenter.NewCustomerInformation();
            if (myOldPasswordTextBox.Enabled)
                presenter.NewPassword();
        }

        private void PasswordEnableButton_Click(object sender, EventArgs e)
        {
            presenter.PasswordEnabling(myOldPasswordTextBox, myNewPasswordTextBox, repeatPasswordTextBox);
        }

        private void SendButton_Click(object sender, EventArgs e)
        {
            presenter.NewRequest();
            tabControl.SelectedTab = ordersCustomerTabPage; 
            presenter.SearchOrder(idSearchOrderTextBox.Text,
                                   allowDateCheckBox.Checked,
                                   receiptDateSearchTimePicker.Value,
                                   allowCompletionDateCheckBox.Checked,
                                   completionDateSearchTimePicker.Value,
                                   defectDescriptionSearchTextBox.Text,
                                   serialNumberSearchTextBox.Text,
                                   completedSearchCheckBox.Checked);
        }

        private void CustomerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
