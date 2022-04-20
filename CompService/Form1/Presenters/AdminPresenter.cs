using Form1.Models;
using Form1.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1.Presenters
{
    class AdminPresenter
    {
        IAdminModel model;
        IAdminView view;

            public AdminPresenter(IAdminView view)
        {
            this.model = new AdminModel();
            this.view = view;
        }

        public void OrdersLoad(ListBox.ObjectCollection Services, ListBox.ObjectCollection Masters)
        {
            view.SearchData = Core.Context.MostFullOrderInfoes.ToList();
            model.OrdersLoad(Services, Masters);
        }

        public void EditOrdersLoad(int SelectedId)
        {
            model.LoadEditOrders(SelectedId, 
                                 view.EditFullName, 
                                 view.EditPhoneNumber, 
                                 view.EditDate, 
                                 view.EditCompletedSearch, 
                                 view.EditDefectDescription, 
                                 view.EditserialNumber, 
                                 view.EditServicesInOrder, 
                                 view.EditMastersInOrder,
                                 view.EditServices,
                                 view.EditMasters,
                                 view.EditParts);
        }

        public void SortOrders(bool checkBoxChecked)
        {
            view.SortData = model.SortOrders(checkBoxChecked);
        }
        public void SearchOrder(string idSearchOrder,
                                string fullNameSearch,
                                string phoneNumberSearch,
                                bool allowDateCheckBox,
                                DateTime receiptDateSearch,
                                string defectDescriptionSearch,
                                string serialNumberSearch,
                                bool completedSearchCheckBox)
        {
            view.SearchData = model.SearchOrder(idSearchOrder,
                                                fullNameSearch,
                                                phoneNumberSearch,
                                                allowDateCheckBox,
                                                receiptDateSearch,
                                                defectDescriptionSearch,
                                                serialNumberSearch,
                                                completedSearchCheckBox);
        }

        public void AddNewOrder(string fullName, 
                                string phoneNumber, 
                                DateTime receiptDate,
                                string defectDescription, 
                                string serialNumber, 
                                object servicesInOrder,
                                object mastersInOrder, 
                                object parts)
        {
            if (fullName != "" && phoneNumber != "" && defectDescription != "")
            {
                model.AddNewOrder(fullName, 
                                  phoneNumber, 
                                  receiptDate,
                                  defectDescription, 
                                  serialNumber, 
                                  servicesInOrder,
                                  mastersInOrder, 
                                  parts);
                MessageBox.Show("Заказ добавлен", "Успешно!", MessageBoxButtons.OK);
            }
            else
                MessageBox.Show("Заполните поля", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
