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
    public partial class DepotWorkersForm : Form
    {
        private DepartmentManagement departmentManagement;
        private SalesManagement salesManagement;
        private Employee currentEmp;
        private StockManagement stockManagement;
        private DBControl dbc;


        public DepotWorkersForm(DepartmentManagement departmentManagement, Employee currentEmp, SalesManagement salesManagement, StockManagement stockManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.salesManagement = salesManagement;
            this.stockManagement = stockManagement;
            this.dbc = new DBControl();

            lbGreetingMsg.Text = $"Hello, {currentEmp.FirstName}";

           // dbc.GetShelfRestockRequests(salesManagement, stockManagement);
            UpdateRequestListboxes();
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(departmentManagement, stockManagement);
            loginForm.Show();
        }

        private void DepotWorkersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSehflRestockRequestsClearSelected_Click(object sender, EventArgs e)
        {
            lbxAllShelfRestockRequests.SelectedIndex = -1;
        }

        private void UpdateRequestListboxes()
        {
            lbxAllShelfRestockRequests.Items.Clear();
            lbxHistoryShelfRestockRequests.Items.Clear();

            if (salesManagement != null)
            {
                foreach (ShelfRestockRequest srr in salesManagement.GetAllSRRRequests())
                {
                    if (srr.Status == SRRstatus.Pending)
                    {
                        lbxAllShelfRestockRequests.Items.Add(srr);
                    }
                    else
                    {
                        lbxHistoryShelfRestockRequests.Items.Add(srr);
                    }
                }
            }
        }

        private void btnShelftRestockRequestsMarkAsDone_Click(object sender, EventArgs e)
        {
            ShelfRestockRequest request = (ShelfRestockRequest)lbxAllShelfRestockRequests.SelectedItem;
            dbc.UpdateShelfRestockStatus(request, SRRstatus.Done);
            //dbc.GetShelfRestockRequests(this.salesManagement, this.stockManagement);

            lbxAllShelfRestockRequests.SelectedIndex = -1;

            UpdateRequestListboxes();
        }

        private void btnShelftRestockRequestsDecline_Click(object sender, EventArgs e)
        {
            ShelfRestockRequest request = (ShelfRestockRequest)lbxAllShelfRestockRequests.SelectedItem;
            dbc.UpdateShelfRestockStatus(request, SRRstatus.Declined);
            //dbc.GetShelfRestockRequests(this.salesManagement, this.stockManagement);

            lbxAllShelfRestockRequests.SelectedIndex = -1;

            UpdateRequestListboxes();
        }
    }
}
