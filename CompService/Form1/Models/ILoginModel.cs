using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompService.Models
{
    interface ILoginModel
    {
        User LoginMethod(string login, string password);
        bool CheckConnection();
    }
}
