using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1.Models
{
    interface IAdminModel
    {
        object SortOrders(bool checkBoxChecked);

        void AddNewOrder(string fullName, string phoneNumber, DateTime receiptDate,
            string defectDescription, string serialNumber, object servicesInOrder,
            object mastersInOrder, object parts); // сюда не смотреть!!

        List<MostFullOrderInfo> SearchOrder(string idSearchOrder,
                               string fullNameSearch,
                               string phoneNumberSearch,
                               bool allowDateCheckBox,
                               DateTime receiptDateSearch,
                               string defectDescriptionSearch,
                               string serialNumberSearch,
                               bool completedSearchCheckBox);

        void OrdersLoad(ListBox.ObjectCollection Services, ListBox.ObjectCollection Masters);

        void EditOrdersLoad(int SelectedId,
                            TextBox fullName,
                            MaskedTextBox phoneNumber,
                            DateTimePicker receiptDate,
                            CheckBox completedCheckBox,
                            TextBox defectDescription,
                            TextBox serialNumber,
                            ListBox.ObjectCollection ServicesInOrder,
                            ListBox.ObjectCollection MastersInOrder,
                            ListBox.ObjectCollection Services,
                            ListBox.ObjectCollection Masters,
                            ListBox.ObjectCollection Parts);
    }
}
