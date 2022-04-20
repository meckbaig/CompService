
namespace Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главнаяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.возможностиАдминаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.ordersCutomer = new System.Windows.Forms.TabPage();
            this.accountCustomer = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главнаяToolStripMenuItem,
            this.возможностиАдминаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1223, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // главнаяToolStripMenuItem
            // 
            this.главнаяToolStripMenuItem.Name = "главнаяToolStripMenuItem";
            this.главнаяToolStripMenuItem.Size = new System.Drawing.Size(70, 23);
            this.главнаяToolStripMenuItem.Text = "Заказы";
            // 
            // возможностиАдминаToolStripMenuItem
            // 
            this.возможностиАдминаToolStripMenuItem.Name = "возможностиАдминаToolStripMenuItem";
            this.возможностиАдминаToolStripMenuItem.Size = new System.Drawing.Size(74, 23);
            this.возможностиАдминаToolStripMenuItem.Text = "Аккаунт";
            this.возможностиАдминаToolStripMenuItem.Click += new System.EventHandler(this.возможностиАдминаToolStripMenuItem_Click);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.ordersCutomer);
            this.tabControl.Controls.Add(this.accountCustomer);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 29);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1223, 632);
            this.tabControl.TabIndex = 2;
            // 
            // ordersCutomer
            // 
            this.ordersCutomer.Location = new System.Drawing.Point(4, 28);
            this.ordersCutomer.Name = "ordersCutomer";
            this.ordersCutomer.Padding = new System.Windows.Forms.Padding(3);
            this.ordersCutomer.Size = new System.Drawing.Size(1215, 600);
            this.ordersCutomer.TabIndex = 0;
            this.ordersCutomer.Text = "Заказы";
            this.ordersCutomer.UseVisualStyleBackColor = true;
            // 
            // accountCustomer
            // 
            this.accountCustomer.Location = new System.Drawing.Point(4, 28);
            this.accountCustomer.Name = "accountCustomer";
            this.accountCustomer.Padding = new System.Windows.Forms.Padding(3);
            this.accountCustomer.Size = new System.Drawing.Size(1215, 600);
            this.accountCustomer.TabIndex = 1;
            this.accountCustomer.Text = "Аккаунт";
            this.accountCustomer.UseVisualStyleBackColor = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 661);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.menuStrip1);
            this.MaximumSize = new System.Drawing.Size(1239, 700);
            this.MinimumSize = new System.Drawing.Size(1239, 700);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главнаяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem возможностиАдминаToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage ordersCutomer;
        private System.Windows.Forms.TabPage accountCustomer;
    }
}