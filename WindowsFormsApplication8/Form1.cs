using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication8
{
    public partial class Form1 : Form
    {
        string[] bands = { "BMW", "Lanos", "Mercedes", "Toyota" };
        public Form1()
        {
            InitializeComponent();
            //BdManager bd = new BdManager();
            //bd.Open();
            //bd.Cmd();
            //bd.Close();
            cmbBxBrand.DataSource = bands;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            BdManager bd1 = new BdManager();
            bd1.Open();
            bd1.Cmd();
            bd1.Close();
        }
        bool IsCorrectName() {//Проверка +регулярное выражение вынесены в отдельный метод
            if (!string.IsNullOrEmpty(this.txBx.Text))
            {
                Regex reg = new Regex(@"[A-ZА-Я]{5,}", RegexOptions.IgnoreCase);
                if (!reg.IsMatch(txBx.Text))
                {
                    errorProvider1.SetError(txBx, "состоит минимум из пяти символов");
                    return false;

                }
                else {
                    errorProvider1.SetError(txBx, "");
                    return true;
                }
            }
            else {
                errorProvider1.SetError(txBx, "введите имя детали");
                return false;
            }

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            IsCorrectName();
            //теперь собираем обьекты для добавления
            Item it = new Item();
            it.Name =txBx.Text;
            it.Description =txBxDescription.Text;
            it.Brand =bands[cmbBxBrand.SelectedIndex];//добавляем выбранный из массива
            try
            {
                it.Price = decimal.Parse(txBxPrice.Text);
                errorProvider1.SetError(txBxPrice, "");
               
            }
            catch (Exception ex) {
                errorProvider1.SetError(txBxPrice, ex.Message);
            }
            try {
                it.Amount = int.Parse(txBxAmount.Text);
                errorProvider1.SetError(txBxAmount, "");

            }
            catch (Exception ex) {
                errorProvider1.SetError(txBxAmount, ex.Message);

            }

        }
    }
}
