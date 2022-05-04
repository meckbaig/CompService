using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompService.Views
{
    public interface IConnectionView 
    {
        void Close();
        string Server { get; set; }
        string DataBase { get; set; }
        string Login { get; set; }
        string Password { get; set; }
    }
}
