using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompService.Views
{
    interface ILoginView
    {
        void Hide();
        string Login { set; get; }
        string Password { set; get; }
        bool SaveOptions { set; get; }
    }
}
