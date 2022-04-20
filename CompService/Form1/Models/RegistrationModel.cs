using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.Models
{
    class RegistrationModel : IRegistrationModel
    {
        public void RegistrationMethod(string login, string password, string repeatPassword)
        {

            if (login != "" && password != "" && password == repeatPassword && login.Length > 4 && password.Length > 4 && login.Length <= 30 && password.Length <= 30)
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
                        //MessageBox.Show("Такой пользователь уже существует", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                throw new Exception("Проверьте правильность ввода логина и пароля");
                //MessageBox.Show("Проверьте правильность ввода логина и пароля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
