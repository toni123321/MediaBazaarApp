using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace MediaBazaarApp
{
    public partial class SalesForm : Form
    {
        private DepartmentManagement departmentManagement;
        private StockManagement stockManagement;
        private Employee currentEmp;
        private SalesManagement salesManagement;
        private DBControl dbc;

        public SalesForm(DepartmentManagement departmentManagement, Employee currentEmp, SalesManagement salesManagement, StockManagement stockManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.salesManagement = salesManagement;
            this.stockManagement = stockManagement;
            this.dbc = new DBControl();

            UpdateHistoryListBox();

            lbGreetingMsg.Text = $"Hello, {currentEmp.FirstName}!";
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(departmentManagement, stockManagement, salesManagement);
            loginForm.Show();
        }

        private void btnShowAllStocks_Click(object sender, EventArgs e)
        {
            foreach (Stock stock in stockManagement.GetAllStocks())
            {
                lbxAllStocks.Items.Add(stock);
            }
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            lbxAllStocks.SelectedIndex = -1;
        }

        public void UpdateHistoryListBox()
        {
            foreach (ShelfRestockRequest srr in salesManagement.GetAllSRRRequests())
            {
                lbxHistoryShelfRestockRequests.Items.Add(srr.ToString());
            }
        }

        private void btnMakeShelfRestockRequest_Click(object sender, EventArgs e)
        {
            Stock stock = (Stock)lbxAllStocks.SelectedItem;
            gbxStockChooseQuantity.Visible = true;
            lbStockInfo.Text = $"{stock.Brand} {stock.Model}";
        }

        private void btnConfirmRequest_Click(object sender, EventArgs e)
        {
            bool isValid = Regex.IsMatch(tbxStockQuantity.Text, @"^[A-Za-z]{2,}$");

            if (isValid)
            {
                Stock stock = (Stock)lbxAllStocks.SelectedItem;
                int quantity = Convert.ToInt32(tbxStockQuantity.Text);

                dbc.AddShelfRestockRequest(stock, quantity, this.currentEmp.Id, SRRstatus.Pending);
                dbc.GetShelfRestockRequests(this.salesManagement, this.stockManagement);

                //salesManagement.AddRequest(stock, quantity, this.currentEmp.Id);

                gbxStockChooseQuantity.Visible = false;
                lbStockQuantity.Text = "";

                UpdateHistoryListBox();
            }
            else
            {
                throw new IntegerValueExpected(tbxStockQuantity.Text);
            }
        }

        private void btnSearchStock_Click(object sender, EventArgs e)
        {
            foreach (Stock s in stockManagement.GetAllStocks())
            {
                if (s.Brand.Contains(tbxSearchStock.Text) || s.Model.Contains(tbxSearchStock.Text))
                {
                    lbxAllStocks.Items.Add(s);
                }
            }
        }

        private void SalesForm_Load(object sender, EventArgs e)
        {

        }

        private void btnShowAllStocks_Click_1(object sender, EventArgs e)
        {
            lbxAllStocks.Items.Clear();

            foreach (Stock s in stockManagement.GetAllStocks())
            {
                lbxAllStocks.Items.Add(s);
            }
        }
    }
}
