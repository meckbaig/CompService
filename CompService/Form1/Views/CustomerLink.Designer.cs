
namespace CompService.Views
{
    partial class CustomerLink
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
            this.customersDataGridView = new System.Windows.Forms.DataGridView();
            this.fullNameRadioButton = new System.Windows.Forms.RadioButton();
            this.phoneNumberRadioButton = new System.Windows.Forms.RadioButton();
            this.loginRadioButton = new System.Windows.Forms.RadioButton();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.chooseCustomerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // customersDataGridView
            // 
            this.customersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.customersDataGridView.Location = new System.Drawing.Point(0, 55);
            this.customersDataGridView.Name = "customersDataGridView";
            this.customersDataGridView.Size = new System.Drawing.Size(1008, 549);
            this.customersDataGridView.TabIndex = 0;
            // 
            // fullNameRadioButton
            // 
            this.fullNameRadioButton.AutoSize = true;
            this.fullNameRadioButton.Checked = true;
            this.fullNameRadioButton.Location = new System.Drawing.Point(13, 32);
            this.fullNameRadioButton.Name = "fullNameRadioButton";
            this.fullNameRadioButton.Size = new System.Drawing.Size(95, 23);
            this.fullNameRadioButton.TabIndex = 1;
            this.fullNameRadioButton.TabStop = true;
            this.fullNameRadioButton.Text = "По имени";
            this.fullNameRadioButton.UseVisualStyleBackColor = true;
            // 
            // phoneNumberRadioButton
            // 
            this.phoneNumberRadioButton.AutoSize = true;
            this.phoneNumberRadioButton.Location = new System.Drawing.Point(114, 32);
            this.phoneNumberRadioButton.Name = "phoneNumberRadioButton";
            this.phoneNumberRadioButton.Size = new System.Drawing.Size(169, 23);
            this.phoneNumberRadioButton.TabIndex = 2;
            this.phoneNumberRadioButton.TabStop = true;
            this.phoneNumberRadioButton.Text = "По номеру телефона";
            this.phoneNumberRadioButton.UseVisualStyleBackColor = true;
            // 
            // loginRadioButton
            // 
            this.loginRadioButton.AutoSize = true;
            this.loginRadioButton.Location = new System.Drawing.Point(289, 32);
            this.loginRadioButton.Name = "loginRadioButton";
            this.loginRadioButton.Size = new System.Drawing.Size(96, 23);
            this.loginRadioButton.TabIndex = 3;
            this.loginRadioButton.TabStop = true;
            this.loginRadioButton.Text = "По логину";
            this.loginRadioButton.UseVisualStyleBackColor = true;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(13, 5);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(369, 27);
            this.searchTextBox.TabIndex = 4;
            this.searchTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchTextBox_KeyDown);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(391, 5);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(95, 44);
            this.searchButton.TabIndex = 5;
            this.searchButton.Text = "Поиск";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // chooseCustomerButton
            // 
            this.chooseCustomerButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.chooseCustomerButton.Location = new System.Drawing.Point(492, 5);
            this.chooseCustomerButton.Name = "chooseCustomerButton";
            this.chooseCustomerButton.Size = new System.Drawing.Size(95, 44);
            this.chooseCustomerButton.TabIndex = 6;
            this.chooseCustomerButton.Text = "Выбрать";
            this.chooseCustomerButton.UseVisualStyleBackColor = true;
            this.chooseCustomerButton.Click += new System.EventHandler(this.ChooseCustomerButton_Click);
            // 
            // CustomerLink
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 604);
            this.Controls.Add(this.chooseCustomerButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.loginRadioButton);
            this.Controls.Add(this.phoneNumberRadioButton);
            this.Controls.Add(this.fullNameRadioButton);
            this.Controls.Add(this.customersDataGridView);
            this.Name = "CustomerLink";
            this.Text = "CustomerLink";
            ((System.ComponentModel.ISupportInitialize)(this.customersDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView customersDataGridView;
        private System.Windows.Forms.RadioButton fullNameRadioButton;
        private System.Windows.Forms.RadioButton phoneNumberRadioButton;
        private System.Windows.Forms.RadioButton loginRadioButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button chooseCustomerButton;
    }
}