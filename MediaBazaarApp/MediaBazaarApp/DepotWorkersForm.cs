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
        private Dictionary<Point, bool> shortcutLocations;

        public DepotWorkersForm(DepartmentManagement departmentManagement, Employee currentEmp, SalesManagement salesManagement, StockManagement stockManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.salesManagement = salesManagement;
            this.stockManagement = stockManagement;
            this.dbc = new DBControl();
            shortcutLocations = new Dictionary<Point, bool>();

            setShortcutLocationtions();
            checkForShortcuts();

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
        private void setShortcutLocationtions()
        {
            shortcutLocations.Add(new Point(514, 395), true);
            shortcutLocations.Add(new Point(514, 481), true);
        }
        private void checkForShortcuts()
        {
            requestShortcut.Visible = false;
            historyShortcut.Visible = false;

            List<Panel> allShortcuts = new List<Panel>();

            allShortcuts.Add(requestShortcut);
            allShortcuts.Add(historyShortcut);

            List<string> shortcutsSTR = dbc.GetActivatedShortcuts(currentEmp);
            List<Point> keys = new List<Point>(shortcutLocations.Keys);

            foreach (Point k in keys)
            {
                shortcutLocations[k] = true;
            }
            foreach (Panel s in allShortcuts)
            {
                if (shortcutsSTR.Contains(s.Name))
                {
                    activateShortCut(s);
                    if (s.Name == requestShortcut.Name)
                    {
                        reqCH.Checked = true;
                    }
                    else if (s.Name == historyShortcut.Name)
                    {
                        historyCH.Checked = true;
                    }
                }
            }
        }

        private void activateShortCut(Panel shortcut)
        {
            dbc.RemoveShortcut(currentEmp, shortcut.Name);
            List<Point> keys = new List<Point>(shortcutLocations.Keys);
            foreach (Point k in keys)
            {
                if (shortcutLocations[k] == true)
                {
                    shortcut.Location = k;
                    shortcut.Visible = true;
                    shortcutLocations[k] = false;
                    dbc.SaveShortcut(currentEmp, shortcut.Name);
                    break;
                }
            }
        }

        private void ApplyShortcutsBTN_Click_1(object sender, EventArgs e)
        {
            if (reqCH.Checked == false)
            {
                requestShortcut.Visible = false;
                Point location = requestShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, requestShortcut.Name);
            }

            if (historyCH.Checked == false)
            {
                historyShortcut.Visible = false;
                Point location = historyShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, historyShortcut.Name);
            }
            if (reqCH.Checked)
            {
                activateShortCut(requestShortcut);
            }
            if (historyCH.Checked)
            {
                activateShortCut(historyShortcut);
            }
        }

        private void GoToRequests()
        {
            tabControlDepotWorkers.SelectedTab = MakeShelfRestockRequestsTab;
        }
        private void GoToHistory()
        {
            tabControlDepotWorkers.SelectedTab = HistoryShelfRestockTab;
        }

        private void RequestShortcut_Click(object sender, EventArgs e)
        {
            GoToRequests();
        }

        private void ReqLBL_Click(object sender, EventArgs e)
        {
            GoToRequests();
        }

        private void ReqPic_Click(object sender, EventArgs e)
        {
            GoToRequests();
        }

        private void HistoryShortcut_Click(object sender, EventArgs e)
        {
            GoToHistory();
        }

        private void HistoryLBL_Click(object sender, EventArgs e)
        {
            GoToHistory();
        }

        private void HistoryPic_Click(object sender, EventArgs e)
        {
            GoToHistory();
        }
    }
}
