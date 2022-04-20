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
            object mastersInOrder, object parts);

        List<MostFullOrderInfo> SearchOrder(string idSearchOrder,
                               string fullNameSearch,
                               string phoneNumberSearch,
                               bool allowDateCheckBox,
                               DateTime receiptDateSearch,
                               string defectDescriptionSearch,
                               string serialNumberSearch,
                               bool completedSearchCheckBox);
        void OrdersLoad(ListBox.ObjectCollection Services, ListBox.ObjectCollection Masters);

        object EditOrdersLoad(int SelectedId);
        void LoadEditOrders(int SelectedId,
                                   string editFullName,
                                   string editPhoneNumber,
                                   DateTime editDate,
                                   bool editCompletedSearch,
                                   string editDefectDescription,
                                   string editserialNumber,
                                   object[] editServicesInOrder,
                                   object[] editMastersInOrder,
                                   object[] editServices,
                                   object[] editMasters,
                                   object[] editParts);
    }
}
