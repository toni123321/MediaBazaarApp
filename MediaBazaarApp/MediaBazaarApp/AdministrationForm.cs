using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class AdministrationForm : Form
    {
        StockManagement stockManagement;
        Stock selectedStock;
        public AdministrationForm()
        {
            InitializeComponent();
            stockManagement = new StockManagement();
        }

       

        private void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }


        private void BtnAddStock_Click_1(object sender, EventArgs e)
        {
            if (StockTBXCheck() == false)
            {
                MessageBox.Show("Please fill in all text boxes before adding stock.");
            }
            else
            {
                string model = tbxStockModel.Text.ToUpper();
                string brand = tbxStockBrand.Text.ToUpper();
                double price = double.Parse(tbxStockPrice.Text);
                int quantity = int.Parse(tbxStockQuantity.Text);
                double height = double.Parse(tbxStockHeight.Text);
                double width = double.Parse(tbxStockWidth.Text);
                double depth = double.Parse(tbxStockDepth.Text);
                double weight = double.Parse(tbxStockWeight.Text);
                string shortDescription;

                if (tbxStockShortDescription.Text == "")
                {
                    shortDescription = "No description was added";
                }
                else
                {
                    shortDescription = tbxStockShortDescription.Text;
                }

                stockManagement.AddStock(model, brand, price, quantity, height, width, depth, weight, shortDescription);
                ClearStockTbx();
            }
        }

        private void BtnShowAllStocks_Click_1(object sender, EventArgs e)
        {
            lbAllStocks.Items.Clear();
            List<Stock> stocks = stockManagement.GetAllStocks();
            foreach (Stock stock in stocks)
            {
                lbAllStocks.Items.Add(stock);
            }
        }

        public bool StockTBXCheck()
        {

            if (tbxStockModel.Text == "" || tbxStockBrand.Text == "" || tbxStockPrice.Text == "" || tbxStockQuantity.Text == "" || tbxStockWeight.Text == "" || tbxStockWidth.Text == "" || tbxStockHeight.Text == "" || tbxStockDepth.Text == "")
            {
                return false;
            }
            return true;
        }

        public void ClearStockTbx()
        {
            tbxStockBrand.Clear();
            tbxStockModel.Clear();
            tbxStockPrice.Clear();
            tbxStockDepth.Clear();
            tbxStockQuantity.Clear();
            tbxStockHeight.Clear();
            tbxStockWeight.Clear();
            tbxStockWidth.Clear();
            tbxStockShortDescription.Clear();
        }
        public Stock GetSelectedStock()
        {
            return selectedStock;
        }
        public StockManagement GetStockManagement()
        {
            return stockManagement;
        }
        public void StockListBoxRefresh()
        {
            lbAllStocks.Items.Clear();
            List<Stock> stocks = stockManagement.GetAllStocks();
            foreach (Stock stock in stocks)
            {
                lbAllStocks.Items.Add(stock);
            }
        }

        private void BtnSearchStock_Click(object sender, EventArgs e)
        {
            lbAllStocks.Items.Clear();
            List<Stock> stocks = stockManagement.GetAllStocks();
            string word = tbxSearchStock.Text;
            foreach (Stock stock in stocks)
            {
                if (stock.Brand.Contains(word.ToUpper()) || stock.Model.Contains(word.ToUpper()))
                {
                    lbAllStocks.Items.Add(stock);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            lbAllStocks.Items.Clear(); 
            List<Stock> stocks = stockManagement.GetAllStocks();
            string word = tbxSearchStock.Text;
            foreach (Stock stock in stocks)
            {
                if (word==stock.Id.ToString())
                {
                    lbAllStocks.Items.Add(stock);
                }
            }
        }

        private void BtnRemoveStock_Click(object sender, EventArgs e)
        {
            selectedStock = (Stock)lbAllStocks.SelectedItem;

            if (selectedStock!=null)
            {
                RemoveStockForm removeStockForm = new RemoveStockForm(this);
                removeStockForm.Show();
            }
            else
            {
                MessageBox.Show("Please select the stock you wish to remove.");
            }
        }
    }
}
