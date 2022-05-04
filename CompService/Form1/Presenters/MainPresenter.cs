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

        internal void CheckOutLoad(int selectedId)
        {

            view.ServicesInOrderData = Core.Context.ServicesByIdOrder(selectedId).ToList();
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
                //masterUser = Core.Context.Users.FirstOrDefault(c => c.Login == view.MasterLogin && c.Password == view.MasterPassword);
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

        internal void CheckPrinting()
        {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "DOCX|*.docx";
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    var wordApp = new Word.Application();
                    wordApp.Visible = false;
                    var document = wordApp.Documents.Add(Environment.CurrentDirectory + @"\templates\template.docx");

                    var table = document.Tables[1];
                    var data = view.ServicesInOrderData as object[][];
                    for (int i = 0; i < data[1].Length; i++)
                    {
                        table.Rows.Add(table.Rows[i + 2]);
                        table.Cell(i + 2, 1).Range.Text = data[0][i].ToString();
                        table.Cell(i + 2, 2).Range.Text = data[1][i].ToString();
                        table.Cell(i + 2, 3).Range.Text = data[2][i].ToString();
                        table.Cell(i + 2, 4).Range.Text = data[3][i].ToString();
                    }

                    table.Rows.Last.Delete();

                    document.SaveAs(saveFileDialog1.FileName);
                    wordApp.Quit();
                }
                else
                    MessageBox.Show("Файл сохранен", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }
        internal void LoadData(int pageSize, int currentPage)
        {
            var data = view.SearchData as object[][];
            var count = data.Count();
            int amountPages = count / pageSize + (count % pageSize > 0 ? 1 : 0);
            var skip = pageSize * (currentPage - 1);
            var take = model.SearchDataOrderBy(skip, pageSize);
            view.SearchData = take;
            view.TotalPages = amountPages.ToString();
        }
    }
}