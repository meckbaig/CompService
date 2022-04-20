using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.Views
{
    interface IAdminView
    {

        object SortData { set; }
        object SearchData { set; }
    }
}
