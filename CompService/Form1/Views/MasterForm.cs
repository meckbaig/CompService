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
    public partial class MasterForm : TemplateForm
    {
        public MasterForm()
        {
            InitializeComponent();
        }
        private void MasterForm_Load(object sender, EventArgs e)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            var orders = Core.Context.Orders.ToList();
            searchGridView.DataSource = orders;
        }

        private void поискЗаказаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = searchOrder;
            var orders = Core.Context.Orders.ToList();
            searchGridView.DataSource = orders;
        }

        private void новыйЗаказToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = newOrder;
        }

        private void SortOrders()
        {
            var orders = Core.Context.Orders.ToList();
            if (completedCheckBox.Checked)
                orders = orders.Where(o => !(o.Completed ?? false)).ToList();           //проверка на завершенность
            sortGridView.DataSource = orders;
        }

        private void AddNewOrder()
        {
            if (fullNameTextBox.Text != "" && phoneNumberTextBox.Text != "" && defectDescriptionTextBox.Text != "")
            {
                Order order = new Order();
                order.FullName = fullNameTextBox.Text;
                order.PhoneNumber = phoneNumberTextBox.Text;
                order.ReceiptDate = receiptDateDateTimePicker.Value;
                order.DefectDescription = defectDescriptionTextBox.Text;
                order.SerialNumber = serialNumberTextBox.Text;
                order.Completed = false;
                Core.Context.Orders.Add(order);
                Core.Context.SaveChanges();
                MessageBox.Show("Заказ добавлен", "Успешно!", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Заполните поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void списокЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = listOrder;
            SortOrders();
        }


        private void sortButton_Click(object sender, EventArgs e)
        {
            SortOrders();
        }

        private void createOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                AddNewOrder();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            var orders = Core.Context.Orders.ToList();
            if (idSearchOrderTextBox.Text != "")
                orders = orders.Where(o => o.IdOrder == Convert.ToInt32(idSearchOrderTextBox.Text)).ToList();
            if (fullNameSearchTextBox.Text != "")
                orders = orders.Where(o => o.FullName.ToLower().Contains(fullNameSearchTextBox.Text.ToLower())).ToList();
            if (phoneNumberSearchTextBox.Text != "")
                orders = orders.Where(o => o.PhoneNumber.Contains(phoneNumberSearchTextBox.Text)).ToList();
            if (allowDateCheckBox.Checked)
                orders = orders.Where(o => o.ReceiptDate.Date.Date == receiptDateSearchTimePicker.Value.Date).ToList();
            if (defectDescriptionSearchTextBox.Text != "")
                orders = orders.Where(o => o.DefectDescription.ToLower().Contains(defectDescriptionSearchTextBox.Text.ToLower())).ToList();
            if (serialNumberSearchTextBox.Text != "")
                orders = orders.Where(o => o.SerialNumber.ToLower().Contains(serialNumberSearchTextBox.Text.ToLower())).ToList();
            if (completedSearchCheckBox.Checked)
                orders = orders.Where(o => !(o.Completed ?? false)).ToList();           //проверка на завершенность
            searchGridView.DataSource = orders;
        }
    }
}
