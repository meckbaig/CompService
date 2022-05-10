using CompService.Supporting;
using CompService.Views;
using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                var connectionData = StringСryptography.Decrypt(File.ReadAllText(Environment.CurrentDirectory + @"/config")).Split(';');
                view.Server = connectionData[0];
                view.DataBase = connectionData[1];
                view.Login = connectionData[2];
                view.Password = connectionData[3];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveConnection()
        {
            Core.Server = view.Server;
            Core.Database = view.DataBase;
            Core.Login = view.Login;
            Core.Password = view.Password;
            Core.NewConnectionString();
            try
            {
                Core.Context.FullOrderInfoes.AsNoTracking().ToList();
                MessageBox.Show("Настройки подключения изменены", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.None);
                MainForm adminForm = new MainForm();
                adminForm.Show();
                view.Hide();
            }
            catch (Exception)
            {
                MessageBox.Show("Ошибка подключения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
