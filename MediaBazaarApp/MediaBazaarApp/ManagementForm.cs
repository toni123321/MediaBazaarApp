using System;
using System.Collections.Generic;
using System.Linq;
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
        public string ConnString
        {
            get;
            set;
        }
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
            if (index != -1)
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
            DBControl db = new DBControl();
            foreach (Department department in departmentManagement.GetAllDepartments())
            {
                cbxGenderChart.Items.Add(department.Name);
                cbxAge.Items.Add(department.Name);
                cbxCity.Items.Add(department.Name);
            }



            foreach (Department d in departmentManagement.GetAllDepartments())
            {
                if (d.GetAllEmployees().Count > 0)
                {
                    EmpPerDepChart.Series["Series1"].Points.AddXY($"{d.Name}", $"{d.GetAllEmployees().Count}");
                    EmpPerDepChart.Series["Series1"].Label = "#PERCENT{P2}";
                    EmpPerDepChart.Series["Series1"].LegendText = "#VALX";
                }
            }



            StatisticsEmployee se = new StatisticsEmployee();

            foreach (Department d in departmentManagement.GetAllDepartments())
            {
                if (d.GetAllEmployees().Count > 0)
                {
                    AvgWageChart.Series["Series1"].Points.AddXY($"{d.Name}", $"{se.AveregeWageOfEmployee(d.GetAllEmployees())}");
                    AvgWageChart.Series["Series1"].Label = "#PERCENT{P2}";
                    AvgWageChart.Series["Series1"].LegendText = "#VALX";
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




        private void cbxGenderChart_SelectedIndexChanged(object sender, EventArgs e)
        {
            GenderPieChart.Series["Gender"].Points.Clear();
            string department = cbxGenderChart.SelectedItem.ToString();
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {

                if (department == dep.Name)
                {
                    foreach (Employee emp in dep.GetAllEmployees())
                    {
                        if (emp.Gender.ToString() == "MALE")
                        {
                            GenderPieChart.Series["Gender"].Points.AddXY($"{emp.Gender}", +1);
                        }

                        if (emp.Gender.ToString() == "FEMALE")
                        {
                            GenderPieChart.Series["Gender"].Points.AddXY($"{emp.Gender}", +1);
                        }

                        if (emp.Gender.ToString() == "NONBINARY")
                        {
                            GenderPieChart.Series["Gender"].Points.AddXY($"{emp.Gender}", +1);
                        }

                        if (emp.Gender.ToString() == "OTHER")
                        {
                            GenderPieChart.Series["Gender"].Points.AddXY($"{emp.Gender}", +1);
                        }
                    }

                }


            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgeChart.Series["Age"].Points.Clear();
            int index = cbxAge.SelectedIndex;
            string department = cbxAge.SelectedItem.ToString();
            if (index != -1)
            {

                if (index == 0)
                {
                    foreach (Employee employee in departmentManagement.GetAllEmployees())
                    {
                        AgeChart.Series["Age"].Points.AddXY($"{DateTime.Now.Year - employee.DateOfBirth.Year}", +1);
                    }
                }


                foreach (Department d in departmentManagement.GetAllDepartments())
                {

                    if (department == d.Name)
                    {
                        foreach (Employee employee in d.GetAllEmployees())
                        {
                            AgeChart.Series["Age"].Points.AddXY($"{DateTime.Now.Year - employee.DateOfBirth.Year}", +1);
                        }

                    }




                }

            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ResidenceChart1.Series["Series1"].Points.Clear();
            int index = cbxCity.SelectedIndex;
            string department = cbxCity.SelectedItem.ToString();
            List<string> cities = new List<string>();

            if (index != -1)
            {

                if (index == 0)
                {
                    foreach (Employee emp in departmentManagement.GetAllEmployees())
                    {
                        cities.Add(emp.City);
                    }

                    var uniquecities = cities.Distinct();
                    foreach (string city in uniquecities)
                    {
                        int count = 0;
                        foreach (Employee emp in departmentManagement.GetAllEmployees())
                        {

                            if (emp.City == city)
                            {
                                count += 1;
                            }

                        }
                        ResidenceChart1.Series["Series1"].Points.AddXY($"{city}", count);
                    }

                }
            }


            foreach (Department d in departmentManagement.GetAllDepartments())
            {

                if (department == d.Name)
                {
                    cities.Clear();




                    foreach (Employee emp in departmentManagement.GetAllEmployees())
                    {
                        cities.Add(emp.City);
                    }




                    var uniquecities = cities.Distinct();
                    foreach (string city in uniquecities)
                    {
                        int count = 0;
                        foreach (Employee employee in d.GetAllEmployees())
                        {
                            if (employee.City == city)
                            {
                                count += 1;
                            }

                        }
                        ResidenceChart1.Series["Series1"].Points.AddXY($"{city}", count);
                    }




                }

            }
        }





    }
}


