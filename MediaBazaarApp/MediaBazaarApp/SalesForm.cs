using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;
using System.Linq;
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
        private Dictionary<Point, bool> shortcutLocations;

        public SalesForm(DepartmentManagement departmentManagement, Employee currentEmp, SalesManagement salesManagement, StockManagement stockManagement)
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
            UpdateStockDGV();
            UpdateAllSRR_DGV();
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

        public void UpdateStockDGV()
        {
            var stockDataSource = stockManagement.GetAllStocks().Select(x => new
            {
                ID = x.Id,
                Brand = x.Brand,
                Model = x.Model,
                AvailableQuantity = x.Quantity
            }).ToList();

            dgvStock.DataSource = stockDataSource;

            dgvStock.ClearSelection();
        }

        private void btnClearSelected_Click(object sender, EventArgs e)
        {
            dgvStock.ClearSelection();
        }

        public void UpdateAllSRR_DGV()
        {
            List<ShelfRestockRequest> SRR_all = new List<ShelfRestockRequest>();

            dbc.GetShelfRestockRequests(salesManagement, stockManagement);

            if (salesManagement != null)
            {
                foreach (ShelfRestockRequest srr in salesManagement.GetAllSRRRequests())
                {
                    SRR_all.Add(srr);
                }
            }

            var doneSRRDataSource = SRR_all.Select(x => new
            {
                ID = x.ID,
                Brand = x.Stock.Brand,
                Model = x.Stock.Model,
                RequestedQuantity = x.RequestedQuantity,
                Status = x.Status
            }).ToList();


            dgvSRRall.DataSource = doneSRRDataSource;
            dgvSRRall.ClearSelection();
        }

        private void btnMakeShelfRestockRequest_Click(object sender, EventArgs e)
        {
            if (dgvStock.SelectedRows.Count > 0)
            {   
                int id = Convert.ToInt32(dgvStock.SelectedCells[0].Value.ToString());
                Stock stock = stockManagement.GetStock(id);

                gbxStockChooseQuantity.Visible = true;
                lbStockInfo.Text = $"{stock.Brand} {stock.Model}";
            }
        }

        private void btnConfirmRequest_Click(object sender, EventArgs e)
        {
            bool isValid = Regex.IsMatch(tbxStockQuantity.Text, @"^[A-Za-z]{2,}$");

            if (isValid)
            {
                int id = Convert.ToInt32(dgvStock.SelectedCells[0].Value.ToString());
                Stock stock = stockManagement.GetStock(id);

                int quantity = Convert.ToInt32(tbxStockQuantity.Text);

                if (stock != null)
                {
                    dbc.AddShelfRestockRequest(stock, quantity, this.currentEmp.Id, SRRstatus.Pending);
                }

                dbc.GetShelfRestockRequests(this.salesManagement, this.stockManagement);


                gbxStockChooseQuantity.Visible = false;
                lbStockQuantity.Text = "";

                UpdateAllSRR_DGV();
            }
            else
            {
                throw new IntegerValueExpected(tbxStockQuantity.Text);
            }
        }

        private void btnShowAllStocks_Click_1(object sender, EventArgs e)
        {
            UpdateStockDGV();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            WelcomeMessage();
        }

        private void tbxSearchStock_TextChanged(object sender, EventArgs e)
        {
            string searchInput = tbxSearchStock.Text;

            if (searchInput == "")
            {
                dgvStock.DataBindings.Clear();
            }

            List<Stock> searchResults = new List<Stock>();

            foreach (Stock s in stockManagement.GetAllStocks())
            {
                if (s.Model.Contains(searchInput) || s.Brand.Contains(searchInput) || Convert.ToString(s.Id) == searchInput)
                {
                    searchResults.Add(s);
                }
            }

            var stockDataSource = searchResults.Select(x => new
            {
                ID = x.Id,
                Brand = x.Brand,
                Model = x.Model,
                AvailableQuantity = x.Quantity
            }).ToList();

            dgvStock.DataSource = stockDataSource;
        }
        private void setShortcutLocationtions()
        {
            shortcutLocations.Add(new Point(678, 390), true);
            shortcutLocations.Add(new Point(678, 476), true);
        }
        private void checkForShortcuts()
        {
            requestShortcut.Visible = false;
            historyShortcut.Visible = false;

            reqCH.Checked = false;
            historyCH.Checked = false;

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
            Point location = shortcut.Location;
            shortcutLocations[location] = true;
            shortcut.Visible = false;
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

        private void ApplyShortcutsBTN_Click(object sender, EventArgs e)
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

        private void RequestPic_Click(object sender, EventArgs e)
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
