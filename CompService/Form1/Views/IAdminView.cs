using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Form1.Views
{
    interface IAdminView
    {
        object[] Masters { get; }
        object[] Services { get; }
        object[] Parts { get; }

        string EditFullName { set; get; }
        string EditPhoneNumber { set; get; }
        DateTime EditDate { set; get; }
        bool EditCompletedSearch { set; get; }
        string EditDefectDescription { set; get; }
        string EditserialNumber { set; get; }
        object[] EditServicesInOrder { set; get; }
        object[] EditMastersInOrder { set; get; }
        object[] EditServices { set; get; }
        object[] EditMasters { set; get; }
        object[] EditParts { set; get; }

        object SortData { set; }
        object SearchData { set; }
    }
}
