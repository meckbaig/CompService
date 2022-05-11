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

        #region Pages
        decimal CurrentPage { set; get; }
        decimal CurrentPageMax { set; get; }
        decimal CurrentPageMin { set; get; }
        string TotalPages { set; get; }
        string ResultsAmount { set; }
        bool FirstPage { set; }
        bool LeftPage { set; }
        bool RightPage { set; }
        bool LastPage { set; }
        #endregion

        #region Sort
        bool DateAscending { get; }
        bool DateDescending { get; }
        #endregion

        #region CreateOrderInterface
        string EditFullName { set; get; }
        string EditPhoneNumber { set; get; }
        DateTime EditReceiptDate { set; get; }
        DateTime EditCompletionDate { set; get; }
        bool EnableCompletionDate { set; get; }
        bool EditCompleted { set; get; }
        string EditDefectDescription { set; get; }
        string EditSerialNumber { set; get; }
        object[] EditServicesInOrder { set; get; }
        object[] EditMastersInOrder { set; get; }
        object[] EditServices { set; get; }
        object[] EditMasters { set; get; }
        object[] EditParts { set; get; }
        #endregion

        #region EditMaster
        string MasterName { set; get; }
        string MasterLogin { set; get; }
        string MasterPassword { set; get; }
        #endregion

        #region TablesLoad
        object SortData { set; }
        object SearchData { set; get; }
        object MastersData { set; }
        #endregion

        #region CheckOutOrder
        string CheckIdOrder { set; get; }
        string CheckReceiptDate { set; get; }
        string CheckCompletionDate { set; get; }
        string CheckFullName { set; get; }
        string CheckPhoneNumber { set; get; }
        string CheckSerialNumber { set; get; }
        string CheckTotalPrice { set; get; }
        object ServicesInOrderData { set; get; }
        object PartsInOrderData { set; get; }
        bool PartsGridVisibility { set; get; }
        bool PartsTitleVisibility { set; get; }
        bool IfCompletedVisibility { set; }
        bool IfNullVisibility { set; }
        bool IfCompletedTablesReadonly { set; }
        #endregion

        #region Report
        object MonthlyReportData { set; get; }
        decimal MonthReport { set; get; }
        decimal YearReport { set; get; }
        #endregion
    }
}
