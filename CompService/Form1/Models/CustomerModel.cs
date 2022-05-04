using System;
using CompService.Supporting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompService.Models
{
    class CustomerModel : ICustomerModel
    {
        public List<FullOrderInfo> SearchOrder(string idSearchOrder,
                                   bool allowDateCheckBox,
                                   DateTime receiptDateSearch,
                                   bool allowCompletionDate,
                                   DateTime completionDateSearch,
                                   string defectDescriptionSearch,
                                   string serialNumberSearch,
                                   bool completedSearchCheckBox)
        {
            var orders = Core.Context.FullOrderInfoes.ToList();
            orders = orders.Where(o => o.IdCustomer == CurrentUser.CustomerUser.IdCustomer).ToList();
            if (idSearchOrder != "")
                orders = orders.Where(o => o.IdOrder == Convert.ToInt32(idSearchOrder)).ToList();
            if (allowDateCheckBox)
                orders = orders.Where(o => o.ReceiptDate.Date.Date == receiptDateSearch.Date).ToList();
            if (allowCompletionDate)
                orders = orders.Where(o => o.CompletionDate == completionDateSearch.Date).ToList();
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
