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
    public partial class MainForm : TemplateForm, IMainView
    {
        MainPresenter presenter;
        int pageSize = 7;
        int currentPage = 1;

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        public object[] Masters
        {
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


        public decimal CurrentPage
        {
            set
            {
                currentPageNumeric.Value = value;
            }
            get
            {
                return currentPageNumeric.Value;
            }
        }
        public string TotalPages
        {
            set
            {
                totalPagesLabel.Text = value;
            }
            get
            {
                return totalPagesLabel.Text;
            }
        }

        public string FullName
        {
            set
            {
                fullNameTextBox.Text = value;
            }
            get
            {
                return fullNameTextBox.Text;
            }
        }
        public string PhoneNumber
        {
            set
            {
                phoneNumberTextBox.Text = value;
            }
            get
            {
                return phoneNumberTextBox.Text;
            }
        }
        public DateTime ReceiptDate
        {
            set
            {
                receiptDateDateTimePicker.Value = value;
            }
            get
            {
                return receiptDateDateTimePicker.Value.Date;
            }
        }
        public DateTime CompletionDate
        {
            set
            {
                completionDateDateTimePicker.Value = value;
            }
            get
            {
                return completionDateDateTimePicker.Value.Date;
            }
        }
        public bool EnableCompletionDate
        {
            set
            {
                enableCompletionDateCheckBox.Checked = value;
            }
            get
            {
                return enableCompletionDateCheckBox.Checked;
            }
        }
        public bool CompletedSearch
        {
            set
            {
                completedEditCheckBox.Checked = value;
            }
            get
            {
                return completedEditCheckBox.Checked;
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
        public string SerialNumber
        {
            set
            {
                serialNumberTextBox.Text = value;
            }
            get
            {
                return serialNumberTextBox.Text;
            }
        }
        public object[] EditServicesInOrder
        {
            set
            {
                servicesInOrderListBox.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                    {
                        servicesInOrderListBox.Items.Add(item);
                    }
                }
            }
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
        public object[] EditMastersInOrder
        {
            set
            {
                mastersInOrderListBox.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                    {
                        mastersInOrderListBox.Items.Add(item);
                    }
                }
            }
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
        public object[] EditServices
        {
            set
            {
                servicesListBox.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                    {
                        servicesListBox.Items.Add(item);
                    }
                }
            }
            get
            {
                var data = new object[servicesListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = servicesListBox.Items[i];
                }
                return data;
            }
        }
        public object[] EditMasters
        {
            set
            {
                mastersListBox.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                    {
                        mastersListBox.Items.Add(item);
                    }
                }
            }
            get
            {
                var data = new object[mastersListBox.Items.Count];
                for (int i = 0; i < data.Length; i++)
                {
                    data[i] = mastersListBox.Items[i];
                }
                return data;
            }
        }
        public object[] EditParts
        {
            set
            {
                partsListBox.Items.Clear();
                if (value != null)
                {
                    foreach (var item in value)
                    {
                        partsListBox.Items.Add(item);
                    }
                }
            }
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

        public string MasterName
        {
            set
            {
                masterFullNameTextBox.Text = value;
            }
            get
            {
                return masterFullNameTextBox.Text;
            }
        }
        public string MasterLogin
        {
            set
            {
                masterLoginTextBox.Text = value;
            }
            get
            {
                return masterLoginTextBox.Text;
            }
        }
        public string MasterPassword
        {
            set
            {
                masterPasswordTextBox.Text = value;
            }
            get
            {
                return masterPasswordTextBox.Text;
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
            get
            {
                object[][] result = new object[searchGridView.ColumnCount][];
                for (int i = 0; i < searchGridView.ColumnCount; i++)
                {
                    result[i] = new object[searchGridView.RowCount];
                    for (int j = 0; j < searchGridView.RowCount; j++)
                    {
                        result[i][j] = searchGridView[i, j].Value;
                    }
                }
                return result;
            }
        }
        public object MastersData
        {
            set
            {
                mastersGridView.DataSource = value;
            }
        }

        public object ServicesInOrderData
        {
            set
            {
                servicesInOrderGridView.DataSource = value;
            }
            get
            {
                object[][] result = new object[servicesInOrderGridView.ColumnCount][];
                for (int i = 0; i < servicesInOrderGridView.ColumnCount; i++)
                {
                    result[i] = new object[servicesInOrderGridView.RowCount];
                    for (int j = 0; j < servicesInOrderGridView.RowCount; j++)
                    {
                        result[i][j] = servicesInOrderGridView[i, j].Value;
                    }
                }
                return result;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CurrentUser.MasterUser?.User?.Role.ToString() == null)
                adminFeaturesToolStripMenuItem.Visible = true;
            else
            {
                currentUserLabel.Text = CurrentUser.MasterUser.FullName.ToString();
                currentUserLabel.Visible = true;
            }
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            presenter.OrdersLoad();
            servicesListBox.DisplayMember = "ServiceName";
            servicesInOrderListBox.DisplayMember = "ServiceName";
            mastersListBox.DisplayMember = "FullName";
            mastersInOrderListBox.DisplayMember = "FullName";
            partsListBox.DisplayMember = "PartName";
        }

        private void SearchOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = searchOrderTab;
            presenter.OrdersLoad();
        }

        private void NewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.ClearOrder();
            tabControl.SelectedTab = newOrderTab;
            editLabel.Visible = false;
            addLabel.Visible = true;
            completedEditCheckBox.Visible = false;
            accountLinkButton.Visible = true; 
        }

        private void ListOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = listOrderTab;
            presenter.SortOrders(completedCheckBox.Checked);
        }
        private void ToEditMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = mastersTableTab;
            mastersGridView.DataSource = Core.Context.MasterInfoes.ToArray();
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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            presenter.SaveOrder();
            MessageBox.Show("Успешко!", "Сохранено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            presenter.OrdersLoad();
            tabControl.SelectedTab = searchOrderTab;
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

        private void ToEditOrderButton_Click(object sender, EventArgs e)
        {
            if (searchGridView.CurrentRow != null)
            {
                int selectedOrderId = Convert.ToInt32(searchGridView.CurrentRow.Cells[0].Value);  
                presenter.EditOrdersLoad(selectedOrderId);
                servicesListBox.DisplayMember = "ServiceName";
                servicesInOrderListBox.DisplayMember = "ServiceName";
                mastersListBox.DisplayMember = "FullName";
                mastersInOrderListBox.DisplayMember = "FullName";
                partsListBox.DisplayMember = "PartName";
                editLabel.Visible = true;    
                addLabel.Visible = false;
                completedEditCheckBox.Visible = true;
                accountLinkButton.Visible = false;
                tabControl.SelectedTab = newOrderTab;
            }
        }
        private void CheckOutOrderButton_Click(object sender, EventArgs e)
        {
            int selectedOrderId = Convert.ToInt32(searchGridView.CurrentRow.Cells[0].Value);
            presenter.CheckOutLoad(selectedOrderId);
            tabControl.SelectedTab = checkOutOrderTab;
        }

        private void SearchMasterButton_Click(object sender, EventArgs e)
        {
            presenter.SortMasters(searchTextBox.Text, fullNameRadioButton.Checked);
        }

        private void ChooseMasterButton_Click(object sender, EventArgs e)
        {
            int selectedMasterId = Convert.ToInt32(mastersGridView.CurrentRow.Cells[0].Value);
            presenter.EditMasterLoad(selectedMasterId);
            masterLabel.Text = "Редактирование аккаунта мастера";
            tabControl.SelectedTab = editMasterTab;
        }
        private void CreateMasterButton_Click(object sender, EventArgs e)
        {
            masterLabel.Text = "Создание аккаунта мастера";
            tabControl.SelectedTab = editMasterTab;
        }
        private void SaveMasterInfoButton_Click(object sender, EventArgs e)
        {
            presenter.SaveMaster();
            MessageBox.Show("Успешко!", "Сохранено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            presenter.OrdersLoad();
            tabControl.SelectedTab = searchOrderTab;
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
        public void DeletePartListBox(ListBox sender)
        {
            if (sender.SelectedItem != null)
            {
                var item = sender.SelectedItem;
                sender.Items.Remove(item);
                if (Core.Context.Parts.Equals(item))
                    Core.Context.Parts.Remove(item as Part);
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

        private void AccountLinkButton_Click(object sender, EventArgs e)
        {
            CustomerLink customerLink = new CustomerLink();
            if (customerLink.ShowDialog() == DialogResult.OK)
            {
                presenter.ParceCustomer();
            }
        }

        private void SaveChangesButton_Click(object sender, EventArgs e)
        {
            presenter.SaveOrder();
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            DeletePartListBox(partsListBox);
        }

        private void EnableCompletionDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableCompletionDateCheckBox.Checked)
                completionDateDateTimePicker.Enabled = true;
            else
                completionDateDateTimePicker.Enabled = false;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.CheckPrinting();
        }

        private void FirstPageButton_Click(object sender, EventArgs e)
        {
            //countOfPages = 1;
            //currentPageNumeric.Value = 1;
            //ToFirstButton.Enabled = ToPreviousButton.Enabled = false;
            //ShowButton.Enabled = ToLastButton.Enabled = ToNextButton.Enabled = currentPage < totalPages;
        }

        private void LeftPageButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void RightPageButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            //
        }

        private void CurrentPageNumeric_ValueChanged(object sender, EventArgs e)
        {
            presenter.LoadData(pageSize, currentPage);
            currentPageNumeric.Maximum = Convert.ToInt32(totalPagesLabel.Text);
        }

        private void ChangeConnectionPropertiesButton_Click(object sender, EventArgs e)
        {
            ConnectionForm connection = new ConnectionForm();
            connection.Show();
            Hide();
        }
    }
}
