using CompService.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService.Presenters
{
    public class ConnectionPresenter
    {
        IConnectionView view;
        public ConnectionPresenter(IConnectionView view)
        {
            this.view = view;
        }

        public void LoadConnectionInfo()
        {
            view.Server = Core.Server;
            view.DataBase = Core.Database;
            view.Login = Core.Login;
            view.Password = Core.Password;
        }

        public void SaveConnection()
        {
            Core.Server = view.Server;
            Core.Database = view.DataBase;
            Core.Login = view.Login;
            Core.Password = view.Password;
            Core.NewConnectionString();
            MessageBox.Show("Настройки подключения изменены", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.None);
            MainForm adminForm = new MainForm();
            adminForm.Show();
            view.Close();
        }
    }
}
