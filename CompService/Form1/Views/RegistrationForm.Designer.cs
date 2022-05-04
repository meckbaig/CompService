
namespace CompService
{
    partial class RegistrationForm
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
            this.components = new System.ComponentModel.Container();
            this.regErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.registrationPage = new System.Windows.Forms.TabPage();
            this.repeatPasswordTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.registrationButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.infoPage = new System.Windows.Forms.TabPage();
            this.finishRegistrationButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.phoneNumberTextBox = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.fullNameTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.regErrorProvider)).BeginInit();
            this.tabControl.SuspendLayout();
            this.registrationPage.SuspendLayout();
            this.infoPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // regErrorProvider
            // 
            this.regErrorProvider.ContainerControl = this;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.registrationPage);
            this.tabControl.Controls.Add(this.infoPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(379, 482);
            this.tabControl.TabIndex = 0;
            // 
            // registrationPage
            // 
            this.registrationPage.BackColor = System.Drawing.Color.SeaShell;
            this.registrationPage.Controls.Add(this.repeatPasswordTextBox);
            this.registrationPage.Controls.Add(this.label4);
            this.registrationPage.Controls.Add(this.registrationButton);
            this.registrationPage.Controls.Add(this.passwordTextBox);
            this.registrationPage.Controls.Add(this.loginTextBox);
            this.registrationPage.Controls.Add(this.label3);
            this.registrationPage.Controls.Add(this.label2);
            this.registrationPage.Controls.Add(this.label1);
            this.registrationPage.Location = new System.Drawing.Point(4, 48);
            this.registrationPage.Name = "registrationPage";
            this.registrationPage.Padding = new System.Windows.Forms.Padding(3);
            this.registrationPage.Size = new System.Drawing.Size(371, 430);
            this.registrationPage.TabIndex = 0;
            this.registrationPage.Text = "Регистрация";
            // 
            // repeatPasswordTextBox
            // 
            this.repeatPasswordTextBox.Location = new System.Drawing.Point(8, 298);
            this.repeatPasswordTextBox.MaxLength = 30;
            this.repeatPasswordTextBox.Name = "repeatPasswordTextBox";
            this.repeatPasswordTextBox.Size = new System.Drawing.Size(355, 47);
            this.repeatPasswordTextBox.TabIndex = 23;
            this.repeatPasswordTextBox.TextChanged += new System.EventHandler(this.RepeatPasswordTextBox_TextChanged);
            this.repeatPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 256);
            this.label4.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(263, 39);
            this.label4.TabIndex = 22;
            this.label4.Text = "Повторите пароль";
            // 
            // registrationButton
            // 
            this.registrationButton.Location = new System.Drawing.Point(35, 375);
            this.registrationButton.Name = "registrationButton";
            this.registrationButton.Size = new System.Drawing.Size(297, 50);
            this.registrationButton.TabIndex = 21;
            this.registrationButton.Text = "Зарегистрироваться";
            this.registrationButton.UseVisualStyleBackColor = true;
            this.registrationButton.Click += new System.EventHandler(this.RegistrationButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(8, 203);
            this.passwordTextBox.MaxLength = 30;
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(355, 47);
            this.passwordTextBox.TabIndex = 20;
            this.passwordTextBox.TextChanged += new System.EventHandler(this.PasswordTextBox_TextChanged);
            this.passwordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(8, 105);
            this.loginTextBox.MaxLength = 30;
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(355, 47);
            this.loginTextBox.TabIndex = 19;
            this.loginTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBox_KeyDown);
            this.loginTextBox.Validating += new System.ComponentModel.CancelEventHandler(this.LoginTextBox_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 39);
            this.label3.TabIndex = 18;
            this.label3.Text = "Пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 63);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 39);
            this.label2.TabIndex = 17;
            this.label2.Text = "Логин";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(16, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 45);
            this.label1.TabIndex = 16;
            this.label1.Text = "Добро пожаловать!";
            // 
            // infoPage
            // 
            this.infoPage.BackColor = System.Drawing.Color.SeaShell;
            this.infoPage.Controls.Add(this.finishRegistrationButton);
            this.infoPage.Controls.Add(this.label7);
            this.infoPage.Controls.Add(this.phoneNumberTextBox);
            this.infoPage.Controls.Add(this.label10);
            this.infoPage.Controls.Add(this.label5);
            this.infoPage.Controls.Add(this.fullNameTextBox);
            this.infoPage.Location = new System.Drawing.Point(4, 48);
            this.infoPage.Name = "infoPage";
            this.infoPage.Padding = new System.Windows.Forms.Padding(3);
            this.infoPage.Size = new System.Drawing.Size(371, 430);
            this.infoPage.TabIndex = 1;
            this.infoPage.Text = "Доп информация";
            // 
            // finishRegistrationButton
            // 
            this.finishRegistrationButton.Location = new System.Drawing.Point(61, 284);
            this.finishRegistrationButton.Name = "finishRegistrationButton";
            this.finishRegistrationButton.Size = new System.Drawing.Size(232, 90);
            this.finishRegistrationButton.TabIndex = 63;
            this.finishRegistrationButton.Text = "Завершить регистрацию";
            this.finishRegistrationButton.UseVisualStyleBackColor = true;
            this.finishRegistrationButton.Click += new System.EventHandler(this.FinishRegistrationButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(18, 15);
            this.label7.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(304, 33);
            this.label7.TabIndex = 62;
            this.label7.Text = "Заполните информацию";
            // 
            // phoneNumberTextBox
            // 
            this.phoneNumberTextBox.Location = new System.Drawing.Point(8, 196);
            this.phoneNumberTextBox.Mask = "80000000000";
            this.phoneNumberTextBox.Name = "phoneNumberTextBox";
            this.phoneNumberTextBox.Size = new System.Drawing.Size(344, 47);
            this.phoneNumberTextBox.TabIndex = 61;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(253, 39);
            this.label10.TabIndex = 60;
            this.label10.Text = "Номер телефона:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 63);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(255, 39);
            this.label5.TabIndex = 59;
            this.label5.Text = "Ваше полное имя";
            // 
            // fullNameTextBox
            // 
            this.fullNameTextBox.Location = new System.Drawing.Point(8, 105);
            this.fullNameTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.fullNameTextBox.MaxLength = 50;
            this.fullNameTextBox.Name = "fullNameTextBox";
            this.fullNameTextBox.Size = new System.Drawing.Size(344, 47);
            this.fullNameTextBox.TabIndex = 56;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 39F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(379, 482);
            this.Controls.Add(this.tabControl);
            this.Font = new System.Drawing.Font("Calibri", 24F);
            this.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.MaximumSize = new System.Drawing.Size(395, 521);
            this.MinimumSize = new System.Drawing.Size(395, 521);
            this.Name = "RegistrationForm";
            this.Text = "RedistrationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.regErrorProvider)).EndInit();
            this.tabControl.ResumeLayout(false);
            this.registrationPage.ResumeLayout(false);
            this.registrationPage.PerformLayout();
            this.infoPage.ResumeLayout(false);
            this.infoPage.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ErrorProvider regErrorProvider;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage registrationPage;
        private System.Windows.Forms.TextBox repeatPasswordTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button registrationButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage infoPage;
        private System.Windows.Forms.Button finishRegistrationButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox phoneNumberTextBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox fullNameTextBox;
    }
}