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
    public partial class RemoveStockForm : Form
    {
        AdministrationForm parent;
        Stock stock;
        StockManagement stockManagement;
        public RemoveStockForm(AdministrationForm parent)
        {
            this.parent = parent;
            stock = parent.GetSelectedStock();
            stockManagement = parent.GetStockManagement();
            InitializeComponent();
            lbProduct.Text = $"Product: {stock.Brand} - {stock.Model}";
            lbQuantity.Text = $"Quantity: {stock.Quantity}";
        }

        private void RemoveStockBTN_Click(object sender, EventArgs e)
        {
            stockManagement.RemoveStock(stock);
            MessageBox.Show($"Stock ID: {stock.Id} - Brand: {stock.Brand} - Model: {stock.Model} was removed.");
            parent.StockListBoxRefresh();
            this.Close();
        }

        private void RemoveAmountBTN_Click(object sender, EventArgs e)
        {
            if (removeAmountTBX.Text != "")
            {
                stock.Quantity -= int.Parse(removeAmountTBX.Text);
                MessageBox.Show($"Stock ID: {stock.Id} - Brand: {stock.Brand} - Model: {stock.Model} quantity was reduced to {stock.Quantity}.");
                parent.StockListBoxRefresh();
                this.Close();
            }
            else
            {
                MessageBox.Show("Please enter the amount you wish to remove");
            }
        }
    }
}
