using System;
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

            UpdateRequestListboxes();

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
            lbxAllShelfRestockRequests.SelectedIndex = -1;
        }

        private void UpdateRequestListboxes()
        {
            dbc.GetShelfRestockRequests(salesManagement, stockManagement);

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
                    else if (srr.Status == SRRstatus.Done || srr.Status == SRRstatus.Declined)
                    {
                        lbxHistoryShelfRestockRequests.Items.Add(srr);
                    }
                }
            }
        }

        private void btnShelftRestockRequestsMarkAsDone_Click(object sender, EventArgs e)
        {
            ShelfRestockRequest request = (ShelfRestockRequest)lbxAllShelfRestockRequests.SelectedItem;
            dbc.UpdateShelfRestockStatus(request, SRRstatus.Done, salesManagement);
            //dbc.GetShelfRestockRequests(this.salesManagement, this.stockManagement);
            dbc.GetShelfRestockRequests(salesManagement, stockManagement);

            lbxAllShelfRestockRequests.SelectedIndex = -1;

            UpdateRequestListboxes();
        }

        private void btnShelftRestockRequestsDecline_Click(object sender, EventArgs e)
        {
            ShelfRestockRequest request = (ShelfRestockRequest)lbxAllShelfRestockRequests.SelectedItem;
            dbc.UpdateShelfRestockStatus(request, SRRstatus.Declined, salesManagement);
            //dbc.GetShelfRestockRequests(this.salesManagement, this.stockManagement);
            dbc.GetShelfRestockRequests(salesManagement, stockManagement);

            lbxAllShelfRestockRequests.SelectedIndex = -1;

            UpdateRequestListboxes();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WelcomeMessage();
        }
    }
}
