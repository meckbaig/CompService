using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompService.Models
{
    interface IRegistrationModel
    {
        void RegistrationMethod(string login, string password, string repeatPassword);
        User ParceCustomer(string login, string password);
        void AddInformation(string fullName, string phoneNumber);
    }
}
