using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompService.Views
{
    interface ICustomerView
    {
        object SearchData { set; }
        string FullName { set; get; }
        string Login { set; get; }
        string OldPassword { set; get; }
        string PhoneNumber { set; get; }
        string NewPassword { set; get; }
        string RepeatPassword { set; get; }
        string DefectDescription { set; get; }
    }
}
