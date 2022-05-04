using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompService.Models
{
    interface ICustomerModel
    {
        List<FullOrderInfo> SearchOrder(string idSearchOrder,
                                  bool allowDateCheckBox,
                                  DateTime receiptDateSearch,
                                  bool allowCompletionDate,
                                  DateTime completionDateSearch,
                                  string defectDescriptionSearch,
                                  string serialNumberSearch,
                                  bool completedSearchCheckBox);
    }
}
