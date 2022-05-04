using CompService.Models;
using CompService.Views;
using CompService.Supporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService.Presenters
{
    class CustomerPresenter
    {
        ICustomerModel model;
        ICustomerView view;
        Customer currentCustomer;

        public CustomerPresenter(ICustomerView view)
        {
            this.model = new CustomerModel();
            this.view = view;
        }
        public void SearchOrder(string idSearchOrder,
                                bool allowDateCheckBox,
                                DateTime receiptDateSearch,
                                bool allowCompletionDate,
                                DateTime completionDateSearch,
                                string defectDescriptionSearch,
                                string serialNumberSearch,
                                bool completedSearchCheckBox)
        {
            view.SearchData = model.SearchOrder(idSearchOrder,
                                                allowDateCheckBox,
                                                receiptDateSearch,
                                                allowCompletionDate,
                                                completionDateSearch,
                                                defectDescriptionSearch,
                                                serialNumberSearch,
                                                completedSearchCheckBox);
        }

        public void NewCustomerInformation()
        {
            try
            {
                currentCustomer = Core.Context.Customers.Find(CurrentUser.CustomerUser.IdCustomer);
                if (view.FullName != "" && view.Login != "" && view.PhoneNumber.Length == 11 && view.Login.Length > 4)
                {
                    bool dataChanged = false;
                    if (view.FullName != CurrentUser.CustomerUser.FullName)
                    {
                        currentCustomer.FullName = view.FullName;
                        dataChanged = true;
                    }
                    if (view.Login != CurrentUser.CustomerUser.User.Login)
                    {
                        currentCustomer.User.Login = view.Login;
                        dataChanged = true;
                    }
                    if (view.PhoneNumber != CurrentUser.CustomerUser.PhoneNumber)
                    {
                        currentCustomer.PhoneNumber = view.PhoneNumber;
                        dataChanged = true;
                    }
                    Core.Context.SaveChanges();
                    if (dataChanged)
                        MessageBox.Show("Изменения сохранены", "Успешно!", MessageBoxButtons.OK);
                }
                else
                    throw new Exception("Проверьте правильность ввода имени, логина или номера телефона");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void NewPassword()
        {
            try
            {
                currentCustomer = Core.Context.Customers.Find(CurrentUser.CustomerUser.IdCustomer);
                if (view.OldPassword == CurrentUser.CustomerUser.User.Password && view.NewPassword != "" && 
                    view.NewPassword == view.RepeatPassword && view.NewPassword.Length > 4 && view.NewPassword.Length <= 30)
                {
                    currentCustomer.User.Password = view.NewPassword;
                    Core.Context.SaveChanges();
                    MessageBox.Show("Пароль изменён", "Успешно!", MessageBoxButtons.OK);
                }
                else
                    throw new Exception("Проверьте правильность ввода пароля");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void ParceMyInfo()
        {
            view.FullName = CurrentUser.CustomerUser.FullName;
            view.Login = CurrentUser.CustomerUser.User.Login;
            view.PhoneNumber = CurrentUser.CustomerUser.PhoneNumber;
        }

        internal void PasswordEnabling(TextBox oldPassword, TextBox newPassword, TextBox repeatPassword)
        {
            if(oldPassword.Enabled)
                oldPassword.Enabled = newPassword.Enabled = repeatPassword.Enabled = false;
            else
                oldPassword.Enabled = newPassword.Enabled = repeatPassword.Enabled = true;
        }

        internal void NewRequest()
        {
            try
            {
                if (view.DefectDescription != "")
                {
                    Order orderRequest = new Order();
                    orderRequest.FullName = CurrentUser.CustomerUser.FullName;
                    orderRequest.PhoneNumber = CurrentUser.CustomerUser.PhoneNumber;
                    orderRequest.DefectDescription = view.DefectDescription;
                    orderRequest.IdCustomer = CurrentUser.CustomerUser.IdCustomer;
                    orderRequest.ReceiptDate = DateTime.Now;
                    orderRequest.Completed = false;
                    Core.Context.Orders.Add(orderRequest);
                    Core.Context.SaveChanges();
                    MessageBox.Show("Заявка отправлена, ожидайте СМС с\n приглашением в сервисный центр", "Успешно!", MessageBoxButtons.OK);
                    view.DefectDescription = "";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
