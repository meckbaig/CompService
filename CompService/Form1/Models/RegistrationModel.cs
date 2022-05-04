using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CompService.Supporting;

namespace CompService.Models
{
    class RegistrationModel : IRegistrationModel
    {
        public void RegistrationMethod(string login, string password, string repeatPassword)
        {

            if (login != "" && password != "" && password == repeatPassword && login.Length > 4 && password.Length > 4)
            {
                var result = Core.Context.Users.FirstOrDefault(u => u.Login == login);
                if (result == null)
                {
                    User user = new User();
                    user.Login = login;
                    user.Password = password;
                    user.Role = Core.Context.Roles.First(r => r.RoleName == "User");
                    Core.Context.Users.Add(user);
                    Core.Context.SaveChanges();
                }
                else
                    throw new Exception("Такой пользователь уже существует");
            }
            else
                throw new Exception("Проверьте правильность ввода логина и пароля");
        }

        public User ParceCustomer(string login, string password)
        {
            NewCustomer.User = Core.Context.Users.FirstOrDefault(c => c.Login == login && c.Password == password);
            return NewCustomer.User;
        }

        public void AddInformation(string fullName, string phoneNumber)
        {
            var result = Core.Context.Customers.FirstOrDefault(c => c.PhoneNumber == phoneNumber);
            if (result == null)
            {
                Customer customer = new Customer();
                customer.FullName = fullName;
                customer.PhoneNumber = phoneNumber;
                customer.IdUser = NewCustomer.User.IdUser;
                Core.Context.Customers.Add(customer);
                Core.Context.SaveChanges();
            }
            else
                throw new Exception("Указанный номер телефона уже занят");
        }
    }
}
