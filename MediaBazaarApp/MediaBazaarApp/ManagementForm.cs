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
    public partial class ManagementForm : Form
    {
        private DepartmentManagement departmentManagement;
        private StockManagement stockManagement;
        private Employee currentEmp;
        SalesManagement salesManagement;
        StatisticsEmployee se = new StatisticsEmployee();
        StatisticsStock ss = new StatisticsStock();

        public ManagementForm(DepartmentManagement departmentManagement, Employee currentEmp, SalesManagement salesManagement, StockManagement stockManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.stockManagement = stockManagement;
            this.salesManagement = salesManagement;


            tbxNrEmp.Text = $"{se.GetAllEmployees(departmentManagement.GetAllEmployees()).Count()}";
            tbxAvgWageEmp.Text = $"{se.AveregeWageOfEmployee(departmentManagement.GetAllEmployees())}";
            lbxAvgWageEmpDepartment.Items.AddRange(se.AveregeWagePerDepartmenr(departmentManagement.GetAllDepartments(), departmentManagement.GetAllEmployees()).ToArray());
            lbxNrEmpPerDepartment.Items.AddRange(se.EmpPerDepToString(departmentManagement.GetAllDepartments()).ToArray());

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
            lbDateDayOfWeek.Text = DateTime.Now.ToString("dddd, MMMM dd");

        }

        private void ManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(departmentManagement, stockManagement, salesManagement);
            loginForm.Show();
        }

        private void cbStatisticType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbxAllStocksStatistics.Items.Clear();
            int index = cbStatisticType.SelectedIndex;
            if(index != -1)
            {
                if (index == 0)
                {
                    
                    lbxAllStocksStatistics.Items.AddRange(ss.GetLowestPrice(stockManagement.GetAllStocks()).ToArray());
                }



                if (index == 1)
                {
                    lbxAllStocksStatistics.Items.AddRange(ss.GetHighestPrice(stockManagement.GetAllStocks()).ToArray());
                }



                if (index == 2)
                {
                    lbxAllStocksStatistics.Items.AddRange(ss.GetSmallestQuantity(stockManagement.GetAllStocks()).ToArray());
                }



                if (index == 3)
                {
                    lbxAllStocksStatistics.Items.AddRange(ss.GetBiggestQuantity(stockManagement.GetAllStocks()).ToArray());
                }
            }
            
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {

            foreach (Department d in departmentManagement.GetAllDepartments())
            {
                if (d.GetAllEmployees().Count > 0)
                {

                    EmpPerDepChart.Series["Series1"].Points.AddXY($"{d.Name}", $"{d.GetAllEmployees().Count}");
                }
            }



            StatisticsEmployee se = new StatisticsEmployee();

            foreach (Department d in departmentManagement.GetAllDepartments())
            {
                if (d.GetAllEmployees().Count > 0)
                {
                    AvgWageChart.Series["Series1"].Points.AddXY($"{d.Name}", $"{se.AveregeWageOfEmployee(d.GetAllEmployees())}");
                }
            }

            foreach (Stock s in stockManagement.GetAllStocks())
            {
                StocksChart.Series["Price"].Points.AddXY($"{s.Brand} {s.Model}", $"{s.Price}");
            }



            foreach (Stock s in stockManagement.GetAllStocks())
            {
                StocksChart.Series["Quantity"].Points.AddXY($"{s.Brand} {s.Model}", $"{s.Quantity}");
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
            WelcomeMessage();
        }
    }
}
