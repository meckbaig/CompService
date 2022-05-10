using System;
using CompService.Views;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CompService.Presenters;

namespace CompService.Views
{
    public partial class ConnectionForm : TemplateForm, IConnectionView
    {
        ConnectionPresenter presenter;
        public string Server
        {
            set
            {
                serverTextBox.Text = value;
            }
            get
            {
                return serverTextBox.Text;
            }
        }
        public string DataBase
        {
            set
            {
                databaseTextBox.Text = value;
            }
            get
            {
                return databaseTextBox.Text;
            }
        }
        public string Login
        {
            set
            {
                loginTextBox.Text = value;
            }
            get
            {
                return loginTextBox.Text;
            }
        }
        public string Password
        {
            set
            {
                passwordTextBox.Text = value;
            }
            get
            {
                return passwordTextBox.Text;
            }
        }
        public ConnectionForm()
        {
            InitializeComponent();
            presenter = new ConnectionPresenter(this);
        }

        private void ConnectionForm_Load(object sender, EventArgs e)
        {
            presenter.LoadConnectionInfo();
        }

        private void SaveConnectionPropertiesButton_Click(object sender, EventArgs e)
        {
            presenter.SaveConnection();
        }

        private void ConnectionForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
