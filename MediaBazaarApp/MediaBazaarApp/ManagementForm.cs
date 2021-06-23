using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

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
        private DBControl dbc;
        private Dictionary<Point, bool> shortcutLocations;
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
            this.dbc = new DBControl();
            this.shortcutLocations = new Dictionary<Point, bool>();
            this.setShortcutLocationtions();
            this.checkForShortcuts();


            /* tbxNrEmp.Text = $"{se.GetAllEmployees(departmentManagement.GetAllEmployees()).Count()}";
             tbxAvgWageEmp.Text = $"{se.AveregeWageOfEmployee(departmentManagement.GetAllEmployees())}";
             lbxAvgWageEmpDepartment.Items.AddRange(se.AveregeWagePerDepartmenr(departmentManagement.GetAllDepartments(), departmentManagement.GetAllEmployees()).ToArray());
             lbxNrEmpPerDepartment.Items.AddRange(se.EmpPerDepToString(departmentManagement.GetAllDepartments()).ToArray());*/

            WelcomeMessage();


            int minYear = 2000;
            int maxYear = DateTime.Now.Year;
            cbFilterByYearNrEmpIncrease.DataSource = Enumerable.Range(minYear, maxYear - minYear + 1).Reverse().ToList();
            cbFilterByYearNrEmpStarted.DataSource = Enumerable.Range(minYear, maxYear - minYear + 1).Reverse().ToList();
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

        private void ManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(departmentManagement, stockManagement, salesManagement);
            loginForm.Show();
        }


        private void UpdateDGVStockStatistics(List<Stock> stocks)
        {
            var stockStatisticsDataSource = stocks.Select(x => new
            {
                ID = x.Id,
                Brand = x.Brand,
                Model = x.Model,
                Quantity = x.Quantity,
                Price = x.Price,
                Width = x.Width,
                Height = x.Height,
                Depth = x.Depth,
                Weight = x.Weight,
                Description = x.ShortDescription != null ? $"{x.ShortDescription}" : "n/a",
                Location = x.Location != null ? $"{x.Location}" : "n/a",
                Disontinued = x.Discontinued
            }).ToList();

            dgvStockStatistics.DataSource = stockStatisticsDataSource;

            dgvStockStatistics.ClearSelection();
        }


        private void cbStatisticType_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = cbStatisticType.SelectedIndex;
            if (index != -1)
            {
                if (index == 0)
                {

                    UpdateDGVStockStatistics(ss.GetLowestPrice(stockManagement.GetAllStocks()));
                }
                else if (index == 1)
                {
                    UpdateDGVStockStatistics(ss.GetHighestPrice(stockManagement.GetAllStocks()));
                }
                else if (index == 2)
                {
                    UpdateDGVStockStatistics(ss.GetSmallestQuantity(stockManagement.GetAllStocks()));
                }
                else if (index == 3)
                {
                    UpdateDGVStockStatistics(ss.GetBiggestQuantity(stockManagement.GetAllStocks()));
                }
            }

        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {
            cbFilterByDepEmpNrIncrease.Items.Add("Overall");
            cbFilterByDepNrEmpStarted.Items.Add("Overall");
            DBControl db = new DBControl();
            
            foreach (Department department in departmentManagement.GetAllDepartments())
            {
/*                cbxGenderChart.Items.Add(department.Name);
*/                cbxAge.Items.Add(department.Name);
                cbxCity.Items.Add(department.Name);
                cbFilterByDepEmpNrIncrease.Items.Add(department.Name);
                cbFilterByDepNrEmpStarted.Items.Add(department.Name);
            } 


            foreach (Department d in departmentManagement.GetAllDepartments())
            {
                if (d.GetAllEmployees().Count > 0)
                {
                    EmpPerDepChart.Series["Series1"].Points.AddXY($"{d.Name} - {d.GetAllEmployees().Count} employees", $"{d.GetAllEmployees().Count}");
                }
            }

           

            StatisticsEmployee se = new StatisticsEmployee();

            foreach (Department d in departmentManagement.GetAllDepartments())
            {
                if (d.GetAllEmployees().Count > 0)
                {
                    AvgWageChart.Series["Series1"].Points.AddXY($"{d.Name} - €{Math.Round(se.AveregeWageOfEmployee(d.GetAllEmployees()),2)}", $"{se.AveregeWageOfEmployee(d.GetAllEmployees())}");
                }
            }

            foreach (Stock s in stockManagement.GetAllStocks())
            {
                StocksChart.Series["Price in €"].Points.AddXY($"{s.Brand} {s.Model}", $"{s.Price}");
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



/*
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
                        int count = 0;
                        if (emp.Gender.ToString() == "MALE")
                        {
                            count += 1;
                            GenderPieChart.Series["Gender"].Points.AddXY($"Male", count);
                        }

                        if (emp.Gender.ToString() == "FEMALE")
                        {
                            count += 1;
                            GenderPieChart.Series["Gender"].Points.AddXY($"Female", count);
                        }

                        if (emp.Gender.ToString() == "NONBINARY")
                        {
                            count += 1;
                            GenderPieChart.Series["Gender"].Points.AddXY($"NONBIARY", count);
                        }

                        if (emp.Gender.ToString() == "OTHER")
                        {
                            count += 1;
                            GenderPieChart.Series["Gender"].Points.AddXY($"OTHER", count);
                        }
                    }

                }


            }
        }*/


        private Dictionary<string, int> ShowAges(List<Employee> employees)
        {
            Dictionary<string, int> ageRanges = new Dictionary<string, int>();

            ageRanges.Add("14-17", 0);
            ageRanges.Add("18-24", 0);
            ageRanges.Add("25-34", 0);
            ageRanges.Add("35-44", 0);
            ageRanges.Add("45-54", 0);
            ageRanges.Add("55-64", 0);
            ageRanges.Add("65-74", 0);
            ageRanges.Add("75+", 0);



            List<int> allAges = new List<int>();

            foreach (Employee emp in employees)
            {
                allAges.Add(DateTime.Now.Year - emp.DateOfBirth.Year);
                
            }
            foreach (int age in allAges)
            {
                if (age >= 14 && age <= 17)
                {
                    ageRanges["14-17"]++;
                }
                else if (age >= 18 && age <= 24)
                {
                    ageRanges["18-24"]++;
                }
                if (age >= 25 && age <= 34)
                {
                    ageRanges["25-34"]++;
                }
                if (age >= 35 && age <= 44)
                {
                    ageRanges["35-44"]++;
                }
                if (age >= 45 && age <= 54)
                {
                    ageRanges["45-54"]++;
                }
                if (age >= 55 && age <= 64)
                {
                    ageRanges["55-64"]++;
                }
                if (age >= 65 && age <= 74)
                {
                    ageRanges["65-74"]++;
                }
                if (age >= 75)
                {
                    ageRanges["75+"]++;
                }
            }
            return ageRanges;
        } 

        private Dictionary<string, int> ShowAgesPerDepartment(string depName)
        {
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                if(dep.Name == depName)
                {
                    return ShowAges(dep.GetAllEmployees());
                }
            }
            return null;
        }

        private Dictionary<string, int> ShowAllAges()
        {
            return ShowAges(departmentManagement.GetAllEmployees());
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            AgeChart.Series["Employees Age"].Points.Clear();
            int index = cbxAge.SelectedIndex;
            string department = cbxAge.SelectedItem.ToString();

            if (index != -1)
            {
                if(index == 0)
                {
                    Dictionary<string, int> ageRanges = ShowAllAges();

                    for (int i = 0; i < ShowAllAges().Count; i++)
                    {
                        AgeChart.Series["Employees Age"].Points.AddXY(ageRanges.Keys.ElementAt(i), ageRanges.Values.ElementAt(i));
                    }
                }
                else
                {
                    Dictionary<string, int> ageRanges = ShowAgesPerDepartment(cbxAge.SelectedItem.ToString());
                    for (int i = 0; i < ageRanges.Count; i++)
                    {
                        AgeChart.Series["Employees Age"].Points.AddXY(ageRanges.Keys.ElementAt(i), ageRanges.Values.ElementAt(i));
                    }
                }
                
            }
        }

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            ResidenceChart1.Series["Employees"].Points.Clear();
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
                        ResidenceChart1.Series["Employees"].Points.AddXY($"{city}", count);
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
                        ResidenceChart1.Series["Employees"].Points.AddXY($"{city}", count);
                    }




                }

            }
        }
       /* private Dictionary<string, int> ShowAllMonths()
        {
            return ShowMonths(departmentManagement.GetAllEmployees());
        }
        private Dictionary<string, int> ShowMonths(List<Employee> employees)
        {
            Dictionary<string, int> Months = new Dictionary<string, int>();

            Months.Add("January", 0);
            Months.Add("February", 0);
            Months.Add("March", 0);
            Months.Add("April", 0);
            Months.Add("May", 0);
            Months.Add("June", 0);
            Months.Add("July", 0);
            Months.Add("August", 0);
            Months.Add("September", 0);
            Months.Add("October", 0);
            Months.Add("November", 0);
            Months.Add("December", 0);

            List<string> allMonths = new List<string>();
            string[] Month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };


            List<int> allAges = new List<int>();

            foreach (Employee emp in employees)
            {
                allAges.Add(DateTime.Now.Year - emp.DateOfBirth.Year);
            }
            foreach (string m in Month)
            {
                foreach (Employee e in departmentManagement.GetAllEmployees())
                {
                    if (e.StartDate.Month == 01)
                    {
                        Months["January"]++;
                    }
                    else if (e.StartDate.Month == 02)
                    {
                        Months["February"]++;
                    }
                    if (e.StartDate.Month == 03)
                    {
                        Months["March"]++;
                    }
                    if (e.StartDate.Month == 04)
                    {
                        Months["April"]++;
                    }
                    if (e.StartDate.Month == 05)
                    {
                        Months["May"]++;
                    }
                    if (e.StartDate.Month == 06)
                    {
                        Months["June"]++;
                    }
                    if (e.StartDate.Month == 07)
                    {
                        Months["July"]++;
                    }
                    if (e.StartDate.Month == 08)
                    {
                        Months["August"]++;
                    }
                    if (e.StartDate.Month == 09)
                    {
                        Months["September"]++;
                    }
                    if (e.StartDate.Month == 10)
                    {
                        Months["October"]++;
                    }
                    if (e.StartDate.Month == 11)
                    {
                        Months["November"]++;
                    }
                    if (e.StartDate.Month == 12)
                    {
                        Months["December"]++;
                    }
                }
                
            }
            return Months;
        }

*/



       private Dictionary<string, int> SetNrEmployeesStartedPerPeriod(int year, List<Employee> employees)
       {
           Dictionary<string, int> employeesNrStartedPerMonths = new Dictionary<string, int>();
           
           employeesNrStartedPerMonths.Add("Jan", 0);
           employeesNrStartedPerMonths.Add("Feb", 0);
           employeesNrStartedPerMonths.Add("Mar", 0);
           employeesNrStartedPerMonths.Add("Apr", 0);
           employeesNrStartedPerMonths.Add("May", 0);
           employeesNrStartedPerMonths.Add("Jun", 0);
           employeesNrStartedPerMonths.Add("Jul", 0);
           employeesNrStartedPerMonths.Add("Aug", 0);
           employeesNrStartedPerMonths.Add("Sep", 0);
           employeesNrStartedPerMonths.Add("Oct", 0);
           employeesNrStartedPerMonths.Add("Nov", 0);
           employeesNrStartedPerMonths.Add("Dec", 0);


            foreach (Employee emp in employees)
            {
                if (emp.StartDate.Year == year)
                {
                    employeesNrStartedPerMonths[emp.StartDate.ToString("MMM")]++;
                }
            }

            return employeesNrStartedPerMonths;
       }


       private void ShowStatisticNrEmpStarted()
       {
           chartEmployeeNrStarted.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
           chartEmployeeNrStarted.Series["EmployeesNrStarted"].Points.Clear();



           //lineChartEmployeeNrIncrease.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
           //lineChartEmployeeNrIncrease.ChartAreas.FirstOrDefault().AxisY.Interval = 1;
           //lineChartEmployeeNrIncrease.Series["EmployeesNrStarted"].Points.Clear();

            int index = cbFilterByDepNrEmpStarted.SelectedIndex;

           int year = Convert.ToInt32(cbFilterByYearNrEmpStarted.SelectedItem);

           if (index != -1)
           {
               if (index == 0)
               {
                   Dictionary<string, int> empNrPerMonths = SetNrEmployeesStartedPerPeriod(year, departmentManagement.GetAllEmployees());

                   for (int i = 0; i<empNrPerMonths.Count; i++)
                   {
                       chartEmployeeNrStarted.Series["EmployeesNrStarted"].Points.AddXY(
                           empNrPerMonths.Keys.ElementAt(i),
                           empNrPerMonths.Values.ElementAt(i));

                       /*lineChartEmployeeNrIncrease.Series["EmployeesNrStarted"].Points.AddXY(
                           empNrPerMonths.Keys.ElementAt(i),
                           empNrPerMonths.Values.ElementAt(i));*/
                    }
               }
               else
               {
                   string department = cbFilterByDepNrEmpStarted.SelectedItem.ToString();
                   Department selectedDep = departmentManagement.GetDepartment(department);

                   Dictionary<string, int> empNrPerMonths = SetNrEmployeesStartedPerPeriod(year, selectedDep.GetAllEmployees());

                   for (int i = 0; i < empNrPerMonths.Count; i++)
                   {
                       chartEmployeeNrStarted.Series["EmployeesNrStarted"].Points.AddXY(
                           empNrPerMonths.Keys.ElementAt(i),
                           empNrPerMonths.Values.ElementAt(i));
                       /*lineChartEmployeeNrIncrease.Series["EmployeesNrStarted"].Points.AddXY(
                           empNrPerMonths.Keys.ElementAt(i),
                           empNrPerMonths.Values.ElementAt(i));*/
                    }
               }

           }
       }


       private Dictionary<string, int> SetEmployeesIncreasePerPeriod(int year, List<Employee> employees)
       {
           Dictionary<string, int> employeesNrStartedPerMonths = new Dictionary<string, int>();

           employeesNrStartedPerMonths.Add("Jan", 0);
           employeesNrStartedPerMonths.Add("Feb", 0);
           employeesNrStartedPerMonths.Add("Mar", 0);
           employeesNrStartedPerMonths.Add("Apr", 0);
           employeesNrStartedPerMonths.Add("May", 0);
           employeesNrStartedPerMonths.Add("Jun", 0);
           employeesNrStartedPerMonths.Add("Jul", 0);
           employeesNrStartedPerMonths.Add("Aug", 0);
           employeesNrStartedPerMonths.Add("Sep", 0);
           employeesNrStartedPerMonths.Add("Oct", 0);
           employeesNrStartedPerMonths.Add("Nov", 0);
           employeesNrStartedPerMonths.Add("Dec", 0);

           

           foreach (Employee emp in employees)
           {
               if (emp.StartDate.Year == year)
               {
                   employeesNrStartedPerMonths[emp.StartDate.ToString("MMM")]++;
               }
           }
           
           for (int i = 0; i < employeesNrStartedPerMonths.Keys.Count; i++)
           {
               if (i > 0)
               {
                   employeesNrStartedPerMonths[employeesNrStartedPerMonths.Keys.ElementAt(i)] += 
                       employeesNrStartedPerMonths[employeesNrStartedPerMonths.Keys.ElementAt(i-1)];
                }
               
           }

           return employeesNrStartedPerMonths;
       }


       private void ShowStatisticsNrEmpIncrease()
       {
            lineChartEmployeeNrIncrease.ChartAreas.FirstOrDefault().AxisX.Interval = 1;
            lineChartEmployeeNrIncrease.ChartAreas.FirstOrDefault().AxisY.Interval = 1;
            lineChartEmployeeNrIncrease.Series["EmployeesNrIncrease"].Points.Clear();

            int index = cbFilterByDepEmpNrIncrease.SelectedIndex;

            int year = Convert.ToInt32(cbFilterByYearNrEmpIncrease.SelectedItem);

            if (index != -1)
            {
                if (index == 0)
                {
                    Dictionary<string, int> empNrPerMonths = SetEmployeesIncreasePerPeriod(year, departmentManagement.GetAllEmployees());

                    for (int i = 0; i < empNrPerMonths.Count; i++)
                    {
                        lineChartEmployeeNrIncrease.Series["EmployeesNrIncrease"].Points.AddXY(
                            empNrPerMonths.Keys.ElementAt(i),
                            empNrPerMonths.Values.ElementAt(i));
                    }
                }
                else
                {
                    string department = cbFilterByDepEmpNrIncrease.SelectedItem.ToString();
                    Department selectedDep = departmentManagement.GetDepartment(department);

                    Dictionary<string, int> empNrPerMonths = SetEmployeesIncreasePerPeriod(year, selectedDep.GetAllEmployees());

                    for (int i = 0; i < empNrPerMonths.Count; i++)
                    {
                        lineChartEmployeeNrIncrease.Series["EmployeesNrIncrease"].Points.AddXY(
                            empNrPerMonths.Keys.ElementAt(i),
                            empNrPerMonths.Values.ElementAt(i));
                    }
                }

            }
        }
       
       private void cbChooseYearNrEmpIncrease_SelectedIndexChanged(object sender, EventArgs e)
       {
           ShowStatisticsNrEmpIncrease();
       }

        private void cbFilterByDepEmpNrIncrease_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowStatisticsNrEmpIncrease();
        }

        private void cbFilterByDepNrEmpStarted_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowStatisticNrEmpStarted();
        }
        private void cbFilterByYearNrEmpStarted_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowStatisticNrEmpStarted();
        }

        private void tabControlManagement_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlManagement.SelectedTab == EmployeesIncreaseTab)
            {
                cbFilterByDepEmpNrIncrease.SelectedIndex = 0;
               
                cbFilterByYearNrEmpIncrease.SelectedIndex = cbFilterByYearNrEmpIncrease.Items.IndexOf(DateTime.Now.Year);
            }
            else if(tabControlManagement.SelectedTab == NrEmployeesStartedTab)
            {
                cbFilterByDepNrEmpStarted.SelectedIndex = 0;
                cbFilterByYearNrEmpStarted.SelectedIndex = cbFilterByYearNrEmpStarted.Items.IndexOf(DateTime.Now.Year);
            }
        }

        private void ApplyShortcutsBTN_Click(object sender, EventArgs e)
        {
            if (empChartsCH.Checked == false)
            {
                empChartsShortcut.Visible = false;
                Point location = empChartsShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, empChartsShortcut.Name);
            }

            if (stocksChartCH.Checked == false)
            {
                stockChartShortcut.Visible = false;
                Point location = stockChartShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, stockChartShortcut.Name);
            }

            if (empAgeCH.Checked == false)
            {
                empAgeChartShortcut.Visible = false;
                Point location = empAgeChartShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, empAgeChartShortcut.Name);
            }

            if (empIncreaseCH.Checked == false)
            {
                empIncreaseShortcut.Visible = false;
                Point location = empIncreaseShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, empIncreaseShortcut.Name);
            }

            if (empCityCH.Checked == false)
            {
                empCityChartShortcut.Visible = false;
                Point location = empCityChartShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, empCityChartShortcut.Name);
            }

            if (newEmpCH.Checked == false)
            {
                newEmpStatsShortcut.Visible = false;
                Point location = newEmpStatsShortcut.Location;
                shortcutLocations[location] = true;
                dbc.RemoveShortcut(currentEmp, newEmpStatsShortcut.Name);
            }

            if (empChartsCH.Checked)
            {
                activateShortCut(empChartsShortcut);
            }

            if (stocksChartCH.Checked)
            {
                activateShortCut(stockChartShortcut);
            }

            if (empAgeCH.Checked)
            {
                activateShortCut(empAgeChartShortcut);
            }

            if (newEmpCH.Checked)
            {
                activateShortCut(newEmpStatsShortcut);
            }

            if (empIncreaseCH.Checked)
            {
                activateShortCut(empIncreaseShortcut);
            }

            if (empCityCH.Checked)
            {
                activateShortCut(empCityChartShortcut);
            }
        }
        private void activateShortCut(Panel shortcut)
        {
            Point location = shortcut.Location;
            shortcutLocations[location] = true;
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
        private void checkForShortcuts()
        {
            empChartsShortcut.Visible = false;
            stockChartShortcut.Visible = false;
            empAgeChartShortcut.Visible = false;
            newEmpStatsShortcut.Visible = false;
            empIncreaseShortcut.Visible = false;
            empCityChartShortcut.Visible = false;


            List<Panel> allShortcuts = new List<Panel>();

            allShortcuts.Add(empChartsShortcut);
            allShortcuts.Add(stockChartShortcut);
            allShortcuts.Add(empAgeChartShortcut);
            allShortcuts.Add(newEmpStatsShortcut);
            allShortcuts.Add(empIncreaseShortcut);
            allShortcuts.Add(empCityChartShortcut);

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
                    if (s.Name == empChartsShortcut.Name)
                    {
                        empChartsCH.Checked = true;
                    }
                    else if (s.Name == stockChartShortcut.Name)
                    {
                        stocksChartCH.Checked = true;
                    }
                    else if (s.Name == empAgeChartShortcut.Name)
                    {
                        empAgeCH.Checked = true;
                    }
                    else if (s.Name == newEmpStatsShortcut.Name)
                    {
                        newEmpCH.Checked = true;
                    }
                    else if (s.Name == empIncreaseShortcut.Name)
                    {
                        empIncreaseCH.Checked = true;
                    }
                    else if (s.Name == empCityChartShortcut.Name)
                    {
                        empCityCH.Checked = true;
                    }
                }
            }
        }
        private void setShortcutLocationtions()
        {
            shortcutLocations.Add(new Point(1112, 74), true);
            shortcutLocations.Add(new Point(1112, 160), true);
            shortcutLocations.Add(new Point(1112, 246), true);
            shortcutLocations.Add(new Point(1112, 332), true);
            shortcutLocations.Add(new Point(1112, 418), true);
            shortcutLocations.Add(new Point(1112, 504), true);
        }
        private void GoToEmpCharts()
        {
            tabControlManagement.SelectedTab = ViewChartsEmp;
        }
        private void GoToStockChart()
        {
            tabControlManagement.SelectedTab = ViewChartStocks;
        }
        private void GoToEmpAgeChart()
        {
            tabControlManagement.SelectedTab = Age;
        }
        private void GoToEmpCityChart()
        {
            tabControlManagement.SelectedTab = City;
        }
        private void GoToEmpIncreaseChart()
        {
            tabControlManagement.SelectedTab = EmployeesIncreaseTab;
        }
        private void GoToNewEmpStats()
        {
            tabControlManagement.SelectedTab = NrEmployeesStartedTab;
        }

        private void EmpChartsShortcut_Click(object sender, EventArgs e)
        {
            GoToEmpCharts();
        }

        private void EmpChartsLBL_Click(object sender, EventArgs e)
        {
            GoToEmpCharts();
        }

        private void EmpChartShortcut_Click(object sender, EventArgs e)
        {
            GoToEmpCharts();
        }

        private void StockChartShortcut_Click(object sender, EventArgs e)
        {
            GoToStockChart();
        }

        private void StockChartLBL_Click(object sender, EventArgs e)
        {
            GoToStockChart();
        }

        private void StockChartPic_Click(object sender, EventArgs e)
        {
            GoToStockChart();
        }

        private void EmpAgeChartShortcut_Click(object sender, EventArgs e)
        {
            GoToEmpAgeChart();
        }

        private void EmpAgeLBL_Click(object sender, EventArgs e)
        {
            GoToEmpAgeChart();
        }

        private void EmpAgeChartPic_Click(object sender, EventArgs e)
        {
            GoToEmpAgeChart();
        }

        private void EmpCityChartShortcut_Click(object sender, EventArgs e)
        {
            GoToEmpCityChart();
        }

        private void EmpCityChartLBL_Click(object sender, EventArgs e)
        {
            GoToEmpCityChart();
        }

        private void EmpCityChartPic_Click(object sender, EventArgs e)
        {
            GoToEmpCityChart();
        }

        private void EmpIncreaseShortcut_Click(object sender, EventArgs e)
        {
            GoToEmpIncreaseChart();
        }

        private void EmpIncreaseLBL_Click(object sender, EventArgs e)
        {
            GoToEmpIncreaseChart();
        }

        private void EmpIncreasePic_Click(object sender, EventArgs e)
        {
            GoToEmpIncreaseChart();
        }

        private void NewEmpStatsShortcut_Click(object sender, EventArgs e)
        {
            GoToNewEmpStats();
        }

        private void NewEmpStatsLBL_Click(object sender, EventArgs e)
        {
            GoToNewEmpStats();
        }

        private void NewEmpStatsPic_Click(object sender, EventArgs e)
        {
            GoToNewEmpStats();
        }
    }
}


