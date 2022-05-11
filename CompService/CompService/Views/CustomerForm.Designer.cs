
namespace CompService
{
    partial class CustomerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label idOrderLabel1;
            System.Windows.Forms.Label receiptDateLabel1;
            System.Windows.Forms.Label defectDescriptionLabel1;
            System.Windows.Forms.Label serialNumberLabel1;
            System.Windows.Forms.Label completedLabel1;
            System.Windows.Forms.Label label12;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.myOrdersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.welcomeTabPage = new System.Windows.Forms.TabPage();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.ordersCustomerTabPage = new System.Windows.Forms.TabPage();
            this.ordersGridView = new System.Windows.Forms.DataGridView();
            this.Order_IdOrder = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_PhoneNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_ReceiptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_CompletionDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_DefectDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_SerialNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_Completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Order_ServiceNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_MasterNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_IdPart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_PartName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Order_IdCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.allowCompletionDateCheckBox = new System.Windows.Forms.CheckBox();
            this.completionDateSearchTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.allowDateCheckBox = new System.Windows.Forms.CheckBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.idSearchOrderTextBox = new System.Windows.Forms.TextBox();
            this.defectDescriptionSearchTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberSearchTextBox = new System.Windows.Forms.TextBox();
            this.receiptDateSearchTimePicker = new System.Windows.Forms.DateTimePicker();
            this.completedSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.accountCustomerTabPage = new System.Windows.Forms.TabPage();
            this.passwordEnableButton = new System.Windows.Forms.Button();
            this.myPhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.saveChanges = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.myOldPasswordTextBox = new System.Windows.Forms.TextBox();
            this.myNewPasswordTextBox = new System.Windows.Forms.TextBox();
            this.myFullNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.myLoginTextBox = new System.Windows.Forms.TextBox();
            this.newOrderTabPage = new System.Windows.Forms.TabPage();
            this.sendButton = new System.Windows.Forms.Button();
            this.defectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            idOrderLabel1 = new System.Windows.Forms.Label();
            receiptDateLabel1 = new System.Windows.Forms.Label();
            defectDescriptionLabel1 = new System.Windows.Forms.Label();
            serialNumberLabel1 = new System.Windows.Forms.Label();
            completedLabel1 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.welcomeTabPage.SuspendLayout();
            this.ordersCustomerTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).BeginInit();
            this.accountCustomerTabPage.SuspendLayout();
            this.newOrderTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(12, 153);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 19);
            label1.TabIndex = 41;
            label1.Text = "Дата завершения:";
            // 
            // idOrderLabel1
            // 
            idOrderLabel1.AutoSize = true;
            idOrderLabel1.Location = new System.Drawing.Point(12, 58);
            idOrderLabel1.Name = "idOrderLabel1";
            idOrderLabel1.Size = new System.Drawing.Size(77, 19);
            idOrderLabel1.TabIndex = 22;
            idOrderLabel1.Text = "ID Заказа:";
            // 
            // receiptDateLabel1
            // 
            receiptDateLabel1.AutoSize = true;
            receiptDateLabel1.Location = new System.Drawing.Point(12, 94);
            receiptDateLabel1.Name = "receiptDateLabel1";
            receiptDateLabel1.Size = new System.Drawing.Size(90, 19);
            receiptDateLabel1.TabIndex = 28;
            receiptDateLabel1.Text = "Дата сдачи:";
            // 
            // defectDescriptionLabel1
            // 
            defectDescriptionLabel1.AutoSize = true;
            defectDescriptionLabel1.Location = new System.Drawing.Point(12, 215);
            defectDescriptionLabel1.Name = "defectDescriptionLabel1";
            defectDescriptionLabel1.Size = new System.Drawing.Size(142, 19);
            defectDescriptionLabel1.TabIndex = 30;
            defectDescriptionLabel1.Text = "Описание дефекта:";
            // 
            // serialNumberLabel1
            // 
            serialNumberLabel1.AutoSize = true;
            serialNumberLabel1.Location = new System.Drawing.Point(12, 305);
            serialNumberLabel1.Name = "serialNumberLabel1";
            serialNumberLabel1.Size = new System.Drawing.Size(133, 19);
            serialNumberLabel1.TabIndex = 32;
            serialNumberLabel1.Text = "Серийный номер:";
            // 
            // completedLabel1
            // 
            completedLabel1.AutoSize = true;
            completedLabel1.Location = new System.Drawing.Point(12, 335);
            completedLabel1.Name = "completedLabel1";
            completedLabel1.Size = new System.Drawing.Size(104, 19);
            completedLabel1.TabIndex = 34;
            completedLabel1.Text = "Не выполнен:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label12.Location = new System.Drawing.Point(41, 60);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(218, 23);
            label12.TabIndex = 44;
            label12.Text = "Описание неисправности:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.myOrdersToolStripMenuItem,
            this.accountToolStripMenuItem,
            this.newOrderToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1192, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // myOrdersToolStripMenuItem
            // 
            this.myOrdersToolStripMenuItem.Name = "myOrdersToolStripMenuItem";
            this.myOrdersToolStripMenuItem.Size = new System.Drawing.Size(103, 23);
            this.myOrdersToolStripMenuItem.Text = "Мои заказы";
            this.myOrdersToolStripMenuItem.Click += new System.EventHandler(this.MyOrdersToolStripMenuItem_Click);
            // 
            // accountToolStripMenuItem
            // 
            this.accountToolStripMenuItem.Name = "accountToolStripMenuItem";
            this.accountToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.accountToolStripMenuItem.Text = "Аккаунт";
            this.accountToolStripMenuItem.Click += new System.EventHandler(this.AccountToolStripMenuItem_Click);
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(133, 23);
            this.newOrderToolStripMenuItem.Text = "Оставить заявку";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.NewOrderToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.welcomeTabPage);
            this.tabControl.Controls.Add(this.ordersCustomerTabPage);
            this.tabControl.Controls.Add(this.accountCustomerTabPage);
            this.tabControl.Controls.Add(this.newOrderTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1192, 560);
            this.tabControl.TabIndex = 2;
            // 
            // welcomeTabPage
            // 
            this.welcomeTabPage.Controls.Add(this.welcomeLabel);
            this.welcomeTabPage.Location = new System.Drawing.Point(4, 28);
            this.welcomeTabPage.Name = "welcomeTabPage";
            this.welcomeTabPage.Size = new System.Drawing.Size(1184, 528);
            this.welcomeTabPage.TabIndex = 2;
            this.welcomeTabPage.Text = "Добро пожаловать";
            this.welcomeTabPage.UseVisualStyleBackColor = true;
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.welcomeLabel.Font = new System.Drawing.Font("Calibri", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.welcomeLabel.Location = new System.Drawing.Point(0, 0);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Padding = new System.Windows.Forms.Padding(20);
            this.welcomeLabel.Size = new System.Drawing.Size(467, 99);
            this.welcomeLabel.TabIndex = 0;
            this.welcomeLabel.Text = "Добро пожаловать!";
            this.welcomeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ordersCustomerTabPage
            // 
            this.ordersCustomerTabPage.BackColor = System.Drawing.Color.SeaShell;
            this.ordersCustomerTabPage.Controls.Add(this.ordersGridView);
            this.ordersCustomerTabPage.Controls.Add(this.allowCompletionDateCheckBox);
            this.ordersCustomerTabPage.Controls.Add(label1);
            this.ordersCustomerTabPage.Controls.Add(this.completionDateSearchTimePicker);
            this.ordersCustomerTabPage.Controls.Add(this.label9);
            this.ordersCustomerTabPage.Controls.Add(this.allowDateCheckBox);
            this.ordersCustomerTabPage.Controls.Add(this.searchButton);
            this.ordersCustomerTabPage.Controls.Add(idOrderLabel1);
            this.ordersCustomerTabPage.Controls.Add(this.idSearchOrderTextBox);
            this.ordersCustomerTabPage.Controls.Add(this.defectDescriptionSearchTextBox);
            this.ordersCustomerTabPage.Controls.Add(this.serialNumberSearchTextBox);
            this.ordersCustomerTabPage.Controls.Add(receiptDateLabel1);
            this.ordersCustomerTabPage.Controls.Add(this.receiptDateSearchTimePicker);
            this.ordersCustomerTabPage.Controls.Add(defectDescriptionLabel1);
            this.ordersCustomerTabPage.Controls.Add(serialNumberLabel1);
            this.ordersCustomerTabPage.Controls.Add(completedLabel1);
            this.ordersCustomerTabPage.Controls.Add(this.completedSearchCheckBox);
            this.ordersCustomerTabPage.Location = new System.Drawing.Point(4, 28);
            this.ordersCustomerTabPage.Name = "ordersCustomerTabPage";
            this.ordersCustomerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.ordersCustomerTabPage.Size = new System.Drawing.Size(1184, 528);
            this.ordersCustomerTabPage.TabIndex = 0;
            this.ordersCustomerTabPage.Text = "Заказы";
            // 
            // ordersGridView
            // 
            this.ordersGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ordersGridView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.ordersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ordersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Order_IdOrder,
            this.Order_FullName,
            this.Order_PhoneNumber,
            this.Order_ReceiptDate,
            this.Order_CompletionDate,
            this.Order_DefectDescription,
            this.Order_SerialNumber,
            this.Order_Completed,
            this.Order_ServiceNames,
            this.Order_MasterNames,
            this.Order_IdPart,
            this.Order_PartName,
            this.Order_IdCustomer});
            this.ordersGridView.Location = new System.Drawing.Point(392, 3);
            this.ordersGridView.Name = "ordersGridView";
            this.ordersGridView.ReadOnly = true;
            this.ordersGridView.RowHeadersVisible = false;
            this.ordersGridView.RowHeadersWidth = 51;
            this.ordersGridView.Size = new System.Drawing.Size(789, 548);
            this.ordersGridView.TabIndex = 42;
            // 
            // Order_IdOrder
            // 
            this.Order_IdOrder.DataPropertyName = "IdOrder";
            this.Order_IdOrder.FillWeight = 70F;
            this.Order_IdOrder.HeaderText = "Номер заказа";
            this.Order_IdOrder.Name = "Order_IdOrder";
            this.Order_IdOrder.ReadOnly = true;
            this.Order_IdOrder.Width = 70;
            // 
            // Order_FullName
            // 
            this.Order_FullName.DataPropertyName = "FullName";
            this.Order_FullName.FillWeight = 200F;
            this.Order_FullName.HeaderText = "Полное имя";
            this.Order_FullName.Name = "Order_FullName";
            this.Order_FullName.ReadOnly = true;
            this.Order_FullName.Width = 200;
            // 
            // Order_PhoneNumber
            // 
            this.Order_PhoneNumber.DataPropertyName = "PhoneNumber";
            this.Order_PhoneNumber.HeaderText = "Номер телефона";
            this.Order_PhoneNumber.Name = "Order_PhoneNumber";
            this.Order_PhoneNumber.ReadOnly = true;
            // 
            // Order_ReceiptDate
            // 
            this.Order_ReceiptDate.DataPropertyName = "ReceiptDate";
            this.Order_ReceiptDate.HeaderText = "Дата поступления";
            this.Order_ReceiptDate.Name = "Order_ReceiptDate";
            this.Order_ReceiptDate.ReadOnly = true;
            // 
            // Order_CompletionDate
            // 
            this.Order_CompletionDate.DataPropertyName = "CompletionDate";
            this.Order_CompletionDate.HeaderText = "Дата завершения";
            this.Order_CompletionDate.Name = "Order_CompletionDate";
            this.Order_CompletionDate.ReadOnly = true;
            // 
            // Order_DefectDescription
            // 
            this.Order_DefectDescription.DataPropertyName = "DefectDescription";
            this.Order_DefectDescription.FillWeight = 200F;
            this.Order_DefectDescription.HeaderText = "Описание дефекта";
            this.Order_DefectDescription.Name = "Order_DefectDescription";
            this.Order_DefectDescription.ReadOnly = true;
            this.Order_DefectDescription.Width = 200;
            // 
            // Order_SerialNumber
            // 
            this.Order_SerialNumber.DataPropertyName = "SerialNumber";
            this.Order_SerialNumber.FillWeight = 120F;
            this.Order_SerialNumber.HeaderText = "Серийный номер";
            this.Order_SerialNumber.Name = "Order_SerialNumber";
            this.Order_SerialNumber.ReadOnly = true;
            this.Order_SerialNumber.Width = 120;
            // 
            // Order_Completed
            // 
            this.Order_Completed.DataPropertyName = "Completed";
            this.Order_Completed.FillWeight = 85F;
            this.Order_Completed.HeaderText = "Завершён";
            this.Order_Completed.Name = "Order_Completed";
            this.Order_Completed.ReadOnly = true;
            this.Order_Completed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Order_Completed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Order_Completed.Width = 85;
            // 
            // Order_ServiceNames
            // 
            this.Order_ServiceNames.DataPropertyName = "ServiceNames";
            this.Order_ServiceNames.FillWeight = 200F;
            this.Order_ServiceNames.HeaderText = "Услуги";
            this.Order_ServiceNames.Name = "Order_ServiceNames";
            this.Order_ServiceNames.ReadOnly = true;
            this.Order_ServiceNames.Width = 200;
            // 
            // Order_MasterNames
            // 
            this.Order_MasterNames.DataPropertyName = "MasterNames";
            this.Order_MasterNames.FillWeight = 200F;
            this.Order_MasterNames.HeaderText = "Мастеры";
            this.Order_MasterNames.Name = "Order_MasterNames";
            this.Order_MasterNames.ReadOnly = true;
            this.Order_MasterNames.Width = 200;
            // 
            // Order_IdPart
            // 
            this.Order_IdPart.DataPropertyName = "IdPart";
            this.Order_IdPart.FillWeight = 80F;
            this.Order_IdPart.HeaderText = "Номер запчаcти";
            this.Order_IdPart.Name = "Order_IdPart";
            this.Order_IdPart.ReadOnly = true;
            this.Order_IdPart.Visible = false;
            this.Order_IdPart.Width = 80;
            // 
            // Order_PartName
            // 
            this.Order_PartName.DataPropertyName = "PartName";
            this.Order_PartName.FillWeight = 180F;
            this.Order_PartName.HeaderText = "Запчасти";
            this.Order_PartName.Name = "Order_PartName";
            this.Order_PartName.ReadOnly = true;
            this.Order_PartName.Width = 180;
            // 
            // Order_IdCustomer
            // 
            this.Order_IdCustomer.DataPropertyName = "IdCustomer";
            this.Order_IdCustomer.FillWeight = 80F;
            this.Order_IdCustomer.HeaderText = "Номер клиента";
            this.Order_IdCustomer.Name = "Order_IdCustomer";
            this.Order_IdCustomer.ReadOnly = true;
            this.Order_IdCustomer.Visible = false;
            this.Order_IdCustomer.Width = 80;
            // 
            // allowCompletionDateCheckBox
            // 
            this.allowCompletionDateCheckBox.Location = new System.Drawing.Point(159, 178);
            this.allowCompletionDateCheckBox.Name = "allowCompletionDateCheckBox";
            this.allowCompletionDateCheckBox.Size = new System.Drawing.Size(227, 24);
            this.allowCompletionDateCheckBox.TabIndex = 4;
            this.allowCompletionDateCheckBox.Text = "Учитывать дату завершения";
            this.allowCompletionDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // completionDateSearchTimePicker
            // 
            this.completionDateSearchTimePicker.Location = new System.Drawing.Point(160, 149);
            this.completionDateSearchTimePicker.Name = "completionDateSearchTimePicker";
            this.completionDateSearchTimePicker.Size = new System.Drawing.Size(216, 27);
            this.completionDateSearchTimePicker.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(21, 7);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(186, 39);
            this.label9.TabIndex = 40;
            this.label9.Text = "Мои заказы";
            // 
            // allowDateCheckBox
            // 
            this.allowDateCheckBox.Location = new System.Drawing.Point(160, 119);
            this.allowDateCheckBox.Name = "allowDateCheckBox";
            this.allowDateCheckBox.Size = new System.Drawing.Size(200, 24);
            this.allowDateCheckBox.TabIndex = 2;
            this.allowDateCheckBox.Text = "Учитывать дату сдачи";
            this.allowDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(302, 383);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 27);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // idSearchOrderTextBox
            // 
            this.idSearchOrderTextBox.Location = new System.Drawing.Point(160, 55);
            this.idSearchOrderTextBox.Name = "idSearchOrderTextBox";
            this.idSearchOrderTextBox.Size = new System.Drawing.Size(216, 27);
            this.idSearchOrderTextBox.TabIndex = 0;
            // 
            // defectDescriptionSearchTextBox
            // 
            this.defectDescriptionSearchTextBox.Location = new System.Drawing.Point(160, 212);
            this.defectDescriptionSearchTextBox.Multiline = true;
            this.defectDescriptionSearchTextBox.Name = "defectDescriptionSearchTextBox";
            this.defectDescriptionSearchTextBox.Size = new System.Drawing.Size(216, 84);
            this.defectDescriptionSearchTextBox.TabIndex = 5;
            // 
            // serialNumberSearchTextBox
            // 
            this.serialNumberSearchTextBox.Location = new System.Drawing.Point(160, 302);
            this.serialNumberSearchTextBox.Name = "serialNumberSearchTextBox";
            this.serialNumberSearchTextBox.Size = new System.Drawing.Size(216, 27);
            this.serialNumberSearchTextBox.TabIndex = 6;
            // 
            // receiptDateSearchTimePicker
            // 
            this.receiptDateSearchTimePicker.Location = new System.Drawing.Point(160, 90);
            this.receiptDateSearchTimePicker.Name = "receiptDateSearchTimePicker";
            this.receiptDateSearchTimePicker.Size = new System.Drawing.Size(216, 27);
            this.receiptDateSearchTimePicker.TabIndex = 1;
            // 
            // completedSearchCheckBox
            // 
            this.completedSearchCheckBox.Location = new System.Drawing.Point(160, 335);
            this.completedSearchCheckBox.Name = "completedSearchCheckBox";
            this.completedSearchCheckBox.Size = new System.Drawing.Size(200, 24);
            this.completedSearchCheckBox.TabIndex = 7;
            this.completedSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // accountCustomerTabPage
            // 
            this.accountCustomerTabPage.BackColor = System.Drawing.Color.SeaShell;
            this.accountCustomerTabPage.Controls.Add(this.passwordEnableButton);
            this.accountCustomerTabPage.Controls.Add(this.myPhoneNumberTextBox);
            this.accountCustomerTabPage.Controls.Add(this.label10);
            this.accountCustomerTabPage.Controls.Add(this.saveChanges);
            this.accountCustomerTabPage.Controls.Add(this.label8);
            this.accountCustomerTabPage.Controls.Add(this.repeatPasswordTextBox);
            this.accountCustomerTabPage.Controls.Add(this.label7);
            this.accountCustomerTabPage.Controls.Add(this.label6);
            this.accountCustomerTabPage.Controls.Add(this.label5);
            this.accountCustomerTabPage.Controls.Add(this.label4);
            this.accountCustomerTabPage.Controls.Add(this.label3);
            this.accountCustomerTabPage.Controls.Add(this.myOldPasswordTextBox);
            this.accountCustomerTabPage.Controls.Add(this.myNewPasswordTextBox);
            this.accountCustomerTabPage.Controls.Add(this.myFullNameTextBox);
            this.accountCustomerTabPage.Controls.Add(this.label2);
            this.accountCustomerTabPage.Controls.Add(this.myLoginTextBox);
            this.accountCustomerTabPage.Location = new System.Drawing.Point(4, 28);
            this.accountCustomerTabPage.Name = "accountCustomerTabPage";
            this.accountCustomerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.accountCustomerTabPage.Size = new System.Drawing.Size(1184, 528);
            this.accountCustomerTabPage.TabIndex = 1;
            this.accountCustomerTabPage.Text = "Аккаунт";
            // 
            // passwordEnableButton
            // 
            this.passwordEnableButton.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passwordEnableButton.Location = new System.Drawing.Point(28, 277);
            this.passwordEnableButton.Name = "passwordEnableButton";
            this.passwordEnableButton.Size = new System.Drawing.Size(173, 24);
            this.passwordEnableButton.TabIndex = 7;
            this.passwordEnableButton.Text = "Вкл/выкл изменение пароля";
            this.passwordEnableButton.UseVisualStyleBackColor = true;
            this.passwordEnableButton.Click += new System.EventHandler(this.PasswordEnableButton_Click);
            // 
            // myPhoneNumberTextBox
            // 
            this.myPhoneNumberTextBox.Location = new System.Drawing.Point(163, 120);
            this.myPhoneNumberTextBox.Mask = "80000000000";
            this.myPhoneNumberTextBox.Name = "myPhoneNumberTextBox";
            this.myPhoneNumberTextBox.Size = new System.Drawing.Size(195, 27);
            this.myPhoneNumberTextBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(25, 123);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 19);
            this.label10.TabIndex = 54;
            this.label10.Text = "Номер телефона:";
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(37, 358);
            this.saveChanges.Margin = new System.Windows.Forms.Padding(2);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(179, 42);
            this.saveChanges.TabIndex = 8;
            this.saveChanges.Text = "Сохранить изменения";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.SaveChanges_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(25, 251);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(176, 19);
            this.label8.TabIndex = 51;
            this.label8.Text = "Подтверждение пароля:";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Enabled = false;
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(208, 249);
            this.repeatPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.repeatPasswordTextBox.MaxLength = 30;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(195, 27);
            this.repeatPasswordTextBox.TabIndex = 6;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(142, 162);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 19);
            this.label7.TabIndex = 3;
            this.label7.Text = "Изменение пароля";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(25, 221);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(111, 19);
            this.label6.TabIndex = 48;
            this.label6.Text = "Новый пароль:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 191);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 19);
            this.label5.TabIndex = 47;
            this.label5.Text = "Старый пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 59);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 19);
            this.label4.TabIndex = 46;
            this.label4.Text = "Полное имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 92);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 45;
            this.label3.Text = "Логин:";
            // 
            // myOldPasswordTextBox
            // 
            this.myOldPasswordTextBox.Enabled = false;
            this.myOldPasswordTextBox.Location = new System.Drawing.Point(208, 188);
            this.myOldPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.myOldPasswordTextBox.MaxLength = 30;
            this.myOldPasswordTextBox.Name = "myOldPasswordTextBox";
            this.myOldPasswordTextBox.Size = new System.Drawing.Size(195, 27);
            this.myOldPasswordTextBox.TabIndex = 4;
            // 
            // myNewPasswordTextBox
            // 
            this.myNewPasswordTextBox.Enabled = false;
            this.myNewPasswordTextBox.Location = new System.Drawing.Point(208, 219);
            this.myNewPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.myNewPasswordTextBox.MaxLength = 30;
            this.myNewPasswordTextBox.Name = "myNewPasswordTextBox";
            this.myNewPasswordTextBox.Size = new System.Drawing.Size(195, 27);
            this.myNewPasswordTextBox.TabIndex = 5;
            // 
            // myFullNameTextBox
            // 
            this.myFullNameTextBox.Location = new System.Drawing.Point(163, 59);
            this.myFullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.myFullNameTextBox.Name = "myFullNameTextBox";
            this.myFullNameTextBox.Size = new System.Drawing.Size(195, 27);
            this.myFullNameTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 39);
            this.label2.TabIndex = 41;
            this.label2.Text = "Мой аккаунт";
            // 
            // myLoginTextBox
            // 
            this.myLoginTextBox.Location = new System.Drawing.Point(163, 89);
            this.myLoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.myLoginTextBox.Name = "myLoginTextBox";
            this.myLoginTextBox.Size = new System.Drawing.Size(195, 27);
            this.myLoginTextBox.TabIndex = 1;
            // 
            // newOrderTabPage
            // 
            this.newOrderTabPage.BackColor = System.Drawing.Color.SeaShell;
            this.newOrderTabPage.Controls.Add(this.sendButton);
            this.newOrderTabPage.Controls.Add(label12);
            this.newOrderTabPage.Controls.Add(this.defectDescriptionTextBox);
            this.newOrderTabPage.Controls.Add(this.label11);
            this.newOrderTabPage.Location = new System.Drawing.Point(4, 28);
            this.newOrderTabPage.Name = "newOrderTabPage";
            this.newOrderTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newOrderTabPage.Size = new System.Drawing.Size(1184, 528);
            this.newOrderTabPage.TabIndex = 3;
            this.newOrderTabPage.Text = "Оставить заявку";
            // 
            // sendButton
            // 
            this.sendButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sendButton.Location = new System.Drawing.Point(48, 390);
            this.sendButton.Name = "sendButton";
            this.sendButton.Size = new System.Drawing.Size(94, 36);
            this.sendButton.TabIndex = 1;
            this.sendButton.Text = "Отправить";
            this.sendButton.UseVisualStyleBackColor = true;
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // defectDescriptionTextBox
            // 
            this.defectDescriptionTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.defectDescriptionTextBox.Location = new System.Drawing.Point(28, 92);
            this.defectDescriptionTextBox.MaxLength = 1000;
            this.defectDescriptionTextBox.Multiline = true;
            this.defectDescriptionTextBox.Name = "defectDescriptionTextBox";
            this.defectDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.defectDescriptionTextBox.Size = new System.Drawing.Size(1132, 288);
            this.defectDescriptionTextBox.TabIndex = 0;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(21, 7);
            this.label11.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(242, 39);
            this.label11.TabIndex = 42;
            this.label11.Text = "Оставить заявку";
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1192, 589);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(3840, 628);
            this.MinimumSize = new System.Drawing.Size(450, 628);
            this.Name = "CustomerForm";
            this.Text = "Клиент";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.CustomerForm_FormClosed);
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.welcomeTabPage.ResumeLayout(false);
            this.welcomeTabPage.PerformLayout();
            this.ordersCustomerTabPage.ResumeLayout(false);
            this.ordersCustomerTabPage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ordersGridView)).EndInit();
            this.accountCustomerTabPage.ResumeLayout(false);
            this.accountCustomerTabPage.PerformLayout();
            this.newOrderTabPage.ResumeLayout(false);
            this.newOrderTabPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem myOrdersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ordersCustomerTabPage;
        private System.Windows.Forms.TabPage accountCustomerTabPage;
        private System.Windows.Forms.CheckBox allowCompletionDateCheckBox;
        private System.Windows.Forms.DateTimePicker completionDateSearchTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox allowDateCheckBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox idSearchOrderTextBox;
        private System.Windows.Forms.TextBox defectDescriptionSearchTextBox;
        private System.Windows.Forms.TextBox serialNumberSearchTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateSearchTimePicker;
        private System.Windows.Forms.CheckBox completedSearchCheckBox;
        private System.Windows.Forms.TabPage welcomeTabPage;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox myOldPasswordTextBox;
        private System.Windows.Forms.TextBox myNewPasswordTextBox;
        private System.Windows.Forms.TextBox myFullNameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox myLoginTextBox;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.MaskedTextBox myPhoneNumberTextBox;
        private System.Windows.Forms.Button passwordEnableButton;
        private System.Windows.Forms.TabPage newOrderTabPage;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox defectDescriptionTextBox;
        private System.Windows.Forms.Button sendButton;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.DataGridView ordersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_IdOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_PhoneNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ReceiptDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_CompletionDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_DefectDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_SerialNumber;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Order_Completed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_ServiceNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_MasterNames;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_IdPart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_PartName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Order_IdCustomer;
    }
}