using CompService.Models;
using CompService.Presenters;
using CompService.Supporting;
using CompService.Views;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CompService
{
    public partial class MainForm : TemplateForm, IMainView
    {
        MainPresenter presenter;
        int pageSize = 29;
        int currentPage = 1;

        public MainForm()
        {
            InitializeComponent();
            presenter = new MainPresenter(this);
        }

        #region Pages
        public decimal CurrentPage
        {
            set
            {
                try
                {
                    currentPageNumeric.Value = value;
                }
                catch (ArgumentOutOfRangeException) { }
            }
            get
            {
                return currentPageNumeric.Value;
            }
        }
        public decimal CurrentPageMax
        {
            set
            {
                currentPageNumeric.Maximum = value;
            }
            get
            {
                return currentPageNumeric.Maximum;
            }
        }
        public decimal CurrentPageMin
        {
            set
            {
                currentPageNumeric.Minimum = value;
            }
            get
            {
                return currentPageNumeric.Minimum;
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
        public string ResultsAmount
        {
            set
            {
                resultsAmountLabel.Text = value;
            }
        }
        public bool FirstPage
        {
            set
            {
                firstPageButton.Enabled = value;
            }
        }
        public bool LeftPage
        {
            set
            {
                leftPageButton.Enabled = value;
            }
        }
        public bool RightPage
        {
            set
            {
                rightPageButton.Enabled = value;
            }
        }
        public bool LastPage
        {
            set
            {
                lastPageButton.Enabled = value;
            }
        }
        #endregion

        #region Sort
        public bool DateAscending
        {
            get
            {
                return dateAscendingRadioButton.Checked;
            }
        }

        public bool DateDescending
        {
            get
            {
                return dateDescendingRadioButton.Checked;
            }
        }
        #endregion

        #region CreateOrderInterface
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
        #endregion

        #region EditMaster
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
        #endregion

        #region TablesLoad
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
        #endregion

        #region CheckOutOrder
        public string CheckIdOrder
        {
            set
            {
                checkIdOrderLabel.Text = value;
            }
            get
            {
                return checkIdOrderLabel.Text;
            }
        }
        public string CheckReceiptDate
        {
            set
            {
                checkReceiptDateLabel.Text = value;
            }
            get
            {
                return checkReceiptDateLabel.Text;
            }
        }
        public string CheckCompletionDate
        {
            set
            {
                checkCompletionDateLabel.Text = value;
            }
            get
            {
                return checkCompletionDateLabel.Text;
            }
        }
        public string CheckFullName
        {
            set
            {
                checkFullNameLabel.Text = value;
            }
            get
            {
                return checkFullNameLabel.Text;
            }
        }
        public string CheckPhoneNumber
        {
            set
            {
                checkPhoneNumberLabel.Text = value;
            }
            get
            {
                return checkPhoneNumberLabel.Text;
            }
        }
        public string CheckSerialNumber
        {
            set
            {
                checkSerialNumberLabel.Text = value;
            }
            get
            {
                return checkSerialNumberLabel.Text;
            }
        }
        public string CheckTotalPrice
        {
            set
            {
                checkTotalPriceLabel.Text = value;
            }
            get
            {
                return checkTotalPriceLabel.Text;
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
        public object PartsInOrderData
        {
            set
            {
                partsInOrderGridView.DataSource = value;
            }
            get
            {
                object[][] result = new object[partsInOrderGridView.ColumnCount][];
                for (int i = 0; i < partsInOrderGridView.ColumnCount; i++)
                {
                    result[i] = new object[partsInOrderGridView.RowCount];
                    for (int j = 0; j < partsInOrderGridView.RowCount; j++)
                    {
                        result[i][j] = partsInOrderGridView[i, j].Value;
                    }
                }
                return result;
            }
        }
        public bool PartsGridVisibility
        {
            set
            {
                partsInOrderGridView.Visible = value;
            }
            get
            {
                return partsInOrderGridView.Visible;
            }
        }
        public bool PartsTitleVisibility
        {
            set
            {
                partsTitleLabel.Visible = value;
            }
            get
            {
                return partsTitleLabel.Visible;
            }
        }
        public bool IfCompletedVisibility
        {
            set
            {
                recalculatePriceButton.Visible = closeOrderButton.Visible = value;
            }
        }
        public bool IfCompletedTablesReadonly
        {
            set
            {
                servicesInOrderGridView.ReadOnly = partsInOrderGridView.ReadOnly = value;
            }
        }
        #endregion

        #region Report
        public object MonthlyReportData
        {
            set
            {
                monthlyReportGridView.DataSource = value;
            }
            get
            {
                object[][] result = new object[monthlyReportGridView.ColumnCount][];
                for (int i = 0; i < monthlyReportGridView.ColumnCount; i++)
                {
                    result[i] = new object[monthlyReportGridView.RowCount];
                    for (int j = 0; j < monthlyReportGridView.RowCount; j++)
                    {
                        result[i][j] = monthlyReportGridView[i, j].Value;
                    }
                }
                return result;
            }
        }
        public decimal MonthReport
        {
            set
            {
                monthNumeric.Value = value;
            }
            get
            {
                return monthNumeric.Value;
            }
        }
        public decimal YearReport
        {
            set
            {
                yearNumeric.Value = value;
            }
            get
            {
                return yearNumeric.Value;
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            if (CurrentUser.MasterUser?.User?.Role.ToString() == null)
            {
                adminFeaturesToolStripMenuItem.Visible = changeConnectionPropertiesButton.Visible = true;
                Text = "Администратор";
            }
            else
            {
                currentUserLabel.Text = CurrentUser.MasterUser.FullName.ToString();
                currentUserLabel.Visible = true;
                Text = "Мастер";
            }
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
            presenter.OrdersLoad(); 
            presenter.Navigation(pageSize, currentPage);
            servicesListBox.DisplayMember = "ServiceName";
            servicesInOrderListBox.DisplayMember = "ServiceName";
            mastersListBox.DisplayMember = "FullName";
            mastersInOrderListBox.DisplayMember = "FullName";
            partsListBox.DisplayMember = "PartName";
        }

        #region ToolStrips
        private void SearchOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = searchOrderTab;
            presenter.OrdersLoad();
            presenter.Navigation(pageSize, currentPage);
        }

        private void NewOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            presenter.ClearOrder();
            tabControl.SelectedTab = newOrderTab;
            editLabel.Visible = false;
            addLabel.Visible = true;
            completedEditCheckBox.Visible = false;
            enableCompletionDateCheckBox.Visible = false;
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

        private void ToReportOutputToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTab = monthlyReportTab;
            presenter.LoadDateNow();
        }
        #endregion

        #region SearchOrder
        private void SearchButton_Click(object sender, EventArgs e)
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
            presenter.Navigation(pageSize, currentPage);
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
                editLabel.Visible = enableCompletionDateCheckBox.Visible = true;
                addLabel.Visible = accountLinkButton.Visible = false;
                completedEditCheckBox.Visible = true;
                tabControl.SelectedTab = newOrderTab;
            }
        }

        private void CheckOutOrderButton_Click(object sender, EventArgs e)
        {
            int selectedOrderId = Convert.ToInt32(searchGridView.CurrentRow.Cells[0].Value);
            presenter.CheckOutLoad(selectedOrderId);
            tabControl.SelectedTab = checkOutOrderTab;
        }

        #endregion

        #region Navigation
        private void FirstPageButton_Click(object sender, EventArgs e)
        {
            currentPageNumeric.Value = 1;
        }

        private void LeftPageButton_Click(object sender, EventArgs e)
        {
            if (currentPageNumeric.Value > currentPageNumeric.Minimum)
                currentPageNumeric.Value--;
        }

        private void RightPageButton_Click(object sender, EventArgs e)
        {
            if (currentPageNumeric.Value < currentPageNumeric.Maximum)
                currentPageNumeric.Value++;
        }

        private void LastPageButton_Click(object sender, EventArgs e)
        {
            currentPageNumeric.Value = currentPageNumeric.Maximum;
        }

        private void CurrentPageNumeric_ValueChanged(object sender, EventArgs e)
        {
            currentPage = (int)currentPageNumeric.Value;
            presenter.Navigation(pageSize, currentPage);
        }
        #endregion

        #region NewOrder/EditOrder
        private void AccountLinkButton_Click(object sender, EventArgs e)
        {
            try
            {
                CustomerLink customerLink = new CustomerLink();
                if (customerLink.ShowDialog() == DialogResult.OK)
                {
                    presenter.ParceCustomer();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SwitchItemListBox(ListBox sender, ListBox receiver)
        {
            try
            {
                if (sender.SelectedItem != null)
                {
                    var item = sender.SelectedItem;
                    receiver.Items.Add(item);
                    sender.Items.Remove(item);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                Part part = new Part();
                var form = new NewPartForm(ref part);
                if (form.ShowDialog() == DialogResult.OK)
                {
                    partsListBox.Items.Add(part);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void DeletePartListBox(ListBox sender)
        {
            try
            {
                if (sender.SelectedItem != null)
                {
                    var item = sender.SelectedItem;
                    sender.Items.Remove(item);
                    if (Core.Context.Parts.Equals(item))
                        Core.Context.Parts.Remove(item as Part);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeletePartButton_Click(object sender, EventArgs e)
        {
            DeletePartListBox(partsListBox);
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            presenter.SaveOrder();
            presenter.Navigation(pageSize, currentPage);
            tabControl.SelectedTab = searchOrderTab;
        }

        private void EnableCompletionDateCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (enableCompletionDateCheckBox.Checked)
                completionDateDateTimePicker.Enabled = true;
            else
                completionDateDateTimePicker.Enabled = false;
        }
        #endregion

        #region Sort
        private void SortButton_Click(object sender, EventArgs e)
        {
            presenter.SortOrders(completedCheckBox.Checked);
        }
        #endregion

        #region MasterEdit
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
            presenter.Navigation(pageSize, currentPage);
            tabControl.SelectedTab = searchOrderTab;
        }
        #endregion

        #region CheckOut
        private void RecalculatePriceButton_Click(object sender, EventArgs e)
        {
            presenter.RecalculateTotalPrice();
        }

        private void SaveCheckButton_Click(object sender, EventArgs e)
        {
            presenter.CheckPrinting();
        }

        private void CloseOrderButton_Click(object sender, EventArgs e)
        {
            presenter.CloseOrder();
            tabControl.SelectedTab = searchOrderTab;
            presenter.Navigation(pageSize, currentPage);
        }
        #endregion

        #region Report
        private void ExportReportButton_Click(object sender, EventArgs e)
        {
            presenter.ExportReport(monthlyReportGridView.RowCount);
        }

        private void ReportDate_ValueChanged(object sender, EventArgs e)
        {
            presenter.LoadReportData();
        }
        #endregion

        private void ChangeConnectionPropertiesButton_Click(object sender, EventArgs e)
        {
            ConnectionForm connection = new ConnectionForm();
            connection.Show();
            Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}