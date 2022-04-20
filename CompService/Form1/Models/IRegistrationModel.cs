using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.Models
{
    interface IRegistrationModel
    {
        void RegistrationMethod(string login, string password, string repeatPassword);
    }
}
