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

        public DepotWorkersForm(DepartmentManagement departmentManagement, Employee currentEmp, SalesManagement salesManagement, StockManagement stockManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.salesManagement = salesManagement;
            this.stockManagement = stockManagement;

            lbGreetingMsg.Text = $"Hello, {currentEmp.FirstName}";

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
            foreach (ShelfRestockRequest srr in salesManagement.GetAllSRRRequests())
            {
                if (srr.Status == SRRstatus.PENDING)
                {
                    lbxAllShelfRestockRequests.Items.Add(srr);
                }
                else
                {
                    lbxHistoryShelfRestockRequests.Items.Add(srr);
                }
            }
            UpdateRequestListboxes();
        }

        private void btnShelftRestockRequestsMarkAsDone_Click(object sender, EventArgs e)
        {
            ShelfRestockRequest request = (ShelfRestockRequest)lbxAllShelfRestockRequests.SelectedItem;

            request.Status = SRRstatus.DONE;

            lbxAllShelfRestockRequests.SelectedIndex = -1;

            UpdateRequestListboxes();
        }

        private void btnShelftRestockRequestsDecline_Click(object sender, EventArgs e)
        {
            ShelfRestockRequest request = (ShelfRestockRequest)lbxAllShelfRestockRequests.SelectedItem;

            request.Status = SRRstatus.DECLINED;

            lbxAllShelfRestockRequests.SelectedIndex = -1;

            UpdateRequestListboxes();
        }
    }
}
