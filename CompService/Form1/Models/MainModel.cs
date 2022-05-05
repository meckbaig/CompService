using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService.Models
{
    class MainModel : IMainModel
    {
        List<FullOrderInfo> orders;

        public void SaveOrder(Order order)
        {
            if (order.IdOrder == 0)
                Core.Context.Orders.Add(order);
            Core.Context.SaveChanges();
        }

        public object SortOrders(bool checkBoxChecked)
        {
            if (checkBoxChecked)
                return Core.Context.FullOrderInfoWhenNotCompleteds.ToList();
            else
                return Core.Context.FullOrderInfoes.ToList();
        }

        public List<FullOrderInfo> OrdersLoad()
        {
            orders = Core.Context.FullOrderInfoes.AsNoTracking().ToList();
            return orders;
        }
        public List<FullOrderInfo> ReturnOrders()
        {
            return orders;
        }

        public List<FullOrderInfo> SearchOrder(string idSearchOrder,
                                string fullNameSearch,
                                string phoneNumberSearch,
                                bool allowDateCheckBox,
                                DateTime receiptDateSearch,
                                bool allowCompletionDate,
                                DateTime completionDateSearch,
                                string defectDescriptionSearch,
                                string serialNumberSearch,
                                bool completedSearchCheckBox)
        {
            orders = Core.Context.FullOrderInfoes.AsNoTracking().ToList();
            if (idSearchOrder != "")
                orders = orders.Where(o => o.IdOrder == Convert.ToInt32(idSearchOrder)).ToList();
            if (fullNameSearch != "")
                orders = orders.Where(o => o.FullName.ToLower().Contains(fullNameSearch.ToLower())).ToList();
            if (phoneNumberSearch != "")
                orders = orders.Where(o => o.PhoneNumber.Contains(phoneNumberSearch)).ToList();
            if (allowDateCheckBox)
                orders = orders.Where(o => o.ReceiptDate.Date.Date == receiptDateSearch.Date).ToList();
            if (allowCompletionDate)
                orders = orders.Where(o => o.CompletionDate == completionDateSearch.Date).ToList();
            if (defectDescriptionSearch != "")
                orders = orders.Where(o => o.DefectDescription.ToLower().Contains(defectDescriptionSearch.ToLower())).ToList();
            if (serialNumberSearch != "")
                orders = orders.Where(o => o.SerialNumber?.ToLower().Contains(serialNumberSearch.ToLower()) ?? false).ToList();
            if (completedSearchCheckBox)
                orders = orders.Where(o => !(o.Completed ?? true)).ToList();

            return orders;
        }

        public Order GetOrder(int selectedId)
        {
            return Core.Context.Orders.Find(selectedId);
        }

        public object[] GetServicesNotInOrder(ICollection<Service> services)
        {
            var servicesNotInOrder = Core.Context.Services.ToList();
            foreach(var item in services)
            {
                servicesNotInOrder.Remove(item);
            }
            return servicesNotInOrder.ToArray();
        }

        public object[] GetMastersNotInOrder(ICollection<Master> masters)
        {
            var mastersNotInOrder = Core.Context.Masters.ToList();
            foreach (var item in masters)
            {
                mastersNotInOrder.Remove(item);
            }
            return mastersNotInOrder.ToArray();
        }

        public List<FullOrderInfo> SearchDataOrderBy(int skip, int pageSize)
        {
            return orders.OrderByDescending(o => o.ReceiptDate).Skip(skip).Take(pageSize).ToList();
        }
    }
}
