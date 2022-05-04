
namespace CompService
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label20;
            System.Windows.Forms.Label completedLabel1;
            System.Windows.Forms.Label serialNumberLabel1;
            System.Windows.Forms.Label defectDescriptionLabel1;
            System.Windows.Forms.Label receiptDateLabel1;
            System.Windows.Forms.Label phoneNumberLabel1;
            System.Windows.Forms.Label fullNameLabel1;
            System.Windows.Forms.Label idOrderLabel1;
            System.Windows.Forms.Label label1;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newOrderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.orderListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminFeaturesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToEditMasterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listOrderTab = new System.Windows.Forms.TabPage();
            this.sortButton = new System.Windows.Forms.Button();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.sortGridView = new System.Windows.Forms.DataGridView();
            this.newOrderTab = new System.Windows.Forms.TabPage();
            this.accountLinkButton = new System.Windows.Forms.Button();
            this.enableCompletionDateCheckBox = new System.Windows.Forms.CheckBox();
            this.deletePartButton = new System.Windows.Forms.Button();
            this.completionDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.editLabel = new System.Windows.Forms.Label();
            this.completedEditCheckBox = new System.Windows.Forms.CheckBox();
            this.addPartButton = new System.Windows.Forms.Button();
            this.partsListBox = new System.Windows.Forms.ListBox();
            this.rightMastersButton = new System.Windows.Forms.Button();
            this.leftMastersButton = new System.Windows.Forms.Button();
            this.mastersListBox = new System.Windows.Forms.ListBox();
            this.mastersInOrderListBox = new System.Windows.Forms.ListBox();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.rightServicesButton = new System.Windows.Forms.Button();
            this.leftServicesButton = new System.Windows.Forms.Button();
            this.servicesListBox = new System.Windows.Forms.ListBox();
            this.servicesInOrderListBox = new System.Windows.Forms.ListBox();
            this.addLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.defectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.receiptDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.searchOrderTab = new System.Windows.Forms.TabPage();
            this.currentPageNumeric = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.totalPagesLabel = new System.Windows.Forms.Label();
            this.lastPageButton = new System.Windows.Forms.Button();
            this.rightPageButton = new System.Windows.Forms.Button();
            this.leftPageButton = new System.Windows.Forms.Button();
            this.firstPageButton = new System.Windows.Forms.Button();
            this.checkOutOrderButton = new System.Windows.Forms.Button();
            this.allowCompletionDateCheckBox = new System.Windows.Forms.CheckBox();
            this.completionDateSearchTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.toEditOrderButton = new System.Windows.Forms.Button();
            this.allowDateCheckBox = new System.Windows.Forms.CheckBox();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.idSearchOrderTextBox = new System.Windows.Forms.TextBox();
            this.fullNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberSearchTextBox = new System.Windows.Forms.TextBox();
            this.defectDescriptionSearchTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberSearchTextBox = new System.Windows.Forms.TextBox();
            this.receiptDateSearchTimePicker = new System.Windows.Forms.DateTimePicker();
            this.completedSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.mastersTableTab = new System.Windows.Forms.TabPage();
            this.createMasterButton = new System.Windows.Forms.Button();
            this.chooseMasterButton = new System.Windows.Forms.Button();
            this.searchMasterButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.loginRadioButton = new System.Windows.Forms.RadioButton();
            this.fullNameRadioButton = new System.Windows.Forms.RadioButton();
            this.mastersGridView = new System.Windows.Forms.DataGridView();
            this.editMasterTab = new System.Windows.Forms.TabPage();
            this.saveMasterInfoButton = new System.Windows.Forms.Button();
            this.masterLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.masterPasswordTextBox = new System.Windows.Forms.TextBox();
            this.masterFullNameTextBox = new System.Windows.Forms.TextBox();
            this.masterLoginTextBox = new System.Windows.Forms.TextBox();
            this.checkOutOrderTab = new System.Windows.Forms.TabPage();
            this.partsInOrderGridView = new System.Windows.Forms.DataGridView();
            this.servicesInOrderGridView = new System.Windows.Forms.DataGridView();
            this.end = new System.Windows.Forms.Button();
            this.currentUserLabel = new System.Windows.Forms.Label();
            this.changeConnectionPropertiesButton = new System.Windows.Forms.Button();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label20 = new System.Windows.Forms.Label();
            completedLabel1 = new System.Windows.Forms.Label();
            serialNumberLabel1 = new System.Windows.Forms.Label();
            defectDescriptionLabel1 = new System.Windows.Forms.Label();
            receiptDateLabel1 = new System.Windows.Forms.Label();
            phoneNumberLabel1 = new System.Windows.Forms.Label();
            fullNameLabel1 = new System.Windows.Forms.Label();
            idOrderLabel1 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.listOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortGridView)).BeginInit();
            this.newOrderTab.SuspendLayout();
            this.searchOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPageNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.tabControl.SuspendLayout();
            this.mastersTableTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastersGridView)).BeginInit();
            this.editMasterTab.SuspendLayout();
            this.checkOutOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsInOrderGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesInOrderGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(45, 336);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(133, 19);
            label7.TabIndex = 21;
            label7.Text = "Серийный номер:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(44, 205);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(142, 19);
            label6.TabIndex = 20;
            label6.Text = "Описание дефекта:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(44, 136);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 19);
            label5.TabIndex = 19;
            label5.Text = "Дата сдачи:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(44, 105);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(127, 19);
            label4.TabIndex = 18;
            label4.Text = "Номер телефона:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(45, 72);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 19);
            label3.TabIndex = 17;
            label3.Text = "Полное имя:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(45, 366);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 19);
            label2.TabIndex = 22;
            label2.Text = "Услуги:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(44, 548);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(75, 19);
            label8.TabIndex = 33;
            label8.Text = "Запчасти:";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new System.Drawing.Point(44, 174);
            label20.Name = "label20";
            label20.Size = new System.Drawing.Size(134, 19);
            label20.TabIndex = 65;
            label20.Text = "Дата завершения:";
            // 
            // completedLabel1
            // 
            completedLabel1.AutoSize = true;
            completedLabel1.Location = new System.Drawing.Point(18, 405);
            completedLabel1.Name = "completedLabel1";
            completedLabel1.Size = new System.Drawing.Size(104, 19);
            completedLabel1.TabIndex = 12;
            completedLabel1.Text = "Не выполнен:";
            // 
            // serialNumberLabel1
            // 
            serialNumberLabel1.AutoSize = true;
            serialNumberLabel1.Location = new System.Drawing.Point(18, 375);
            serialNumberLabel1.Name = "serialNumberLabel1";
            serialNumberLabel1.Size = new System.Drawing.Size(133, 19);
            serialNumberLabel1.TabIndex = 10;
            serialNumberLabel1.Text = "Серийный номер:";
            // 
            // defectDescriptionLabel1
            // 
            defectDescriptionLabel1.AutoSize = true;
            defectDescriptionLabel1.Location = new System.Drawing.Point(18, 285);
            defectDescriptionLabel1.Name = "defectDescriptionLabel1";
            defectDescriptionLabel1.Size = new System.Drawing.Size(142, 19);
            defectDescriptionLabel1.TabIndex = 8;
            defectDescriptionLabel1.Text = "Описание дефекта:";
            // 
            // receiptDateLabel1
            // 
            receiptDateLabel1.AutoSize = true;
            receiptDateLabel1.Location = new System.Drawing.Point(18, 164);
            receiptDateLabel1.Name = "receiptDateLabel1";
            receiptDateLabel1.Size = new System.Drawing.Size(90, 19);
            receiptDateLabel1.TabIndex = 6;
            receiptDateLabel1.Text = "Дата сдачи:";
            // 
            // phoneNumberLabel1
            // 
            phoneNumberLabel1.AutoSize = true;
            phoneNumberLabel1.Location = new System.Drawing.Point(18, 130);
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            phoneNumberLabel1.Size = new System.Drawing.Size(127, 19);
            phoneNumberLabel1.TabIndex = 4;
            phoneNumberLabel1.Text = "Номер телефона:";
            // 
            // fullNameLabel1
            // 
            fullNameLabel1.AutoSize = true;
            fullNameLabel1.Location = new System.Drawing.Point(18, 97);
            fullNameLabel1.Name = "fullNameLabel1";
            fullNameLabel1.Size = new System.Drawing.Size(96, 19);
            fullNameLabel1.TabIndex = 2;
            fullNameLabel1.Text = "Полное имя:";
            // 
            // idOrderLabel1
            // 
            idOrderLabel1.AutoSize = true;
            idOrderLabel1.Location = new System.Drawing.Point(18, 64);
            idOrderLabel1.Name = "idOrderLabel1";
            idOrderLabel1.Size = new System.Drawing.Size(77, 19);
            idOrderLabel1.TabIndex = 0;
            idOrderLabel1.Text = "ID Заказа:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(18, 223);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(134, 19);
            label1.TabIndex = 19;
            label1.Text = "Дата завершения:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.adminFeaturesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1384, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchOrderToolStripMenuItem,
            this.newOrderToolStripMenuItem,
            this.orderListToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // searchOrderToolStripMenuItem
            // 
            this.searchOrderToolStripMenuItem.Name = "searchOrderToolStripMenuItem";
            this.searchOrderToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.searchOrderToolStripMenuItem.Text = "Поиск заказа";
            this.searchOrderToolStripMenuItem.Click += new System.EventHandler(this.SearchOrderToolStripMenuItem_Click);
            // 
            // newOrderToolStripMenuItem
            // 
            this.newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            this.newOrderToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.newOrderToolStripMenuItem.Text = "Новый заказ";
            this.newOrderToolStripMenuItem.Click += new System.EventHandler(this.NewOrderToolStripMenuItem_Click);
            // 
            // orderListToolStripMenuItem
            // 
            this.orderListToolStripMenuItem.Name = "orderListToolStripMenuItem";
            this.orderListToolStripMenuItem.Size = new System.Drawing.Size(183, 24);
            this.orderListToolStripMenuItem.Text = "Список заказов";
            this.orderListToolStripMenuItem.Click += new System.EventHandler(this.ListOrderToolStripMenuItem_Click);
            // 
            // adminFeaturesToolStripMenuItem
            // 
            this.adminFeaturesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToEditMasterToolStripMenuItem});
            this.adminFeaturesToolStripMenuItem.Name = "adminFeaturesToolStripMenuItem";
            this.adminFeaturesToolStripMenuItem.Size = new System.Drawing.Size(172, 23);
            this.adminFeaturesToolStripMenuItem.Text = "Возможности админа";
            this.adminFeaturesToolStripMenuItem.Visible = false;
            // 
            // ToEditMasterToolStripMenuItem
            // 
            this.ToEditMasterToolStripMenuItem.Name = "ToEditMasterToolStripMenuItem";
            this.ToEditMasterToolStripMenuItem.Size = new System.Drawing.Size(315, 24);
            this.ToEditMasterToolStripMenuItem.Text = "Редактирование аккаунта мастера";
            this.ToEditMasterToolStripMenuItem.Click += new System.EventHandler(this.ToEditMasterToolStripMenuItem_Click);
            // 
            // serviceBindingSource1
            // 
            this.serviceBindingSource1.DataMember = "Service";
            // 
            // orderBindingSource
            // 
            this.orderBindingSource.DataMember = "Order";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataMember = "Service";
            // 
            // listOrderTab
            // 
            this.listOrderTab.BackColor = System.Drawing.Color.SeaShell;
            this.listOrderTab.Controls.Add(this.sortButton);
            this.listOrderTab.Controls.Add(this.completedCheckBox);
            this.listOrderTab.Controls.Add(this.sortGridView);
            this.listOrderTab.Location = new System.Drawing.Point(4, 28);
            this.listOrderTab.Name = "listOrderTab";
            this.listOrderTab.Size = new System.Drawing.Size(1376, 670);
            this.listOrderTab.TabIndex = 2;
            this.listOrderTab.Text = "Список заказов";
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(8, 32);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(74, 27);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Поиск";
            this.sortButton.UseVisualStyleBackColor = true;
            this.sortButton.Click += new System.EventHandler(this.SortButton_Click);
            // 
            // completedCheckBox
            // 
            this.completedCheckBox.AutoSize = true;
            this.completedCheckBox.Checked = true;
            this.completedCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.completedCheckBox.Location = new System.Drawing.Point(8, 3);
            this.completedCheckBox.Name = "completedCheckBox";
            this.completedCheckBox.Size = new System.Drawing.Size(146, 23);
            this.completedCheckBox.TabIndex = 1;
            this.completedCheckBox.Text = "Не завершённые";
            this.completedCheckBox.UseVisualStyleBackColor = true;
            // 
            // sortGridView
            // 
            this.sortGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sortGridView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.sortGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortGridView.Location = new System.Drawing.Point(160, 0);
            this.sortGridView.Name = "sortGridView";
            this.sortGridView.RowHeadersWidth = 51;
            this.sortGridView.Size = new System.Drawing.Size(1220, 690);
            this.sortGridView.TabIndex = 0;
            // 
            // newOrderTab
            // 
            this.newOrderTab.BackColor = System.Drawing.Color.SeaShell;
            this.newOrderTab.Controls.Add(this.accountLinkButton);
            this.newOrderTab.Controls.Add(this.enableCompletionDateCheckBox);
            this.newOrderTab.Controls.Add(this.deletePartButton);
            this.newOrderTab.Controls.Add(label20);
            this.newOrderTab.Controls.Add(this.completionDateDateTimePicker);
            this.newOrderTab.Controls.Add(this.editLabel);
            this.newOrderTab.Controls.Add(this.completedEditCheckBox);
            this.newOrderTab.Controls.Add(this.addPartButton);
            this.newOrderTab.Controls.Add(this.partsListBox);
            this.newOrderTab.Controls.Add(label8);
            this.newOrderTab.Controls.Add(this.rightMastersButton);
            this.newOrderTab.Controls.Add(this.leftMastersButton);
            this.newOrderTab.Controls.Add(this.mastersListBox);
            this.newOrderTab.Controls.Add(this.mastersInOrderListBox);
            this.newOrderTab.Controls.Add(this.phoneNumberTextBox);
            this.newOrderTab.Controls.Add(this.rightServicesButton);
            this.newOrderTab.Controls.Add(this.leftServicesButton);
            this.newOrderTab.Controls.Add(this.servicesListBox);
            this.newOrderTab.Controls.Add(this.servicesInOrderListBox);
            this.newOrderTab.Controls.Add(label2);
            this.newOrderTab.Controls.Add(label3);
            this.newOrderTab.Controls.Add(label4);
            this.newOrderTab.Controls.Add(label5);
            this.newOrderTab.Controls.Add(label6);
            this.newOrderTab.Controls.Add(label7);
            this.newOrderTab.Controls.Add(this.addLabel);
            this.newOrderTab.Controls.Add(this.saveButton);
            this.newOrderTab.Controls.Add(this.fullNameTextBox);
            this.newOrderTab.Controls.Add(this.defectDescriptionTextBox);
            this.newOrderTab.Controls.Add(this.serialNumberTextBox);
            this.newOrderTab.Controls.Add(this.receiptDateDateTimePicker);
            this.newOrderTab.Location = new System.Drawing.Point(4, 28);
            this.newOrderTab.Name = "newOrderTab";
            this.newOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.newOrderTab.Size = new System.Drawing.Size(1376, 670);
            this.newOrderTab.TabIndex = 1;
            this.newOrderTab.Text = "Новый заказ";
            // 
            // accountLinkButton
            // 
            this.accountLinkButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accountLinkButton.Location = new System.Drawing.Point(620, 69);
            this.accountLinkButton.Name = "accountLinkButton";
            this.accountLinkButton.Size = new System.Drawing.Size(94, 60);
            this.accountLinkButton.TabIndex = 69;
            this.accountLinkButton.Text = "Привязать аккаунт покупателя";
            this.accountLinkButton.UseVisualStyleBackColor = true;
            this.accountLinkButton.Click += new System.EventHandler(this.AccountLinkButton_Click);
            // 
            // enableCompletionDateCheckBox
            // 
            this.enableCompletionDateCheckBox.Location = new System.Drawing.Point(383, 171);
            this.enableCompletionDateCheckBox.Name = "enableCompletionDateCheckBox";
            this.enableCompletionDateCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.enableCompletionDateCheckBox.Size = new System.Drawing.Size(231, 24);
            this.enableCompletionDateCheckBox.TabIndex = 68;
            this.enableCompletionDateCheckBox.Text = ":Учитывать дату завершения";
            this.enableCompletionDateCheckBox.UseVisualStyleBackColor = true;
            this.enableCompletionDateCheckBox.CheckedChanged += new System.EventHandler(this.EnableCompletionDateCheckBox_CheckedChanged);
            // 
            // deletePartButton
            // 
            this.deletePartButton.Location = new System.Drawing.Point(579, 591);
            this.deletePartButton.Name = "deletePartButton";
            this.deletePartButton.Size = new System.Drawing.Size(87, 33);
            this.deletePartButton.TabIndex = 67;
            this.deletePartButton.Text = "Удалить";
            this.deletePartButton.UseVisualStyleBackColor = true;
            this.deletePartButton.Click += new System.EventHandler(this.DeletePartButton_Click);
            // 
            // completionDateDateTimePicker
            // 
            this.completionDateDateTimePicker.Enabled = false;
            this.completionDateDateTimePicker.Location = new System.Drawing.Point(195, 168);
            this.completionDateDateTimePicker.Name = "completionDateDateTimePicker";
            this.completionDateDateTimePicker.Size = new System.Drawing.Size(182, 27);
            this.completionDateDateTimePicker.TabIndex = 66;
            // 
            // editLabel
            // 
            this.editLabel.AutoSize = true;
            this.editLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.editLabel.Location = new System.Drawing.Point(89, 16);
            this.editLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.editLabel.Name = "editLabel";
            this.editLabel.Size = new System.Drawing.Size(347, 39);
            this.editLabel.TabIndex = 64;
            this.editLabel.Text = "Редактирование заказа";
            this.editLabel.Visible = false;
            // 
            // completedEditCheckBox
            // 
            this.completedEditCheckBox.Location = new System.Drawing.Point(499, 136);
            this.completedEditCheckBox.Name = "completedEditCheckBox";
            this.completedEditCheckBox.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.completedEditCheckBox.Size = new System.Drawing.Size(115, 24);
            this.completedEditCheckBox.TabIndex = 63;
            this.completedEditCheckBox.Text = ":Выполнен";
            this.completedEditCheckBox.UseVisualStyleBackColor = true;
            this.completedEditCheckBox.Visible = false;
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(579, 548);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(87, 33);
            this.addPartButton.TabIndex = 35;
            this.addPartButton.Text = "Добавить";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // partsListBox
            // 
            this.partsListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.partsListBox.FormattingEnabled = true;
            this.partsListBox.ItemHeight = 18;
            this.partsListBox.Location = new System.Drawing.Point(195, 548);
            this.partsListBox.Name = "partsListBox";
            this.partsListBox.Size = new System.Drawing.Size(378, 76);
            this.partsListBox.TabIndex = 34;
            // 
            // rightMastersButton
            // 
            this.rightMastersButton.Location = new System.Drawing.Point(751, 514);
            this.rightMastersButton.Name = "rightMastersButton";
            this.rightMastersButton.Size = new System.Drawing.Size(42, 28);
            this.rightMastersButton.TabIndex = 32;
            this.rightMastersButton.Text = "▶";
            this.rightMastersButton.UseVisualStyleBackColor = true;
            this.rightMastersButton.Click += new System.EventHandler(this.RightMastersButton_Click);
            // 
            // leftMastersButton
            // 
            this.leftMastersButton.Location = new System.Drawing.Point(751, 484);
            this.leftMastersButton.Name = "leftMastersButton";
            this.leftMastersButton.Size = new System.Drawing.Size(42, 28);
            this.leftMastersButton.TabIndex = 31;
            this.leftMastersButton.Text = "◀";
            this.leftMastersButton.UseVisualStyleBackColor = true;
            this.leftMastersButton.Click += new System.EventHandler(this.LeftMastersButton_Click);
            // 
            // mastersListBox
            // 
            this.mastersListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersListBox.FormattingEnabled = true;
            this.mastersListBox.ItemHeight = 18;
            this.mastersListBox.Location = new System.Drawing.Point(799, 484);
            this.mastersListBox.Name = "mastersListBox";
            this.mastersListBox.Size = new System.Drawing.Size(554, 58);
            this.mastersListBox.TabIndex = 30;
            // 
            // mastersInOrderListBox
            // 
            this.mastersInOrderListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mastersInOrderListBox.FormattingEnabled = true;
            this.mastersInOrderListBox.ItemHeight = 18;
            this.mastersInOrderListBox.Location = new System.Drawing.Point(195, 484);
            this.mastersInOrderListBox.Name = "mastersInOrderListBox";
            this.mastersInOrderListBox.Size = new System.Drawing.Size(550, 58);
            this.mastersInOrderListBox.TabIndex = 29;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(195, 102);
            this.phoneNumberTextBox.Mask = "80000000000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(419, 27);
            this.phoneNumberTextBox.TabIndex = 28;
            // 
            // rightServicesButton
            // 
            this.rightServicesButton.Location = new System.Drawing.Point(751, 395);
            this.rightServicesButton.Name = "rightServicesButton";
            this.rightServicesButton.Size = new System.Drawing.Size(42, 28);
            this.rightServicesButton.TabIndex = 27;
            this.rightServicesButton.Text = "▶";
            this.rightServicesButton.UseVisualStyleBackColor = true;
            this.rightServicesButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // leftServicesButton
            // 
            this.leftServicesButton.Location = new System.Drawing.Point(751, 366);
            this.leftServicesButton.Name = "leftServicesButton";
            this.leftServicesButton.Size = new System.Drawing.Size(42, 28);
            this.leftServicesButton.TabIndex = 26;
            this.leftServicesButton.Text = "◀";
            this.leftServicesButton.UseVisualStyleBackColor = true;
            this.leftServicesButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // servicesListBox
            // 
            this.servicesListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesListBox.FormattingEnabled = true;
            this.servicesListBox.ItemHeight = 18;
            this.servicesListBox.Location = new System.Drawing.Point(799, 366);
            this.servicesListBox.Name = "servicesListBox";
            this.servicesListBox.Size = new System.Drawing.Size(554, 112);
            this.servicesListBox.TabIndex = 25;
            // 
            // servicesInOrderListBox
            // 
            this.servicesInOrderListBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.servicesInOrderListBox.FormattingEnabled = true;
            this.servicesInOrderListBox.ItemHeight = 18;
            this.servicesInOrderListBox.Location = new System.Drawing.Point(195, 366);
            this.servicesInOrderListBox.Name = "servicesInOrderListBox";
            this.servicesInOrderListBox.Size = new System.Drawing.Size(550, 112);
            this.servicesInOrderListBox.TabIndex = 24;
            // 
            // addLabel
            // 
            this.addLabel.AutoSize = true;
            this.addLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addLabel.Location = new System.Drawing.Point(89, 16);
            this.addLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.addLabel.Name = "addLabel";
            this.addLabel.Size = new System.Drawing.Size(288, 39);
            this.addLabel.TabIndex = 15;
            this.addLabel.Text = "Добавление заказа";
            this.addLabel.Visible = false;
            // 
            // saveButton
            // 
            this.saveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(195, 630);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(94, 36);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(195, 69);
            this.fullNameTextBox.MaxLength = 30;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(419, 27);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // defectDescriptionTextBox
            // 
            this.defectDescriptionTextBox.Location = new System.Drawing.Point(195, 202);
            this.defectDescriptionTextBox.MaxLength = 1000;
            this.defectDescriptionTextBox.Multiline = true;
            this.defectDescriptionTextBox.Name = "defectDescriptionTextBox";
            this.defectDescriptionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.defectDescriptionTextBox.Size = new System.Drawing.Size(550, 125);
            this.defectDescriptionTextBox.TabIndex = 9;
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.Location = new System.Drawing.Point(195, 333);
            this.serialNumberTextBox.MaxLength = 30;
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(419, 27);
            this.serialNumberTextBox.TabIndex = 11;
            // 
            // receiptDateDateTimePicker
            // 
            this.receiptDateDateTimePicker.Location = new System.Drawing.Point(195, 135);
            this.receiptDateDateTimePicker.Name = "receiptDateDateTimePicker";
            this.receiptDateDateTimePicker.Size = new System.Drawing.Size(182, 27);
            this.receiptDateDateTimePicker.TabIndex = 7;
            // 
            // searchOrderTab
            // 
            this.searchOrderTab.BackColor = System.Drawing.Color.SeaShell;
            this.searchOrderTab.Controls.Add(this.currentPageNumeric);
            this.searchOrderTab.Controls.Add(this.label14);
            this.searchOrderTab.Controls.Add(this.label13);
            this.searchOrderTab.Controls.Add(this.totalPagesLabel);
            this.searchOrderTab.Controls.Add(this.lastPageButton);
            this.searchOrderTab.Controls.Add(this.rightPageButton);
            this.searchOrderTab.Controls.Add(this.leftPageButton);
            this.searchOrderTab.Controls.Add(this.firstPageButton);
            this.searchOrderTab.Controls.Add(this.checkOutOrderButton);
            this.searchOrderTab.Controls.Add(this.allowCompletionDateCheckBox);
            this.searchOrderTab.Controls.Add(label1);
            this.searchOrderTab.Controls.Add(this.completionDateSearchTimePicker);
            this.searchOrderTab.Controls.Add(this.label9);
            this.searchOrderTab.Controls.Add(this.toEditOrderButton);
            this.searchOrderTab.Controls.Add(this.allowDateCheckBox);
            this.searchOrderTab.Controls.Add(this.searchGridView);
            this.searchOrderTab.Controls.Add(this.searchButton);
            this.searchOrderTab.Controls.Add(idOrderLabel1);
            this.searchOrderTab.Controls.Add(this.idSearchOrderTextBox);
            this.searchOrderTab.Controls.Add(this.fullNameSearchTextBox);
            this.searchOrderTab.Controls.Add(this.phoneNumberSearchTextBox);
            this.searchOrderTab.Controls.Add(this.defectDescriptionSearchTextBox);
            this.searchOrderTab.Controls.Add(this.serialNumberSearchTextBox);
            this.searchOrderTab.Controls.Add(fullNameLabel1);
            this.searchOrderTab.Controls.Add(phoneNumberLabel1);
            this.searchOrderTab.Controls.Add(receiptDateLabel1);
            this.searchOrderTab.Controls.Add(this.receiptDateSearchTimePicker);
            this.searchOrderTab.Controls.Add(defectDescriptionLabel1);
            this.searchOrderTab.Controls.Add(serialNumberLabel1);
            this.searchOrderTab.Controls.Add(completedLabel1);
            this.searchOrderTab.Controls.Add(this.completedSearchCheckBox);
            this.searchOrderTab.Location = new System.Drawing.Point(4, 28);
            this.searchOrderTab.Name = "searchOrderTab";
            this.searchOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchOrderTab.Size = new System.Drawing.Size(1376, 670);
            this.searchOrderTab.TabIndex = 0;
            this.searchOrderTab.Text = "Поиск заказа";
            // 
            // currentPageNumeric
            // 
            this.currentPageNumeric.Font = new System.Drawing.Font("Calibri", 12F);
            this.currentPageNumeric.Location = new System.Drawing.Point(161, 623);
            this.currentPageNumeric.Name = "currentPageNumeric";
            this.currentPageNumeric.Size = new System.Drawing.Size(75, 27);
            this.currentPageNumeric.TabIndex = 32;
            this.currentPageNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.currentPageNumeric.ValueChanged += new System.EventHandler(this.CurrentPageNumeric_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(80, 623);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(75, 19);
            this.label14.TabIndex = 31;
            this.label14.Text = "Страница";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(80, 647);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(156, 19);
            this.label13.TabIndex = 30;
            this.label13.Text = "Количество страниц: ";
            // 
            // totalPagesLabel
            // 
            this.totalPagesLabel.AutoSize = true;
            this.totalPagesLabel.Location = new System.Drawing.Point(242, 648);
            this.totalPagesLabel.Name = "totalPagesLabel";
            this.totalPagesLabel.Size = new System.Drawing.Size(80, 19);
            this.totalPagesLabel.TabIndex = 29;
            this.totalPagesLabel.Text = "TotalPages";
            // 
            // lastPageButton
            // 
            this.lastPageButton.Font = new System.Drawing.Font("Calibri", 10F);
            this.lastPageButton.Location = new System.Drawing.Point(365, 634);
            this.lastPageButton.Name = "lastPageButton";
            this.lastPageButton.Size = new System.Drawing.Size(32, 27);
            this.lastPageButton.TabIndex = 28;
            this.lastPageButton.Text = ">|";
            this.lastPageButton.UseVisualStyleBackColor = true;
            this.lastPageButton.Click += new System.EventHandler(this.LastPageButton_Click);
            // 
            // rightPageButton
            // 
            this.rightPageButton.Location = new System.Drawing.Point(328, 634);
            this.rightPageButton.Name = "rightPageButton";
            this.rightPageButton.Size = new System.Drawing.Size(31, 27);
            this.rightPageButton.TabIndex = 27;
            this.rightPageButton.Text = ">";
            this.rightPageButton.UseVisualStyleBackColor = true;
            this.rightPageButton.Click += new System.EventHandler(this.RightPageButton_Click);
            // 
            // leftPageButton
            // 
            this.leftPageButton.Location = new System.Drawing.Point(43, 635);
            this.leftPageButton.Name = "leftPageButton";
            this.leftPageButton.Size = new System.Drawing.Size(31, 27);
            this.leftPageButton.TabIndex = 26;
            this.leftPageButton.Text = "<";
            this.leftPageButton.UseVisualStyleBackColor = true;
            this.leftPageButton.Click += new System.EventHandler(this.LeftPageButton_Click);
            // 
            // firstPageButton
            // 
            this.firstPageButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.firstPageButton.Location = new System.Drawing.Point(5, 635);
            this.firstPageButton.Name = "firstPageButton";
            this.firstPageButton.Size = new System.Drawing.Size(32, 27);
            this.firstPageButton.TabIndex = 25;
            this.firstPageButton.Text = "|<";
            this.firstPageButton.UseVisualStyleBackColor = true;
            this.firstPageButton.Click += new System.EventHandler(this.FirstPageButton_Click);
            // 
            // checkOutOrderButton
            // 
            this.checkOutOrderButton.Location = new System.Drawing.Point(286, 454);
            this.checkOutOrderButton.Name = "checkOutOrderButton";
            this.checkOutOrderButton.Size = new System.Drawing.Size(77, 27);
            this.checkOutOrderButton.TabIndex = 22;
            this.checkOutOrderButton.Text = "Выдать";
            this.checkOutOrderButton.UseVisualStyleBackColor = true;
            this.checkOutOrderButton.Click += new System.EventHandler(this.CheckOutOrderButton_Click);
            // 
            // allowCompletionDateCheckBox
            // 
            this.allowCompletionDateCheckBox.Location = new System.Drawing.Point(165, 248);
            this.allowCompletionDateCheckBox.Name = "allowCompletionDateCheckBox";
            this.allowCompletionDateCheckBox.Size = new System.Drawing.Size(227, 24);
            this.allowCompletionDateCheckBox.TabIndex = 21;
            this.allowCompletionDateCheckBox.Text = "Учитывать дату завершения";
            this.allowCompletionDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // completionDateSearchTimePicker
            // 
            this.completionDateSearchTimePicker.Location = new System.Drawing.Point(166, 219);
            this.completionDateSearchTimePicker.Name = "completionDateSearchTimePicker";
            this.completionDateSearchTimePicker.Size = new System.Drawing.Size(216, 27);
            this.completionDateSearchTimePicker.TabIndex = 20;
            this.completionDateSearchTimePicker.Value = new System.DateTime(2022, 5, 2, 14, 35, 21, 0);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.Location = new System.Drawing.Point(27, 13);
            this.label9.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 39);
            this.label9.TabIndex = 18;
            this.label9.Text = "Поиск заказа";
            // 
            // toEditOrderButton
            // 
            this.toEditOrderButton.Location = new System.Drawing.Point(131, 454);
            this.toEditOrderButton.Name = "toEditOrderButton";
            this.toEditOrderButton.Size = new System.Drawing.Size(129, 27);
            this.toEditOrderButton.TabIndex = 17;
            this.toEditOrderButton.Text = "Редактировать";
            this.toEditOrderButton.UseVisualStyleBackColor = true;
            this.toEditOrderButton.Click += new System.EventHandler(this.ToEditOrderButton_Click);
            // 
            // allowDateCheckBox
            // 
            this.allowDateCheckBox.Location = new System.Drawing.Point(166, 189);
            this.allowDateCheckBox.Name = "allowDateCheckBox";
            this.allowDateCheckBox.Size = new System.Drawing.Size(200, 24);
            this.allowDateCheckBox.TabIndex = 16;
            this.allowDateCheckBox.Text = "Учитывать дату сдачи";
            this.allowDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchGridView
            // 
            this.searchGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGridView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Location = new System.Drawing.Point(399, 3);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.RowHeadersWidth = 51;
            this.searchGridView.Size = new System.Drawing.Size(975, 689);
            this.searchGridView.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(31, 454);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 27);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // idSearchOrderTextBox
            // 
            this.idSearchOrderTextBox.Location = new System.Drawing.Point(166, 61);
            this.idSearchOrderTextBox.Name = "idSearchOrderTextBox";
            this.idSearchOrderTextBox.Size = new System.Drawing.Size(216, 27);
            this.idSearchOrderTextBox.TabIndex = 1;
            // 
            // fullNameSearchTextBox
            // 
            this.fullNameSearchTextBox.Location = new System.Drawing.Point(166, 94);
            this.fullNameSearchTextBox.Name = "fullNameSearchTextBox";
            this.fullNameSearchTextBox.Size = new System.Drawing.Size(216, 27);
            this.fullNameSearchTextBox.TabIndex = 3;
            // 
            // phoneNumberSearchTextBox
            // 
            this.phoneNumberSearchTextBox.Location = new System.Drawing.Point(166, 127);
            this.phoneNumberSearchTextBox.Name = "phoneNumberSearchTextBox";
            this.phoneNumberSearchTextBox.Size = new System.Drawing.Size(216, 27);
            this.phoneNumberSearchTextBox.TabIndex = 5;
            // 
            // defectDescriptionSearchTextBox
            // 
            this.defectDescriptionSearchTextBox.Location = new System.Drawing.Point(166, 282);
            this.defectDescriptionSearchTextBox.Multiline = true;
            this.defectDescriptionSearchTextBox.Name = "defectDescriptionSearchTextBox";
            this.defectDescriptionSearchTextBox.Size = new System.Drawing.Size(216, 84);
            this.defectDescriptionSearchTextBox.TabIndex = 9;
            // 
            // serialNumberSearchTextBox
            // 
            this.serialNumberSearchTextBox.Location = new System.Drawing.Point(166, 372);
            this.serialNumberSearchTextBox.Name = "serialNumberSearchTextBox";
            this.serialNumberSearchTextBox.Size = new System.Drawing.Size(216, 27);
            this.serialNumberSearchTextBox.TabIndex = 11;
            // 
            // receiptDateSearchTimePicker
            // 
            this.receiptDateSearchTimePicker.Location = new System.Drawing.Point(166, 160);
            this.receiptDateSearchTimePicker.Name = "receiptDateSearchTimePicker";
            this.receiptDateSearchTimePicker.Size = new System.Drawing.Size(216, 27);
            this.receiptDateSearchTimePicker.TabIndex = 7;
            this.receiptDateSearchTimePicker.Value = new System.DateTime(2022, 5, 2, 0, 0, 0, 0);
            // 
            // completedSearchCheckBox
            // 
            this.completedSearchCheckBox.Location = new System.Drawing.Point(166, 405);
            this.completedSearchCheckBox.Name = "completedSearchCheckBox";
            this.completedSearchCheckBox.Size = new System.Drawing.Size(200, 24);
            this.completedSearchCheckBox.TabIndex = 13;
            this.completedSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.searchOrderTab);
            this.tabControl.Controls.Add(this.newOrderTab);
            this.tabControl.Controls.Add(this.listOrderTab);
            this.tabControl.Controls.Add(this.mastersTableTab);
            this.tabControl.Controls.Add(this.editMasterTab);
            this.tabControl.Controls.Add(this.checkOutOrderTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1384, 702);
            this.tabControl.TabIndex = 1;
            // 
            // mastersTableTab
            // 
            this.mastersTableTab.BackColor = System.Drawing.Color.SeaShell;
            this.mastersTableTab.Controls.Add(this.createMasterButton);
            this.mastersTableTab.Controls.Add(this.chooseMasterButton);
            this.mastersTableTab.Controls.Add(this.searchMasterButton);
            this.mastersTableTab.Controls.Add(this.searchTextBox);
            this.mastersTableTab.Controls.Add(this.loginRadioButton);
            this.mastersTableTab.Controls.Add(this.fullNameRadioButton);
            this.mastersTableTab.Controls.Add(this.mastersGridView);
            this.mastersTableTab.Location = new System.Drawing.Point(4, 28);
            this.mastersTableTab.Name = "mastersTableTab";
            this.mastersTableTab.Size = new System.Drawing.Size(1376, 670);
            this.mastersTableTab.TabIndex = 3;
            this.mastersTableTab.Text = "Таблица мастеров";
            // 
            // createMasterButton
            // 
            this.createMasterButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.createMasterButton.Location = new System.Drawing.Point(502, 8);
            this.createMasterButton.Name = "createMasterButton";
            this.createMasterButton.Size = new System.Drawing.Size(95, 44);
            this.createMasterButton.TabIndex = 13;
            this.createMasterButton.Text = "Создать";
            this.createMasterButton.UseVisualStyleBackColor = true;
            this.createMasterButton.Click += new System.EventHandler(this.CreateMasterButton_Click);
            // 
            // chooseMasterButton
            // 
            this.chooseMasterButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.chooseMasterButton.Location = new System.Drawing.Point(401, 8);
            this.chooseMasterButton.Name = "chooseMasterButton";
            this.chooseMasterButton.Size = new System.Drawing.Size(95, 44);
            this.chooseMasterButton.TabIndex = 12;
            this.chooseMasterButton.Text = "Выбрать";
            this.chooseMasterButton.UseVisualStyleBackColor = true;
            this.chooseMasterButton.Click += new System.EventHandler(this.ChooseMasterButton_Click);
            // 
            // searchMasterButton
            // 
            this.searchMasterButton.Location = new System.Drawing.Point(300, 8);
            this.searchMasterButton.Name = "searchMasterButton";
            this.searchMasterButton.Size = new System.Drawing.Size(95, 44);
            this.searchMasterButton.TabIndex = 11;
            this.searchMasterButton.Text = "Поиск";
            this.searchMasterButton.UseVisualStyleBackColor = true;
            this.searchMasterButton.Click += new System.EventHandler(this.SearchMasterButton_Click);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(9, 8);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(281, 27);
            this.searchTextBox.TabIndex = 10;
            // 
            // loginRadioButton
            // 
            this.loginRadioButton.AutoSize = true;
            this.loginRadioButton.Location = new System.Drawing.Point(110, 35);
            this.loginRadioButton.Name = "loginRadioButton";
            this.loginRadioButton.Size = new System.Drawing.Size(96, 23);
            this.loginRadioButton.TabIndex = 9;
            this.loginRadioButton.TabStop = true;
            this.loginRadioButton.Text = "По логину";
            this.loginRadioButton.UseVisualStyleBackColor = true;
            // 
            // fullNameRadioButton
            // 
            this.fullNameRadioButton.AutoSize = true;
            this.fullNameRadioButton.Checked = true;
            this.fullNameRadioButton.Location = new System.Drawing.Point(9, 35);
            this.fullNameRadioButton.Name = "fullNameRadioButton";
            this.fullNameRadioButton.Size = new System.Drawing.Size(95, 23);
            this.fullNameRadioButton.TabIndex = 7;
            this.fullNameRadioButton.TabStop = true;
            this.fullNameRadioButton.Text = "По имени";
            this.fullNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // mastersGridView
            // 
            this.mastersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mastersGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.mastersGridView.Location = new System.Drawing.Point(0, 60);
            this.mastersGridView.Name = "mastersGridView";
            this.mastersGridView.Size = new System.Drawing.Size(1376, 610);
            this.mastersGridView.TabIndex = 0;
            // 
            // editMasterTab
            // 
            this.editMasterTab.BackColor = System.Drawing.Color.SeaShell;
            this.editMasterTab.Controls.Add(this.saveMasterInfoButton);
            this.editMasterTab.Controls.Add(this.masterLabel);
            this.editMasterTab.Controls.Add(this.label10);
            this.editMasterTab.Controls.Add(this.label11);
            this.editMasterTab.Controls.Add(this.label12);
            this.editMasterTab.Controls.Add(this.masterPasswordTextBox);
            this.editMasterTab.Controls.Add(this.masterFullNameTextBox);
            this.editMasterTab.Controls.Add(this.masterLoginTextBox);
            this.editMasterTab.Location = new System.Drawing.Point(4, 28);
            this.editMasterTab.Name = "editMasterTab";
            this.editMasterTab.Padding = new System.Windows.Forms.Padding(3);
            this.editMasterTab.Size = new System.Drawing.Size(1376, 670);
            this.editMasterTab.TabIndex = 4;
            this.editMasterTab.Text = "Редактирование аккаунта мастера";
            // 
            // saveMasterInfoButton
            // 
            this.saveMasterInfoButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveMasterInfoButton.Location = new System.Drawing.Point(204, 179);
            this.saveMasterInfoButton.Name = "saveMasterInfoButton";
            this.saveMasterInfoButton.Size = new System.Drawing.Size(94, 36);
            this.saveMasterInfoButton.TabIndex = 66;
            this.saveMasterInfoButton.Text = "Сохранить";
            this.saveMasterInfoButton.UseVisualStyleBackColor = true;
            this.saveMasterInfoButton.Click += new System.EventHandler(this.SaveMasterInfoButton_Click);
            // 
            // masterLabel
            // 
            this.masterLabel.AutoSize = true;
            this.masterLabel.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.masterLabel.Location = new System.Drawing.Point(89, 16);
            this.masterLabel.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.masterLabel.Name = "masterLabel";
            this.masterLabel.Size = new System.Drawing.Size(499, 39);
            this.masterLabel.TabIndex = 65;
            this.masterLabel.Text = "Редактирование аккаунта мастера";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(53, 142);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 54;
            this.label10.Text = "Пароль:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(53, 78);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(96, 19);
            this.label11.TabIndex = 53;
            this.label11.Text = "Полное имя:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(53, 111);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 19);
            this.label12.TabIndex = 52;
            this.label12.Text = "Логин:";
            // 
            // masterPasswordTextBox
            // 
            this.masterPasswordTextBox.Location = new System.Drawing.Point(153, 136);
            this.masterPasswordTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.masterPasswordTextBox.MaxLength = 30;
            this.masterPasswordTextBox.Name = "masterPasswordTextBox";
            this.masterPasswordTextBox.Size = new System.Drawing.Size(195, 27);
            this.masterPasswordTextBox.TabIndex = 51;
            // 
            // masterFullNameTextBox
            // 
            this.masterFullNameTextBox.Location = new System.Drawing.Point(153, 75);
            this.masterFullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.masterFullNameTextBox.Name = "masterFullNameTextBox";
            this.masterFullNameTextBox.Size = new System.Drawing.Size(195, 27);
            this.masterFullNameTextBox.TabIndex = 49;
            // 
            // masterLoginTextBox
            // 
            this.masterLoginTextBox.Location = new System.Drawing.Point(153, 105);
            this.masterLoginTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.masterLoginTextBox.Name = "masterLoginTextBox";
            this.masterLoginTextBox.Size = new System.Drawing.Size(195, 27);
            this.masterLoginTextBox.TabIndex = 50;
            // 
            // checkOutOrderTab
            // 
            this.checkOutOrderTab.BackColor = System.Drawing.Color.SeaShell;
            this.checkOutOrderTab.Controls.Add(this.partsInOrderGridView);
            this.checkOutOrderTab.Controls.Add(this.servicesInOrderGridView);
            this.checkOutOrderTab.Controls.Add(this.end);
            this.checkOutOrderTab.Location = new System.Drawing.Point(4, 28);
            this.checkOutOrderTab.Name = "checkOutOrderTab";
            this.checkOutOrderTab.Size = new System.Drawing.Size(1376, 670);
            this.checkOutOrderTab.TabIndex = 5;
            this.checkOutOrderTab.Text = "Выдача заказа";
            // 
            // partsInOrderGridView
            // 
            this.partsInOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsInOrderGridView.Location = new System.Drawing.Point(42, 311);
            this.partsInOrderGridView.Name = "partsInOrderGridView";
            this.partsInOrderGridView.Size = new System.Drawing.Size(501, 132);
            this.partsInOrderGridView.TabIndex = 2;
            // 
            // servicesInOrderGridView
            // 
            this.servicesInOrderGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.servicesInOrderGridView.Location = new System.Drawing.Point(42, 40);
            this.servicesInOrderGridView.Name = "servicesInOrderGridView";
            this.servicesInOrderGridView.Size = new System.Drawing.Size(501, 229);
            this.servicesInOrderGridView.TabIndex = 1;
            // 
            // end
            // 
            this.end.Location = new System.Drawing.Point(1150, 603);
            this.end.Name = "end";
            this.end.Size = new System.Drawing.Size(151, 31);
            this.end.TabIndex = 0;
            this.end.Text = "Завершить заказ";
            this.end.UseVisualStyleBackColor = true;
            this.end.Click += new System.EventHandler(this.button1_Click);
            // 
            // currentUserLabel
            // 
            this.currentUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.currentUserLabel.AutoSize = true;
            this.currentUserLabel.BackColor = System.Drawing.SystemColors.MenuBar;
            this.currentUserLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentUserLabel.Location = new System.Drawing.Point(84, 5);
            this.currentUserLabel.Name = "currentUserLabel";
            this.currentUserLabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.currentUserLabel.Size = new System.Drawing.Size(53, 19);
            this.currentUserLabel.TabIndex = 2;
            this.currentUserLabel.Text = " admin";
            this.currentUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.currentUserLabel.Visible = false;
            // 
            // changeConnectionPropertiesButton
            // 
            this.changeConnectionPropertiesButton.Location = new System.Drawing.Point(1119, 0);
            this.changeConnectionPropertiesButton.Name = "changeConnectionPropertiesButton";
            this.changeConnectionPropertiesButton.Size = new System.Drawing.Size(261, 29);
            this.changeConnectionPropertiesButton.TabIndex = 3;
            this.changeConnectionPropertiesButton.Text = "Изменить настройки подключения";
            this.changeConnectionPropertiesButton.UseVisualStyleBackColor = true;
            this.changeConnectionPropertiesButton.Click += new System.EventHandler(this.ChangeConnectionPropertiesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 731);
            this.Controls.Add(this.changeConnectionPropertiesButton);
            this.Controls.Add(this.currentUserLabel);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(3840, 770);
            this.MinimumSize = new System.Drawing.Size(1400, 770);
            this.Name = "MainForm";
            this.Text = "AdminForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.listOrderTab.ResumeLayout(false);
            this.listOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortGridView)).EndInit();
            this.newOrderTab.ResumeLayout(false);
            this.newOrderTab.PerformLayout();
            this.searchOrderTab.ResumeLayout(false);
            this.searchOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.currentPageNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.mastersTableTab.ResumeLayout(false);
            this.mastersTableTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mastersGridView)).EndInit();
            this.editMasterTab.ResumeLayout(false);
            this.editMasterTab.PerformLayout();
            this.checkOutOrderTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.partsInOrderGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesInOrderGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newOrderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem orderListToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminFeaturesToolStripMenuItem;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.ToolStripMenuItem ToEditMasterToolStripMenuItem;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private System.Windows.Forms.TabPage listOrderTab;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.CheckBox completedCheckBox;
        private System.Windows.Forms.DataGridView sortGridView;
        private System.Windows.Forms.TabPage newOrderTab;
        private System.Windows.Forms.DateTimePicker completionDateDateTimePicker;
        private System.Windows.Forms.Label editLabel;
        private System.Windows.Forms.CheckBox completedEditCheckBox;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.ListBox partsListBox;
        private System.Windows.Forms.Button rightMastersButton;
        private System.Windows.Forms.Button leftMastersButton;
        private System.Windows.Forms.ListBox mastersListBox;
        private System.Windows.Forms.ListBox mastersInOrderListBox;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.Button rightServicesButton;
        private System.Windows.Forms.Button leftServicesButton;
        private System.Windows.Forms.ListBox servicesListBox;
        private System.Windows.Forms.ListBox servicesInOrderListBox;
        private System.Windows.Forms.Label addLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox defectDescriptionTextBox;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateDateTimePicker;
        private System.Windows.Forms.TabPage searchOrderTab;
        private System.Windows.Forms.CheckBox allowCompletionDateCheckBox;
        private System.Windows.Forms.DateTimePicker completionDateSearchTimePicker;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button toEditOrderButton;
        private System.Windows.Forms.CheckBox allowDateCheckBox;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox idSearchOrderTextBox;
        private System.Windows.Forms.TextBox fullNameSearchTextBox;
        private System.Windows.Forms.TextBox phoneNumberSearchTextBox;
        private System.Windows.Forms.TextBox defectDescriptionSearchTextBox;
        private System.Windows.Forms.TextBox serialNumberSearchTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateSearchTimePicker;
        private System.Windows.Forms.CheckBox completedSearchCheckBox;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Button deletePartButton;
        private System.Windows.Forms.TabPage mastersTableTab;
        private System.Windows.Forms.CheckBox enableCompletionDateCheckBox;
        private System.Windows.Forms.Button accountLinkButton;
        private System.Windows.Forms.DataGridView mastersGridView;
        private System.Windows.Forms.Button chooseMasterButton;
        private System.Windows.Forms.Button searchMasterButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.RadioButton loginRadioButton;
        private System.Windows.Forms.RadioButton fullNameRadioButton;
        private System.Windows.Forms.TabPage editMasterTab;
        private System.Windows.Forms.Label masterLabel;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox masterPasswordTextBox;
        private System.Windows.Forms.TextBox masterFullNameTextBox;
        private System.Windows.Forms.TextBox masterLoginTextBox;
        private System.Windows.Forms.Button saveMasterInfoButton;
        private System.Windows.Forms.Button createMasterButton;
        private System.Windows.Forms.Label currentUserLabel;
        private System.Windows.Forms.TabPage checkOutOrderTab;
        private System.Windows.Forms.Button checkOutOrderButton;
        private System.Windows.Forms.Button end;
        private System.Windows.Forms.DataGridView servicesInOrderGridView;
        private System.Windows.Forms.DataGridView partsInOrderGridView;
        private System.Windows.Forms.Button changeConnectionPropertiesButton;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label totalPagesLabel;
        private System.Windows.Forms.Button lastPageButton;
        private System.Windows.Forms.Button rightPageButton;
        private System.Windows.Forms.Button leftPageButton;
        private System.Windows.Forms.Button firstPageButton;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown currentPageNumeric;
    }
}

