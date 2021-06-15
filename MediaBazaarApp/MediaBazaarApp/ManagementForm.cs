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
            lbDateDayOfWeek.Text = DateTime.Now.ToString("dddd, MMMM dd, yyyy");

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
            comboBox1.Items.Add("Overall");
            DBControl db = new DBControl();
            
            foreach (Department department in departmentManagement.GetAllDepartments())
            {
                cbxGenderChart.Items.Add(department.Name);
                cbxAge.Items.Add(department.Name);
                cbxCity.Items.Add(department.Name);
                comboBox1.Items.Add(department.Name);
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
                            GenderPieChart.Series["Gender"].Points.AddXY($"{emp.Gender}", count);
                        }

                        if (emp.Gender.ToString() == "FEMALE")
                        {
                            count += 1;
                            GenderPieChart.Series["Gender"].Points.AddXY($"{emp.Gender}", count);
                        }

                        if (emp.Gender.ToString() == "NONBINARY")
                        {
                            count += 1;
                            GenderPieChart.Series["Gender"].Points.AddXY($"{emp.Gender}", count);
                        }

                        if (emp.Gender.ToString() == "OTHER")
                        {
                            count += 1;
                            GenderPieChart.Series["Gender"].Points.AddXY($"{emp.Gender}", count);
                        }
                    }

                }


            }
        }


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
            


           
           




            /*
                        if (index != -1)
                        {

                            if (index == 0)
                            {
                                foreach (Employee emp in departmentManagement.GetAllEmployees())
                                {
                                    age.Add($"{ DateTime.Now.Year - emp.DateOfBirth.Year}");
                                }

                                var uniqueage = age.Distinct();
                                foreach (string a in uniqueage)
                                {
                                    int count = 0;
                                    foreach (Employee emp in departmentManagement.GetAllEmployees())
                                    {

                                        if ($"{ DateTime.Now.Year - emp.DateOfBirth.Year}" == a)
                                        {
                                            count += 1;
                                        }

                                    }
                                    ShowAgesInGeneral();
                                    AgeChart.Series["Employees Age"].Points.AddXY($"{a}", count);
                                }

                            }
                        }*/

            /*
                        foreach (Department d in departmentManagement.GetAllDepartments())
                        {

                            if (department == d.Name)
                            {
                                age.Clear();




                                foreach (Employee emp in departmentManagement.GetAllEmployees())
                                {
                                    age.Add($"{ DateTime.Now.Year - emp.DateOfBirth.Year}");
                                }








                                foreach (var item in collection)
                                {

                                }


                                var uniqueage = age.Distinct();
                                foreach (string a in uniqueage)
                                {
                                    int count = 0;
                                    foreach (Employee employee in d.GetAllEmployees())
                                    {
                                        if ($"{ DateTime.Now.Year - employee.DateOfBirth.Year}" == a)
                                        {
                                            count += 1;
                                        }

                                    }
                                    AgeChart.Series["Employees Age"].Points.AddXY($"25-30", count);
                                }




                            }

                        }*/


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



        private void comboBox1_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            EmpIncrChart.Series["EmplLine"].Points.Clear();
            EmpIncrChart.ChartAreas[0].AxisX.RoundAxisValues();
            int index = comboBox1.SelectedIndex;
            string[] Month = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };
            Dictionary<string, int> Months = new Dictionary<string, int>();
            string department = comboBox1.SelectedItem.ToString();




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


            if (index != -1)
            {
                if (index == 0)
                {
                    EmpIncrChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    EmpIncrChart.ChartAreas["ChartArea1"].AxisY.Interval = 1;


                    EmpIncrChart.ChartAreas[0].AxisY.RoundAxisValues();

                    /*Dictionary<string, int> Months = ShowAllMonths();
                    for (int i = 0; i < ShowAllAges().Count; i++)
                    {
                        EmpIncrChart.Series["EmplLine"].Points.AddXY(Months.Keys.ElementAt(i), Months.Values.ElementAt(i));
                    }*/


                    foreach (Employee employee in departmentManagement.GetAllEmployees())
                        {
                            if (employee.StartDate.Month == 01)
                            {
                                Months["January"]++;
                            }
                            else if (employee.StartDate.Month == 02)
                            {
                                Months["February"]++;
                            }
                            if (employee.StartDate.Month == 03)
                            {
                                Months["March"]++;
                            }
                            if (employee.StartDate.Month == 04)
                            {
                                Months["April"]++;
                            }
                            if (employee.StartDate.Month == 05)
                            {
                                Months["May"]++;
                            }
                            if (employee.StartDate.Month == 06)
                            {
                                Months["June"]++;
                            }
                            if (employee.StartDate.Month == 07)
                            {
                                Months["July"]++;
                            }
                            if (employee.StartDate.Month == 08)
                            {
                                Months["August"]++;
                            }
                            if (employee.StartDate.Month == 09)
                            {
                                Months["September"]++;
                            }
                            if (employee.StartDate.Month == 10)
                            {
                                Months["October"]++;
                            }
                            if (employee.StartDate.Month == 11)
                            {
                                Months["November"]++;
                            }
                            if (employee.StartDate.Month == 12)
                            {
                                Months["December"]++;
                            }
                        }
                        for (int i = 0; i < 12; i++)
                        {
                            EmpIncrChart.Series["EmplLine"].Points.AddXY(Months.Keys.ElementAt(i), Months.Values.ElementAt(i));
                        }
                    
                }
                else
                {
                    EmpIncrChart.ChartAreas["ChartArea1"].AxisX.Interval = 1;
                    EmpIncrChart.ChartAreas["ChartArea1"].AxisY.Interval = 1;


                    EmpIncrChart.ChartAreas[0].AxisY.RoundAxisValues();
                    foreach (Department d in departmentManagement.GetAllDepartments())
                    {
                        if (department == d.Name)
                        {
                            foreach (Employee employee in d.GetAllEmployees())
                            {
                                if (employee.StartDate.Month == 01)
                                {
                                    Months["January"]++;
                                }
                                else if (employee.StartDate.Month == 02)
                                {
                                    Months["February"]++;
                                }
                                if (employee.StartDate.Month == 03)
                                {
                                    Months["March"]++;
                                }
                                if (employee.StartDate.Month == 04)
                                {
                                    Months["April"]++;
                                }
                                if (employee.StartDate.Month == 05)
                                {
                                    Months["May"]++;
                                }
                                if (employee.StartDate.Month == 06)
                                {
                                    Months["June"]++;
                                }
                                if (employee.StartDate.Month == 07)
                                {
                                    Months["July"]++;
                                }
                                if (employee.StartDate.Month == 08)
                                {
                                    Months["August"]++;
                                }
                                if (employee.StartDate.Month == 09)
                                {
                                    Months["September"]++;
                                }
                                if (employee.StartDate.Month == 10)
                                {
                                    Months["October"]++;
                                }
                                if (employee.StartDate.Month == 11)
                                {
                                    Months["November"]++;
                                }
                                if (employee.StartDate.Month == 12)
                                {
                                    Months["December"]++;
                                }
                            }
                            for (int i = 0; i < 12; i++)
                            {
                                EmpIncrChart.Series["EmplLine"].Points.AddXY(Months.Keys.ElementAt(i), Months.Values.ElementAt(i));
                            }
                        }
                    }
                    
                }
            }
            


        }
    }
}


