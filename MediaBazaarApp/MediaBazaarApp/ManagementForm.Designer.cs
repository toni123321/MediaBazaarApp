
namespace MediaBazaarApp
{
    partial class ManagementForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.tabControlManagement = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.ViewChartsEmp = new System.Windows.Forms.TabPage();
            this.AvgWageChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EmpPerDepChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ViewChartStocks = new System.Windows.Forms.TabPage();
            this.StocksChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Age = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxAge = new System.Windows.Forms.ComboBox();
            this.AgeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.City = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxCity = new System.Windows.Forms.ComboBox();
            this.ResidenceChart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.EmployeesIncreaseTab = new System.Windows.Forms.TabPage();
            this.lineChartEmployeeNrIncrease = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.gbxFilterByYearNrEmpIncrease = new System.Windows.Forms.GroupBox();
            this.cbFilterByYearNrEmpIncrease = new System.Windows.Forms.ComboBox();
            this.gbxFilterByDepNrEmpIncrease = new System.Windows.Forms.GroupBox();
            this.cbFilterByDepEmpNrIncrease = new System.Windows.Forms.ComboBox();
            this.NrEmployeesStartedTab = new System.Windows.Forms.TabPage();
            this.gbxFilterByYearNrEmpStarted = new System.Windows.Forms.GroupBox();
            this.cbFilterByYearNrEmpStarted = new System.Windows.Forms.ComboBox();
            this.gbxFilterByDepNrEmpStarted = new System.Windows.Forms.GroupBox();
            this.cbFilterByDepNrEmpStarted = new System.Windows.Forms.ComboBox();
            this.chartEmployeeNrStarted = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.tabControlManagement.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.ViewChartsEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AvgWageChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPerDepChart)).BeginInit();
            this.ViewChartStocks.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StocksChart)).BeginInit();
            this.Age.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeChart)).BeginInit();
            this.City.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResidenceChart1)).BeginInit();
            this.EmployeesIncreaseTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lineChartEmployeeNrIncrease)).BeginInit();
            this.gbxFilterByYearNrEmpIncrease.SuspendLayout();
            this.gbxFilterByDepNrEmpIncrease.SuspendLayout();
            this.NrEmployeesStartedTab.SuspendLayout();
            this.gbxFilterByYearNrEmpStarted.SuspendLayout();
            this.gbxFilterByDepNrEmpStarted.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeNrStarted)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlManagement
            // 
            this.tabControlManagement.Controls.Add(this.Home);
            this.tabControlManagement.Controls.Add(this.ViewChartsEmp);
            this.tabControlManagement.Controls.Add(this.ViewChartStocks);
            this.tabControlManagement.Controls.Add(this.Age);
            this.tabControlManagement.Controls.Add(this.City);
            this.tabControlManagement.Controls.Add(this.EmployeesIncreaseTab);
            this.tabControlManagement.Controls.Add(this.NrEmployeesStartedTab);
            this.tabControlManagement.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlManagement.Location = new System.Drawing.Point(4, 5);
            this.tabControlManagement.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tabControlManagement.Name = "tabControlManagement";
            this.tabControlManagement.SelectedIndex = 0;
            this.tabControlManagement.Size = new System.Drawing.Size(1495, 781);
            this.tabControlManagement.TabIndex = 0;
            this.tabControlManagement.SelectedIndexChanged += new System.EventHandler(this.tabControlManagement_SelectedIndexChanged);
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Home.Controls.Add(this.pictureBox7);
            this.Home.Controls.Add(this.lbTime);
            this.Home.Controls.Add(this.lbDateDayOfWeek);
            this.Home.Controls.Add(this.lbGreetingMsg);
            this.Home.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Home.Location = new System.Drawing.Point(4, 27);
            this.Home.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(1487, 750);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MediaBazaarApp.Properties.Resources.MediaBazaarLogo;
            this.pictureBox7.Location = new System.Drawing.Point(19, 541);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(223, 191);
            this.pictureBox7.TabIndex = 15;
            this.pictureBox7.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTime.Location = new System.Drawing.Point(51, 363);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(120, 54);
            this.lbTime.TabIndex = 14;
            this.lbTime.Text = "12:30";
            // 
            // lbDateDayOfWeek
            // 
            this.lbDateDayOfWeek.AutoSize = true;
            this.lbDateDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDayOfWeek.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(51, 423);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(278, 54);
            this.lbDateDayOfWeek.TabIndex = 13;
            this.lbDateDayOfWeek.Text = "Monday, 1 Jan";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreetingMsg.Location = new System.Drawing.Point(49, 288);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(533, 65);
            this.lbGreetingMsg.TabIndex = 12;
            this.lbGreetingMsg.Text = "Good morning, Name!";
            // 
            // ViewChartsEmp
            // 
            this.ViewChartsEmp.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ViewChartsEmp.Controls.Add(this.AvgWageChart);
            this.ViewChartsEmp.Controls.Add(this.EmpPerDepChart);
            this.ViewChartsEmp.Location = new System.Drawing.Point(4, 27);
            this.ViewChartsEmp.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewChartsEmp.Name = "ViewChartsEmp";
            this.ViewChartsEmp.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewChartsEmp.Size = new System.Drawing.Size(1487, 750);
            this.ViewChartsEmp.TabIndex = 3;
            this.ViewChartsEmp.Text = "Employees charts";
            // 
            // AvgWageChart
            // 
            this.AvgWageChart.BackColor = System.Drawing.Color.MediumTurquoise;
            chartArea1.Name = "ChartArea1";
            this.AvgWageChart.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.AvgWageChart.Legends.Add(legend1);
            this.AvgWageChart.Location = new System.Drawing.Point(728, 5);
            this.AvgWageChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AvgWageChart.Name = "AvgWageChart";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.AvgWageChart.Series.Add(series1);
            this.AvgWageChart.Size = new System.Drawing.Size(737, 678);
            this.AvgWageChart.TabIndex = 1;
            this.AvgWageChart.Text = "chart1";
            title1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title1.Name = "Averege Wage Per Department";
            title1.Text = "Averege Wage Per Department";
            this.AvgWageChart.Titles.Add(title1);
            // 
            // EmpPerDepChart
            // 
            this.EmpPerDepChart.BackColor = System.Drawing.Color.MediumTurquoise;
            chartArea2.Name = "ChartArea1";
            this.EmpPerDepChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.EmpPerDepChart.Legends.Add(legend2);
            this.EmpPerDepChart.Location = new System.Drawing.Point(0, 5);
            this.EmpPerDepChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmpPerDepChart.Name = "EmpPerDepChart";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.EmpPerDepChart.Series.Add(series2);
            this.EmpPerDepChart.Size = new System.Drawing.Size(749, 678);
            this.EmpPerDepChart.TabIndex = 0;
            this.EmpPerDepChart.Text = "chart1";
            title2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Employees Per Department";
            title2.Text = "Employees Per Department";
            this.EmpPerDepChart.Titles.Add(title2);
            // 
            // ViewChartStocks
            // 
            this.ViewChartStocks.Controls.Add(this.StocksChart);
            this.ViewChartStocks.Location = new System.Drawing.Point(4, 27);
            this.ViewChartStocks.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewChartStocks.Name = "ViewChartStocks";
            this.ViewChartStocks.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ViewChartStocks.Size = new System.Drawing.Size(1487, 750);
            this.ViewChartStocks.TabIndex = 4;
            this.ViewChartStocks.Text = "Stocks chart";
            this.ViewChartStocks.UseVisualStyleBackColor = true;
            // 
            // StocksChart
            // 
            this.StocksChart.BackColor = System.Drawing.Color.MediumTurquoise;
            chartArea3.Name = "ChartArea1";
            this.StocksChart.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.StocksChart.Legends.Add(legend3);
            this.StocksChart.Location = new System.Drawing.Point(7, 9);
            this.StocksChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.StocksChart.Name = "StocksChart";
            series3.ChartArea = "ChartArea1";
            series3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series3.Legend = "Legend1";
            series3.Name = "Price in €";
            series3.YValuesPerPoint = 4;
            series4.ChartArea = "ChartArea1";
            series4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series4.Legend = "Legend1";
            series4.Name = "Quantity";
            this.StocksChart.Series.Add(series3);
            this.StocksChart.Series.Add(series4);
            this.StocksChart.Size = new System.Drawing.Size(1458, 678);
            this.StocksChart.TabIndex = 0;
            this.StocksChart.Text = "chart1";
            title3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title3.Name = "Stocks";
            title3.Text = "Stocks";
            this.StocksChart.Titles.Add(title3);
            // 
            // Age
            // 
            this.Age.BackColor = System.Drawing.Color.MediumTurquoise;
            this.Age.Controls.Add(this.label3);
            this.Age.Controls.Add(this.cbxAge);
            this.Age.Controls.Add(this.AgeChart);
            this.Age.Location = new System.Drawing.Point(4, 27);
            this.Age.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Age.Name = "Age";
            this.Age.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Age.Size = new System.Drawing.Size(1487, 750);
            this.Age.TabIndex = 6;
            this.Age.Text = "Emplyees age Chart";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(242, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "Choose department";
            // 
            // cbxAge
            // 
            this.cbxAge.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbxAge.FormattingEnabled = true;
            this.cbxAge.Items.AddRange(new object[] {
            "View age overall"});
            this.cbxAge.Location = new System.Drawing.Point(20, 116);
            this.cbxAge.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxAge.Name = "cbxAge";
            this.cbxAge.Size = new System.Drawing.Size(186, 26);
            this.cbxAge.TabIndex = 1;
            this.cbxAge.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // AgeChart
            // 
            chartArea4.Name = "ChartArea1";
            this.AgeChart.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.AgeChart.Legends.Add(legend4);
            this.AgeChart.Location = new System.Drawing.Point(282, 9);
            this.AgeChart.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AgeChart.Name = "AgeChart";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Employees Age";
            this.AgeChart.Series.Add(series5);
            this.AgeChart.Size = new System.Drawing.Size(951, 661);
            this.AgeChart.TabIndex = 0;
            this.AgeChart.Text = "chart1";
            // 
            // City
            // 
            this.City.BackColor = System.Drawing.Color.MediumTurquoise;
            this.City.Controls.Add(this.label2);
            this.City.Controls.Add(this.cbxCity);
            this.City.Controls.Add(this.ResidenceChart1);
            this.City.Location = new System.Drawing.Point(4, 27);
            this.City.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.City.Name = "City";
            this.City.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.City.Size = new System.Drawing.Size(1487, 750);
            this.City.TabIndex = 7;
            this.City.Text = "Employees city chart";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(68, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "Choose department";
            // 
            // cbxCity
            // 
            this.cbxCity.BackColor = System.Drawing.Color.Gainsboro;
            this.cbxCity.FormattingEnabled = true;
            this.cbxCity.Items.AddRange(new object[] {
            "Overall"});
            this.cbxCity.Location = new System.Drawing.Point(73, 180);
            this.cbxCity.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCity.Name = "cbxCity";
            this.cbxCity.Size = new System.Drawing.Size(147, 26);
            this.cbxCity.TabIndex = 1;
            this.cbxCity.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // ResidenceChart1
            // 
            chartArea5.Name = "ChartArea1";
            this.ResidenceChart1.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.ResidenceChart1.Legends.Add(legend5);
            this.ResidenceChart1.Location = new System.Drawing.Point(414, 101);
            this.ResidenceChart1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ResidenceChart1.Name = "ResidenceChart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Employees";
            this.ResidenceChart1.Series.Add(series6);
            this.ResidenceChart1.Size = new System.Drawing.Size(746, 509);
            this.ResidenceChart1.TabIndex = 0;
            this.ResidenceChart1.Text = "chart1";
            // 
            // EmployeesIncreaseTab
            // 
            this.EmployeesIncreaseTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.EmployeesIncreaseTab.Controls.Add(this.lineChartEmployeeNrIncrease);
            this.EmployeesIncreaseTab.Controls.Add(this.gbxFilterByYearNrEmpIncrease);
            this.EmployeesIncreaseTab.Controls.Add(this.gbxFilterByDepNrEmpIncrease);
            this.EmployeesIncreaseTab.Location = new System.Drawing.Point(4, 27);
            this.EmployeesIncreaseTab.Name = "EmployeesIncreaseTab";
            this.EmployeesIncreaseTab.Size = new System.Drawing.Size(1487, 750);
            this.EmployeesIncreaseTab.TabIndex = 8;
            this.EmployeesIncreaseTab.Text = "Employee increase";
            // 
            // lineChartEmployeeNrIncrease
            // 
            chartArea6.Name = "ChartArea1";
            this.lineChartEmployeeNrIncrease.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.lineChartEmployeeNrIncrease.Legends.Add(legend6);
            this.lineChartEmployeeNrIncrease.Location = new System.Drawing.Point(68, 122);
            this.lineChartEmployeeNrIncrease.Name = "lineChartEmployeeNrIncrease";
            series7.ChartArea = "ChartArea1";
            series7.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series7.Legend = "Legend1";
            series7.Name = "EmployeesNrIncrease";
            this.lineChartEmployeeNrIncrease.Series.Add(series7);
            this.lineChartEmployeeNrIncrease.Size = new System.Drawing.Size(1329, 557);
            this.lineChartEmployeeNrIncrease.TabIndex = 5;
            this.lineChartEmployeeNrIncrease.Text = "chart1";
            // 
            // gbxFilterByYearNrEmpIncrease
            // 
            this.gbxFilterByYearNrEmpIncrease.Controls.Add(this.cbFilterByYearNrEmpIncrease);
            this.gbxFilterByYearNrEmpIncrease.Location = new System.Drawing.Point(754, 33);
            this.gbxFilterByYearNrEmpIncrease.Name = "gbxFilterByYearNrEmpIncrease";
            this.gbxFilterByYearNrEmpIncrease.Size = new System.Drawing.Size(327, 70);
            this.gbxFilterByYearNrEmpIncrease.TabIndex = 4;
            this.gbxFilterByYearNrEmpIncrease.TabStop = false;
            this.gbxFilterByYearNrEmpIncrease.Text = "Choose year";
            // 
            // cbFilterByYearNrEmpIncrease
            // 
            this.cbFilterByYearNrEmpIncrease.FormattingEnabled = true;
            this.cbFilterByYearNrEmpIncrease.Location = new System.Drawing.Point(112, 23);
            this.cbFilterByYearNrEmpIncrease.Name = "cbFilterByYearNrEmpIncrease";
            this.cbFilterByYearNrEmpIncrease.Size = new System.Drawing.Size(166, 26);
            this.cbFilterByYearNrEmpIncrease.TabIndex = 0;
            this.cbFilterByYearNrEmpIncrease.SelectedIndexChanged += new System.EventHandler(this.cbChooseYearNrEmpIncrease_SelectedIndexChanged);
            // 
            // gbxFilterByDepNrEmpIncrease
            // 
            this.gbxFilterByDepNrEmpIncrease.Controls.Add(this.cbFilterByDepEmpNrIncrease);
            this.gbxFilterByDepNrEmpIncrease.Location = new System.Drawing.Point(352, 33);
            this.gbxFilterByDepNrEmpIncrease.Name = "gbxFilterByDepNrEmpIncrease";
            this.gbxFilterByDepNrEmpIncrease.Size = new System.Drawing.Size(327, 70);
            this.gbxFilterByDepNrEmpIncrease.TabIndex = 3;
            this.gbxFilterByDepNrEmpIncrease.TabStop = false;
            this.gbxFilterByDepNrEmpIncrease.Text = "Filter by department";
            // 
            // cbFilterByDepEmpNrIncrease
            // 
            this.cbFilterByDepEmpNrIncrease.FormattingEnabled = true;
            this.cbFilterByDepEmpNrIncrease.Location = new System.Drawing.Point(87, 23);
            this.cbFilterByDepEmpNrIncrease.Name = "cbFilterByDepEmpNrIncrease";
            this.cbFilterByDepEmpNrIncrease.Size = new System.Drawing.Size(205, 26);
            this.cbFilterByDepEmpNrIncrease.TabIndex = 0;
            this.cbFilterByDepEmpNrIncrease.SelectedIndexChanged += new System.EventHandler(this.cbFilterByDepEmpNrIncrease_SelectedIndexChanged);
            // 
            // NrEmployeesStartedTab
            // 
            this.NrEmployeesStartedTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.NrEmployeesStartedTab.Controls.Add(this.gbxFilterByYearNrEmpStarted);
            this.NrEmployeesStartedTab.Controls.Add(this.gbxFilterByDepNrEmpStarted);
            this.NrEmployeesStartedTab.Controls.Add(this.chartEmployeeNrStarted);
            this.NrEmployeesStartedTab.Location = new System.Drawing.Point(4, 27);
            this.NrEmployeesStartedTab.Name = "NrEmployeesStartedTab";
            this.NrEmployeesStartedTab.Size = new System.Drawing.Size(1487, 750);
            this.NrEmployeesStartedTab.TabIndex = 9;
            this.NrEmployeesStartedTab.Text = "New Employees statistics";
            // 
            // gbxFilterByYearNrEmpStarted
            // 
            this.gbxFilterByYearNrEmpStarted.Controls.Add(this.cbFilterByYearNrEmpStarted);
            this.gbxFilterByYearNrEmpStarted.Location = new System.Drawing.Point(771, 32);
            this.gbxFilterByYearNrEmpStarted.Name = "gbxFilterByYearNrEmpStarted";
            this.gbxFilterByYearNrEmpStarted.Size = new System.Drawing.Size(327, 70);
            this.gbxFilterByYearNrEmpStarted.TabIndex = 6;
            this.gbxFilterByYearNrEmpStarted.TabStop = false;
            this.gbxFilterByYearNrEmpStarted.Text = "Choose year";
            // 
            // cbFilterByYearNrEmpStarted
            // 
            this.cbFilterByYearNrEmpStarted.FormattingEnabled = true;
            this.cbFilterByYearNrEmpStarted.Location = new System.Drawing.Point(112, 23);
            this.cbFilterByYearNrEmpStarted.Name = "cbFilterByYearNrEmpStarted";
            this.cbFilterByYearNrEmpStarted.Size = new System.Drawing.Size(166, 26);
            this.cbFilterByYearNrEmpStarted.TabIndex = 0;
            this.cbFilterByYearNrEmpStarted.SelectedIndexChanged += new System.EventHandler(this.cbFilterByYearNrEmpStarted_SelectedIndexChanged);
            // 
            // gbxFilterByDepNrEmpStarted
            // 
            this.gbxFilterByDepNrEmpStarted.Controls.Add(this.cbFilterByDepNrEmpStarted);
            this.gbxFilterByDepNrEmpStarted.Location = new System.Drawing.Point(309, 32);
            this.gbxFilterByDepNrEmpStarted.Name = "gbxFilterByDepNrEmpStarted";
            this.gbxFilterByDepNrEmpStarted.Size = new System.Drawing.Size(327, 70);
            this.gbxFilterByDepNrEmpStarted.TabIndex = 5;
            this.gbxFilterByDepNrEmpStarted.TabStop = false;
            this.gbxFilterByDepNrEmpStarted.Text = "Filter by department";
            // 
            // cbFilterByDepNrEmpStarted
            // 
            this.cbFilterByDepNrEmpStarted.FormattingEnabled = true;
            this.cbFilterByDepNrEmpStarted.Location = new System.Drawing.Point(87, 23);
            this.cbFilterByDepNrEmpStarted.Name = "cbFilterByDepNrEmpStarted";
            this.cbFilterByDepNrEmpStarted.Size = new System.Drawing.Size(205, 26);
            this.cbFilterByDepNrEmpStarted.TabIndex = 0;
            this.cbFilterByDepNrEmpStarted.SelectedIndexChanged += new System.EventHandler(this.cbFilterByDepNrEmpStarted_SelectedIndexChanged);
            // 
            // chartEmployeeNrStarted
            // 
            chartArea7.Name = "ChartArea1";
            this.chartEmployeeNrStarted.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.chartEmployeeNrStarted.Legends.Add(legend7);
            this.chartEmployeeNrStarted.Location = new System.Drawing.Point(110, 136);
            this.chartEmployeeNrStarted.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chartEmployeeNrStarted.Name = "chartEmployeeNrStarted";
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "EmployeesNrStarted";
            this.chartEmployeeNrStarted.Series.Add(series8);
            this.chartEmployeeNrStarted.Size = new System.Drawing.Size(1197, 545);
            this.chartEmployeeNrStarted.TabIndex = 3;
            this.chartEmployeeNrStarted.Text = "chart1";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1512, 787);
            this.Controls.Add(this.tabControlManagement);
            this.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "ManagementForm";
            this.Text = "ManagementForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ManagementForm_FormClosed);
            this.Load += new System.EventHandler(this.ManagementForm_Load);
            this.tabControlManagement.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.Home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.ViewChartsEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AvgWageChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpPerDepChart)).EndInit();
            this.ViewChartStocks.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.StocksChart)).EndInit();
            this.Age.ResumeLayout(false);
            this.Age.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AgeChart)).EndInit();
            this.City.ResumeLayout(false);
            this.City.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ResidenceChart1)).EndInit();
            this.EmployeesIncreaseTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lineChartEmployeeNrIncrease)).EndInit();
            this.gbxFilterByYearNrEmpIncrease.ResumeLayout(false);
            this.gbxFilterByDepNrEmpIncrease.ResumeLayout(false);
            this.NrEmployeesStartedTab.ResumeLayout(false);
            this.gbxFilterByYearNrEmpStarted.ResumeLayout(false);
            this.gbxFilterByDepNrEmpStarted.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartEmployeeNrStarted)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlManagement;
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage ViewChartsEmp;
        private System.Windows.Forms.DataVisualization.Charting.Chart EmpPerDepChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart AvgWageChart;
        private System.Windows.Forms.TabPage ViewChartStocks;
        private System.Windows.Forms.DataVisualization.Charting.Chart StocksChart;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage Age;
        private System.Windows.Forms.ComboBox cbxAge;
        private System.Windows.Forms.DataVisualization.Charting.Chart AgeChart;
        private System.Windows.Forms.TabPage City;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxCity;
        private System.Windows.Forms.DataVisualization.Charting.Chart ResidenceChart1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbGreetingMsg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TabPage EmployeesIncreaseTab;
        private System.Windows.Forms.ComboBox cbFilterByDepEmpNrIncrease;
        private System.Windows.Forms.GroupBox gbxFilterByYearNrEmpIncrease;
        private System.Windows.Forms.GroupBox gbxFilterByDepNrEmpIncrease;
        private System.Windows.Forms.ComboBox cbFilterByYearNrEmpIncrease;
        private System.Windows.Forms.DataVisualization.Charting.Chart lineChartEmployeeNrIncrease;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.TabPage NrEmployeesStartedTab;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartEmployeeNrStarted;
        private System.Windows.Forms.GroupBox gbxFilterByYearNrEmpStarted;
        private System.Windows.Forms.ComboBox cbFilterByYearNrEmpStarted;
        private System.Windows.Forms.GroupBox gbxFilterByDepNrEmpStarted;
        private System.Windows.Forms.ComboBox cbFilterByDepNrEmpStarted;
    }
}
