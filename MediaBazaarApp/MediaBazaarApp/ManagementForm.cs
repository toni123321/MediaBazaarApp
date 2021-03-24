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


            
            
        }

        private void ManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(departmentManagement, stockManagement);
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
    }
}
