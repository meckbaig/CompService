using System;
using CompService.Supporting;
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
    public partial class CustomerLink : TemplateForm
    {
        public CustomerLink()
        {
            InitializeComponent();
            customersDataGridView.DataSource = Core.Context.CustomerInfoes.ToList();
        }
        private void SortCustomers()
        {
            if (fullNameRadioButton.Checked)
                customersDataGridView.DataSource = Core.Context.CustomerInfoes.Where(c => c.FullName.Contains(searchTextBox.Text)).ToList();
            if (phoneNumberRadioButton.Checked)
                customersDataGridView.DataSource = Core.Context.CustomerInfoes.Where(c => c.PhoneNumber.Contains(searchTextBox.Text)).ToList();
            if (loginRadioButton.Checked)
                customersDataGridView.DataSource = Core.Context.CustomerInfoes.Where(c => c.Login.Contains(searchTextBox.Text)).ToList();
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            SortCustomers();
        }

        private void SearchTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                SortCustomers();
        }

        private void ChooseCustomerButton_Click(object sender, EventArgs e)
        {
            int selectedOrderId = Convert.ToInt32(customersDataGridView.CurrentRow.Cells[0].Value);
            ParceCustomerIntoOrder.User = Core.Context.Customers.FirstOrDefault(c => c.IdCustomer == selectedOrderId);
        }
    }
}
