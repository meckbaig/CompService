using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompService.Views
{
    interface IMainView
    {
        void Hide();
        object[] Masters { get; }
        object[] Services { get; }
        object[] Parts { get; }

        decimal CurrentPage { set; get; }
        string TotalPages { set; get; }

        string FullName { set; get; }
        string PhoneNumber { set; get; }
        DateTime ReceiptDate { set; get; }
        DateTime CompletionDate { set; get; }
        bool EnableCompletionDate { set; get; }
        bool CompletedSearch { set; get; }
        string DefectDescription { set; get; }
        string SerialNumber { set; get; }
        object[] EditServicesInOrder { set; get; }
        object[] EditMastersInOrder { set; get; }
        object[] EditServices { set; get; }
        object[] EditMasters { set; get; }
        object[] EditParts { set; get; }

        string MasterName { set; get; }
        string MasterLogin { set; get; }
        string MasterPassword { set; get; }

        object SortData { set; }
        object SearchData { set; get; }
        object MastersData { set; }
        object ServicesInOrderData { set; get; }
    }
}
