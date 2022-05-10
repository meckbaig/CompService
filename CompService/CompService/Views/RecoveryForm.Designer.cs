
namespace CompService.Views
{
    partial class RecoveryForm
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.userDataTabPage = new System.Windows.Forms.TabPage();
            this.confirmButton = new System.Windows.Forms.Button();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            this.newPasswordTabPage = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.changePasswordButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.userDataTabPage.SuspendLayout();
            this.newPasswordTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.userDataTabPage);
            this.tabControl.Controls.Add(this.newPasswordTabPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(379, 482);
            this.tabControl.TabIndex = 0;
            // 
            // userDataTabPage
            // 
            this.userDataTabPage.BackColor = System.Drawing.Color.SeaShell;
            this.userDataTabPage.Controls.Add(this.confirmButton);
            this.userDataTabPage.Controls.Add(this.loginTextBox);
            this.userDataTabPage.Controls.Add(this.label2);
            this.userDataTabPage.Controls.Add(this.label7);
            this.userDataTabPage.Controls.Add(this.phoneNumberTextBox);
            this.userDataTabPage.Controls.Add(this.label10);
            this.userDataTabPage.Controls.Add(this.label5);
            this.userDataTabPage.Controls.Add(this.fullNameTextBox);
            this.userDataTabPage.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userDataTabPage.Location = new System.Drawing.Point(4, 28);
            this.userDataTabPage.Name = "userDataTabPage";
            this.userDataTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.userDataTabPage.Size = new System.Drawing.Size(371, 450);
            this.userDataTabPage.TabIndex = 0;
            this.userDataTabPage.Text = "Информация пользователя";
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(71, 374);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(219, 50);
            this.confirmButton.TabIndex = 3;
            this.confirmButton.Text = "Подтвердить";
            this.confirmButton.UseVisualStyleBackColor = true;
            this.confirmButton.Click += new System.EventHandler(this.ConfirmButton_Click);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(8, 102);
            this.loginTextBox.MaxLength = 30;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(355, 47);
            this.loginTextBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 39);
            this.label2.TabIndex = 68;
            this.label2.Text = "Логин";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(5, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(358, 39);
            this.label7.TabIndex = 67;
            this.label7.Text = "Заполните информацию";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(8, 287);
            this.phoneNumberTextBox.Mask = "80000000000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(355, 47);
            this.phoneNumberTextBox.TabIndex = 2;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 245);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 39);
            this.label10.TabIndex = 65;
            this.label10.Text = "Номер телефона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 155);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 39);
            this.label5.TabIndex = 64;
            this.label5.Text = "Ваше полное имя";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(8, 196);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullNameTextBox.MaxLength = 50;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(355, 47);
            this.fullNameTextBox.TabIndex = 1;
            // 
            // newPasswordTabPage
            // 
            this.newPasswordTabPage.BackColor = System.Drawing.Color.SeaShell;
            this.newPasswordTabPage.Controls.Add(this.label1);
            this.newPasswordTabPage.Controls.Add(this.repeatPasswordTextBox);
            this.newPasswordTabPage.Controls.Add(this.label4);
            this.newPasswordTabPage.Controls.Add(this.changePasswordButton);
            this.newPasswordTabPage.Controls.Add(this.passwordTextBox);
            this.newPasswordTabPage.Controls.Add(this.label3);
            this.newPasswordTabPage.Font = new System.Drawing.Font("Calibri", 24F);
            this.newPasswordTabPage.ForeColor = System.Drawing.SystemColors.InfoText;
            this.newPasswordTabPage.Location = new System.Drawing.Point(4, 28);
            this.newPasswordTabPage.Name = "newPasswordTabPage";
            this.newPasswordTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.newPasswordTabPage.Size = new System.Drawing.Size(371, 450);
            this.newPasswordTabPage.TabIndex = 1;
            this.newPasswordTabPage.Text = "Новый пароль";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 39);
            this.label1.TabIndex = 68;
            this.label1.Text = "Введите новый пароль";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(8, 207);
            this.repeatPasswordTextBox.MaxLength = 30;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(355, 47);
            this.repeatPasswordTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 165);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 39);
            this.label4.TabIndex = 27;
            this.label4.Text = "Повторите пароль";
            // 
            // changePasswordButton
            // 
            this.changePasswordButton.Location = new System.Drawing.Point(24, 281);
            this.changePasswordButton.Name = "changePasswordButton";
            this.changePasswordButton.Size = new System.Drawing.Size(297, 50);
            this.changePasswordButton.TabIndex = 2;
            this.changePasswordButton.Text = "Изменить пароль";
            this.changePasswordButton.UseVisualStyleBackColor = true;
            this.changePasswordButton.Click += new System.EventHandler(this.ChangePasswordButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(8, 112);
            this.passwordTextBox.MaxLength = 30;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(355, 47);
            this.passwordTextBox.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 24;
            this.label3.Text = "Пароль";
            // 
            // RecoveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 482);
            this.Controls.Add(this.tabControl);
            this.MaximumSize = new System.Drawing.Size(395, 521);
            this.MinimumSize = new System.Drawing.Size(395, 521);
            this.Name = "RecoveryForm";
            this.Text = "Восстановление пароля";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RecoveryForm_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.userDataTabPage.ResumeLayout(false);
            this.userDataTabPage.PerformLayout();
            this.newPasswordTabPage.ResumeLayout(false);
            this.newPasswordTabPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage newPasswordTabPage;
        private System.Windows.Forms.TabPage userDataTabPage;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fullNameTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button confirmButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button changePasswordButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label label3;
    }
}