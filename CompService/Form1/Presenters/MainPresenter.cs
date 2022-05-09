using CompService.Models;
using CompService.Views;
using CompService.Supporting;
using System;
using System.Linq;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;
using Excel = Microsoft.Office.Interop.Excel;

namespace CompService.Presenters
{
    class MainPresenter
    {
        IMainModel model;
        IMainView view;
        Order currentOrder;
        Order checkOrder;
        Master editMaster;
        int? parceCustomerId = null;

        public MainPresenter(IMainView view)
        {
            this.model = new MainModel();
            this.view = view;
        }

        #region SearchOrder
        public void OrdersLoad()
        {
            try
            {
                view.SearchData = model.OrdersLoad();
                view.CurrentPage = 1;
            }
            catch (Exception)
            {
                MessageBox.Show("Проблемы с подключением к БД. \nПопробуйте сменить параметры подключения", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SearchOrder(string idSearchOrder, string fullNameSearch, string phoneNumberSearch,
                                bool allowDateCheckBox, DateTime receiptDateSearch, bool allowCompletionDate,
                                DateTime completionDateSearch, string defectDescriptionSearch,
                                string serialNumberSearch, bool completedSearchCheckBox)
        {
            try
            {
                view.SearchData = model.SearchOrder(idSearchOrder, fullNameSearch, phoneNumberSearch, allowDateCheckBox,
                                                    receiptDateSearch, allowCompletionDate, completionDateSearch,
                                                    defectDescriptionSearch, serialNumberSearch, completedSearchCheckBox);
                view.CurrentPage = view.CurrentPageMin = 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void Navigation(int pageSize, int currentPage)
        {
            try
            {
                var data = model.ReturnOrders();
                var count = data.Count();
                int amountPages = count / pageSize + (count % pageSize > 0 ? 1 : 0);
                var skip = pageSize * (currentPage - 1);
                var take = model.SearchDataOrderBy(skip, pageSize);
                view.SearchData = take;
                view.CurrentPageMax = amountPages;
                view.ResultsAmount = Convert.ToString(count);
                view.TotalPages = amountPages.ToString();
                LockButtons(currentPage, amountPages);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void LockButtons(int currentPage, int amountPages)
        {
            try
            {
                view.FirstPage = view.LeftPage = currentPage > 1;
                if (view.CurrentPageMax == 1 || currentPage >= amountPages)
                    view.LastPage = view.RightPage = false;
                else
                    view.LastPage = view.RightPage = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        # region NewOrder/EditOrder
        public void EditOrdersLoad(int selectedId)
        {
            try
            {
                currentOrder = model.GetOrder(selectedId);

                view.FullName = currentOrder.FullName;
                view.PhoneNumber = currentOrder.PhoneNumber;
                view.ReceiptDate = currentOrder.ReceiptDate;
                if (currentOrder.CompletionDate?.Date != null)
                {
                    view.CompletionDate = currentOrder.CompletionDate.Value;
                    view.EnableCompletionDate = true;
                }
                else
                    view.EnableCompletionDate = false;
                view.CompletedSearch = currentOrder.Completed;
                view.DefectDescription = currentOrder.DefectDescription;
                view.SerialNumber = currentOrder.SerialNumber;
                view.EditServicesInOrder = currentOrder.Services.ToArray();
                view.EditMastersInOrder = currentOrder.Masters.ToArray();
                view.EditServices = model.GetServicesNotInOrder(currentOrder.Services);
                view.EditMasters = model.GetMastersNotInOrder(currentOrder.Masters);
                view.EditParts = currentOrder.Parts.ToArray();
                parceCustomerId = currentOrder.IdCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ParceCustomer()
        {
            try
            {
                view.FullName = ParceCustomerIntoOrder.User.FullName;
                view.PhoneNumber = ParceCustomerIntoOrder.User.PhoneNumber;
                parceCustomerId = ParceCustomerIntoOrder.User.IdCustomer;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearOrder()
        {
            try
            {
                view.FullName = null;
                view.PhoneNumber = null;
                view.ReceiptDate = DateTime.Now;
                view.CompletionDate = DateTime.Now;
                view.EnableCompletionDate = false;
                view.CompletedSearch = false;
                view.DefectDescription = null;
                view.SerialNumber = null;
                view.EditServicesInOrder = null;
                view.EditMastersInOrder = null;
                view.EditServices = Core.Context.Services.ToArray();
                view.EditMasters = Core.Context.Masters.ToArray();
                view.EditParts = null;
                parceCustomerId = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SaveOrder()
        {
            try
            {
                if (currentOrder == null)
                    currentOrder = new Order();
                currentOrder.FullName = view.FullName;
                currentOrder.PhoneNumber = view.PhoneNumber;
                currentOrder.ReceiptDate = view.ReceiptDate;
                if (view.EnableCompletionDate)
                    currentOrder.CompletionDate = view.CompletionDate;
                currentOrder.Completed = view.CompletedSearch;
                currentOrder.DefectDescription = view.DefectDescription;
                currentOrder.SerialNumber = view.SerialNumber;
                currentOrder.Services = view.EditServicesInOrder.Cast<Service>().ToList();
                currentOrder.Masters = view.EditMastersInOrder.Cast<Master>().ToList();
                currentOrder.Parts = view.EditParts.Cast<Part>().ToList();
                currentOrder.IdCustomer = parceCustomerId;
                model.SaveOrder(currentOrder);
                MessageBox.Show("Успешно!", "Сохранено!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrdersLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Sort
        public void SortOrders(bool checkBoxChecked)
        {
            try
            {
                view.SortData = model.SortOrders(checkBoxChecked, view.DateAscending, view.DateDescending);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region MasterEdit
        public void SortMasters(string search, bool byName)
        {
            try
            {
                if (byName)
                    view.MastersData = Core.Context.MasterInfoes.Where(m => m.FullName.Contains(search)).ToList();
                else
                    view.MastersData = Core.Context.MasterInfoes.Where(m => m.Login.Contains(search)).ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void EditMasterLoad(int selectedMasterId)
        {
            try
            {
                editMaster = Core.Context.Masters.Find(selectedMasterId);

                view.MasterName = editMaster.FullName;
                view.MasterLogin = editMaster.User.Login;
                view.MasterPassword = editMaster.User.Password;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void SaveMaster()
        {
            try
            {
                if (editMaster == null)
                {
                    User masterUser = new User();
                    masterUser.Login = view.MasterLogin;
                    masterUser.Password = view.MasterPassword;
                    masterUser.Role = Core.Context.Roles.First(r => r.RoleName == "Master");
                    Core.Context.Users.Add(masterUser);
                    editMaster = new Master();
                    editMaster.IdUser = masterUser.IdUser;
                }
                else
                {
                    editMaster.User.Login = view.MasterLogin;
                    editMaster.User.Password = view.MasterPassword;
                }
                editMaster.FullName = view.MasterName;
                if (editMaster.IdMaster == 0)
                    Core.Context.Masters.Add(editMaster);
                Core.Context.SaveChanges();

                editMaster = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region CheckOut
        internal void CheckOutLoad(int selectedId)
        {
            try
            {
                view.ServicesInOrderData = Core.Context.ServicesByIdOrder(selectedId).ToList();
                view.PartsInOrderData = Core.Context.PartsByIdOrder(selectedId).ToList();
                checkOrder = Core.Context.Orders.FirstOrDefault(o => o.IdOrder == selectedId);
                view.CheckIdOrder = Convert.ToString(checkOrder.IdOrder);
                view.CheckReceiptDate = Convert.ToString(checkOrder.ReceiptDate.ToShortDateString());
                if (checkOrder.CompletionDate == null)
                    view.CheckCompletionDate = Convert.ToString(DateTime.Now);
                else
                    view.CheckCompletionDate = Convert.ToString(Convert.ToDateTime(checkOrder.CompletionDate.Value).ToShortDateString());
                view.CheckFullName = checkOrder.FullName;
                view.CheckPhoneNumber = checkOrder.PhoneNumber;
                view.CheckSerialNumber = checkOrder.SerialNumber;
                HideIfCompleted();
                HideParts();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void RecalculateTotalPrice()
        {
            try
            {
                double totalPrice = 0;
                var servicesData = view.ServicesInOrderData as object[][];
                var partsData = view.PartsInOrderData as object[][];
                for (int i = 0; i < servicesData[1].Length; i++)
                {
                    totalPrice += Convert.ToDouble(servicesData[3][i]);
                }
                if ((view.PartsInOrderData as object[][])[0][0] != null)
                {
                    for (int i = 0; i < partsData[1].Length; i++)
                    {
                        totalPrice += Convert.ToDouble(partsData[3][i]);
                    }
                }
                view.CheckTotalPrice = totalPrice.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void HideIfCompleted()
        {
            if (checkOrder.Completed)
            {
                view.IfCompletedVisibility = false;
                view.IfCompletedTablesReadonly = true;
                view.CheckTotalPrice = Convert.ToString(checkOrder.TotalPrice);
            }
            else
            {
                view.IfCompletedVisibility = true;
                view.IfCompletedTablesReadonly = false;
                RecalculateTotalPrice();
            }
        }

        internal void HideParts()
        {
            try
            {
                if ((view.PartsInOrderData as object[][])[0][0] == null)
                    view.PartsGridVisibility = view.PartsTitleVisibility = false;
                else
                    view.PartsGridVisibility = view.PartsTitleVisibility = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void CheckPrinting()
        {
            try
            {
                int rub = (int)Convert.ToDouble(view.CheckTotalPrice);
                int cop = (int)((Convert.ToDouble(view.CheckTotalPrice) - rub) * 100);
                var wordApp = new Word.Application();
                var document = wordApp.Documents.Add(Environment.CurrentDirectory + @"\templates\template.docx");
                document.Content.Find.Execute(FindText: "%IdOrder", ReplaceWith: view.CheckIdOrder, Replace: Word.WdReplace.wdReplaceOne);
                document.Content.Find.Execute(FindText: "%CompletionDate", ReplaceWith: view.CheckCompletionDate, Replace: Word.WdReplace.wdReplaceOne);
                document.Content.Find.Execute(FindText: "%FullName", ReplaceWith: view.CheckFullName, Replace: Word.WdReplace.wdReplaceOne);
                document.Content.Find.Execute(FindText: "%ReceiptDate", ReplaceWith: view.CheckReceiptDate, Replace: Word.WdReplace.wdReplaceOne);
                document.Content.Find.Execute(FindText: "%PhoneNumber", ReplaceWith: view.CheckPhoneNumber, Replace: Word.WdReplace.wdReplaceOne);
                document.Content.Find.Execute(FindText: "%SerialNumber", ReplaceWith: view.CheckSerialNumber, Replace: Word.WdReplace.wdReplaceOne);
                document.Content.Find.Execute(FindText: "%rubPrice", ReplaceWith: rub, Replace: Word.WdReplace.wdReplaceOne);
                document.Content.Find.Execute(FindText: "%copPrice", ReplaceWith: cop, Replace: Word.WdReplace.wdReplaceOne);

                var servicesTable = document.Tables[2];
                var servicesData = view.ServicesInOrderData as object[][];
                for (int i = 0; i < servicesData[1].Length; i++)
                {
                    servicesTable.Rows.Add(servicesTable.Rows[i + 2]);
                    servicesTable.Cell(i + 2, 1).Range.Text = servicesData[0][i].ToString();
                    servicesTable.Cell(i + 2, 2).Range.Text = servicesData[1][i].ToString();
                    servicesTable.Cell(i + 2, 3).Range.Text = servicesData[2][i].ToString();
                    servicesTable.Cell(i + 2, 4).Range.Text = servicesData[3][i].ToString() + " руб.";
                }
                servicesTable.Rows.Last.Delete();

                if (view.PartsGridVisibility)
                {
                    var partsTable = document.Tables[3];
                    var partsData = view.PartsInOrderData as object[][];
                    for (int i = 0; i < partsData[1].Length; i++)
                    {
                        partsTable.Rows.Add(partsTable.Rows[i + 2]);
                        partsTable.Cell(i + 2, 1).Range.Text = partsData[0][i].ToString();
                        partsTable.Cell(i + 2, 2).Range.Text = partsData[1][i].ToString();
                        partsTable.Cell(i + 2, 3).Range.Text = partsData[2][i].ToString();
                        partsTable.Cell(i + 2, 4).Range.Text = partsData[3][i].ToString() + " руб.";
                    }
                    partsTable.Rows.Last.Delete();
                }

                wordApp.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        internal void CloseOrder()
        {
            try
            {
                checkOrder.CompletionDate = Convert.ToDateTime(view.CheckCompletionDate);
                checkOrder.TotalPrice = Convert.ToDecimal(view.CheckTotalPrice);
                Core.Context.Database.ExecuteSqlCommand($"DELETE FROM dbo.[Order] WHERE [Order].IdOrder = {checkOrder.IdOrder}");
                Core.Context.SaveChanges();
                MessageBox.Show("Заказ выдан", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                OrdersLoad();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Report
        internal void LoadReportData()
        {
            view.MonthlyReportData = Core.Context.IncomeByMonthAndYear((int)view.MonthReport, (int)view.YearReport);
        }

        internal void ExportReport(int rowCount)
        {
            Excel.Application excelApp = new Excel.Application();
            Excel.Workbook workBook;
            Excel.Worksheet workSheet;
            workBook = excelApp.Workbooks.Add();
            workSheet = (Excel.Worksheet)workBook.Worksheets.get_Item(1);

            workSheet.Cells[1, 1] = "ID Заказа";
            workSheet.Cells[1, 2] = "Имя заказчика";
            workSheet.Cells[1, 3] = "Дата выполнения";
            workSheet.Cells[1, 4] = "Выручка";
            var reportData = view.MonthlyReportData as object[][];
            for (int j = 1; j <= rowCount; j++)
            {
                workSheet.Cells[j + 1, 1] = reportData[0][j - 1];
                workSheet.Cells[j + 1, 2] = reportData[1][j - 1];
                workSheet.Cells[j + 1, 3] = reportData[2][j - 1];
                workSheet.Cells[j + 1, 4] = reportData[3][j - 1];
            }
            workSheet.Cells[rowCount + 2, 4].Formula = $"=SUM(D2:D{rowCount + 1})";
            Excel.ChartObjects chartObjects = (Excel.ChartObjects)workSheet.ChartObjects();
            Excel.ChartObject chartObject = chartObjects.Add(197, 7, 800, 200);
            Excel.Chart xlChart = chartObject.Chart;
            string sRange = "C1:D" + (rowCount + 1).ToString();
            Excel.Range range = workSheet.Range[sRange];
            xlChart.ChartType = Excel.XlChartType.xlColumnStacked;
            xlChart.SetSourceData(range);

            excelApp.Visible = true;
            excelApp.UserControl = true;
        }

        internal void LoadDateNow()
        {
            view.MonthReport = DateTime.Now.Month;
            view.YearReport = DateTime.Now.Year;
            LoadReportData();
        }
        #endregion
    }
}