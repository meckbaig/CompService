using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService.Models
{
    interface IMainModel
    {
        object SortOrders(bool checkBoxChecked);

        List<FullOrderInfo> SearchOrder(string idSearchOrder,
                               string fullNameSearch,
                               string phoneNumberSearch,
                               bool allowDateCheckBox,
                               DateTime receiptDateSearch,
                               bool allowCompletionDate,
                               DateTime completionDateSearch,
                               string defectDescriptionSearch,
                               string serialNumberSearch,
                               bool completedSearchCheckBox);
        List<FullOrderInfo> OrdersLoad();
        Order GetOrder(int selectedId);

        object[] GetServicesNotInOrder(ICollection<Service> services);
        object[] GetMastersNotInOrder(ICollection<Master> masters);
        void SaveOrder(Order currentOrder);
        List<FullOrderInfo> SearchDataOrderBy(int skip, int pageSize);
        List<FullOrderInfo> ReturnOrders();
    }
}
