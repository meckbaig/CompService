using CompService.Models;
using CompService.Views;
using CompService.Supporting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace CompService.Presenters
{
    class MainPresenter
    {
        IMainModel model;
        IMainView view;
        Order currentOrder;
        Master editMaster;
        int? parceCustomerId = null;

        public MainPresenter(IMainView view)
        {
            this.model = new MainModel();
            this.view = view;
        }

        public void OrdersLoad()
        {
            try
            {
                view.SearchData = model.OrdersLoad();
                view.CurrentPage = 1;
            }
            catch (Exception)
            {
                throw new Exception();
            }
        }

        public void EditOrdersLoad(int selectedId)
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
            view.CompletedSearch = currentOrder.Completed ?? false;
            view.DefectDescription = currentOrder.DefectDescription;
            view.SerialNumber = currentOrder.SerialNumber;
            view.EditServicesInOrder = currentOrder.Services.ToArray();
            view.EditMastersInOrder = currentOrder.Masters.ToArray();
            view.EditServices = model.GetServicesNotInOrder(currentOrder.Services);
            view.EditMasters = model.GetMastersNotInOrder(currentOrder.Masters);
            view.EditParts = currentOrder.Parts.ToArray();
            parceCustomerId = currentOrder.IdCustomer;
        }

        public void SaveOrder()
        {
            if(currentOrder == null)
                currentOrder = new Order();
            currentOrder.FullName = view.FullName;
            currentOrder.PhoneNumber = view.PhoneNumber;
            currentOrder.ReceiptDate = view.ReceiptDate;
            if(view.EnableCompletionDate)
                currentOrder.CompletionDate = view.CompletionDate;
            currentOrder.Completed = view.CompletedSearch;
            currentOrder.DefectDescription = view.DefectDescription;
            currentOrder.SerialNumber = view.SerialNumber;
            currentOrder.Services = view.EditServicesInOrder.Cast<Service>().ToList();
            currentOrder.Masters = view.EditMastersInOrder.Cast<Master>().ToList();
            currentOrder.Parts = view.EditParts.Cast<Part>().ToList();
            currentOrder.IdCustomer = parceCustomerId;
            model.SaveOrder(currentOrder);
        }

        public void ClearOrder()
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

        public void SortOrders(bool checkBoxChecked)
        {
            view.SortData = model.SortOrders(checkBoxChecked);
        }
        public void SearchOrder(string idSearchOrder,
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
            view.SearchData = model.SearchOrder(idSearchOrder,
                                                fullNameSearch,
                                                phoneNumberSearch,
                                                allowDateCheckBox,
                                                receiptDateSearch,
                                                allowCompletionDate,
                                                completionDateSearch,
                                                defectDescriptionSearch,
                                                serialNumberSearch,
                                                completedSearchCheckBox);
            view.CurrentPage = 1;
        }

        public void ParceCustomer()
        {
            view.FullName = ParceCustomerIntoOrder.User.FullName;
            view.PhoneNumber = ParceCustomerIntoOrder.User.PhoneNumber;
            parceCustomerId = ParceCustomerIntoOrder.User.IdCustomer;
        }

        public void SortMasters(string search, bool byName)
        {
            if (byName)
                view.MastersData = Core.Context.MasterInfoes.Where(m => m.FullName.Contains(search)).ToList();
            else
                view.MastersData = Core.Context.MasterInfoes.Where(m => m.Login.Contains(search)).ToList();

        }

        internal void EditMasterLoad(int selectedMasterId)
        {
            editMaster = Core.Context.Masters.Find(selectedMasterId);

            view.MasterName = editMaster.FullName;
            view.MasterLogin = editMaster.User.Login;
            view.MasterPassword = editMaster.User.Password;
        }

        internal void SaveMaster()
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

        internal void CheckOutLoad(int selectedId, bool partsGrid, bool partsTitle)
        {
            view.ServicesInOrderData = Core.Context.ServicesByIdOrder(selectedId).ToList();
            view.PartsInOrderData = Core.Context.PartsByIdOrder(selectedId).ToList();
            //if (Core.Context.PartsByIdOrder(selectedId).ToList() == null)
            //if (view.PartsInOrderData == null)
            if ((view.PartsInOrderData as object[][])[0][0] == null)
                partsGrid = partsTitle = false;
            else
                partsGrid = partsTitle = true;
            Order checkOrder = Core.Context.Orders.FirstOrDefault(o => o.IdOrder == selectedId);
            view.CheckIdOrder = Convert.ToString(checkOrder.IdOrder);
            view.CheckReceiptDate = Convert.ToString(checkOrder.ReceiptDate.ToShortDateString());
            view.CheckCompletionDate = Convert.ToString(DateTime.Now);
            view.CheckFullName = checkOrder.FullName;
            view.CheckPhoneNumber = checkOrder.PhoneNumber;
            view.CheckSerialNumber = checkOrder.SerialNumber;
            RecalculateTotalPrice();
        }

        internal void CheckPrinting()
        {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "DOCX|*.docx";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var wordApp = new Word.Application();
                wordApp.Visible = false;
                var document = wordApp.Documents.Add(Environment.CurrentDirectory + @"\templates\template.docx");

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

                var partsTable = document.Tables[3];
                var partsData = view.PartsInOrderData as object[][];
                for (int i = 0; i < partsData[1].Length; i++)
                {
                    partsTable.Rows.Add(partsTable.Rows[i + 2]);
                    partsTable.Cell(i + 2, 1).Range.Text = partsData[0][i].ToString();
                    partsTable.Cell(i + 2, 2).Range.Text = partsData[2][i].ToString();
                    partsTable.Cell(i + 2, 3).Range.Text = partsData[3][i].ToString();
                    partsTable.Cell(i + 2, 4).Range.Text = partsData[4][i].ToString() + " руб.";
                }
                partsTable.Rows.Last.Delete();

                document.SaveAs(saveFileDialog.FileName);
                wordApp.Quit();
                MessageBox.Show("Чек сохранён", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Чек не был сохранён", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        internal void Navigation(int pageSize, int currentPage)
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

        internal void LockButtons(int currentPage, int amountPages)
        {
            view.FirstPage = view.LeftPage = currentPage > 1;
            if (view.CurrentPageMax == 1 || currentPage >= amountPages)
                view.LastPage = view.RightPage = false;
            else
                view.LastPage = view.RightPage = true;
        }

        internal void RecalculateTotalPrice()
        {
            double totalPrice = 0;
            var servicesData = view.ServicesInOrderData as object[][];
            var partsData = view.PartsInOrderData as object[][];
            for (int i = 0; i < servicesData[1].Length; i++)
            {
                totalPrice += Convert.ToDouble(servicesData[3][i]);
            }
            for (int i = 0; i < partsData[1].Length; i++)
            {
                totalPrice += Convert.ToDouble(partsData[4][i]);
            }
            view.CheckTotalPrice = totalPrice.ToString();
        }
    }
}