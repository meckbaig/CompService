using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1.Models
{
    class AdminModel : IAdminModel
    {
        public void OrdersLoad(ListBox.ObjectCollection Services, ListBox.ObjectCollection Masters)
        {
            foreach (var item in Core.Context.Services.ToList())
            {
                Services.Add(item);
            }
            foreach (var item in Core.Context.Masters.ToList())
            {
                Masters.Add(item);
            }
        }

        public void EditOrdersLoad(int SelectedId)
        {
            var order = Core.Context.Orders.FirstOrDefault(o => o.IdOrder == SelectedId);

        }

        public void LoadEditOrders(int SelectedId, 
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
                                   object[] editParts)
        {
            var orders = Core.Context.Orders.FirstOrDefault(o => o.IdOrder == SelectedId);
            editFullName = orders.FullName;
            editPhoneNumber = orders.PhoneNumber;
            editDate = orders.ReceiptDate;
            editCompletedSearch = orders.Completed.Value;
            editDefectDescription = orders.DefectDescription;
            editserialNumber = orders.SerialNumber;
            editServicesInOrder.Clear();
            editMastersInOrder.Clear();
            editServices.Clear();
            editMasters.Clear();
            editParts.Clear();
            foreach (var item in orders.Services.ToList())
            {
                editServicesInOrder.Add(item);
            }
            foreach (var item in orders.Masters.ToList())
            {
                editMastersInOrder.Add(item);
            }
            foreach (var item in Core.Context.Services.ToList())
            {
                editServices.Add(item);
            }
            foreach (var item in Core.Context.Masters.ToList())
            {
                editMasters.Add(item);
            }
            foreach (var item in orders.Parts.ToList())
            {
                editParts.Add(item);
            }
            foreach (var item in editServicesInOrder)
            {
                editServices.Remove(item);
            }
            foreach (var item in editMastersInOrder)
            {
                editMasters.Remove(item);
            }
        }

        public object SortOrders(bool checkBoxChecked)
        {
            if (checkBoxChecked)
                return Core.Context.MostFullOrderInfoes.ToList();
            else
                return Core.Context.MostFullOrderInfoWhenNotCompleteds.ToList();
        }

        public void AddNewOrder(string fullName, string phoneNumber, DateTime receiptDate,
            string defectDescription, string serialNumber, object servicesInOrder,
            object mastersInOrder, object parts)
        {
            Order order = new Order();
            order.FullName = fullName;
            order.PhoneNumber = phoneNumber;
            order.ReceiptDate = receiptDate;
            order.DefectDescription = defectDescription;
            order.SerialNumber = serialNumber;
            order.Completed = false;
            foreach (var item in servicesInOrder as object[])
            {
                order.Services.Add(item as Service);
            }
            foreach (var item in mastersInOrder as object[])
            {
                order.Masters.Add(item as Master);
            }
            foreach (var item in parts as object[])
            {
                order.Parts.Add(item as Part);
            }
            Core.Context.Orders.Add(order);
            Core.Context.SaveChanges();
        }

        public List<MostFullOrderInfo> SearchOrder(string idSearchOrder,
                                string fullNameSearch,
                                string phoneNumberSearch,
                                bool allowDateCheckBox,
                                DateTime receiptDateSearch,
                                string defectDescriptionSearch,
                                string serialNumberSearch,
                                bool completedSearchCheckBox)
        {
            var orders = Core.Context.MostFullOrderInfoes.ToList();
            if (idSearchOrder != "")
                orders = orders.Where(o => o.IdOrder == Convert.ToInt32(idSearchOrder)).ToList();
            if (fullNameSearch != "")
                orders = orders.Where(o => o.FullName.ToLower().Contains(fullNameSearch.ToLower())).ToList();
            if (phoneNumberSearch != "")
                orders = orders.Where(o => o.PhoneNumber.Contains(phoneNumberSearch)).ToList();
            if (allowDateCheckBox)
                orders = orders.Where(o => o.ReceiptDate.Date.Date == receiptDateSearch.Date).ToList();
            if (defectDescriptionSearch != "")
                orders = orders.Where(o => o.DefectDescription.ToLower().Contains(defectDescriptionSearch.ToLower())).ToList();
            if (serialNumberSearch != "")
                orders = orders.Where(o => o.SerialNumber.ToLower().Contains(serialNumberSearch.ToLower())).ToList();
            if (completedSearchCheckBox)
                orders = orders.Where(o => !(o.Completed ?? true)).ToList();           //проверка на завершенность

            return orders;
        }
    }
}
