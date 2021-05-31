using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;

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

            UpdateRequestsDGV();

            WelcomeMessage();
        }

        public void WelcomeMessage()
        {

            string time = DateTime.Now.ToString("HH");

            if (time.StartsWith("0"))
            {
                time.Remove(0, 1);
            }

            int currentTime = Convert.ToInt32(time);


            if (currentTime >= 5 && currentTime < 12)
            {
                lbGreetingMsg.Text = $"Good morning, {currentEmp.FirstName}!";
            }
            else if (currentTime >= 12 && currentTime < 17)
            {
                lbGreetingMsg.Text = $"Have a good afternoon, {currentEmp.FirstName}";
            }
            else if (currentTime >= 17 && currentTime < 21)
            {
                lbGreetingMsg.Text = $"Have a nice evening, {currentEmp.FirstName}!";
            }
            else
            {
                lbGreetingMsg.Text = $"Good night, {currentEmp.FirstName}";
            }

            lbTime.Text = DateTime.Now.ToString("HH:mm");
            lbDateDayOfWeek.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

        }


        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(departmentManagement, stockManagement, salesManagement);
            loginForm.Show();
        }

        private void DepotWorkersForm_Load(object sender, EventArgs e)
        {

        }

        private void btnSehflRestockRequestsClearSelected_Click(object sender, EventArgs e)
        {
            dgvSRRPending.ClearSelection();
        }

        private void UpdateRequestsDGV()
        {
            List<ShelfRestockRequest> SRR_done = new List<ShelfRestockRequest>();
            List<ShelfRestockRequest> SRR_pending = new List<ShelfRestockRequest>();

            dbc.GetShelfRestockRequests(salesManagement, stockManagement);

            if (salesManagement != null)
            {
                foreach (ShelfRestockRequest srr in salesManagement.GetAllSRRRequests())
                {
                    if (srr.Status == SRRstatus.Pending)
                    {
                        SRR_pending.Add(srr);
                    }
                    else if (srr.Status == SRRstatus.Done || srr.Status == SRRstatus.Declined)
                    {
                        SRR_done.Add(srr);
                    }
                }
            }

            var doneSRRDataSource = SRR_done.Select(x => new
            {
                ID = x.ID,
                Brand = x.Stock.Brand,
                Model = x.Stock.Model,
                Status = x.Status
            }).ToList();

            var pendingSRRDataSource = SRR_pending.Select(x => new
            {
                ID = x.ID,
                Brand = x.Stock.Brand,
                Model = x.Stock.Model
            }).ToList();

            dgvSRRdone.DataSource = doneSRRDataSource;
            dgvSRRdone.ClearSelection();

            dgvSRRPending.DataSource = pendingSRRDataSource;
            dgvSRRPending.ClearSelection();
        }

        private void btnShelftRestockRequestsMarkAsDone_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvSRRPending.SelectedCells[0].Value.ToString());
            ShelfRestockRequest request = salesManagement.GetSRR(id);

            if (request != null)
            {
                dbc.UpdateShelfRestockStatus(request, SRRstatus.Done, salesManagement);
            }

            dbc.GetShelfRestockRequests(salesManagement, stockManagement);

            dgvSRRPending.ClearSelection();

            UpdateRequestsDGV();
        }

        private void btnShelftRestockRequestsDecline_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(dgvSRRPending.SelectedCells[0].Value.ToString());
            ShelfRestockRequest request = salesManagement.GetSRR(id);

            if (request != null)
            {
                dbc.UpdateShelfRestockStatus(request, SRRstatus.Declined, salesManagement);
            }

            dbc.GetShelfRestockRequests(salesManagement, stockManagement);

            dgvSRRPending.ClearSelection();

            UpdateRequestsDGV();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WelcomeMessage();
        }
    }
}
