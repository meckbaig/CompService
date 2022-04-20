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
    public partial class AdminForm : TemplateForm, IAdminView
    {
        AdminPresenter presenter;
        int SelectedOrderId;
        public AdminForm()
        {
            InitializeComponent();
            presenter = new AdminPresenter(this);
        }
        public object[] Masters
        {
            //set
            //{
            //    foreach (var item in value)
            //    {
            //        mastersInOrderListBox.Items.Add(item);
            //    }
            //}
            get
            {
                var data = new object[mastersInOrderListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = mastersInOrderListBox.Items[i];
                }
                return data;
            }
        }
        public object[] Services
        {
            //set
            //{
            //    foreach (var item in value)
            //    {
            //        mastersInOrderListBox.Items.Add(item);
            //    }
            //}
            get
            {
                var data = new object[servicesInOrderListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = servicesInOrderListBox.Items[i];
                }
                return data;
            }
        }
        public object[] Parts
        {
            //set
            //{
            //    foreach (var item in value)
            //    {
            //        mastersInOrderListBox.Items.Add(item);
            //    }
            //}
            get
            {
                var data = new object[partsListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = partsListBox.Items[i];
                }
                return data;
            }
        }

        public string EditFullName
        {
            set
            {
                editFullNameTextBox.Text = value;
            }
            get
            {
                return editFullNameTextBox.Text;
            }
        }
        public string EditPhoneNumber
        {
            set
            {
                editPhoneNumberTextBox.Text = value;
            }
            get
            {
                return editPhoneNumberTextBox.Text;
            }
        }
        public DateTime EditDate
        {
            set
            {
                editReceiptDateDateTimePicker.Value = value;
            }
            get
            {
                return editReceiptDateDateTimePicker.Value;
            }
        }
        public bool EditCompletedSearch
        {
            set
            {
                editCompletedSearchCheckBox.Checked = value;
            }
            get
            {
                return editCompletedSearchCheckBox.Checked;
            }
        }
        public string EditDefectDescription
        {
            set
            {
                editDefectDescriptionTextBox.Text = value;
            }
            get
            {
                return editDefectDescriptionTextBox.Text;
            }
        }
        public string EditserialNumber
        {
            set
            {
                editSerialNumberTextBox.Text = value;
            }
            get
            {
                return editSerialNumberTextBox.Text;
            }
        }
        public object[] EditServicesInOrder
        {
            set
            {
                foreach (var item in value)
                {
                    editServicesInOrderListBox.Items.Add(item);
                }
            }
            get
            {
                var data = new object[editServicesInOrderListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = editServicesInOrderListBox.Items[i];
                }
                return data;
            }
        }
        public object[] EditMastersInOrder
        {
            set
            {
                foreach (var item in value)
                {
                    editMastersInOrderListBox.Items.Add(item);
                }
            }
            get
            {
                var data = new object[editMastersInOrderListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = editMastersInOrderListBox.Items[i];
                }
                return data;
            }
        }
        public object[] EditServices
        {
            set
            {
                foreach (var item in value)
                {
                    editServicesListBox.Items.Add(item);
                }
            }
            get
            {
                var data = new object[editServicesListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = editServicesListBox.Items[i];
                }
                return data;
            }
        }
        public object[] EditMasters
        {
            set
            {
                foreach (var item in value)
                {
                    editMastersListBox.Items.Add(item);
                }
            }
            get
            {
                var data = new object[editMastersListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = editMastersListBox.Items[i];
                }
                return data;
            }
        }
        public object[] EditParts
        {
            set
            {
                foreach (var item in value)
                {
                    editPartsListBox.Items.Add(item);
                }
            }
            get
            {
                var data = new object[editPartsListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = editPartsListBox.Items[i];
                }
                return data;
            }
        }

        public object SortData
        {
            set
            {
                sortGridView.DataSource = value;
            }
        }
        public object SearchData
        {
            set
            {
                searchGridView.DataSource = value;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            presenter.OrdersLoad(servicesListBox.Items, mastersListBox.Items);
            servicesListBox.DisplayMember = "ServiceName";
            servicesInOrderListBox.DisplayMember = "ServiceName";
            mastersListBox.DisplayMember = "FullName";
            mastersInOrderListBox.DisplayMember = "FullName";
            partsListBox.DisplayMember = "PartName";
        }

        private void SearchOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = searchOrderTab;
            var orders = Core.Context.Orders.ToList();
            searchGridView.DataSource = orders;
        }

        private void NewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = newOrderTab;
        }

        private void ListOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = listOrderTab;
            presenter.SortOrders(completedCheckBox.Checked);
        }

        private void EditOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = editOrderTab;
            LoadEditOrder();

        }

        private void LoadEditOrder()
        {
            var orderEdit = Core.Context.MostFullOrderInfoes.ToList();
            if (editOrderTab != null)
            {
                ////////////////////
            }
        }

        private void SortButton_Click(object sender, EventArgs e)
        {
            presenter.SortOrders(completedCheckBox.Checked);
        }

        private void OrderBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.orderBindingSource.EndEdit();
        }

        private void CreateOrderButton_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.AddNewOrder(fullNameTextBox.Text, 
                                      phoneNumberTextBox.Text,
                                      receiptDateDateTimePicker.Value,
                                      defectDescriptionTextBox.Text, 
                                      serialNumberTextBox.Text, 
                                      Services,
                                      Masters, 
                                      Parts);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            try
            {
                presenter.SearchOrder(idSearchOrderTextBox.Text,
                                     fullNameSearchTextBox.Text,
                                     phoneNumberSearchTextBox.Text,
                                     allowDateCheckBox.Checked,
                                     receiptDateSearchTimePicker.Value,
                                     defectDescriptionSearchTextBox.Text,
                                     serialNumberSearchTextBox.Text,
                                     completedSearchCheckBox.Checked);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ToEditOrderButton_Click(object sender, EventArgs e)
        {
            if (searchGridView.CurrentRow != null)
            {
                SelectedOrderId = Convert.ToInt32(searchGridView.CurrentRow.Cells[0].Value);  // пока типа проверяю, что передаёт выделенный ID
                presenter.EditOrdersLoad(SelectedOrderId);
                editServicesListBox.DisplayMember = "ServiceName";
                editServicesInOrderListBox.DisplayMember = "ServiceName";
                editMastersListBox.DisplayMember = "FullName";
                editMastersInOrderListBox.DisplayMember = "FullName";
                editPartsListBox.DisplayMember = "PartName";
                tabControl.SelectedTab = editOrderTab;                                          // пока типа проверяю, что передаёт выделенный ID
                ////////////

            }
        }

        public void SwitchItemListBox(ListBox sender, ListBox receiver)
        {
            if (sender.SelectedItem != null)
            {
                var item = sender.SelectedItem;
                receiver.Items.Add(item);
                sender.Items.Remove(item);
            }
        }

        private void LeftButton_Click(object sender, EventArgs e)
        {
            SwitchItemListBox(servicesListBox, servicesInOrderListBox);
        }

        private void RightButton_Click(object sender, EventArgs e)
        {
            SwitchItemListBox(servicesInOrderListBox, servicesListBox);
        }

        private void LeftMastersButton_Click(object sender, EventArgs e)
        {
            SwitchItemListBox(mastersListBox, mastersInOrderListBox);
        }

        private void RightMastersButton_Click(object sender, EventArgs e)
        {
            SwitchItemListBox(mastersInOrderListBox, mastersListBox);
        }

        private void AddPartButton_Click(object sender, EventArgs e)
        {
            Part part = new Part();
            var form = new NewPartForm(ref part);
            if (form.ShowDialog() == DialogResult.OK)
            {
                partsListBox.Items.Add(part);
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            //presenter.Что-то тут будет()
        }

        ///Gomi:

        /*private void SortOrders()
        {
            var orders = Core.Context.MostFullOrderInfoes.ToList();
            var ordersNotCompleted = Core.Context.MostFullOrderInfoWhenNotCompleteds.ToList();
            if (completedCheckBox.Checked)
                sortGridView.DataSource = orders;
            else
                sortGridView.DataSource = ordersNotCompleted;
            //var orders = Core.Context.Parts.Select(p => new { p.IdOrder, p.Order.FullName, p.Order.PhoneNumber, p.Order.ReceiptDate, p.Order.DefectDescription, p.Order.SerialNumber, p.Order.Completed, p.PartName, }).ToList();
            //if (completedCheckBox.Checked)
            //    orders = orders.Where(o => !(o.Completed ?? false)).ToList();           //проверка на завершенность
            //sortGridView.DataSource = orders;
        }*/



        /*private void SearchOrder()
        {
            var orders = Core.Context.MostFullOrderInfoes.ToList();
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
        }*/
        /*private void AddNewOrder()
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
                        foreach (var item in servicesInOrderListBox.Items)
                        {
                            order.Services.Add(item as Service);
                        }
                        foreach (var item in mastersInOrderListBox.Items)
                        {
                            order.Masters.Add(item as Master);
                        }
                        foreach (var item in partsListBox.Items)
                        {
                            order.Parts.Add(item as Part);
                        }
                        Core.Context.Orders.Add(order);
                        Core.Context.SaveChanges();
                        MessageBox.Show("Заказ добавлен", "Успешно!", MessageBoxButtons.OK);
                    }
                    else
                        MessageBox.Show("Заполните поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }*/
    }
}
