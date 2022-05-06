using CompService.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CompService
{
    public partial class NewPartForm : TemplateForm
    {
        Part part;
        public NewPartForm(ref Part part)
        {
            InitializeComponent();
            this.part = part;
        }

        private void SavePartButton_Click(object sender, EventArgs e)
        {
            try
            {
                part.PartName = partNameTextBox.Text;
                part.SerialNumber = serialNumberTextBox.Text;
                part.Price = Convert.ToDecimal(priceTextBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void PriceTextBox_TextChanged(object sender, EventArgs e)
        {
            Regex priceRegex = new Regex(@"^\d{1,6}(\,\d{1,2})?$");
            if (!priceRegex.IsMatch(priceTextBox.Text))
                errorProvider.SetError(priceTextBox, "Цена должна быть не больше 999999,99. Разделитель - запятая (',')");
            else
                errorProvider.Clear();
        }
    }
}
