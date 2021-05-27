using System;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class EditStockForm : Form
    {
        Stock stock;
        AdministrationForm parent;
        public EditStockForm(AdministrationForm parent)
        {
            InitializeComponent();
            this.parent = parent;
            stock = parent.GetSelectedStock();
            stockLb.Text = $"Stock with id:{stock.Id}";
            tbxStockBrand.Text = stock.Brand;
            tbxStockModel.Text = stock.Model;
            tbxStockPrice.Text = stock.Price.ToString();
            tbxStockQuantity.Text = stock.Quantity.ToString();
            tbxStockHeight.Text = stock.Height.ToString();
            tbxStockDepth.Text = stock.Depth.ToString();
            tbxStockWidth.Text = stock.Width.ToString();
            tbxStockWeight.Text = stock.Weight.ToString();
        }

        private void BtnEditStock_Click(object sender, EventArgs e)
        {
            if (tbxStockBrand.Text != "" && tbxStockDepth.Text != "" && tbxStockHeight.Text != "" && tbxStockModel.Text != "" && tbxStockPrice.Text != "" && tbxStockQuantity.Text != "" && tbxStockWeight.Text != "" && tbxStockWidth.Text != "")
            {
                stock.Brand = tbxStockBrand.Text.ToUpper();
                stock.Model = tbxStockModel.Text.ToUpper();
                stock.Depth = double.Parse(tbxStockDepth.Text);
                stock.Height = double.Parse(tbxStockHeight.Text);
                stock.Weight = double.Parse(tbxStockWeight.Text);
                stock.Width = double.Parse(tbxStockWidth.Text);
                stock.Quantity = int.Parse(tbxStockQuantity.Text);
                stock.Price = double.Parse(tbxStockPrice.Text);

                if (tbxStockShortDescription.Text == "")
                {
                    stock.ShortDescription = "No description was added.";
                }
                else
                {
                    stock.ShortDescription = tbxStockShortDescription.Text;
                }
                MessageBox.Show("Changes applied.");
                parent.UpdateDGVStock();
                DBControl dbControl = new DBControl();
                dbControl.EditStock(stock);
                this.Close();
            }
            else
            {
                MessageBox.Show("All spaces besides the description are mandatory. Please make sure you have filled them out.");
            }
        }
    }
}
