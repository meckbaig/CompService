
namespace Form1
{
    partial class MasterForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поискЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.новыйЗаказToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.списокЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.редактированиеЗаказаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.searchOrder = new System.Windows.Forms.TabPage();
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
            this.newOrder = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.createOrderButton = new System.Windows.Forms.Button();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.phoneNumberTextBox = new System.Windows.Forms.TextBox();
            this.receiptDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.defectDescriptionTextBox = new System.Windows.Forms.TextBox();
            this.serialNumberTextBox = new System.Windows.Forms.TextBox();
            this.listOrder = new System.Windows.Forms.TabPage();
            this.sortButton = new System.Windows.Forms.Button();
            this.completedCheckBox = new System.Windows.Forms.CheckBox();
            this.sortGridView = new System.Windows.Forms.DataGridView();
            this.аккаунтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.моиЗаказыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.searchOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).BeginInit();
            this.newOrder.SuspendLayout();
            this.listOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idOrderLabel1
            // 
            idOrderLabel1.AutoSize = true;
            idOrderLabel1.Location = new System.Drawing.Point(23, 21);
            idOrderLabel1.Name = "idOrderLabel1";
            idOrderLabel1.Size = new System.Drawing.Size(77, 19);
            idOrderLabel1.TabIndex = 0;
            idOrderLabel1.Text = "ID Заказа:";
            // 
            // fullNameLabel1
            // 
            fullNameLabel1.AutoSize = true;
            fullNameLabel1.Location = new System.Drawing.Point(23, 54);
            fullNameLabel1.Name = "fullNameLabel1";
            fullNameLabel1.Size = new System.Drawing.Size(96, 19);
            fullNameLabel1.TabIndex = 2;
            fullNameLabel1.Text = "Полное имя:";
            // 
            // phoneNumberLabel1
            // 
            phoneNumberLabel1.AutoSize = true;
            phoneNumberLabel1.Location = new System.Drawing.Point(23, 87);
            phoneNumberLabel1.Name = "phoneNumberLabel1";
            phoneNumberLabel1.Size = new System.Drawing.Size(127, 19);
            phoneNumberLabel1.TabIndex = 4;
            phoneNumberLabel1.Text = "Номер телефона:";
            // 
            // receiptDateLabel1
            // 
            receiptDateLabel1.AutoSize = true;
            receiptDateLabel1.Location = new System.Drawing.Point(23, 121);
            receiptDateLabel1.Name = "receiptDateLabel1";
            receiptDateLabel1.Size = new System.Drawing.Size(90, 19);
            receiptDateLabel1.TabIndex = 6;
            receiptDateLabel1.Text = "Дата сдачи:";
            // 
            // defectDescriptionLabel1
            // 
            defectDescriptionLabel1.AutoSize = true;
            defectDescriptionLabel1.Location = new System.Drawing.Point(23, 183);
            defectDescriptionLabel1.Name = "defectDescriptionLabel1";
            defectDescriptionLabel1.Size = new System.Drawing.Size(142, 19);
            defectDescriptionLabel1.TabIndex = 8;
            defectDescriptionLabel1.Text = "Описание дефекта:";
            // 
            // serialNumberLabel1
            // 
            serialNumberLabel1.AutoSize = true;
            serialNumberLabel1.Location = new System.Drawing.Point(23, 273);
            serialNumberLabel1.Name = "serialNumberLabel1";
            serialNumberLabel1.Size = new System.Drawing.Size(133, 19);
            serialNumberLabel1.TabIndex = 10;
            serialNumberLabel1.Text = "Серийный номер:";
            // 
            // completedLabel1
            // 
            completedLabel1.AutoSize = true;
            completedLabel1.Location = new System.Drawing.Point(23, 303);
            completedLabel1.Name = "completedLabel1";
            completedLabel1.Size = new System.Drawing.Size(83, 19);
            completedLabel1.TabIndex = 12;
            completedLabel1.Text = "Выполнен:";
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
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.аккаунтToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1223, 29);
            this.menuStrip1.TabIndex = 1;
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
            this.поискЗаказаToolStripMenuItem.Click += new System.EventHandler(this.поискЗаказаToolStripMenuItem_Click);
            // 
            // новыйЗаказToolStripMenuItem
            // 
            this.новыйЗаказToolStripMenuItem.Name = "новыйЗаказToolStripMenuItem";
            this.новыйЗаказToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.новыйЗаказToolStripMenuItem.Text = "Новый заказ";
            this.новыйЗаказToolStripMenuItem.Click += new System.EventHandler(this.новыйЗаказToolStripMenuItem_Click);
            // 
            // списокЗаказовToolStripMenuItem
            // 
            this.списокЗаказовToolStripMenuItem.Name = "списокЗаказовToolStripMenuItem";
            this.списокЗаказовToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.списокЗаказовToolStripMenuItem.Text = "Список заказов";
            this.списокЗаказовToolStripMenuItem.Click += new System.EventHandler(this.списокЗаказовToolStripMenuItem_Click);
            // 
            // редактированиеЗаказаToolStripMenuItem
            // 
            this.редактированиеЗаказаToolStripMenuItem.Name = "редактированиеЗаказаToolStripMenuItem";
            this.редактированиеЗаказаToolStripMenuItem.Size = new System.Drawing.Size(240, 24);
            this.редактированиеЗаказаToolStripMenuItem.Text = "Редактирование заказа";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.searchOrder);
            this.tabControl.Controls.Add(this.newOrder);
            this.tabControl.Controls.Add(this.listOrder);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1223, 632);
            this.tabControl.TabIndex = 2;
            // 
            // searchOrder
            // 
            this.searchOrder.Controls.Add(this.allowDateCheckBox);
            this.searchOrder.Controls.Add(this.searchGridView);
            this.searchOrder.Controls.Add(this.searchButton);
            this.searchOrder.Controls.Add(idOrderLabel1);
            this.searchOrder.Controls.Add(this.idSearchOrderTextBox);
            this.searchOrder.Controls.Add(fullNameLabel1);
            this.searchOrder.Controls.Add(this.fullNameSearchTextBox);
            this.searchOrder.Controls.Add(phoneNumberLabel1);
            this.searchOrder.Controls.Add(this.phoneNumberSearchTextBox);
            this.searchOrder.Controls.Add(receiptDateLabel1);
            this.searchOrder.Controls.Add(this.receiptDateSearchTimePicker);
            this.searchOrder.Controls.Add(defectDescriptionLabel1);
            this.searchOrder.Controls.Add(this.defectDescriptionSearchTextBox);
            this.searchOrder.Controls.Add(serialNumberLabel1);
            this.searchOrder.Controls.Add(this.serialNumberSearchTextBox);
            this.searchOrder.Controls.Add(completedLabel1);
            this.searchOrder.Controls.Add(this.completedSearchCheckBox);
            this.searchOrder.Location = new System.Drawing.Point(4, 28);
            this.searchOrder.Name = "searchOrder";
            this.searchOrder.Padding = new System.Windows.Forms.Padding(3);
            this.searchOrder.Size = new System.Drawing.Size(1215, 600);
            this.searchOrder.TabIndex = 0;
            this.searchOrder.Text = "Поиск заказа";
            this.searchOrder.UseVisualStyleBackColor = true;
            // 
            // allowDateCheckBox
            // 
            this.allowDateCheckBox.Location = new System.Drawing.Point(171, 150);
            this.allowDateCheckBox.Name = "allowDateCheckBox";
            this.allowDateCheckBox.Size = new System.Drawing.Size(200, 24);
            this.allowDateCheckBox.TabIndex = 16;
            this.allowDateCheckBox.Text = "Учитывать дату";
            this.allowDateCheckBox.UseVisualStyleBackColor = true;
            // 
            // searchGridView
            // 
            this.searchGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.searchGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchGridView.Location = new System.Drawing.Point(377, 3);
            this.searchGridView.Name = "searchGridView";
            this.searchGridView.Size = new System.Drawing.Size(835, 594);
            this.searchGridView.TabIndex = 15;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(151, 333);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(74, 27);
            this.searchButton.TabIndex = 14;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // idSearchOrderTextBox
            // 
            this.idSearchOrderTextBox.Location = new System.Drawing.Point(171, 18);
            this.idSearchOrderTextBox.Name = "idSearchOrderTextBox";
            this.idSearchOrderTextBox.Size = new System.Drawing.Size(200, 27);
            this.idSearchOrderTextBox.TabIndex = 1;
            // 
            // fullNameSearchTextBox
            // 
            this.fullNameSearchTextBox.Location = new System.Drawing.Point(171, 51);
            this.fullNameSearchTextBox.Name = "fullNameSearchTextBox";
            this.fullNameSearchTextBox.Size = new System.Drawing.Size(200, 27);
            this.fullNameSearchTextBox.TabIndex = 3;
            // 
            // phoneNumberSearchTextBox
            // 
            this.phoneNumberSearchTextBox.Location = new System.Drawing.Point(171, 84);
            this.phoneNumberSearchTextBox.Name = "phoneNumberSearchTextBox";
            this.phoneNumberSearchTextBox.Size = new System.Drawing.Size(200, 27);
            this.phoneNumberSearchTextBox.TabIndex = 5;
            // 
            // receiptDateSearchTimePicker
            // 
            this.receiptDateSearchTimePicker.Location = new System.Drawing.Point(171, 117);
            this.receiptDateSearchTimePicker.Name = "receiptDateSearchTimePicker";
            this.receiptDateSearchTimePicker.Size = new System.Drawing.Size(200, 27);
            this.receiptDateSearchTimePicker.TabIndex = 7;
            // 
            // defectDescriptionSearchTextBox
            // 
            this.defectDescriptionSearchTextBox.Location = new System.Drawing.Point(171, 180);
            this.defectDescriptionSearchTextBox.Multiline = true;
            this.defectDescriptionSearchTextBox.Name = "defectDescriptionSearchTextBox";
            this.defectDescriptionSearchTextBox.Size = new System.Drawing.Size(200, 84);
            this.defectDescriptionSearchTextBox.TabIndex = 9;
            // 
            // serialNumberSearchTextBox
            // 
            this.serialNumberSearchTextBox.Location = new System.Drawing.Point(171, 270);
            this.serialNumberSearchTextBox.Name = "serialNumberSearchTextBox";
            this.serialNumberSearchTextBox.Size = new System.Drawing.Size(200, 27);
            this.serialNumberSearchTextBox.TabIndex = 11;
            // 
            // completedSearchCheckBox
            // 
            this.completedSearchCheckBox.Location = new System.Drawing.Point(171, 303);
            this.completedSearchCheckBox.Name = "completedSearchCheckBox";
            this.completedSearchCheckBox.Size = new System.Drawing.Size(200, 24);
            this.completedSearchCheckBox.TabIndex = 13;
            this.completedSearchCheckBox.UseVisualStyleBackColor = true;
            // 
            // newOrder
            // 
            this.newOrder.Controls.Add(label3);
            this.newOrder.Controls.Add(label4);
            this.newOrder.Controls.Add(label5);
            this.newOrder.Controls.Add(label6);
            this.newOrder.Controls.Add(label7);
            this.newOrder.Controls.Add(this.label1);
            this.newOrder.Controls.Add(this.createOrderButton);
            this.newOrder.Controls.Add(this.fullNameTextBox);
            this.newOrder.Controls.Add(this.phoneNumberTextBox);
            this.newOrder.Controls.Add(this.receiptDateDateTimePicker);
            this.newOrder.Controls.Add(this.defectDescriptionTextBox);
            this.newOrder.Controls.Add(this.serialNumberTextBox);
            this.newOrder.Location = new System.Drawing.Point(4, 28);
            this.newOrder.Name = "newOrder";
            this.newOrder.Padding = new System.Windows.Forms.Padding(3);
            this.newOrder.Size = new System.Drawing.Size(1215, 600);
            this.newOrder.TabIndex = 1;
            this.newOrder.Text = "Новый заказ";
            this.newOrder.UseVisualStyleBackColor = true;
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
            this.createOrderButton.Location = new System.Drawing.Point(178, 307);
            this.createOrderButton.Name = "createOrderButton";
            this.createOrderButton.Size = new System.Drawing.Size(94, 36);
            this.createOrderButton.TabIndex = 14;
            this.createOrderButton.Text = "Создать";
            this.createOrderButton.UseVisualStyleBackColor = true;
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(199, 76);
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(243, 27);
            this.fullNameTextBox.TabIndex = 3;
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(199, 109);
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(243, 27);
            this.phoneNumberTextBox.TabIndex = 5;
            // 
            // receiptDateDateTimePicker
            // 
            this.receiptDateDateTimePicker.Location = new System.Drawing.Point(199, 142);
            this.receiptDateDateTimePicker.Name = "receiptDateDateTimePicker";
            this.receiptDateDateTimePicker.Size = new System.Drawing.Size(243, 27);
            this.receiptDateDateTimePicker.TabIndex = 7;
            // 
            // defectDescriptionTextBox
            // 
            this.defectDescriptionTextBox.Location = new System.Drawing.Point(199, 175);
            this.defectDescriptionTextBox.Multiline = true;
            this.defectDescriptionTextBox.Name = "defectDescriptionTextBox";
            this.defectDescriptionTextBox.Size = new System.Drawing.Size(243, 84);
            this.defectDescriptionTextBox.TabIndex = 9;
            // 
            // serialNumberTextBox
            // 
            this.serialNumberTextBox.Location = new System.Drawing.Point(199, 265);
            this.serialNumberTextBox.Name = "serialNumberTextBox";
            this.serialNumberTextBox.Size = new System.Drawing.Size(243, 27);
            this.serialNumberTextBox.TabIndex = 11;
            // 
            // listOrder
            // 
            this.listOrder.Controls.Add(this.sortButton);
            this.listOrder.Controls.Add(this.completedCheckBox);
            this.listOrder.Controls.Add(this.sortGridView);
            this.listOrder.Location = new System.Drawing.Point(4, 28);
            this.listOrder.Name = "listOrder";
            this.listOrder.Size = new System.Drawing.Size(1215, 600);
            this.listOrder.TabIndex = 2;
            this.listOrder.Text = "Список заказов";
            this.listOrder.UseVisualStyleBackColor = true;
            // 
            // sortButton
            // 
            this.sortButton.Location = new System.Drawing.Point(8, 32);
            this.sortButton.Name = "sortButton";
            this.sortButton.Size = new System.Drawing.Size(74, 27);
            this.sortButton.TabIndex = 2;
            this.sortButton.Text = "Поиск";
            this.sortButton.UseVisualStyleBackColor = true;
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
            this.sortGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sortGridView.Dock = System.Windows.Forms.DockStyle.Right;
            this.sortGridView.Location = new System.Drawing.Point(160, 0);
            this.sortGridView.Name = "sortGridView";
            this.sortGridView.Size = new System.Drawing.Size(1055, 600);
            this.sortGridView.TabIndex = 0;
            // 
            // аккаунтToolStripMenuItem
            // 
            this.аккаунтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.моиЗаказыToolStripMenuItem});
            this.аккаунтToolStripMenuItem.Name = "аккаунтToolStripMenuItem";
            this.аккаунтToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.аккаунтToolStripMenuItem.Text = "Аккаунт";
            // 
            // моиЗаказыToolStripMenuItem
            // 
            this.моиЗаказыToolStripMenuItem.Name = "моиЗаказыToolStripMenuItem";
            this.моиЗаказыToolStripMenuItem.Size = new System.Drawing.Size(180, 24);
            this.моиЗаказыToolStripMenuItem.Text = "Мои заказы";
            // 
            // MasterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 661);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1239, 700);
            this.MinimumSize = new System.Drawing.Size(1239, 700);
            this.Name = "MasterForm";
            this.Text = "MasterForm";
            this.Load += new System.EventHandler(this.MasterForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.searchOrder.ResumeLayout(false);
            this.searchOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchGridView)).EndInit();
            this.newOrder.ResumeLayout(false);
            this.newOrder.PerformLayout();
            this.listOrder.ResumeLayout(false);
            this.listOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sortGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поискЗаказаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem новыйЗаказToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem списокЗаказовToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem редактированиеЗаказаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage searchOrder;
        private System.Windows.Forms.CheckBox allowDateCheckBox;
        private System.Windows.Forms.DataGridView searchGridView;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox idSearchOrderTextBox;
        private System.Windows.Forms.TextBox fullNameSearchTextBox;
        private System.Windows.Forms.TextBox phoneNumberSearchTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateSearchTimePicker;
        private System.Windows.Forms.TextBox defectDescriptionSearchTextBox;
        private System.Windows.Forms.TextBox serialNumberSearchTextBox;
        private System.Windows.Forms.CheckBox completedSearchCheckBox;
        private System.Windows.Forms.TabPage newOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button createOrderButton;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox phoneNumberTextBox;
        private System.Windows.Forms.DateTimePicker receiptDateDateTimePicker;
        private System.Windows.Forms.TextBox defectDescriptionTextBox;
        private System.Windows.Forms.TextBox serialNumberTextBox;
        private System.Windows.Forms.TabPage listOrder;
        private System.Windows.Forms.Button sortButton;
        private System.Windows.Forms.CheckBox completedCheckBox;
        private System.Windows.Forms.DataGridView sortGridView;
        private System.Windows.Forms.ToolStripMenuItem аккаунтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem моиЗаказыToolStripMenuItem;
    }
}