using System;
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
            DBControl dbControl = new DBControl();
            dbControl.RemoveStock(stock.Id);
            MessageBox.Show($"Stock ID: {stock.Id} - Brand: {stock.Brand} - Model: {stock.Model} was removed.");
            parent.StockListBoxRefresh();
            this.Close();
        }

        private void RemoveAmountBTN_Click(object sender, EventArgs e)
        {
            if (removeAmountTBX.Text != "")
            {
                try
                {
                    if (stock.Quantity > 0)
                    {
                        stock.Quantity -= int.Parse(removeAmountTBX.Text);
                        DBControl dbControl = new DBControl();
                        dbControl.UpdateStockQuantity(stock);
                        MessageBox.Show($"Stock ID: {stock.Id} - Brand: {stock.Brand} - Model: {stock.Model} quantity was reduced to {stock.Quantity}.");
                        parent.StockListBoxRefresh();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Stock amount is already 0.");
                    }

                }
                catch
                {
                    MessageBox.Show("Please enter a valid value (A whole number.)");
                }

            }
            else
            {
                MessageBox.Show("Please enter the amount you wish to remove");
            }
        }
    }
}
