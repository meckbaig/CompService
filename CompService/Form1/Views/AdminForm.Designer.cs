
namespace Form1
{
    partial class AdminForm
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
            System.Windows.Forms.Label idOrderLabel1;
            System.Windows.Forms.Label fullNameLabel1;
            System.Windows.Forms.Label phoneNumberLabel1;
            System.Windows.Forms.Label receiptDateLabel1;
            System.Windows.Forms.Label defectDescriptionLabel1;
            System.Windows.Forms.Label serialNumberLabel1;
            System.Windows.Forms.Label completedLabel1;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label4;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.Label label6;
            System.Windows.Forms.Label label7;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label8;
            System.Windows.Forms.Label label10;
            System.Windows.Forms.Label label11;
            System.Windows.Forms.Label label12;
            System.Windows.Forms.Label label13;
            System.Windows.Forms.Label label14;
            System.Windows.Forms.Label label15;
            System.Windows.Forms.Label label16;
            System.Windows.Forms.Label label18;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возможностиАдминаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеАккаунтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.searchOrderTab = new System.Windows.Forms.TabPage();
            this.label9 = new System.Windows.Forms.Label();
            this.toEditOrderButton = new System.Windows.Forms.Button();
            this.allowDateCheckBox = new System.Windows.Forms.CheckBox();
            this.searchGridView = new System.Windows.Forms.DataGridView();
            this.searchButton = new System.Windows.Forms.Button();
            this.idSearchOrderTextBox = new System.Windows.Forms.TextBox();
            this.fullNameSearchTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberSearchTextBox = new System.Windows.Forms.TextBox();
            this.receiptDateSearchTimePicker = new System.Windows.Forms.DateTimePicker();
            this.defectDescriptionSearchTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberSearchTextBox = new System.Windows.Forms.TextBox();
            this.completedSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.newOrderTab = new System.Windows.Forms.TabPage();
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
            this.label1 = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.receiptDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.defectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.listOrderTab = new System.Windows.Forms.TabPage();
            this.sortButton = new System.Windows.Forms.Button();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.sortGridView = new System.Windows.Forms.DataGridView();
            this.editOrderTab = new System.Windows.Forms.TabPage();
            this.editCompletedSearchCheckBox = new System.Windows.Forms.CheckBox();
            this.editAddPartButton = new System.Windows.Forms.Button();
            this.editPartsListBox = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.editMastersListBox = new System.Windows.Forms.ListBox();
            this.editMastersInOrderListBox = new System.Windows.Forms.ListBox();
            this.editPhoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.editRightServicesButton = new System.Windows.Forms.Button();
            this.editLeftServicesButton = new System.Windows.Forms.Button();
            this.editServicesListBox = new System.Windows.Forms.ListBox();
            this.editServicesInOrderListBox = new System.Windows.Forms.ListBox();
            this.label17 = new System.Windows.Forms.Label();
            this.saveChangesButton = new System.Windows.Forms.Button();
            this.editFullNameTextBox = new System.Windows.Forms.TextBox();
            this.editReceiptDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.editDefectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.editSerialNumberTextBox = new System.Windows.Forms.TextBox();
            this.serviceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.orderBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            idOrderLabel1 = new System.Windows.Forms.Label();
            fullNameLabel1 = new System.Windows.Forms.Label();
            phoneNumberLabel1 = new System.Windows.Forms.Label();
            receiptDateLabel1 = new System.Windows.Forms.Label();
            defectDescriptionLabel1 = new System.Windows.Forms.Label();
            serialNumberLabel1 = new System.Windows.Forms.Label();
            completedLabel1 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            label12 = new System.Windows.Forms.Label();
            label13 = new System.Windows.Forms.Label();
            label14 = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label16 = new System.Windows.Forms.Label();
            label18 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.searchOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.newOrderTab.SuspendLayout();
            this.listOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortGridView)).BeginInit();
            this.editOrderTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // fullNameLabel1
            // 
            fullNameLabel1.AutoSize = true;
            fullNameLabel1.Location = new System.Drawing.Point(18, 97);
            fullNameLabel1.Name = "fullNameLabel1";
            fullNameLabel1.Size = new System.Drawing.Size(96, 19);
            fullNameLabel1.TabIndex = 2;
            fullNameLabel1.Text = "Полное имя:";
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
            // receiptDateLabel1
            // 
            receiptDateLabel1.AutoSize = true;
            receiptDateLabel1.Location = new System.Drawing.Point(18, 164);
            receiptDateLabel1.Name = "receiptDateLabel1";
            receiptDateLabel1.Size = new System.Drawing.Size(90, 19);
            receiptDateLabel1.TabIndex = 6;
            receiptDateLabel1.Text = "Дата сдачи:";
            // 
            // defectDescriptionLabel1
            // 
            defectDescriptionLabel1.AutoSize = true;
            defectDescriptionLabel1.Location = new System.Drawing.Point(18, 226);
            defectDescriptionLabel1.Name = "defectDescriptionLabel1";
            defectDescriptionLabel1.Size = new System.Drawing.Size(142, 19);
            defectDescriptionLabel1.TabIndex = 8;
            defectDescriptionLabel1.Text = "Описание дефекта:";
            // 
            // serialNumberLabel1
            // 
            serialNumberLabel1.AutoSize = true;
            serialNumberLabel1.Location = new System.Drawing.Point(18, 316);
            serialNumberLabel1.Name = "serialNumberLabel1";
            serialNumberLabel1.Size = new System.Drawing.Size(133, 19);
            serialNumberLabel1.TabIndex = 10;
            serialNumberLabel1.Text = "Серийный номер:";
            // 
            // completedLabel1
            // 
            completedLabel1.AutoSize = true;
            completedLabel1.Location = new System.Drawing.Point(18, 346);
            completedLabel1.Name = "completedLabel1";
            completedLabel1.Size = new System.Drawing.Size(104, 19);
            completedLabel1.TabIndex = 12;
            completedLabel1.Text = "Не выполнен:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(49, 79);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(96, 19);
            label3.TabIndex = 17;
            label3.Text = "Полное имя:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new System.Drawing.Point(48, 112);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(127, 19);
            label4.TabIndex = 18;
            label4.Text = "Номер телефона:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new System.Drawing.Point(48, 143);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(90, 19);
            label5.TabIndex = 19;
            label5.Text = "Дата сдачи:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new System.Drawing.Point(48, 178);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(142, 19);
            label6.TabIndex = 20;
            label6.Text = "Описание дефекта:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new System.Drawing.Point(49, 268);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(133, 19);
            label7.TabIndex = 21;
            label7.Text = "Серийный номер:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(49, 310);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(57, 19);
            label2.TabIndex = 22;
            label2.Text = "Услуги:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new System.Drawing.Point(48, 493);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(75, 19);
            label8.TabIndex = 33;
            label8.Text = "Запчасти:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new System.Drawing.Point(34, 524);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(75, 19);
            label10.TabIndex = 57;
            label10.Text = "Запчасти:";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new System.Drawing.Point(35, 341);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(57, 19);
            label11.TabIndex = 47;
            label11.Text = "Услуги:";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new System.Drawing.Point(35, 78);
            label12.Name = "label12";
            label12.Size = new System.Drawing.Size(96, 19);
            label12.TabIndex = 42;
            label12.Text = "Полное имя:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new System.Drawing.Point(34, 111);
            label13.Name = "label13";
            label13.Size = new System.Drawing.Size(127, 19);
            label13.TabIndex = 43;
            label13.Text = "Номер телефона:";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new System.Drawing.Point(34, 142);
            label14.Name = "label14";
            label14.Size = new System.Drawing.Size(90, 19);
            label14.TabIndex = 44;
            label14.Text = "Дата сдачи:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new System.Drawing.Point(34, 209);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(142, 19);
            label15.TabIndex = 45;
            label15.Text = "Описание дефекта:";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new System.Drawing.Point(35, 299);
            label16.Name = "label16";
            label16.Size = new System.Drawing.Size(133, 19);
            label16.TabIndex = 46;
            label16.Text = "Серийный номер:";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new System.Drawing.Point(34, 176);
            label18.Name = "label18";
            label18.Size = new System.Drawing.Size(83, 19);
            label18.TabIndex = 60;
            label18.Text = "Выполнен:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.возможностиАдминаToolStripMenuItem});
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
            this.поискЗаказаToolStripMenuItem,
            this.новыйЗаказToolStripMenuItem,
            this.списокЗаказовToolStripMenuItem,
            this.редактированиеЗаказаToolStripMenuItem});
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.главнаяToolStripMenuItem.Text = "Главная";
            // 
            // поискЗаказаToolStripMenuItem
            // 
            this.поискЗаказаToolStripMenuItem.Name = "поискЗаказаToolStripMenuItem";
            this.поискЗаказаToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.поискЗаказаToolStripMenuItem.Text = "Поиск заказа";
            this.поискЗаказаToolStripMenuItem.Click += new System.EventHandler(this.SearchOrderToolStripMenuItem_Click);
            // 
            // новыйЗаказToolStripMenuItem
            // 
            this.новыйЗаказToolStripMenuItem.Name = "новыйЗаказToolStripMenuItem";
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.новыйЗаказToolStripMenuItem.Text = "Новый заказ";
            this.новыйЗаказToolStripMenuItem.Click += new System.EventHandler(this.NewOrderToolStripMenuItem_Click);
            // 
            // списокЗаказовToolStripMenuItem
            // 
            this.списокЗаказовToolStripMenuItem.Name = "списокЗаказовToolStripMenuItem";
            this.списокЗаказовToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.списокЗаказовToolStripMenuItem.Text = "Список заказов";
            this.списокЗаказовToolStripMenuItem.Click += new System.EventHandler(this.ListOrderToolStripMenuItem_Click);
            // 
            // редактированиеЗаказаToolStripMenuItem
            // 
            this.редактированиеЗаказаToolStripMenuItem.Name = "редактированиеЗаказаToolStripMenuItem";
            this.редактированиеЗаказаToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.редактированиеЗаказаToolStripMenuItem.Text = "Редактирование заказа";
            this.редактированиеЗаказаToolStripMenuItem.Click += new System.EventHandler(this.EditOrderToolStripMenuItem_Click);
            // 
            // возможностиАдминаToolStripMenuItem
            // 
            this.возможностиАдминаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.созданиеАккаунтаToolStripMenuItem,
            this.редактированиеАккаунтаToolStripMenuItem});
            this.возможностиАдминаToolStripMenuItem.Name = "возможностиАдминаToolStripMenuItem";
            this.возможностиАдминаToolStripMenuItem.Size = new System.Drawing.Size(172, 23);
            this.возможностиАдминаToolStripMenuItem.Text = "Возможности админа";
            // 
            // созданиеАккаунтаToolStripMenuItem
            // 
            this.созданиеАккаунтаToolStripMenuItem.Name = "созданиеАккаунтаToolStripMenuItem";
            this.созданиеАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.созданиеАккаунтаToolStripMenuItem.Text = "Создание аккаунта";
            // 
            // редактированиеАккаунтаToolStripMenuItem
            // 
            this.редактированиеАккаунтаToolStripMenuItem.Name = "редактированиеАккаунтаToolStripMenuItem";
            this.редактированиеАккаунтаToolStripMenuItem.Size = new System.Drawing.Size(255, 24);
            this.редактированиеАккаунтаToolStripMenuItem.Text = "Редактирование аккаунта";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.searchOrderTab);
            this.tabControl.Controls.Add(this.newOrderTab);
            this.tabControl.Controls.Add(this.listOrderTab);
            this.tabControl.Controls.Add(this.editOrderTab);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1384, 682);
            this.tabControl.TabIndex = 1;
            // 
            // searchOrderTab
            // 
            this.searchOrderTab.BackColor = System.Drawing.Color.SeaShell;
            this.searchOrderTab.Controls.Add(this.label9);
            this.searchOrderTab.Controls.Add(this.toEditOrderButton);
            this.searchOrderTab.Controls.Add(this.allowDateCheckBox);
            this.searchOrderTab.Controls.Add(this.searchGridView);
            this.searchOrderTab.Controls.Add(this.searchButton);
            this.searchOrderTab.Controls.Add(idOrderLabel1);
            this.searchOrderTab.Controls.Add(this.idSearchOrderTextBox);
            this.searchOrderTab.Controls.Add(fullNameLabel1);
            this.searchOrderTab.Controls.Add(this.fullNameSearchTextBox);
            this.searchOrderTab.Controls.Add(phoneNumberLabel1);
            this.searchOrderTab.Controls.Add(this.phoneNumberSearchTextBox);
            this.searchOrderTab.Controls.Add(receiptDateLabel1);
            this.searchOrderTab.Controls.Add(this.receiptDateSearchTimePicker);
            this.searchOrderTab.Controls.Add(defectDescriptionLabel1);
            this.searchOrderTab.Controls.Add(this.defectDescriptionSearchTextBox);
            this.searchOrderTab.Controls.Add(serialNumberLabel1);
            this.searchOrderTab.Controls.Add(this.serialNumberSearchTextBox);
            this.searchOrderTab.Controls.Add(completedLabel1);
            this.searchOrderTab.Controls.Add(this.completedSearchCheckBox);
            this.searchOrderTab.Location = new System.Drawing.Point(4, 28);
            this.searchOrderTab.Name = "searchOrderTab";
            this.searchOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.searchOrderTab.Size = new System.Drawing.Size(1376, 650);
            this.searchOrderTab.TabIndex = 0;
            this.searchOrderTab.Text = "Поиск заказа";
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
            this.toEditOrderButton.Location = new System.Drawing.Point(205, 486);
            this.toEditOrderButton.Name = "toEditOrderButton";
            this.toEditOrderButton.Size = new System.Drawing.Size(129, 27);
            this.toEditOrderButton.TabIndex = 17;
            this.toEditOrderButton.Text = "Редактировать";
            this.toEditOrderButton.UseVisualStyleBackColor = true;
            this.toEditOrderButton.Click += new System.EventHandler(this.ToEditOrderButton_Click);
            // 
            // allowDateCheckBox
            // 
            this.allowDateCheckBox.Location = new System.Drawing.Point(166, 193);
            this.allowDateCheckBox.Name = "allowDateCheckBox";
            this.allowDateCheckBox.Size = new System.Drawing.Size(200, 24);
            this.allowDateCheckBox.TabIndex = 16;
            this.allowDateCheckBox.Text = "Учитывать дату";
            this.allowDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchGridView
            // 
            this.searchGridView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchGridView.BackgroundColor = System.Drawing.Color.SeaShell;
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Location = new System.Drawing.Point(385, 3);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.Size = new System.Drawing.Size(988, 644);
            this.searchGridView.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(43, 486);
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
            this.idSearchOrderTextBox.Size = new System.Drawing.Size(200, 27);
            this.idSearchOrderTextBox.TabIndex = 1;
            // 
            // fullNameSearchTextBox
            // 
            this.fullNameSearchTextBox.Location = new System.Drawing.Point(166, 94);
            this.fullNameSearchTextBox.Name = "fullNameSearchTextBox";
            this.fullNameSearchTextBox.Size = new System.Drawing.Size(200, 27);
            this.fullNameSearchTextBox.TabIndex = 3;
            // 
            // phoneNumberSearchTextBox
            // 
            this.phoneNumberSearchTextBox.Location = new System.Drawing.Point(166, 127);
            this.phoneNumberSearchTextBox.Name = "phoneNumberSearchTextBox";
            this.phoneNumberSearchTextBox.Size = new System.Drawing.Size(200, 27);
            this.phoneNumberSearchTextBox.TabIndex = 5;
            // 
            // receiptDateSearchTimePicker
            // 
            this.receiptDateSearchTimePicker.Location = new System.Drawing.Point(166, 160);
            this.receiptDateSearchTimePicker.Name = "receiptDateSearchTimePicker";
            this.receiptDateSearchTimePicker.Size = new System.Drawing.Size(200, 27);
            this.receiptDateSearchTimePicker.TabIndex = 7;
            // 
            // defectDescriptionSearchTextBox
            // 
            this.defectDescriptionSearchTextBox.Location = new System.Drawing.Point(166, 223);
            this.defectDescriptionSearchTextBox.Multiline = true;
            this.defectDescriptionSearchTextBox.Name = "defectDescriptionSearchTextBox";
            this.defectDescriptionSearchTextBox.Size = new System.Drawing.Size(200, 84);
            this.defectDescriptionSearchTextBox.TabIndex = 9;
            // 
            // serialNumberSearchTextBox
            // 
            this.serialNumberSearchTextBox.Location = new System.Drawing.Point(166, 313);
            this.serialNumberSearchTextBox.Name = "serialNumberSearchTextBox";
            this.serialNumberSearchTextBox.Size = new System.Drawing.Size(200, 27);
            this.serialNumberSearchTextBox.TabIndex = 11;
            // 
            // completedSearchCheckBox
            // 
            this.completedSearchCheckBox.Location = new System.Drawing.Point(166, 346);
            this.completedSearchCheckBox.Name = "completedSearchCheckBox";
            this.completedSearchCheckBox.Size = new System.Drawing.Size(200, 24);
            this.completedSearchCheckBox.TabIndex = 13;
            this.completedSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // newOrderTab
            // 
            this.newOrderTab.BackColor = System.Drawing.Color.SeaShell;
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
            this.newOrderTab.Controls.Add(this.label1);
            this.newOrderTab.Controls.Add(this.createOrderButton);
            this.newOrderTab.Controls.Add(this.fullNameTextBox);
            this.newOrderTab.Controls.Add(this.receiptDateDateTimePicker);
            this.newOrderTab.Controls.Add(this.defectDescriptionTextBox);
            this.newOrderTab.Controls.Add(this.serialNumberTextBox);
            this.newOrderTab.Location = new System.Drawing.Point(4, 28);
            this.newOrderTab.Name = "newOrderTab";
            this.newOrderTab.Padding = new System.Windows.Forms.Padding(3);
            this.newOrderTab.Size = new System.Drawing.Size(1376, 650);
            this.newOrderTab.TabIndex = 1;
            this.newOrderTab.Text = "Новый заказ";
            // 
            // addPartButton
            // 
            this.addPartButton.Location = new System.Drawing.Point(583, 493);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(87, 33);
            this.addPartButton.TabIndex = 35;
            this.addPartButton.Text = "Добавить";
            this.addPartButton.UseVisualStyleBackColor = true;
            this.addPartButton.Click += new System.EventHandler(this.AddPartButton_Click);
            // 
            // partsListBox
            // 
            this.partsListBox.FormattingEnabled = true;
            this.partsListBox.ItemHeight = 19;
            this.partsListBox.Location = new System.Drawing.Point(199, 493);
            this.partsListBox.Name = "partsListBox";
            this.partsListBox.Size = new System.Drawing.Size(378, 61);
            this.partsListBox.TabIndex = 34;
            // 
            // rightMastersButton
            // 
            this.rightMastersButton.Location = new System.Drawing.Point(754, 454);
            this.rightMastersButton.Name = "rightMastersButton";
            this.rightMastersButton.Size = new System.Drawing.Size(42, 28);
            this.rightMastersButton.TabIndex = 32;
            this.rightMastersButton.Text = "▶";
            this.rightMastersButton.UseVisualStyleBackColor = true;
            this.rightMastersButton.Click += new System.EventHandler(this.RightMastersButton_Click);
            // 
            // leftMastersButton
            // 
            this.leftMastersButton.Location = new System.Drawing.Point(754, 421);
            this.leftMastersButton.Name = "leftMastersButton";
            this.leftMastersButton.Size = new System.Drawing.Size(42, 28);
            this.leftMastersButton.TabIndex = 31;
            this.leftMastersButton.Text = "◀";
            this.leftMastersButton.UseVisualStyleBackColor = true;
            this.leftMastersButton.Click += new System.EventHandler(this.LeftMastersButton_Click);
            // 
            // mastersListBox
            // 
            this.mastersListBox.FormattingEnabled = true;
            this.mastersListBox.ItemHeight = 19;
            this.mastersListBox.Location = new System.Drawing.Point(803, 421);
            this.mastersListBox.Name = "mastersListBox";
            this.mastersListBox.Size = new System.Drawing.Size(554, 61);
            this.mastersListBox.TabIndex = 30;
            // 
            // mastersInOrderListBox
            // 
            this.mastersInOrderListBox.FormattingEnabled = true;
            this.mastersInOrderListBox.ItemHeight = 19;
            this.mastersInOrderListBox.Location = new System.Drawing.Point(199, 421);
            this.mastersInOrderListBox.Name = "mastersInOrderListBox";
            this.mastersInOrderListBox.Size = new System.Drawing.Size(550, 61);
            this.mastersInOrderListBox.TabIndex = 29;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(199, 109);
            this.phoneNumberTextBox.Mask = "00000000000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(378, 27);
            this.phoneNumberTextBox.TabIndex = 28;
            // 
            // rightServicesButton
            // 
            this.rightServicesButton.Location = new System.Drawing.Point(754, 335);
            this.rightServicesButton.Name = "rightServicesButton";
            this.rightServicesButton.Size = new System.Drawing.Size(42, 28);
            this.rightServicesButton.TabIndex = 27;
            this.rightServicesButton.Text = "▶";
            this.rightServicesButton.UseVisualStyleBackColor = true;
            this.rightServicesButton.Click += new System.EventHandler(this.RightButton_Click);
            // 
            // leftServicesButton
            // 
            this.leftServicesButton.Location = new System.Drawing.Point(754, 301);
            this.leftServicesButton.Name = "leftServicesButton";
            this.leftServicesButton.Size = new System.Drawing.Size(42, 28);
            this.leftServicesButton.TabIndex = 26;
            this.leftServicesButton.Text = "◀";
            this.leftServicesButton.UseVisualStyleBackColor = true;
            this.leftServicesButton.Click += new System.EventHandler(this.LeftButton_Click);
            // 
            // servicesListBox
            // 
            this.servicesListBox.FormattingEnabled = true;
            this.servicesListBox.ItemHeight = 19;
            this.servicesListBox.Location = new System.Drawing.Point(803, 301);
            this.servicesListBox.Name = "servicesListBox";
            this.servicesListBox.Size = new System.Drawing.Size(554, 118);
            this.servicesListBox.TabIndex = 25;
            // 
            // servicesInOrderListBox
            // 
            this.servicesInOrderListBox.FormattingEnabled = true;
            this.servicesInOrderListBox.ItemHeight = 19;
            this.servicesInOrderListBox.Location = new System.Drawing.Point(199, 301);
            this.servicesInOrderListBox.Name = "servicesInOrderListBox";
            this.servicesInOrderListBox.Size = new System.Drawing.Size(550, 118);
            this.servicesInOrderListBox.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(93, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(288, 39);
            this.label1.TabIndex = 15;
            this.label1.Text = "Добавление заказа";
            // 
            // createOrderButton
            // 
            this.createOrderButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.createOrderButton.Location = new System.Drawing.Point(199, 594);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(94, 36);
            this.createOrderButton.TabIndex = 14;
            this.createOrderButton.Text = "Создать";
            this.createOrderButton.UseVisualStyleBackColor = true;
            this.createOrderButton.Click += new System.EventHandler(this.CreateOrderButton_Click);
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(199, 76);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(378, 27);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // receiptDateDateTimePicker
            // 
            this.receiptDateDateTimePicker.Location = new System.Drawing.Point(199, 142);
            this.receiptDateDateTimePicker.Name = "receiptDateDateTimePicker";
            this.receiptDateDateTimePicker.Size = new System.Drawing.Size(182, 27);
            this.receiptDateDateTimePicker.TabIndex = 7;
            // 
            // defectDescriptionTextBox
            // 
            this.defectDescriptionTextBox.Location = new System.Drawing.Point(199, 175);
            this.defectDescriptionTextBox.Multiline = true;
            this.defectDescriptionTextBox.Name = "defectDescriptionTextBox";
            this.defectDescriptionTextBox.Size = new System.Drawing.Size(378, 84);
            this.defectDescriptionTextBox.TabIndex = 9;
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.Location = new System.Drawing.Point(199, 265);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(378, 27);
            this.serialNumberTextBox.TabIndex = 11;
            // 
            // listOrderTab
            // 
            this.listOrderTab.BackColor = System.Drawing.Color.SeaShell;
            this.listOrderTab.Controls.Add(this.sortButton);
            this.listOrderTab.Controls.Add(this.completedCheckBox);
            this.listOrderTab.Controls.Add(this.sortGridView);
            this.listOrderTab.Location = new System.Drawing.Point(4, 28);
            this.listOrderTab.Name = "listOrderTab";
            this.listOrderTab.Size = new System.Drawing.Size(1376, 650);
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
            this.sortGridView.Size = new System.Drawing.Size(1216, 650);
            this.sortGridView.TabIndex = 0;
            // 
            // editOrderTab
            // 
            this.editOrderTab.BackColor = System.Drawing.Color.SeaShell;
            this.editOrderTab.Controls.Add(label18);
            this.editOrderTab.Controls.Add(this.editCompletedSearchCheckBox);
            this.editOrderTab.Controls.Add(this.editAddPartButton);
            this.editOrderTab.Controls.Add(this.editPartsListBox);
            this.editOrderTab.Controls.Add(label10);
            this.editOrderTab.Controls.Add(this.button2);
            this.editOrderTab.Controls.Add(this.button3);
            this.editOrderTab.Controls.Add(this.editMastersListBox);
            this.editOrderTab.Controls.Add(this.editMastersInOrderListBox);
            this.editOrderTab.Controls.Add(this.editPhoneNumberTextBox);
            this.editOrderTab.Controls.Add(this.editRightServicesButton);
            this.editOrderTab.Controls.Add(this.editLeftServicesButton);
            this.editOrderTab.Controls.Add(this.editServicesListBox);
            this.editOrderTab.Controls.Add(this.editServicesInOrderListBox);
            this.editOrderTab.Controls.Add(label11);
            this.editOrderTab.Controls.Add(label12);
            this.editOrderTab.Controls.Add(label13);
            this.editOrderTab.Controls.Add(label14);
            this.editOrderTab.Controls.Add(label15);
            this.editOrderTab.Controls.Add(label16);
            this.editOrderTab.Controls.Add(this.label17);
            this.editOrderTab.Controls.Add(this.saveChangesButton);
            this.editOrderTab.Controls.Add(this.editFullNameTextBox);
            this.editOrderTab.Controls.Add(this.editReceiptDateDateTimePicker);
            this.editOrderTab.Controls.Add(this.editDefectDescriptionTextBox);
            this.editOrderTab.Controls.Add(this.editSerialNumberTextBox);
            this.editOrderTab.Location = new System.Drawing.Point(4, 28);
            this.editOrderTab.Name = "editOrderTab";
            this.editOrderTab.Size = new System.Drawing.Size(1376, 650);
            this.editOrderTab.TabIndex = 3;
            this.editOrderTab.Text = "Редактирование заказа";
            // 
            // editCompletedSearchCheckBox
            // 
            this.editCompletedSearchCheckBox.Location = new System.Drawing.Point(185, 176);
            this.editCompletedSearchCheckBox.Name = "editCompletedSearchCheckBox";
            this.editCompletedSearchCheckBox.Size = new System.Drawing.Size(200, 24);
            this.editCompletedSearchCheckBox.TabIndex = 61;
            this.editCompletedSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // editAddPartButton
            // 
            this.editAddPartButton.Location = new System.Drawing.Point(569, 524);
            this.editAddPartButton.Name = "editAddPartButton";
            this.editAddPartButton.Size = new System.Drawing.Size(87, 33);
            this.editAddPartButton.TabIndex = 59;
            this.editAddPartButton.Text = "Добавить";
            this.editAddPartButton.UseVisualStyleBackColor = true;
            // 
            // editPartsListBox
            // 
            this.editPartsListBox.FormattingEnabled = true;
            this.editPartsListBox.ItemHeight = 19;
            this.editPartsListBox.Location = new System.Drawing.Point(185, 524);
            this.editPartsListBox.Name = "editPartsListBox";
            this.editPartsListBox.Size = new System.Drawing.Size(378, 61);
            this.editPartsListBox.TabIndex = 58;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(42, 28);
            this.button2.TabIndex = 56;
            this.button2.Text = "▶";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(740, 452);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(42, 28);
            this.button3.TabIndex = 55;
            this.button3.Text = "◀";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // editMastersListBox
            // 
            this.editMastersListBox.FormattingEnabled = true;
            this.editMastersListBox.ItemHeight = 19;
            this.editMastersListBox.Location = new System.Drawing.Point(789, 452);
            this.editMastersListBox.Name = "editMastersListBox";
            this.editMastersListBox.Size = new System.Drawing.Size(554, 61);
            this.editMastersListBox.TabIndex = 54;
            // 
            // editMastersInOrderListBox
            // 
            this.editMastersInOrderListBox.FormattingEnabled = true;
            this.editMastersInOrderListBox.ItemHeight = 19;
            this.editMastersInOrderListBox.Location = new System.Drawing.Point(185, 452);
            this.editMastersInOrderListBox.Name = "editMastersInOrderListBox";
            this.editMastersInOrderListBox.Size = new System.Drawing.Size(550, 61);
            this.editMastersInOrderListBox.TabIndex = 53;
            // 
            // editPhoneNumberTextBox
            // 
            this.editPhoneNumberTextBox.Location = new System.Drawing.Point(185, 108);
            this.editPhoneNumberTextBox.Mask = "00000000000";
            this.editPhoneNumberTextBox.Name = "editPhoneNumberTextBox";
            this.editPhoneNumberTextBox.Size = new System.Drawing.Size(378, 27);
            this.editPhoneNumberTextBox.TabIndex = 52;
            // 
            // editRightServicesButton
            // 
            this.editRightServicesButton.Location = new System.Drawing.Point(740, 366);
            this.editRightServicesButton.Name = "editRightServicesButton";
            this.editRightServicesButton.Size = new System.Drawing.Size(42, 28);
            this.editRightServicesButton.TabIndex = 51;
            this.editRightServicesButton.Text = "▶";
            this.editRightServicesButton.UseVisualStyleBackColor = true;
            // 
            // editLeftServicesButton
            // 
            this.editLeftServicesButton.Location = new System.Drawing.Point(740, 332);
            this.editLeftServicesButton.Name = "editLeftServicesButton";
            this.editLeftServicesButton.Size = new System.Drawing.Size(42, 28);
            this.editLeftServicesButton.TabIndex = 50;
            this.editLeftServicesButton.Text = "◀";
            this.editLeftServicesButton.UseVisualStyleBackColor = true;
            // 
            // editServicesListBox
            // 
            this.editServicesListBox.FormattingEnabled = true;
            this.editServicesListBox.ItemHeight = 19;
            this.editServicesListBox.Location = new System.Drawing.Point(789, 332);
            this.editServicesListBox.Name = "editServicesListBox";
            this.editServicesListBox.Size = new System.Drawing.Size(554, 118);
            this.editServicesListBox.TabIndex = 49;
            // 
            // editServicesInOrderListBox
            // 
            this.editServicesInOrderListBox.FormattingEnabled = true;
            this.editServicesInOrderListBox.ItemHeight = 19;
            this.editServicesInOrderListBox.Location = new System.Drawing.Point(185, 332);
            this.editServicesInOrderListBox.Name = "editServicesInOrderListBox";
            this.editServicesInOrderListBox.Size = new System.Drawing.Size(550, 118);
            this.editServicesInOrderListBox.TabIndex = 48;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label17.Location = new System.Drawing.Point(79, 22);
            this.label17.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(347, 39);
            this.label17.TabIndex = 41;
            this.label17.Text = "Редактирование заказа";
            // 
            // saveChangesButton
            // 
            this.saveChangesButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveChangesButton.Location = new System.Drawing.Point(185, 593);
            this.saveChangesButton.Name = "saveChangesButton";
            this.saveChangesButton.Size = new System.Drawing.Size(182, 36);
            this.saveChangesButton.TabIndex = 40;
            this.saveChangesButton.Text = "Сохранить изменения";
            this.saveChangesButton.UseVisualStyleBackColor = true;
            this.saveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
            // 
            // editFullNameTextBox
            // 
            this.editFullNameTextBox.Location = new System.Drawing.Point(185, 75);
            this.editFullNameTextBox.Name = "editFullNameTextBox";
            this.editFullNameTextBox.Size = new System.Drawing.Size(378, 27);
            this.editFullNameTextBox.TabIndex = 36;
            // 
            // editReceiptDateDateTimePicker
            // 
            this.editReceiptDateDateTimePicker.Location = new System.Drawing.Point(185, 141);
            this.editReceiptDateDateTimePicker.Name = "editReceiptDateDateTimePicker";
            this.editReceiptDateDateTimePicker.Size = new System.Drawing.Size(182, 27);
            this.editReceiptDateDateTimePicker.TabIndex = 37;
            // 
            // editDefectDescriptionTextBox
            // 
            this.editDefectDescriptionTextBox.Location = new System.Drawing.Point(185, 206);
            this.editDefectDescriptionTextBox.Multiline = true;
            this.editDefectDescriptionTextBox.Name = "editDefectDescriptionTextBox";
            this.editDefectDescriptionTextBox.Size = new System.Drawing.Size(378, 84);
            this.editDefectDescriptionTextBox.TabIndex = 38;
            // 
            // editSerialNumberTextBox
            // 
            this.editSerialNumberTextBox.Location = new System.Drawing.Point(185, 296);
            this.editSerialNumberTextBox.Name = "editSerialNumberTextBox";
            this.editSerialNumberTextBox.Size = new System.Drawing.Size(378, 27);
            this.editSerialNumberTextBox.TabIndex = 39;
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
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1384, 711);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.MaximumSize = new System.Drawing.Size(3840, 750);
            this.MinimumSize = new System.Drawing.Size(16, 750);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.searchOrderTab.ResumeLayout(false);
            this.searchOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.newOrderTab.ResumeLayout(false);
            this.newOrderTab.PerformLayout();
            this.listOrderTab.ResumeLayout(false);
            this.listOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortGridView)).EndInit();
            this.editOrderTab.ResumeLayout(false);
            this.editOrderTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗаказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возможностиАдминаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеАккаунтаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage searchOrderTab;
        private System.Windows.Forms.TabPage newOrderTab;
        private System.Windows.Forms.TabPage listOrderTab;
        private System.Windows.Forms.DataGridView sortGridView;
        private System.Windows.Forms.CheckBox completedCheckBox;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.TextBox idSearchOrderTextBox;
        private System.Windows.Forms.TextBox fullNameSearchTextBox;
        private System.Windows.Forms.TextBox phoneNumberSearchTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateSearchTimePicker;
        private System.Windows.Forms.TextBox defectDescriptionSearchTextBox;
        private System.Windows.Forms.TextBox serialNumberSearchTextBox;
        private System.Windows.Forms.CheckBox completedSearchCheckBox;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateDateTimePicker;
        private System.Windows.Forms.TextBox defectDescriptionTextBox;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.CheckBox allowDateCheckBox;
        private System.Windows.Forms.ToolStripMenuItem редактированиеЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеАккаунтаToolStripMenuItem;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.BindingSource serviceBindingSource1;
        private System.Windows.Forms.ListBox servicesListBox;
        private System.Windows.Forms.ListBox servicesInOrderListBox;
        private System.Windows.Forms.Button rightServicesButton;
        private System.Windows.Forms.Button leftServicesButton;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.ListBox mastersListBox;
        private System.Windows.Forms.ListBox mastersInOrderListBox;
        private System.Windows.Forms.Button rightMastersButton;
        private System.Windows.Forms.Button leftMastersButton;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.ListBox partsListBox;
        private System.Windows.Forms.Button toEditOrderButton;
        private System.Windows.Forms.TabPage editOrderTab;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox editCompletedSearchCheckBox;
        private System.Windows.Forms.Button editAddPartButton;
        private System.Windows.Forms.ListBox editPartsListBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox editMastersListBox;
        private System.Windows.Forms.ListBox editMastersInOrderListBox;
        private System.Windows.Forms.MaskedTextBox editPhoneNumberTextBox;
        private System.Windows.Forms.Button editRightServicesButton;
        private System.Windows.Forms.Button editLeftServicesButton;
        private System.Windows.Forms.ListBox editServicesListBox;
        private System.Windows.Forms.ListBox editServicesInOrderListBox;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button saveChangesButton;
        private System.Windows.Forms.TextBox editFullNameTextBox;
        private System.Windows.Forms.DateTimePicker editReceiptDateDateTimePicker;
        private System.Windows.Forms.TextBox editDefectDescriptionTextBox;
        private System.Windows.Forms.TextBox editSerialNumberTextBox;
    }
}

