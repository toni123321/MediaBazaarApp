﻿
namespace MediaBazaarApp
{
    partial class AdministrationForm
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
            this.tabControlAdministration = new System.Windows.Forms.TabControl();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbNotificationsShelfRestockRequests = new System.Windows.Forms.Label();
            this.lbNotificationsHolidayRequests = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.AddEmpTab = new System.Windows.Forms.TabPage();
            this.gbxAddEmployee = new System.Windows.Forms.GroupBox();
            this.cbEmpDepartment = new System.Windows.Forms.ComboBox();
            this.lbEmpDepartment = new System.Windows.Forms.Label();
            this.cbEmpHourlyWages = new System.Windows.Forms.ComboBox();
            this.cbEmpPosition = new System.Windows.Forms.ComboBox();
            this.cbEmpEmploymentType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lbEmpAddressStreet = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxEmpAddressStreet = new System.Windows.Forms.TextBox();
            this.tbxEmpAddressCity = new System.Windows.Forms.TextBox();
            this.cbEmpGender = new System.Windows.Forms.ComboBox();
            this.lbEmpAddressCity = new System.Windows.Forms.Label();
            this.tbxEmpEmail = new System.Windows.Forms.TextBox();
            this.tbxEmpAddressCountry = new System.Windows.Forms.TextBox();
            this.lbEmpEmail = new System.Windows.Forms.Label();
            this.lbEmpAddressPostCode = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbEmpAddressCountry = new System.Windows.Forms.Label();
            this.dtpEmpDateOfBirth = new System.Windows.Forms.DateTimePicker();
            this.tbxEmpAddressPostCode = new System.Windows.Forms.TextBox();
            this.btnAddEmpoyee = new System.Windows.Forms.Button();
            this.lbEmpEmployementType = new System.Windows.Forms.Label();
            this.lbEmpPosition = new System.Windows.Forms.Label();
            this.lbEmpDateOfBirth = new System.Windows.Forms.Label();
            this.lbEmpHourlyWages = new System.Windows.Forms.Label();
            this.tbxEmpPhone = new System.Windows.Forms.TextBox();
            this.lbEmpPhone = new System.Windows.Forms.Label();
            this.lbEmployeeAddress = new System.Windows.Forms.Label();
            this.tbxEmpLname = new System.Windows.Forms.TextBox();
            this.lbEmpLname = new System.Windows.Forms.Label();
            this.tbxEmpFname = new System.Windows.Forms.TextBox();
            this.lbEmpFname = new System.Windows.Forms.Label();
            this.ManageEmpTab = new System.Windows.Forms.TabPage();
            this.btnEmpManageAttendance = new System.Windows.Forms.Button();
            this.gbxSearchEmp = new System.Windows.Forms.GroupBox();
            this.btnSearchEmp = new System.Windows.Forms.Button();
            this.tbxSearchEmp = new System.Windows.Forms.TextBox();
            this.gbxShowAllEmp = new System.Windows.Forms.GroupBox();
            this.cbSelectEmpType = new System.Windows.Forms.ComboBox();
            this.btnShowAllEmp = new System.Windows.Forms.Button();
            this.btnClearSelectedEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.lbxAllEmployees = new System.Windows.Forms.ListBox();
            this.ManageScheduleTab = new System.Windows.Forms.TabPage();
            this.gbxAutoShiftsAssignPerDay = new System.Windows.Forms.GroupBox();
            this.btnSubmitAutoShiftsAssignPerDay = new System.Windows.Forms.Button();
            this.tbxSun = new System.Windows.Forms.TextBox();
            this.lbSun = new System.Windows.Forms.Label();
            this.tbxSat = new System.Windows.Forms.TextBox();
            this.lbSat = new System.Windows.Forms.Label();
            this.tbxFri = new System.Windows.Forms.TextBox();
            this.lbFri = new System.Windows.Forms.Label();
            this.tbxThurs = new System.Windows.Forms.TextBox();
            this.lbThurs = new System.Windows.Forms.Label();
            this.tbxWed = new System.Windows.Forms.TextBox();
            this.lbWed = new System.Windows.Forms.Label();
            this.tbxTues = new System.Windows.Forms.TextBox();
            this.lbTues = new System.Windows.Forms.Label();
            this.tbxMon = new System.Windows.Forms.TextBox();
            this.lbMon = new System.Windows.Forms.Label();
            this.gbxAutoShiftsAssignAllDays = new System.Windows.Forms.GroupBox();
            this.btnSubmitAutoShiftsAssignAllDays = new System.Windows.Forms.Button();
            this.lbNrWorkers = new System.Windows.Forms.Label();
            this.tbxNrWorkers = new System.Windows.Forms.TextBox();
            this.gbxAssignShiftsAuto = new System.Windows.Forms.GroupBox();
            this.btnChooseAssignTypeAuto = new System.Windows.Forms.Button();
            this.cbAssignTypeAuto = new System.Windows.Forms.ComboBox();
            this.btnAssignShiftsManually = new System.Windows.Forms.Button();
            this.btnScheduleClearSelected = new System.Windows.Forms.Button();
            this.lbScheduleAllEmp = new System.Windows.Forms.Label();
            this.lbxScheduleAllEmp = new System.Windows.Forms.ListBox();
            this.HolidayRequestsTab = new System.Windows.Forms.TabPage();
            this.lbHolidayRequestsInfo = new System.Windows.Forms.Label();
            this.btnHolidayRequestsClearSelected = new System.Windows.Forms.Button();
            this.btnHolidayRequestsDecline = new System.Windows.Forms.Button();
            this.btnHolidayRequestsAccept = new System.Windows.Forms.Button();
            this.lbxAllHolidayRequests = new System.Windows.Forms.ListBox();
            this.ManageStocksTab = new System.Windows.Forms.TabPage();
            this.btnShowAllStocks = new System.Windows.Forms.Button();
            this.gbxSearchStock = new System.Windows.Forms.GroupBox();
            this.btnSearchStock = new System.Windows.Forms.Button();
            this.tbxSearchStock = new System.Windows.Forms.TextBox();
            this.btnStocksClearSelected = new System.Windows.Forms.Button();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.lbAllStocks = new System.Windows.Forms.ListBox();
            this.gbxAddStock = new System.Windows.Forms.GroupBox();
            this.tbxStockDepth = new System.Windows.Forms.TextBox();
            this.lbStockDepth = new System.Windows.Forms.Label();
            this.tbxStockHeight = new System.Windows.Forms.TextBox();
            this.lbStockHeight = new System.Windows.Forms.Label();
            this.tbxStockWidth = new System.Windows.Forms.TextBox();
            this.lbStockWidth = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.tbxStockQuantity = new System.Windows.Forms.TextBox();
            this.lbStockQuantity = new System.Windows.Forms.Label();
            this.tbxStockShortDescription = new System.Windows.Forms.TextBox();
            this.lbStockShortDescription = new System.Windows.Forms.Label();
            this.lbStockDimensions = new System.Windows.Forms.Label();
            this.tbxStockPrice = new System.Windows.Forms.TextBox();
            this.lbStockPrice = new System.Windows.Forms.Label();
            this.tbxStockModel = new System.Windows.Forms.TextBox();
            this.lbStockModel = new System.Windows.Forms.Label();
            this.tbxStockBrand = new System.Windows.Forms.TextBox();
            this.lbStockBrand = new System.Windows.Forms.Label();
            this.ManageShelfRestockRequestsTab = new System.Windows.Forms.TabPage();
            this.lbHistoryShelfRestockRequests = new System.Windows.Forms.Label();
            this.lbxHistoryShelfRestockRequests = new System.Windows.Forms.ListBox();
            this.lbShelfRestockRequestsInfo = new System.Windows.Forms.Label();
            this.btnSehflRestockRequestsClearSelected = new System.Windows.Forms.Button();
            this.btnShelftRestockRequestsMarkAsDone = new System.Windows.Forms.Button();
            this.btnShelftRestockRequestsDecline = new System.Windows.Forms.Button();
            this.lbxAllShelfRestockRequests = new System.Windows.Forms.ListBox();
            this.ManageDepartmentsTab = new System.Windows.Forms.TabPage();
            this.gbxEditDepartment = new System.Windows.Forms.GroupBox();
            this.lbDepartmentEditInfo = new System.Windows.Forms.Label();
            this.btnApplyChangesDepartment = new System.Windows.Forms.Button();
            this.cbDepartmentManagerEdit = new System.Windows.Forms.ComboBox();
            this.lbDepartmentManagerEdit = new System.Windows.Forms.Label();
            this.tbxDepartmentNameEdit = new System.Windows.Forms.TextBox();
            this.lbDepartmentNameEdit = new System.Windows.Forms.Label();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnDepartmentsClearSelected = new System.Windows.Forms.Button();
            this.lbDepartmentsInfo = new System.Windows.Forms.Label();
            this.lbxAllDepartments = new System.Windows.Forms.ListBox();
            this.gbxCreateDeparmtent = new System.Windows.Forms.GroupBox();
            this.btnCreateDepartment = new System.Windows.Forms.Button();
            this.cbDepartmentManager = new System.Windows.Forms.ComboBox();
            this.lbDepartmentManager = new System.Windows.Forms.Label();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.lbDepartmentName = new System.Windows.Forms.Label();
            this.ViewStatisticsEmpTab = new System.Windows.Forms.TabPage();
            this.lbAvgWageEmpDepartment = new System.Windows.Forms.Label();
            this.lbxAvgWageEmpDepartment = new System.Windows.Forms.ListBox();
            this.tbxAvgWageEmp = new System.Windows.Forms.TextBox();
            this.lbAvgWageEmp = new System.Windows.Forms.Label();
            this.lbNrEmpPerDepartment = new System.Windows.Forms.Label();
            this.lbxNrEmpPerDepartment = new System.Windows.Forms.ListBox();
            this.tbxNrEmp = new System.Windows.Forms.TextBox();
            this.lbNrEmp = new System.Windows.Forms.Label();
            this.ViewStatisticsStocksTab = new System.Windows.Forms.TabPage();
            this.btnShowStockStatistics = new System.Windows.Forms.Button();
            this.cbStatisticType = new System.Windows.Forms.ComboBox();
            this.lbxAllStocksStatistics = new System.Windows.Forms.ListBox();
            this.tabControlAdministration.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.AddEmpTab.SuspendLayout();
            this.gbxAddEmployee.SuspendLayout();
            this.ManageEmpTab.SuspendLayout();
            this.gbxSearchEmp.SuspendLayout();
            this.gbxShowAllEmp.SuspendLayout();
            this.ManageScheduleTab.SuspendLayout();
            this.gbxAutoShiftsAssignPerDay.SuspendLayout();
            this.gbxAutoShiftsAssignAllDays.SuspendLayout();
            this.gbxAssignShiftsAuto.SuspendLayout();
            this.HolidayRequestsTab.SuspendLayout();
            this.ManageStocksTab.SuspendLayout();
            this.gbxSearchStock.SuspendLayout();
            this.gbxAddStock.SuspendLayout();
            this.ManageShelfRestockRequestsTab.SuspendLayout();
            this.ManageDepartmentsTab.SuspendLayout();
            this.gbxEditDepartment.SuspendLayout();
            this.gbxCreateDeparmtent.SuspendLayout();
            this.ViewStatisticsEmpTab.SuspendLayout();
            this.ViewStatisticsStocksTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlAdministration
            // 
            this.tabControlAdministration.Controls.Add(this.HomeTab);
            this.tabControlAdministration.Controls.Add(this.AddEmpTab);
            this.tabControlAdministration.Controls.Add(this.ManageEmpTab);
            this.tabControlAdministration.Controls.Add(this.ManageScheduleTab);
            this.tabControlAdministration.Controls.Add(this.HolidayRequestsTab);
            this.tabControlAdministration.Controls.Add(this.ManageStocksTab);
            this.tabControlAdministration.Controls.Add(this.ManageShelfRestockRequestsTab);
            this.tabControlAdministration.Controls.Add(this.ManageDepartmentsTab);
            this.tabControlAdministration.Controls.Add(this.ViewStatisticsEmpTab);
            this.tabControlAdministration.Controls.Add(this.ViewStatisticsStocksTab);
            this.tabControlAdministration.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdministration.Location = new System.Drawing.Point(12, 24);
            this.tabControlAdministration.Name = "tabControlAdministration";
            this.tabControlAdministration.SelectedIndex = 0;
            this.tabControlAdministration.Size = new System.Drawing.Size(1007, 647);
            this.tabControlAdministration.TabIndex = 0;
            // 
            // HomeTab
            // 
            this.HomeTab.Controls.Add(this.lbTime);
            this.HomeTab.Controls.Add(this.lbDateDayOfWeek);
            this.HomeTab.Controls.Add(this.lbNotificationsShelfRestockRequests);
            this.HomeTab.Controls.Add(this.lbNotificationsHolidayRequests);
            this.HomeTab.Controls.Add(this.lbGreetingMsg);
            this.HomeTab.Location = new System.Drawing.Point(4, 27);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3);
            this.HomeTab.Size = new System.Drawing.Size(999, 616);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            this.HomeTab.UseVisualStyleBackColor = true;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Location = new System.Drawing.Point(112, 291);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(41, 18);
            this.lbTime.TabIndex = 4;
            this.lbTime.Text = "Time";
            // 
            // lbDateDayOfWeek
            // 
            this.lbDateDayOfWeek.AutoSize = true;
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(112, 336);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(125, 18);
            this.lbDateDayOfWeek.TabIndex = 3;
            this.lbDateDayOfWeek.Text = "Date/Day of week";
            // 
            // lbNotificationsShelfRestockRequests
            // 
            this.lbNotificationsShelfRestockRequests.AutoSize = true;
            this.lbNotificationsShelfRestockRequests.Location = new System.Drawing.Point(703, 38);
            this.lbNotificationsShelfRestockRequests.Name = "lbNotificationsShelfRestockRequests";
            this.lbNotificationsShelfRestockRequests.Size = new System.Drawing.Size(239, 18);
            this.lbNotificationsShelfRestockRequests.TabIndex = 2;
            this.lbNotificationsShelfRestockRequests.Text = "Shelf restock requests notifications";
            // 
            // lbNotificationsHolidayRequests
            // 
            this.lbNotificationsHolidayRequests.AutoSize = true;
            this.lbNotificationsHolidayRequests.Location = new System.Drawing.Point(458, 38);
            this.lbNotificationsHolidayRequests.Name = "lbNotificationsHolidayRequests";
            this.lbNotificationsHolidayRequests.Size = new System.Drawing.Size(201, 18);
            this.lbNotificationsHolidayRequests.TabIndex = 1;
            this.lbNotificationsHolidayRequests.Text = "Holiday requests notifications";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Location = new System.Drawing.Point(107, 158);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(129, 18);
            this.lbGreetingMsg.TabIndex = 0;
            this.lbGreetingMsg.Text = "Greeting message";
            // 
            // AddEmpTab
            // 
            this.AddEmpTab.Controls.Add(this.gbxAddEmployee);
            this.AddEmpTab.Location = new System.Drawing.Point(4, 27);
            this.AddEmpTab.Name = "AddEmpTab";
            this.AddEmpTab.Padding = new System.Windows.Forms.Padding(3);
            this.AddEmpTab.Size = new System.Drawing.Size(999, 616);
            this.AddEmpTab.TabIndex = 1;
            this.AddEmpTab.Text = "Add employees";
            this.AddEmpTab.UseVisualStyleBackColor = true;
            // 
            // gbxAddEmployee
            // 
            this.gbxAddEmployee.Controls.Add(this.cbEmpDepartment);
            this.gbxAddEmployee.Controls.Add(this.lbEmpDepartment);
            this.gbxAddEmployee.Controls.Add(this.cbEmpHourlyWages);
            this.gbxAddEmployee.Controls.Add(this.cbEmpPosition);
            this.gbxAddEmployee.Controls.Add(this.cbEmpEmploymentType);
            this.gbxAddEmployee.Controls.Add(this.label5);
            this.gbxAddEmployee.Controls.Add(this.lbEmpAddressStreet);
            this.gbxAddEmployee.Controls.Add(this.label4);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpAddressStreet);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpAddressCity);
            this.gbxAddEmployee.Controls.Add(this.cbEmpGender);
            this.gbxAddEmployee.Controls.Add(this.lbEmpAddressCity);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpEmail);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpAddressCountry);
            this.gbxAddEmployee.Controls.Add(this.lbEmpEmail);
            this.gbxAddEmployee.Controls.Add(this.lbEmpAddressPostCode);
            this.gbxAddEmployee.Controls.Add(this.label1);
            this.gbxAddEmployee.Controls.Add(this.lbEmpAddressCountry);
            this.gbxAddEmployee.Controls.Add(this.dtpEmpDateOfBirth);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpAddressPostCode);
            this.gbxAddEmployee.Controls.Add(this.btnAddEmpoyee);
            this.gbxAddEmployee.Controls.Add(this.lbEmpEmployementType);
            this.gbxAddEmployee.Controls.Add(this.lbEmpPosition);
            this.gbxAddEmployee.Controls.Add(this.lbEmpDateOfBirth);
            this.gbxAddEmployee.Controls.Add(this.lbEmpHourlyWages);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpPhone);
            this.gbxAddEmployee.Controls.Add(this.lbEmpPhone);
            this.gbxAddEmployee.Controls.Add(this.lbEmployeeAddress);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpLname);
            this.gbxAddEmployee.Controls.Add(this.lbEmpLname);
            this.gbxAddEmployee.Controls.Add(this.tbxEmpFname);
            this.gbxAddEmployee.Controls.Add(this.lbEmpFname);
            this.gbxAddEmployee.Location = new System.Drawing.Point(193, 30);
            this.gbxAddEmployee.Name = "gbxAddEmployee";
            this.gbxAddEmployee.Size = new System.Drawing.Size(655, 540);
            this.gbxAddEmployee.TabIndex = 0;
            this.gbxAddEmployee.TabStop = false;
            this.gbxAddEmployee.Text = "Add/Hire employee";
            // 
            // cbEmpDepartment
            // 
            this.cbEmpDepartment.FormattingEnabled = true;
            this.cbEmpDepartment.Location = new System.Drawing.Point(143, 400);
            this.cbEmpDepartment.Name = "cbEmpDepartment";
            this.cbEmpDepartment.Size = new System.Drawing.Size(160, 26);
            this.cbEmpDepartment.TabIndex = 38;
            // 
            // lbEmpDepartment
            // 
            this.lbEmpDepartment.AutoSize = true;
            this.lbEmpDepartment.Location = new System.Drawing.Point(26, 403);
            this.lbEmpDepartment.Name = "lbEmpDepartment";
            this.lbEmpDepartment.Size = new System.Drawing.Size(89, 18);
            this.lbEmpDepartment.TabIndex = 37;
            this.lbEmpDepartment.Text = "Department:";
            // 
            // cbEmpHourlyWages
            // 
            this.cbEmpHourlyWages.FormattingEnabled = true;
            this.cbEmpHourlyWages.Location = new System.Drawing.Point(142, 356);
            this.cbEmpHourlyWages.Name = "cbEmpHourlyWages";
            this.cbEmpHourlyWages.Size = new System.Drawing.Size(160, 26);
            this.cbEmpHourlyWages.TabIndex = 36;
            // 
            // cbEmpPosition
            // 
            this.cbEmpPosition.FormattingEnabled = true;
            this.cbEmpPosition.Location = new System.Drawing.Point(142, 318);
            this.cbEmpPosition.Name = "cbEmpPosition";
            this.cbEmpPosition.Size = new System.Drawing.Size(160, 26);
            this.cbEmpPosition.TabIndex = 35;
            // 
            // cbEmpEmploymentType
            // 
            this.cbEmpEmploymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Full-time",
            "Part-time"});
            this.cbEmpEmploymentType.FormattingEnabled = true;
            this.cbEmpEmploymentType.Items.AddRange(new object[] {
            "Management",
            "Depot worker",
            "Shop employee"});
            this.cbEmpEmploymentType.Location = new System.Drawing.Point(143, 279);
            this.cbEmpEmploymentType.Name = "cbEmpEmploymentType";
            this.cbEmpEmploymentType.Size = new System.Drawing.Size(160, 26);
            this.cbEmpEmploymentType.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(101, 251);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 18);
            this.label5.TabIndex = 33;
            this.label5.Text = "Job specifications:";
            // 
            // lbEmpAddressStreet
            // 
            this.lbEmpAddressStreet.AutoSize = true;
            this.lbEmpAddressStreet.Location = new System.Drawing.Point(382, 157);
            this.lbEmpAddressStreet.Name = "lbEmpAddressStreet";
            this.lbEmpAddressStreet.Size = new System.Drawing.Size(51, 18);
            this.lbEmpAddressStreet.TabIndex = 17;
            this.lbEmpAddressStreet.Text = "Street:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(83, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 18);
            this.label4.TabIndex = 32;
            this.label4.Text = "Personal information:";
            // 
            // tbxEmpAddressStreet
            // 
            this.tbxEmpAddressStreet.Location = new System.Drawing.Point(458, 154);
            this.tbxEmpAddressStreet.Name = "tbxEmpAddressStreet";
            this.tbxEmpAddressStreet.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpAddressStreet.TabIndex = 5;
            // 
            // tbxEmpAddressCity
            // 
            this.tbxEmpAddressCity.Location = new System.Drawing.Point(458, 192);
            this.tbxEmpAddressCity.Name = "tbxEmpAddressCity";
            this.tbxEmpAddressCity.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpAddressCity.TabIndex = 18;
            // 
            // cbEmpGender
            // 
            this.cbEmpGender.FormattingEnabled = true;
            this.cbEmpGender.Items.AddRange(new object[] {
            "Female",
            "Male",
            "Other",
            "Not specified"});
            this.cbEmpGender.Location = new System.Drawing.Point(142, 192);
            this.cbEmpGender.Name = "cbEmpGender";
            this.cbEmpGender.Size = new System.Drawing.Size(161, 26);
            this.cbEmpGender.TabIndex = 30;
            this.cbEmpGender.Text = "Choose gender";
            // 
            // lbEmpAddressCity
            // 
            this.lbEmpAddressCity.AutoSize = true;
            this.lbEmpAddressCity.Location = new System.Drawing.Point(397, 195);
            this.lbEmpAddressCity.Name = "lbEmpAddressCity";
            this.lbEmpAddressCity.Size = new System.Drawing.Size(37, 18);
            this.lbEmpAddressCity.TabIndex = 19;
            this.lbEmpAddressCity.Text = "City:";
            // 
            // tbxEmpEmail
            // 
            this.tbxEmpEmail.Location = new System.Drawing.Point(458, 71);
            this.tbxEmpEmail.Name = "tbxEmpEmail";
            this.tbxEmpEmail.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpEmail.TabIndex = 29;
            // 
            // tbxEmpAddressCountry
            // 
            this.tbxEmpAddressCountry.Location = new System.Drawing.Point(458, 232);
            this.tbxEmpAddressCountry.Name = "tbxEmpAddressCountry";
            this.tbxEmpAddressCountry.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpAddressCountry.TabIndex = 20;
            // 
            // lbEmpEmail
            // 
            this.lbEmpEmail.AutoSize = true;
            this.lbEmpEmail.Location = new System.Drawing.Point(379, 74);
            this.lbEmpEmail.Name = "lbEmpEmail";
            this.lbEmpEmail.Size = new System.Drawing.Size(49, 18);
            this.lbEmpEmail.TabIndex = 28;
            this.lbEmpEmail.Text = "Email:";
            // 
            // lbEmpAddressPostCode
            // 
            this.lbEmpAddressPostCode.AutoSize = true;
            this.lbEmpAddressPostCode.Location = new System.Drawing.Point(359, 271);
            this.lbEmpAddressPostCode.Name = "lbEmpAddressPostCode";
            this.lbEmpAddressPostCode.Size = new System.Drawing.Size(79, 18);
            this.lbEmpAddressPostCode.TabIndex = 25;
            this.lbEmpAddressPostCode.Text = "PostCode:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Gender:";
            // 
            // lbEmpAddressCountry
            // 
            this.lbEmpAddressCountry.AutoSize = true;
            this.lbEmpAddressCountry.Location = new System.Drawing.Point(371, 235);
            this.lbEmpAddressCountry.Name = "lbEmpAddressCountry";
            this.lbEmpAddressCountry.Size = new System.Drawing.Size(64, 18);
            this.lbEmpAddressCountry.TabIndex = 21;
            this.lbEmpAddressCountry.Text = "Country:";
            // 
            // dtpEmpDateOfBirth
            // 
            this.dtpEmpDateOfBirth.Location = new System.Drawing.Point(142, 152);
            this.dtpEmpDateOfBirth.Name = "dtpEmpDateOfBirth";
            this.dtpEmpDateOfBirth.Size = new System.Drawing.Size(161, 24);
            this.dtpEmpDateOfBirth.TabIndex = 1;
            // 
            // tbxEmpAddressPostCode
            // 
            this.tbxEmpAddressPostCode.Location = new System.Drawing.Point(458, 268);
            this.tbxEmpAddressPostCode.Name = "tbxEmpAddressPostCode";
            this.tbxEmpAddressPostCode.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpAddressPostCode.TabIndex = 24;
            // 
            // btnAddEmpoyee
            // 
            this.btnAddEmpoyee.Location = new System.Drawing.Point(236, 480);
            this.btnAddEmpoyee.Name = "btnAddEmpoyee";
            this.btnAddEmpoyee.Size = new System.Drawing.Size(192, 42);
            this.btnAddEmpoyee.TabIndex = 16;
            this.btnAddEmpoyee.Text = "Add employee";
            this.btnAddEmpoyee.UseVisualStyleBackColor = true;
            // 
            // lbEmpEmployementType
            // 
            this.lbEmpEmployementType.AutoSize = true;
            this.lbEmpEmployementType.Location = new System.Drawing.Point(8, 282);
            this.lbEmpEmployementType.Name = "lbEmpEmployementType";
            this.lbEmpEmployementType.Size = new System.Drawing.Size(113, 18);
            this.lbEmpEmployementType.TabIndex = 14;
            this.lbEmpEmployementType.Text = "Eployment type:";
            // 
            // lbEmpPosition
            // 
            this.lbEmpPosition.AutoSize = true;
            this.lbEmpPosition.Location = new System.Drawing.Point(53, 318);
            this.lbEmpPosition.Name = "lbEmpPosition";
            this.lbEmpPosition.Size = new System.Drawing.Size(66, 18);
            this.lbEmpPosition.TabIndex = 12;
            this.lbEmpPosition.Text = "Position:";
            // 
            // lbEmpDateOfBirth
            // 
            this.lbEmpDateOfBirth.AutoSize = true;
            this.lbEmpDateOfBirth.Location = new System.Drawing.Point(26, 152);
            this.lbEmpDateOfBirth.Name = "lbEmpDateOfBirth";
            this.lbEmpDateOfBirth.Size = new System.Drawing.Size(92, 18);
            this.lbEmpDateOfBirth.TabIndex = 10;
            this.lbEmpDateOfBirth.Text = "Date of birth:";
            // 
            // lbEmpHourlyWages
            // 
            this.lbEmpHourlyWages.AutoSize = true;
            this.lbEmpHourlyWages.Location = new System.Drawing.Point(18, 356);
            this.lbEmpHourlyWages.Name = "lbEmpHourlyWages";
            this.lbEmpHourlyWages.Size = new System.Drawing.Size(102, 18);
            this.lbEmpHourlyWages.TabIndex = 8;
            this.lbEmpHourlyWages.Text = "Hourly wages:";
            // 
            // tbxEmpPhone
            // 
            this.tbxEmpPhone.Location = new System.Drawing.Point(458, 109);
            this.tbxEmpPhone.Name = "tbxEmpPhone";
            this.tbxEmpPhone.Size = new System.Drawing.Size(168, 24);
            this.tbxEmpPhone.TabIndex = 7;
            // 
            // lbEmpPhone
            // 
            this.lbEmpPhone.AutoSize = true;
            this.lbEmpPhone.Location = new System.Drawing.Point(379, 112);
            this.lbEmpPhone.Name = "lbEmpPhone";
            this.lbEmpPhone.Size = new System.Drawing.Size(55, 18);
            this.lbEmpPhone.TabIndex = 6;
            this.lbEmpPhone.Text = "Phone:";
            // 
            // lbEmployeeAddress
            // 
            this.lbEmployeeAddress.AutoSize = true;
            this.lbEmployeeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeAddress.Location = new System.Drawing.Point(432, 30);
            this.lbEmployeeAddress.Name = "lbEmployeeAddress";
            this.lbEmployeeAddress.Size = new System.Drawing.Size(126, 18);
            this.lbEmployeeAddress.TabIndex = 4;
            this.lbEmployeeAddress.Text = "Contact details:";
            // 
            // tbxEmpLname
            // 
            this.tbxEmpLname.Location = new System.Drawing.Point(143, 115);
            this.tbxEmpLname.Name = "tbxEmpLname";
            this.tbxEmpLname.Size = new System.Drawing.Size(160, 24);
            this.tbxEmpLname.TabIndex = 3;
            // 
            // lbEmpLname
            // 
            this.lbEmpLname.AutoSize = true;
            this.lbEmpLname.Location = new System.Drawing.Point(39, 115);
            this.lbEmpLname.Name = "lbEmpLname";
            this.lbEmpLname.Size = new System.Drawing.Size(81, 18);
            this.lbEmpLname.TabIndex = 2;
            this.lbEmpLname.Text = "Last name:";
            // 
            // tbxEmpFname
            // 
            this.tbxEmpFname.Location = new System.Drawing.Point(143, 68);
            this.tbxEmpFname.Name = "tbxEmpFname";
            this.tbxEmpFname.Size = new System.Drawing.Size(160, 24);
            this.tbxEmpFname.TabIndex = 1;
            // 
            // lbEmpFname
            // 
            this.lbEmpFname.AutoSize = true;
            this.lbEmpFname.Location = new System.Drawing.Point(39, 71);
            this.lbEmpFname.Name = "lbEmpFname";
            this.lbEmpFname.Size = new System.Drawing.Size(82, 18);
            this.lbEmpFname.TabIndex = 0;
            this.lbEmpFname.Text = "First name:";
            // 
            // ManageEmpTab
            // 
            this.ManageEmpTab.Controls.Add(this.btnEmpManageAttendance);
            this.ManageEmpTab.Controls.Add(this.gbxSearchEmp);
            this.ManageEmpTab.Controls.Add(this.gbxShowAllEmp);
            this.ManageEmpTab.Controls.Add(this.btnClearSelectedEmp);
            this.ManageEmpTab.Controls.Add(this.btnEditEmp);
            this.ManageEmpTab.Controls.Add(this.btnRemoveEmp);
            this.ManageEmpTab.Controls.Add(this.lbxAllEmployees);
            this.ManageEmpTab.Location = new System.Drawing.Point(4, 27);
            this.ManageEmpTab.Name = "ManageEmpTab";
            this.ManageEmpTab.Size = new System.Drawing.Size(999, 616);
            this.ManageEmpTab.TabIndex = 7;
            this.ManageEmpTab.Text = "Manage employees";
            this.ManageEmpTab.UseVisualStyleBackColor = true;
            // 
            // btnEmpManageAttendance
            // 
            this.btnEmpManageAttendance.Location = new System.Drawing.Point(726, 518);
            this.btnEmpManageAttendance.Name = "btnEmpManageAttendance";
            this.btnEmpManageAttendance.Size = new System.Drawing.Size(195, 49);
            this.btnEmpManageAttendance.TabIndex = 11;
            this.btnEmpManageAttendance.Text = "Manage attendance";
            this.btnEmpManageAttendance.UseVisualStyleBackColor = true;
            // 
            // gbxSearchEmp
            // 
            this.gbxSearchEmp.Controls.Add(this.btnSearchEmp);
            this.gbxSearchEmp.Controls.Add(this.tbxSearchEmp);
            this.gbxSearchEmp.Location = new System.Drawing.Point(515, 18);
            this.gbxSearchEmp.Name = "gbxSearchEmp";
            this.gbxSearchEmp.Size = new System.Drawing.Size(406, 90);
            this.gbxSearchEmp.TabIndex = 10;
            this.gbxSearchEmp.TabStop = false;
            this.gbxSearchEmp.Text = "Search for specific employee";
            // 
            // btnSearchEmp
            // 
            this.btnSearchEmp.Location = new System.Drawing.Point(226, 32);
            this.btnSearchEmp.Name = "btnSearchEmp";
            this.btnSearchEmp.Size = new System.Drawing.Size(165, 29);
            this.btnSearchEmp.TabIndex = 6;
            this.btnSearchEmp.Text = "Search";
            this.btnSearchEmp.UseVisualStyleBackColor = true;
            // 
            // tbxSearchEmp
            // 
            this.tbxSearchEmp.Location = new System.Drawing.Point(10, 35);
            this.tbxSearchEmp.Name = "tbxSearchEmp";
            this.tbxSearchEmp.Size = new System.Drawing.Size(186, 24);
            this.tbxSearchEmp.TabIndex = 7;
            this.tbxSearchEmp.Text = "Search...";
            // 
            // gbxShowAllEmp
            // 
            this.gbxShowAllEmp.Controls.Add(this.cbSelectEmpType);
            this.gbxShowAllEmp.Controls.Add(this.btnShowAllEmp);
            this.gbxShowAllEmp.Location = new System.Drawing.Point(76, 18);
            this.gbxShowAllEmp.Name = "gbxShowAllEmp";
            this.gbxShowAllEmp.Size = new System.Drawing.Size(341, 90);
            this.gbxShowAllEmp.TabIndex = 9;
            this.gbxShowAllEmp.TabStop = false;
            this.gbxShowAllEmp.Text = "Select type of employee to show ";
            // 
            // cbSelectEmpType
            // 
            this.cbSelectEmpType.FormattingEnabled = true;
            this.cbSelectEmpType.Items.AddRange(new object[] {
            "All",
            "Administration",
            "Management",
            "Depot workers",
            "Shop employees"});
            this.cbSelectEmpType.Location = new System.Drawing.Point(20, 35);
            this.cbSelectEmpType.Name = "cbSelectEmpType";
            this.cbSelectEmpType.Size = new System.Drawing.Size(121, 26);
            this.cbSelectEmpType.TabIndex = 8;
            this.cbSelectEmpType.Text = "Select type";
            // 
            // btnShowAllEmp
            // 
            this.btnShowAllEmp.Location = new System.Drawing.Point(170, 35);
            this.btnShowAllEmp.Name = "btnShowAllEmp";
            this.btnShowAllEmp.Size = new System.Drawing.Size(165, 26);
            this.btnShowAllEmp.TabIndex = 5;
            this.btnShowAllEmp.Text = "Show";
            this.btnShowAllEmp.UseVisualStyleBackColor = true;
            // 
            // btnClearSelectedEmp
            // 
            this.btnClearSelectedEmp.Location = new System.Drawing.Point(76, 518);
            this.btnClearSelectedEmp.Name = "btnClearSelectedEmp";
            this.btnClearSelectedEmp.Size = new System.Drawing.Size(195, 49);
            this.btnClearSelectedEmp.TabIndex = 4;
            this.btnClearSelectedEmp.Text = "Unmark selected";
            this.btnClearSelectedEmp.UseVisualStyleBackColor = true;
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.Location = new System.Drawing.Point(298, 518);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(195, 49);
            this.btnEditEmp.TabIndex = 3;
            this.btnEditEmp.Text = "Edit employee";
            this.btnEditEmp.UseVisualStyleBackColor = true;
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.Location = new System.Drawing.Point(515, 518);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(195, 49);
            this.btnRemoveEmp.TabIndex = 2;
            this.btnRemoveEmp.Text = "Remove employee";
            this.btnRemoveEmp.UseVisualStyleBackColor = true;
            // 
            // lbxAllEmployees
            // 
            this.lbxAllEmployees.FormattingEnabled = true;
            this.lbxAllEmployees.HorizontalScrollbar = true;
            this.lbxAllEmployees.ItemHeight = 18;
            this.lbxAllEmployees.Location = new System.Drawing.Point(76, 130);
            this.lbxAllEmployees.Name = "lbxAllEmployees";
            this.lbxAllEmployees.Size = new System.Drawing.Size(845, 364);
            this.lbxAllEmployees.TabIndex = 0;
            // 
            // ManageScheduleTab
            // 
            this.ManageScheduleTab.Controls.Add(this.gbxAutoShiftsAssignPerDay);
            this.ManageScheduleTab.Controls.Add(this.gbxAutoShiftsAssignAllDays);
            this.ManageScheduleTab.Controls.Add(this.gbxAssignShiftsAuto);
            this.ManageScheduleTab.Controls.Add(this.btnAssignShiftsManually);
            this.ManageScheduleTab.Controls.Add(this.btnScheduleClearSelected);
            this.ManageScheduleTab.Controls.Add(this.lbScheduleAllEmp);
            this.ManageScheduleTab.Controls.Add(this.lbxScheduleAllEmp);
            this.ManageScheduleTab.Location = new System.Drawing.Point(4, 27);
            this.ManageScheduleTab.Name = "ManageScheduleTab";
            this.ManageScheduleTab.Size = new System.Drawing.Size(999, 616);
            this.ManageScheduleTab.TabIndex = 2;
            this.ManageScheduleTab.Text = "Manage schedule";
            this.ManageScheduleTab.UseVisualStyleBackColor = true;
            // 
            // gbxAutoShiftsAssignPerDay
            // 
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.btnSubmitAutoShiftsAssignPerDay);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.tbxSun);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.lbSun);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.tbxSat);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.lbSat);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.tbxFri);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.lbFri);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.tbxThurs);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.lbThurs);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.tbxWed);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.lbWed);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.tbxTues);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.lbTues);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.tbxMon);
            this.gbxAutoShiftsAssignPerDay.Controls.Add(this.lbMon);
            this.gbxAutoShiftsAssignPerDay.Location = new System.Drawing.Point(573, 138);
            this.gbxAutoShiftsAssignPerDay.Name = "gbxAutoShiftsAssignPerDay";
            this.gbxAutoShiftsAssignPerDay.Size = new System.Drawing.Size(402, 365);
            this.gbxAutoShiftsAssignPerDay.TabIndex = 7;
            this.gbxAutoShiftsAssignPerDay.TabStop = false;
            this.gbxAutoShiftsAssignPerDay.Text = "Choose number of workers per day";
            // 
            // btnSubmitAutoShiftsAssignPerDay
            // 
            this.btnSubmitAutoShiftsAssignPerDay.Location = new System.Drawing.Point(174, 300);
            this.btnSubmitAutoShiftsAssignPerDay.Name = "btnSubmitAutoShiftsAssignPerDay";
            this.btnSubmitAutoShiftsAssignPerDay.Size = new System.Drawing.Size(137, 35);
            this.btnSubmitAutoShiftsAssignPerDay.TabIndex = 5;
            this.btnSubmitAutoShiftsAssignPerDay.Text = "Submit";
            this.btnSubmitAutoShiftsAssignPerDay.UseVisualStyleBackColor = true;
            // 
            // tbxSun
            // 
            this.tbxSun.Location = new System.Drawing.Point(174, 255);
            this.tbxSun.Name = "tbxSun";
            this.tbxSun.Size = new System.Drawing.Size(137, 24);
            this.tbxSun.TabIndex = 13;
            // 
            // lbSun
            // 
            this.lbSun.AutoSize = true;
            this.lbSun.Location = new System.Drawing.Point(97, 258);
            this.lbSun.Name = "lbSun";
            this.lbSun.Size = new System.Drawing.Size(61, 18);
            this.lbSun.TabIndex = 12;
            this.lbSun.Text = "Sunday:";
            // 
            // tbxSat
            // 
            this.tbxSat.Location = new System.Drawing.Point(174, 222);
            this.tbxSat.Name = "tbxSat";
            this.tbxSat.Size = new System.Drawing.Size(137, 24);
            this.tbxSat.TabIndex = 11;
            // 
            // lbSat
            // 
            this.lbSat.AutoSize = true;
            this.lbSat.Location = new System.Drawing.Point(90, 225);
            this.lbSat.Name = "lbSat";
            this.lbSat.Size = new System.Drawing.Size(70, 18);
            this.lbSat.TabIndex = 10;
            this.lbSat.Text = "Saturday:";
            // 
            // tbxFri
            // 
            this.tbxFri.Location = new System.Drawing.Point(174, 184);
            this.tbxFri.Name = "tbxFri";
            this.tbxFri.Size = new System.Drawing.Size(137, 24);
            this.tbxFri.TabIndex = 9;
            // 
            // lbFri
            // 
            this.lbFri.AutoSize = true;
            this.lbFri.Location = new System.Drawing.Point(108, 187);
            this.lbFri.Name = "lbFri";
            this.lbFri.Size = new System.Drawing.Size(52, 18);
            this.lbFri.TabIndex = 8;
            this.lbFri.Text = "Friday:";
            // 
            // tbxThurs
            // 
            this.tbxThurs.Location = new System.Drawing.Point(174, 146);
            this.tbxThurs.Name = "tbxThurs";
            this.tbxThurs.Size = new System.Drawing.Size(137, 24);
            this.tbxThurs.TabIndex = 7;
            // 
            // lbThurs
            // 
            this.lbThurs.AutoSize = true;
            this.lbThurs.Location = new System.Drawing.Point(87, 146);
            this.lbThurs.Name = "lbThurs";
            this.lbThurs.Size = new System.Drawing.Size(73, 18);
            this.lbThurs.TabIndex = 6;
            this.lbThurs.Text = "Thursday:";
            // 
            // tbxWed
            // 
            this.tbxWed.Location = new System.Drawing.Point(174, 109);
            this.tbxWed.Name = "tbxWed";
            this.tbxWed.Size = new System.Drawing.Size(137, 24);
            this.tbxWed.TabIndex = 5;
            // 
            // lbWed
            // 
            this.lbWed.AutoSize = true;
            this.lbWed.Location = new System.Drawing.Point(72, 114);
            this.lbWed.Name = "lbWed";
            this.lbWed.Size = new System.Drawing.Size(90, 18);
            this.lbWed.TabIndex = 4;
            this.lbWed.Text = "Wednesday:";
            // 
            // tbxTues
            // 
            this.tbxTues.Location = new System.Drawing.Point(174, 70);
            this.tbxTues.Name = "tbxTues";
            this.tbxTues.Size = new System.Drawing.Size(137, 24);
            this.tbxTues.TabIndex = 3;
            // 
            // lbTues
            // 
            this.lbTues.AutoSize = true;
            this.lbTues.Location = new System.Drawing.Point(92, 73);
            this.lbTues.Name = "lbTues";
            this.lbTues.Size = new System.Drawing.Size(68, 18);
            this.lbTues.TabIndex = 2;
            this.lbTues.Text = "Tuesday:";
            // 
            // tbxMon
            // 
            this.tbxMon.Location = new System.Drawing.Point(174, 32);
            this.tbxMon.Name = "tbxMon";
            this.tbxMon.Size = new System.Drawing.Size(137, 24);
            this.tbxMon.TabIndex = 1;
            // 
            // lbMon
            // 
            this.lbMon.AutoSize = true;
            this.lbMon.Location = new System.Drawing.Point(97, 37);
            this.lbMon.Name = "lbMon";
            this.lbMon.Size = new System.Drawing.Size(65, 18);
            this.lbMon.TabIndex = 0;
            this.lbMon.Text = "Monday:";
            // 
            // gbxAutoShiftsAssignAllDays
            // 
            this.gbxAutoShiftsAssignAllDays.Controls.Add(this.btnSubmitAutoShiftsAssignAllDays);
            this.gbxAutoShiftsAssignAllDays.Controls.Add(this.lbNrWorkers);
            this.gbxAutoShiftsAssignAllDays.Controls.Add(this.tbxNrWorkers);
            this.gbxAutoShiftsAssignAllDays.Location = new System.Drawing.Point(62, 457);
            this.gbxAutoShiftsAssignAllDays.Name = "gbxAutoShiftsAssignAllDays";
            this.gbxAutoShiftsAssignAllDays.Size = new System.Drawing.Size(402, 139);
            this.gbxAutoShiftsAssignAllDays.TabIndex = 6;
            this.gbxAutoShiftsAssignAllDays.TabStop = false;
            this.gbxAutoShiftsAssignAllDays.Text = "Choose number of workers for the whole week";
            // 
            // btnSubmitAutoShiftsAssignAllDays
            // 
            this.btnSubmitAutoShiftsAssignAllDays.Location = new System.Drawing.Point(211, 86);
            this.btnSubmitAutoShiftsAssignAllDays.Name = "btnSubmitAutoShiftsAssignAllDays";
            this.btnSubmitAutoShiftsAssignAllDays.Size = new System.Drawing.Size(120, 35);
            this.btnSubmitAutoShiftsAssignAllDays.TabIndex = 4;
            this.btnSubmitAutoShiftsAssignAllDays.Text = "Submit";
            this.btnSubmitAutoShiftsAssignAllDays.UseVisualStyleBackColor = true;
            // 
            // lbNrWorkers
            // 
            this.lbNrWorkers.AutoSize = true;
            this.lbNrWorkers.Location = new System.Drawing.Point(63, 43);
            this.lbNrWorkers.Name = "lbNrWorkers";
            this.lbNrWorkers.Size = new System.Drawing.Size(137, 18);
            this.lbNrWorkers.TabIndex = 2;
            this.lbNrWorkers.Text = "number of workers:";
            // 
            // tbxNrWorkers
            // 
            this.tbxNrWorkers.Location = new System.Drawing.Point(211, 43);
            this.tbxNrWorkers.Name = "tbxNrWorkers";
            this.tbxNrWorkers.Size = new System.Drawing.Size(120, 24);
            this.tbxNrWorkers.TabIndex = 3;
            // 
            // gbxAssignShiftsAuto
            // 
            this.gbxAssignShiftsAuto.Controls.Add(this.btnChooseAssignTypeAuto);
            this.gbxAssignShiftsAuto.Controls.Add(this.cbAssignTypeAuto);
            this.gbxAssignShiftsAuto.Location = new System.Drawing.Point(573, 31);
            this.gbxAssignShiftsAuto.Name = "gbxAssignShiftsAuto";
            this.gbxAssignShiftsAuto.Size = new System.Drawing.Size(402, 87);
            this.gbxAssignShiftsAuto.TabIndex = 5;
            this.gbxAssignShiftsAuto.TabStop = false;
            this.gbxAssignShiftsAuto.Text = "Assign work shifts automatically";
            // 
            // btnChooseAssignTypeAuto
            // 
            this.btnChooseAssignTypeAuto.Location = new System.Drawing.Point(260, 31);
            this.btnChooseAssignTypeAuto.Name = "btnChooseAssignTypeAuto";
            this.btnChooseAssignTypeAuto.Size = new System.Drawing.Size(110, 30);
            this.btnChooseAssignTypeAuto.TabIndex = 1;
            this.btnChooseAssignTypeAuto.Text = "Choose";
            this.btnChooseAssignTypeAuto.UseVisualStyleBackColor = true;
            // 
            // cbAssignTypeAuto
            // 
            this.cbAssignTypeAuto.FormattingEnabled = true;
            this.cbAssignTypeAuto.Items.AddRange(new object[] {
            "Per day",
            "For all days"});
            this.cbAssignTypeAuto.Location = new System.Drawing.Point(47, 35);
            this.cbAssignTypeAuto.Name = "cbAssignTypeAuto";
            this.cbAssignTypeAuto.Size = new System.Drawing.Size(182, 26);
            this.cbAssignTypeAuto.TabIndex = 0;
            this.cbAssignTypeAuto.Text = "Choose how to assign";
            // 
            // btnAssignShiftsManually
            // 
            this.btnAssignShiftsManually.Location = new System.Drawing.Point(306, 393);
            this.btnAssignShiftsManually.Name = "btnAssignShiftsManually";
            this.btnAssignShiftsManually.Size = new System.Drawing.Size(230, 39);
            this.btnAssignShiftsManually.TabIndex = 4;
            this.btnAssignShiftsManually.Text = "Assign work shift manually";
            this.btnAssignShiftsManually.UseVisualStyleBackColor = true;
            // 
            // btnScheduleClearSelected
            // 
            this.btnScheduleClearSelected.Location = new System.Drawing.Point(18, 393);
            this.btnScheduleClearSelected.Name = "btnScheduleClearSelected";
            this.btnScheduleClearSelected.Size = new System.Drawing.Size(230, 39);
            this.btnScheduleClearSelected.TabIndex = 3;
            this.btnScheduleClearSelected.Text = "Unmark selected";
            this.btnScheduleClearSelected.UseVisualStyleBackColor = true;
            // 
            // lbScheduleAllEmp
            // 
            this.lbScheduleAllEmp.AutoSize = true;
            this.lbScheduleAllEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbScheduleAllEmp.Location = new System.Drawing.Point(140, 31);
            this.lbScheduleAllEmp.Name = "lbScheduleAllEmp";
            this.lbScheduleAllEmp.Size = new System.Drawing.Size(294, 18);
            this.lbScheduleAllEmp.TabIndex = 2;
            this.lbScheduleAllEmp.Text = "Select employee to assign work shifts";
            // 
            // lbxScheduleAllEmp
            // 
            this.lbxScheduleAllEmp.FormattingEnabled = true;
            this.lbxScheduleAllEmp.HorizontalScrollbar = true;
            this.lbxScheduleAllEmp.ItemHeight = 18;
            this.lbxScheduleAllEmp.Location = new System.Drawing.Point(18, 62);
            this.lbxScheduleAllEmp.Name = "lbxScheduleAllEmp";
            this.lbxScheduleAllEmp.Size = new System.Drawing.Size(518, 310);
            this.lbxScheduleAllEmp.TabIndex = 1;
            // 
            // HolidayRequestsTab
            // 
            this.HolidayRequestsTab.Controls.Add(this.lbHolidayRequestsInfo);
            this.HolidayRequestsTab.Controls.Add(this.btnHolidayRequestsClearSelected);
            this.HolidayRequestsTab.Controls.Add(this.btnHolidayRequestsDecline);
            this.HolidayRequestsTab.Controls.Add(this.btnHolidayRequestsAccept);
            this.HolidayRequestsTab.Controls.Add(this.lbxAllHolidayRequests);
            this.HolidayRequestsTab.Location = new System.Drawing.Point(4, 27);
            this.HolidayRequestsTab.Name = "HolidayRequestsTab";
            this.HolidayRequestsTab.Size = new System.Drawing.Size(999, 616);
            this.HolidayRequestsTab.TabIndex = 3;
            this.HolidayRequestsTab.Text = "Holiday requests";
            this.HolidayRequestsTab.UseVisualStyleBackColor = true;
            // 
            // lbHolidayRequestsInfo
            // 
            this.lbHolidayRequestsInfo.AutoSize = true;
            this.lbHolidayRequestsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHolidayRequestsInfo.Location = new System.Drawing.Point(403, 47);
            this.lbHolidayRequestsInfo.Name = "lbHolidayRequestsInfo";
            this.lbHolidayRequestsInfo.Size = new System.Drawing.Size(160, 18);
            this.lbHolidayRequestsInfo.TabIndex = 4;
            this.lbHolidayRequestsInfo.Text = "New holiday request";
            // 
            // btnHolidayRequestsClearSelected
            // 
            this.btnHolidayRequestsClearSelected.Location = new System.Drawing.Point(225, 447);
            this.btnHolidayRequestsClearSelected.Name = "btnHolidayRequestsClearSelected";
            this.btnHolidayRequestsClearSelected.Size = new System.Drawing.Size(145, 39);
            this.btnHolidayRequestsClearSelected.TabIndex = 3;
            this.btnHolidayRequestsClearSelected.Text = "Unmark selected";
            this.btnHolidayRequestsClearSelected.UseVisualStyleBackColor = true;
            // 
            // btnHolidayRequestsDecline
            // 
            this.btnHolidayRequestsDecline.Location = new System.Drawing.Point(580, 447);
            this.btnHolidayRequestsDecline.Name = "btnHolidayRequestsDecline";
            this.btnHolidayRequestsDecline.Size = new System.Drawing.Size(145, 39);
            this.btnHolidayRequestsDecline.TabIndex = 2;
            this.btnHolidayRequestsDecline.Text = "Decline";
            this.btnHolidayRequestsDecline.UseVisualStyleBackColor = true;
            // 
            // btnHolidayRequestsAccept
            // 
            this.btnHolidayRequestsAccept.Location = new System.Drawing.Point(399, 447);
            this.btnHolidayRequestsAccept.Name = "btnHolidayRequestsAccept";
            this.btnHolidayRequestsAccept.Size = new System.Drawing.Size(145, 39);
            this.btnHolidayRequestsAccept.TabIndex = 1;
            this.btnHolidayRequestsAccept.Text = "Accept";
            this.btnHolidayRequestsAccept.UseVisualStyleBackColor = true;
            // 
            // lbxAllHolidayRequests
            // 
            this.lbxAllHolidayRequests.FormattingEnabled = true;
            this.lbxAllHolidayRequests.HorizontalScrollbar = true;
            this.lbxAllHolidayRequests.ItemHeight = 18;
            this.lbxAllHolidayRequests.Location = new System.Drawing.Point(225, 90);
            this.lbxAllHolidayRequests.Name = "lbxAllHolidayRequests";
            this.lbxAllHolidayRequests.Size = new System.Drawing.Size(500, 328);
            this.lbxAllHolidayRequests.TabIndex = 0;
            // 
            // ManageStocksTab
            // 
            this.ManageStocksTab.Controls.Add(this.btnShowAllStocks);
            this.ManageStocksTab.Controls.Add(this.gbxSearchStock);
            this.ManageStocksTab.Controls.Add(this.btnStocksClearSelected);
            this.ManageStocksTab.Controls.Add(this.btnEditStock);
            this.ManageStocksTab.Controls.Add(this.btnRemoveStock);
            this.ManageStocksTab.Controls.Add(this.lbAllStocks);
            this.ManageStocksTab.Controls.Add(this.gbxAddStock);
            this.ManageStocksTab.Location = new System.Drawing.Point(4, 27);
            this.ManageStocksTab.Name = "ManageStocksTab";
            this.ManageStocksTab.Size = new System.Drawing.Size(999, 616);
            this.ManageStocksTab.TabIndex = 4;
            this.ManageStocksTab.Text = "Manages stocks";
            this.ManageStocksTab.UseVisualStyleBackColor = true;
            // 
            // btnShowAllStocks
            // 
            this.btnShowAllStocks.Location = new System.Drawing.Point(349, 82);
            this.btnShowAllStocks.Name = "btnShowAllStocks";
            this.btnShowAllStocks.Size = new System.Drawing.Size(195, 46);
            this.btnShowAllStocks.TabIndex = 17;
            this.btnShowAllStocks.Text = "Show all stocks";
            this.btnShowAllStocks.UseVisualStyleBackColor = true;
            // 
            // gbxSearchStock
            // 
            this.gbxSearchStock.Controls.Add(this.btnSearchStock);
            this.gbxSearchStock.Controls.Add(this.tbxSearchStock);
            this.gbxSearchStock.Location = new System.Drawing.Point(563, 59);
            this.gbxSearchStock.Name = "gbxSearchStock";
            this.gbxSearchStock.Size = new System.Drawing.Size(406, 90);
            this.gbxSearchStock.TabIndex = 16;
            this.gbxSearchStock.TabStop = false;
            this.gbxSearchStock.Text = "Search for specific stock";
            // 
            // btnSearchStock
            // 
            this.btnSearchStock.Location = new System.Drawing.Point(226, 32);
            this.btnSearchStock.Name = "btnSearchStock";
            this.btnSearchStock.Size = new System.Drawing.Size(165, 29);
            this.btnSearchStock.TabIndex = 6;
            this.btnSearchStock.Text = "Search";
            this.btnSearchStock.UseVisualStyleBackColor = true;
            // 
            // tbxSearchStock
            // 
            this.tbxSearchStock.Location = new System.Drawing.Point(10, 35);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(186, 24);
            this.tbxSearchStock.TabIndex = 7;
            this.tbxSearchStock.Text = "Search...";
            // 
            // btnStocksClearSelected
            // 
            this.btnStocksClearSelected.Location = new System.Drawing.Point(349, 522);
            this.btnStocksClearSelected.Name = "btnStocksClearSelected";
            this.btnStocksClearSelected.Size = new System.Drawing.Size(195, 49);
            this.btnStocksClearSelected.TabIndex = 14;
            this.btnStocksClearSelected.Text = "Unmark selected";
            this.btnStocksClearSelected.UseVisualStyleBackColor = true;
            // 
            // btnEditStock
            // 
            this.btnEditStock.Location = new System.Drawing.Point(564, 522);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(195, 49);
            this.btnEditStock.TabIndex = 13;
            this.btnEditStock.Text = "Edit stock";
            this.btnEditStock.UseVisualStyleBackColor = true;
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.Location = new System.Drawing.Point(774, 522);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(195, 49);
            this.btnRemoveStock.TabIndex = 12;
            this.btnRemoveStock.Text = "Remove stock";
            this.btnRemoveStock.UseVisualStyleBackColor = true;
            // 
            // lbAllStocks
            // 
            this.lbAllStocks.FormattingEnabled = true;
            this.lbAllStocks.HorizontalScrollbar = true;
            this.lbAllStocks.ItemHeight = 18;
            this.lbAllStocks.Location = new System.Drawing.Point(349, 166);
            this.lbAllStocks.Name = "lbAllStocks";
            this.lbAllStocks.Size = new System.Drawing.Size(620, 328);
            this.lbAllStocks.TabIndex = 11;
            // 
            // gbxAddStock
            // 
            this.gbxAddStock.Controls.Add(this.tbxStockDepth);
            this.gbxAddStock.Controls.Add(this.lbStockDepth);
            this.gbxAddStock.Controls.Add(this.tbxStockHeight);
            this.gbxAddStock.Controls.Add(this.lbStockHeight);
            this.gbxAddStock.Controls.Add(this.tbxStockWidth);
            this.gbxAddStock.Controls.Add(this.lbStockWidth);
            this.gbxAddStock.Controls.Add(this.btnAddStock);
            this.gbxAddStock.Controls.Add(this.tbxStockQuantity);
            this.gbxAddStock.Controls.Add(this.lbStockQuantity);
            this.gbxAddStock.Controls.Add(this.tbxStockShortDescription);
            this.gbxAddStock.Controls.Add(this.lbStockShortDescription);
            this.gbxAddStock.Controls.Add(this.lbStockDimensions);
            this.gbxAddStock.Controls.Add(this.tbxStockPrice);
            this.gbxAddStock.Controls.Add(this.lbStockPrice);
            this.gbxAddStock.Controls.Add(this.tbxStockModel);
            this.gbxAddStock.Controls.Add(this.lbStockModel);
            this.gbxAddStock.Controls.Add(this.tbxStockBrand);
            this.gbxAddStock.Controls.Add(this.lbStockBrand);
            this.gbxAddStock.Location = new System.Drawing.Point(20, 20);
            this.gbxAddStock.Name = "gbxAddStock";
            this.gbxAddStock.Size = new System.Drawing.Size(290, 576);
            this.gbxAddStock.TabIndex = 0;
            this.gbxAddStock.TabStop = false;
            this.gbxAddStock.Text = "Add stock";
            // 
            // tbxStockDepth
            // 
            this.tbxStockDepth.Location = new System.Drawing.Point(110, 277);
            this.tbxStockDepth.Name = "tbxStockDepth";
            this.tbxStockDepth.Size = new System.Drawing.Size(137, 24);
            this.tbxStockDepth.TabIndex = 20;
            // 
            // lbStockDepth
            // 
            this.lbStockDepth.AutoSize = true;
            this.lbStockDepth.Location = new System.Drawing.Point(37, 277);
            this.lbStockDepth.Name = "lbStockDepth";
            this.lbStockDepth.Size = new System.Drawing.Size(51, 18);
            this.lbStockDepth.TabIndex = 19;
            this.lbStockDepth.Text = "Depth:";
            // 
            // tbxStockHeight
            // 
            this.tbxStockHeight.Location = new System.Drawing.Point(110, 233);
            this.tbxStockHeight.Name = "tbxStockHeight";
            this.tbxStockHeight.Size = new System.Drawing.Size(137, 24);
            this.tbxStockHeight.TabIndex = 18;
            // 
            // lbStockHeight
            // 
            this.lbStockHeight.AutoSize = true;
            this.lbStockHeight.Location = new System.Drawing.Point(29, 236);
            this.lbStockHeight.Name = "lbStockHeight";
            this.lbStockHeight.Size = new System.Drawing.Size(54, 18);
            this.lbStockHeight.TabIndex = 17;
            this.lbStockHeight.Text = "Height:";
            // 
            // tbxStockWidth
            // 
            this.tbxStockWidth.Location = new System.Drawing.Point(110, 192);
            this.tbxStockWidth.Name = "tbxStockWidth";
            this.tbxStockWidth.Size = new System.Drawing.Size(137, 24);
            this.tbxStockWidth.TabIndex = 16;
            // 
            // lbStockWidth
            // 
            this.lbStockWidth.AutoSize = true;
            this.lbStockWidth.Location = new System.Drawing.Point(29, 195);
            this.lbStockWidth.Name = "lbStockWidth";
            this.lbStockWidth.Size = new System.Drawing.Size(50, 18);
            this.lbStockWidth.TabIndex = 15;
            this.lbStockWidth.Text = "Width:";
            // 
            // btnAddStock
            // 
            this.btnAddStock.Location = new System.Drawing.Point(17, 512);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(230, 43);
            this.btnAddStock.TabIndex = 14;
            this.btnAddStock.Text = "Add new stock";
            this.btnAddStock.UseVisualStyleBackColor = true;
            // 
            // tbxStockQuantity
            // 
            this.tbxStockQuantity.Location = new System.Drawing.Point(110, 328);
            this.tbxStockQuantity.Name = "tbxStockQuantity";
            this.tbxStockQuantity.Size = new System.Drawing.Size(137, 24);
            this.tbxStockQuantity.TabIndex = 13;
            // 
            // lbStockQuantity
            // 
            this.lbStockQuantity.AutoSize = true;
            this.lbStockQuantity.Location = new System.Drawing.Point(14, 328);
            this.lbStockQuantity.Name = "lbStockQuantity";
            this.lbStockQuantity.Size = new System.Drawing.Size(66, 18);
            this.lbStockQuantity.TabIndex = 12;
            this.lbStockQuantity.Text = "Quantity:";
            // 
            // tbxStockShortDescription
            // 
            this.tbxStockShortDescription.Location = new System.Drawing.Point(17, 407);
            this.tbxStockShortDescription.Multiline = true;
            this.tbxStockShortDescription.Name = "tbxStockShortDescription";
            this.tbxStockShortDescription.Size = new System.Drawing.Size(230, 84);
            this.tbxStockShortDescription.TabIndex = 9;
            // 
            // lbStockShortDescription
            // 
            this.lbStockShortDescription.AutoSize = true;
            this.lbStockShortDescription.Location = new System.Drawing.Point(74, 373);
            this.lbStockShortDescription.Name = "lbStockShortDescription";
            this.lbStockShortDescription.Size = new System.Drawing.Size(124, 18);
            this.lbStockShortDescription.TabIndex = 8;
            this.lbStockShortDescription.Text = "Short description:";
            // 
            // lbStockDimensions
            // 
            this.lbStockDimensions.AutoSize = true;
            this.lbStockDimensions.Location = new System.Drawing.Point(86, 156);
            this.lbStockDimensions.Name = "lbStockDimensions";
            this.lbStockDimensions.Size = new System.Drawing.Size(91, 18);
            this.lbStockDimensions.TabIndex = 6;
            this.lbStockDimensions.Text = "Dimensions:";
            // 
            // tbxStockPrice
            // 
            this.tbxStockPrice.Location = new System.Drawing.Point(110, 112);
            this.tbxStockPrice.Name = "tbxStockPrice";
            this.tbxStockPrice.Size = new System.Drawing.Size(137, 24);
            this.tbxStockPrice.TabIndex = 5;
            // 
            // lbStockPrice
            // 
            this.lbStockPrice.AutoSize = true;
            this.lbStockPrice.Location = new System.Drawing.Point(36, 112);
            this.lbStockPrice.Name = "lbStockPrice";
            this.lbStockPrice.Size = new System.Drawing.Size(46, 18);
            this.lbStockPrice.TabIndex = 4;
            this.lbStockPrice.Text = "Price:";
            // 
            // tbxStockModel
            // 
            this.tbxStockModel.Location = new System.Drawing.Point(110, 68);
            this.tbxStockModel.Name = "tbxStockModel";
            this.tbxStockModel.Size = new System.Drawing.Size(137, 24);
            this.tbxStockModel.TabIndex = 3;
            // 
            // lbStockModel
            // 
            this.lbStockModel.AutoSize = true;
            this.lbStockModel.Location = new System.Drawing.Point(29, 71);
            this.lbStockModel.Name = "lbStockModel";
            this.lbStockModel.Size = new System.Drawing.Size(53, 18);
            this.lbStockModel.TabIndex = 2;
            this.lbStockModel.Text = "Model:";
            // 
            // tbxStockBrand
            // 
            this.tbxStockBrand.Location = new System.Drawing.Point(110, 27);
            this.tbxStockBrand.Name = "tbxStockBrand";
            this.tbxStockBrand.Size = new System.Drawing.Size(137, 24);
            this.tbxStockBrand.TabIndex = 1;
            // 
            // lbStockBrand
            // 
            this.lbStockBrand.AutoSize = true;
            this.lbStockBrand.Location = new System.Drawing.Point(29, 30);
            this.lbStockBrand.Name = "lbStockBrand";
            this.lbStockBrand.Size = new System.Drawing.Size(51, 18);
            this.lbStockBrand.TabIndex = 0;
            this.lbStockBrand.Text = "Brand:";
            // 
            // ManageShelfRestockRequestsTab
            // 
            this.ManageShelfRestockRequestsTab.Controls.Add(this.lbHistoryShelfRestockRequests);
            this.ManageShelfRestockRequestsTab.Controls.Add(this.lbxHistoryShelfRestockRequests);
            this.ManageShelfRestockRequestsTab.Controls.Add(this.lbShelfRestockRequestsInfo);
            this.ManageShelfRestockRequestsTab.Controls.Add(this.btnSehflRestockRequestsClearSelected);
            this.ManageShelfRestockRequestsTab.Controls.Add(this.btnShelftRestockRequestsMarkAsDone);
            this.ManageShelfRestockRequestsTab.Controls.Add(this.btnShelftRestockRequestsDecline);
            this.ManageShelfRestockRequestsTab.Controls.Add(this.lbxAllShelfRestockRequests);
            this.ManageShelfRestockRequestsTab.Location = new System.Drawing.Point(4, 27);
            this.ManageShelfRestockRequestsTab.Name = "ManageShelfRestockRequestsTab";
            this.ManageShelfRestockRequestsTab.Size = new System.Drawing.Size(999, 616);
            this.ManageShelfRestockRequestsTab.TabIndex = 6;
            this.ManageShelfRestockRequestsTab.Text = "Manage shelf restock requests";
            this.ManageShelfRestockRequestsTab.UseVisualStyleBackColor = true;
            // 
            // lbHistoryShelfRestockRequests
            // 
            this.lbHistoryShelfRestockRequests.AutoSize = true;
            this.lbHistoryShelfRestockRequests.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHistoryShelfRestockRequests.Location = new System.Drawing.Point(288, 411);
            this.lbHistoryShelfRestockRequests.Name = "lbHistoryShelfRestockRequests";
            this.lbHistoryShelfRestockRequests.Size = new System.Drawing.Size(246, 18);
            this.lbHistoryShelfRestockRequests.TabIndex = 11;
            this.lbHistoryShelfRestockRequests.Text = "History of shelf restock request";
            // 
            // lbxHistoryShelfRestockRequests
            // 
            this.lbxHistoryShelfRestockRequests.FormattingEnabled = true;
            this.lbxHistoryShelfRestockRequests.ItemHeight = 18;
            this.lbxHistoryShelfRestockRequests.Location = new System.Drawing.Point(26, 441);
            this.lbxHistoryShelfRestockRequests.Name = "lbxHistoryShelfRestockRequests";
            this.lbxHistoryShelfRestockRequests.Size = new System.Drawing.Size(756, 148);
            this.lbxHistoryShelfRestockRequests.TabIndex = 10;
            // 
            // lbShelfRestockRequestsInfo
            // 
            this.lbShelfRestockRequestsInfo.AutoSize = true;
            this.lbShelfRestockRequestsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbShelfRestockRequestsInfo.Location = new System.Drawing.Point(288, 26);
            this.lbShelfRestockRequestsInfo.Name = "lbShelfRestockRequestsInfo";
            this.lbShelfRestockRequestsInfo.Size = new System.Drawing.Size(205, 18);
            this.lbShelfRestockRequestsInfo.TabIndex = 9;
            this.lbShelfRestockRequestsInfo.Text = "New shelf restock request";
            // 
            // btnSehflRestockRequestsClearSelected
            // 
            this.btnSehflRestockRequestsClearSelected.Location = new System.Drawing.Point(805, 351);
            this.btnSehflRestockRequestsClearSelected.Name = "btnSehflRestockRequestsClearSelected";
            this.btnSehflRestockRequestsClearSelected.Size = new System.Drawing.Size(145, 39);
            this.btnSehflRestockRequestsClearSelected.TabIndex = 8;
            this.btnSehflRestockRequestsClearSelected.Text = "Unmark selected";
            this.btnSehflRestockRequestsClearSelected.UseVisualStyleBackColor = true;
            // 
            // btnShelftRestockRequestsMarkAsDone
            // 
            this.btnShelftRestockRequestsMarkAsDone.Location = new System.Drawing.Point(805, 62);
            this.btnShelftRestockRequestsMarkAsDone.Name = "btnShelftRestockRequestsMarkAsDone";
            this.btnShelftRestockRequestsMarkAsDone.Size = new System.Drawing.Size(145, 39);
            this.btnShelftRestockRequestsMarkAsDone.TabIndex = 7;
            this.btnShelftRestockRequestsMarkAsDone.Text = "Mark as \'Done\'";
            this.btnShelftRestockRequestsMarkAsDone.UseVisualStyleBackColor = true;
            // 
            // btnShelftRestockRequestsDecline
            // 
            this.btnShelftRestockRequestsDecline.Location = new System.Drawing.Point(805, 201);
            this.btnShelftRestockRequestsDecline.Name = "btnShelftRestockRequestsDecline";
            this.btnShelftRestockRequestsDecline.Size = new System.Drawing.Size(145, 39);
            this.btnShelftRestockRequestsDecline.TabIndex = 6;
            this.btnShelftRestockRequestsDecline.Text = "Decline";
            this.btnShelftRestockRequestsDecline.UseVisualStyleBackColor = true;
            // 
            // lbxAllShelfRestockRequests
            // 
            this.lbxAllShelfRestockRequests.FormattingEnabled = true;
            this.lbxAllShelfRestockRequests.HorizontalScrollbar = true;
            this.lbxAllShelfRestockRequests.ItemHeight = 18;
            this.lbxAllShelfRestockRequests.Location = new System.Drawing.Point(26, 62);
            this.lbxAllShelfRestockRequests.Name = "lbxAllShelfRestockRequests";
            this.lbxAllShelfRestockRequests.Size = new System.Drawing.Size(756, 328);
            this.lbxAllShelfRestockRequests.TabIndex = 5;
            // 
            // ManageDepartmentsTab
            // 
            this.ManageDepartmentsTab.Controls.Add(this.gbxEditDepartment);
            this.ManageDepartmentsTab.Controls.Add(this.btnRemoveDepartment);
            this.ManageDepartmentsTab.Controls.Add(this.btnEditDepartment);
            this.ManageDepartmentsTab.Controls.Add(this.btnDepartmentsClearSelected);
            this.ManageDepartmentsTab.Controls.Add(this.lbDepartmentsInfo);
            this.ManageDepartmentsTab.Controls.Add(this.lbxAllDepartments);
            this.ManageDepartmentsTab.Controls.Add(this.gbxCreateDeparmtent);
            this.ManageDepartmentsTab.Location = new System.Drawing.Point(4, 27);
            this.ManageDepartmentsTab.Name = "ManageDepartmentsTab";
            this.ManageDepartmentsTab.Size = new System.Drawing.Size(999, 616);
            this.ManageDepartmentsTab.TabIndex = 8;
            this.ManageDepartmentsTab.Text = "Manage departments";
            this.ManageDepartmentsTab.UseVisualStyleBackColor = true;
            // 
            // gbxEditDepartment
            // 
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentEditInfo);
            this.gbxEditDepartment.Controls.Add(this.btnApplyChangesDepartment);
            this.gbxEditDepartment.Controls.Add(this.cbDepartmentManagerEdit);
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentManagerEdit);
            this.gbxEditDepartment.Controls.Add(this.tbxDepartmentNameEdit);
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentNameEdit);
            this.gbxEditDepartment.Location = new System.Drawing.Point(547, 315);
            this.gbxEditDepartment.Name = "gbxEditDepartment";
            this.gbxEditDepartment.Size = new System.Drawing.Size(406, 268);
            this.gbxEditDepartment.TabIndex = 5;
            this.gbxEditDepartment.TabStop = false;
            this.gbxEditDepartment.Text = "Edit department";
            // 
            // lbDepartmentEditInfo
            // 
            this.lbDepartmentEditInfo.AutoSize = true;
            this.lbDepartmentEditInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartmentEditInfo.Location = new System.Drawing.Point(117, 39);
            this.lbDepartmentEditInfo.Name = "lbDepartmentEditInfo";
            this.lbDepartmentEditInfo.Size = new System.Drawing.Size(178, 18);
            this.lbDepartmentEditInfo.TabIndex = 5;
            this.lbDepartmentEditInfo.Text = "Department with Id:(id)";
            // 
            // btnApplyChangesDepartment
            // 
            this.btnApplyChangesDepartment.Location = new System.Drawing.Point(192, 185);
            this.btnApplyChangesDepartment.Name = "btnApplyChangesDepartment";
            this.btnApplyChangesDepartment.Size = new System.Drawing.Size(182, 39);
            this.btnApplyChangesDepartment.TabIndex = 4;
            this.btnApplyChangesDepartment.Text = "Apply changes";
            this.btnApplyChangesDepartment.UseVisualStyleBackColor = true;
            // 
            // cbDepartmentManagerEdit
            // 
            this.cbDepartmentManagerEdit.FormattingEnabled = true;
            this.cbDepartmentManagerEdit.Location = new System.Drawing.Point(192, 136);
            this.cbDepartmentManagerEdit.Name = "cbDepartmentManagerEdit";
            this.cbDepartmentManagerEdit.Size = new System.Drawing.Size(182, 26);
            this.cbDepartmentManagerEdit.TabIndex = 1;
            this.cbDepartmentManagerEdit.Text = "Choose a manager";
            // 
            // lbDepartmentManagerEdit
            // 
            this.lbDepartmentManagerEdit.AutoSize = true;
            this.lbDepartmentManagerEdit.Location = new System.Drawing.Point(18, 139);
            this.lbDepartmentManagerEdit.Name = "lbDepartmentManagerEdit";
            this.lbDepartmentManagerEdit.Size = new System.Drawing.Size(151, 18);
            this.lbDepartmentManagerEdit.TabIndex = 3;
            this.lbDepartmentManagerEdit.Text = "Department manager:";
            // 
            // tbxDepartmentNameEdit
            // 
            this.tbxDepartmentNameEdit.Location = new System.Drawing.Point(192, 86);
            this.tbxDepartmentNameEdit.Name = "tbxDepartmentNameEdit";
            this.tbxDepartmentNameEdit.Size = new System.Drawing.Size(182, 24);
            this.tbxDepartmentNameEdit.TabIndex = 1;
            // 
            // lbDepartmentNameEdit
            // 
            this.lbDepartmentNameEdit.AutoSize = true;
            this.lbDepartmentNameEdit.Location = new System.Drawing.Point(117, 92);
            this.lbDepartmentNameEdit.Name = "lbDepartmentNameEdit";
            this.lbDepartmentNameEdit.Size = new System.Drawing.Size(52, 18);
            this.lbDepartmentNameEdit.TabIndex = 1;
            this.lbDepartmentNameEdit.Text = "Name:";
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.Location = new System.Drawing.Point(371, 545);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(131, 38);
            this.btnRemoveDepartment.TabIndex = 5;
            this.btnRemoveDepartment.Text = "Remove";
            this.btnRemoveDepartment.UseVisualStyleBackColor = true;
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.Location = new System.Drawing.Point(199, 545);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(131, 38);
            this.btnEditDepartment.TabIndex = 4;
            this.btnEditDepartment.Text = "Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = true;
            // 
            // btnDepartmentsClearSelected
            // 
            this.btnDepartmentsClearSelected.Location = new System.Drawing.Point(26, 545);
            this.btnDepartmentsClearSelected.Name = "btnDepartmentsClearSelected";
            this.btnDepartmentsClearSelected.Size = new System.Drawing.Size(131, 38);
            this.btnDepartmentsClearSelected.TabIndex = 3;
            this.btnDepartmentsClearSelected.Text = "Unmark selected";
            this.btnDepartmentsClearSelected.UseVisualStyleBackColor = true;
            // 
            // lbDepartmentsInfo
            // 
            this.lbDepartmentsInfo.AutoSize = true;
            this.lbDepartmentsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDepartmentsInfo.Location = new System.Drawing.Point(184, 34);
            this.lbDepartmentsInfo.Name = "lbDepartmentsInfo";
            this.lbDepartmentsInfo.Size = new System.Drawing.Size(163, 18);
            this.lbDepartmentsInfo.TabIndex = 2;
            this.lbDepartmentsInfo.Text = "View all departments";
            // 
            // lbxAllDepartments
            // 
            this.lbxAllDepartments.FormattingEnabled = true;
            this.lbxAllDepartments.HorizontalScrollbar = true;
            this.lbxAllDepartments.ItemHeight = 18;
            this.lbxAllDepartments.Location = new System.Drawing.Point(26, 74);
            this.lbxAllDepartments.Name = "lbxAllDepartments";
            this.lbxAllDepartments.Size = new System.Drawing.Size(476, 454);
            this.lbxAllDepartments.TabIndex = 1;
            // 
            // gbxCreateDeparmtent
            // 
            this.gbxCreateDeparmtent.Controls.Add(this.btnCreateDepartment);
            this.gbxCreateDeparmtent.Controls.Add(this.cbDepartmentManager);
            this.gbxCreateDeparmtent.Controls.Add(this.lbDepartmentManager);
            this.gbxCreateDeparmtent.Controls.Add(this.tbxDepartmentName);
            this.gbxCreateDeparmtent.Controls.Add(this.lbDepartmentName);
            this.gbxCreateDeparmtent.Location = new System.Drawing.Point(547, 74);
            this.gbxCreateDeparmtent.Name = "gbxCreateDeparmtent";
            this.gbxCreateDeparmtent.Size = new System.Drawing.Size(406, 218);
            this.gbxCreateDeparmtent.TabIndex = 0;
            this.gbxCreateDeparmtent.TabStop = false;
            this.gbxCreateDeparmtent.Text = "Create new department";
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.Location = new System.Drawing.Point(192, 148);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Size = new System.Drawing.Size(182, 39);
            this.btnCreateDepartment.TabIndex = 4;
            this.btnCreateDepartment.Text = "Create new department";
            this.btnCreateDepartment.UseVisualStyleBackColor = true;
            // 
            // cbDepartmentManager
            // 
            this.cbDepartmentManager.FormattingEnabled = true;
            this.cbDepartmentManager.Location = new System.Drawing.Point(192, 99);
            this.cbDepartmentManager.Name = "cbDepartmentManager";
            this.cbDepartmentManager.Size = new System.Drawing.Size(182, 26);
            this.cbDepartmentManager.TabIndex = 1;
            this.cbDepartmentManager.Text = "Choose a manager";
            // 
            // lbDepartmentManager
            // 
            this.lbDepartmentManager.AutoSize = true;
            this.lbDepartmentManager.Location = new System.Drawing.Point(18, 102);
            this.lbDepartmentManager.Name = "lbDepartmentManager";
            this.lbDepartmentManager.Size = new System.Drawing.Size(151, 18);
            this.lbDepartmentManager.TabIndex = 3;
            this.lbDepartmentManager.Text = "Department maanger:";
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.Location = new System.Drawing.Point(192, 49);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(182, 24);
            this.tbxDepartmentName.TabIndex = 1;
            // 
            // lbDepartmentName
            // 
            this.lbDepartmentName.AutoSize = true;
            this.lbDepartmentName.Location = new System.Drawing.Point(117, 55);
            this.lbDepartmentName.Name = "lbDepartmentName";
            this.lbDepartmentName.Size = new System.Drawing.Size(52, 18);
            this.lbDepartmentName.TabIndex = 1;
            this.lbDepartmentName.Text = "Name:";
            // 
            // ViewStatisticsEmpTab
            // 
            this.ViewStatisticsEmpTab.Controls.Add(this.lbAvgWageEmpDepartment);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbxAvgWageEmpDepartment);
            this.ViewStatisticsEmpTab.Controls.Add(this.tbxAvgWageEmp);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbAvgWageEmp);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbNrEmpPerDepartment);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbxNrEmpPerDepartment);
            this.ViewStatisticsEmpTab.Controls.Add(this.tbxNrEmp);
            this.ViewStatisticsEmpTab.Controls.Add(this.lbNrEmp);
            this.ViewStatisticsEmpTab.Location = new System.Drawing.Point(4, 27);
            this.ViewStatisticsEmpTab.Name = "ViewStatisticsEmpTab";
            this.ViewStatisticsEmpTab.Size = new System.Drawing.Size(999, 616);
            this.ViewStatisticsEmpTab.TabIndex = 5;
            this.ViewStatisticsEmpTab.Text = "View statistics for employees";
            this.ViewStatisticsEmpTab.UseVisualStyleBackColor = true;
            // 
            // lbAvgWageEmpDepartment
            // 
            this.lbAvgWageEmpDepartment.AutoSize = true;
            this.lbAvgWageEmpDepartment.Location = new System.Drawing.Point(569, 193);
            this.lbAvgWageEmpDepartment.Name = "lbAvgWageEmpDepartment";
            this.lbAvgWageEmpDepartment.Size = new System.Drawing.Size(296, 18);
            this.lbAvgWageEmpDepartment.TabIndex = 7;
            this.lbAvgWageEmpDepartment.Text = "Average wage of employees per department";
            // 
            // lbxAvgWageEmpDepartment
            // 
            this.lbxAvgWageEmpDepartment.FormattingEnabled = true;
            this.lbxAvgWageEmpDepartment.ItemHeight = 18;
            this.lbxAvgWageEmpDepartment.Location = new System.Drawing.Point(542, 233);
            this.lbxAvgWageEmpDepartment.Name = "lbxAvgWageEmpDepartment";
            this.lbxAvgWageEmpDepartment.Size = new System.Drawing.Size(348, 220);
            this.lbxAvgWageEmpDepartment.TabIndex = 6;
            // 
            // tbxAvgWageEmp
            // 
            this.tbxAvgWageEmp.Location = new System.Drawing.Point(744, 133);
            this.tbxAvgWageEmp.Name = "tbxAvgWageEmp";
            this.tbxAvgWageEmp.Size = new System.Drawing.Size(146, 24);
            this.tbxAvgWageEmp.TabIndex = 5;
            // 
            // lbAvgWageEmp
            // 
            this.lbAvgWageEmp.AutoSize = true;
            this.lbAvgWageEmp.Location = new System.Drawing.Point(549, 136);
            this.lbAvgWageEmp.Name = "lbAvgWageEmp";
            this.lbAvgWageEmp.Size = new System.Drawing.Size(189, 18);
            this.lbAvgWageEmp.TabIndex = 4;
            this.lbAvgWageEmp.Text = "Average wage of employee:";
            // 
            // lbNrEmpPerDepartment
            // 
            this.lbNrEmpPerDepartment.AutoSize = true;
            this.lbNrEmpPerDepartment.Location = new System.Drawing.Point(146, 193);
            this.lbNrEmpPerDepartment.Name = "lbNrEmpPerDepartment";
            this.lbNrEmpPerDepartment.Size = new System.Drawing.Size(257, 18);
            this.lbNrEmpPerDepartment.TabIndex = 3;
            this.lbNrEmpPerDepartment.Text = "Number of employees per department";
            // 
            // lbxNrEmpPerDepartment
            // 
            this.lbxNrEmpPerDepartment.FormattingEnabled = true;
            this.lbxNrEmpPerDepartment.ItemHeight = 18;
            this.lbxNrEmpPerDepartment.Location = new System.Drawing.Point(120, 233);
            this.lbxNrEmpPerDepartment.Name = "lbxNrEmpPerDepartment";
            this.lbxNrEmpPerDepartment.Size = new System.Drawing.Size(307, 220);
            this.lbxNrEmpPerDepartment.TabIndex = 2;
            // 
            // tbxNrEmp
            // 
            this.tbxNrEmp.Location = new System.Drawing.Point(281, 133);
            this.tbxNrEmp.Name = "tbxNrEmp";
            this.tbxNrEmp.Size = new System.Drawing.Size(146, 24);
            this.tbxNrEmp.TabIndex = 1;
            // 
            // lbNrEmp
            // 
            this.lbNrEmp.AutoSize = true;
            this.lbNrEmp.Location = new System.Drawing.Point(117, 136);
            this.lbNrEmp.Name = "lbNrEmp";
            this.lbNrEmp.Size = new System.Drawing.Size(158, 18);
            this.lbNrEmp.TabIndex = 0;
            this.lbNrEmp.Text = "Number of employees:";
            // 
            // ViewStatisticsStocksTab
            // 
            this.ViewStatisticsStocksTab.Controls.Add(this.btnShowStockStatistics);
            this.ViewStatisticsStocksTab.Controls.Add(this.cbStatisticType);
            this.ViewStatisticsStocksTab.Controls.Add(this.lbxAllStocksStatistics);
            this.ViewStatisticsStocksTab.Location = new System.Drawing.Point(4, 27);
            this.ViewStatisticsStocksTab.Name = "ViewStatisticsStocksTab";
            this.ViewStatisticsStocksTab.Size = new System.Drawing.Size(999, 616);
            this.ViewStatisticsStocksTab.TabIndex = 9;
            this.ViewStatisticsStocksTab.Text = "View statistics for stocks";
            this.ViewStatisticsStocksTab.UseVisualStyleBackColor = true;
            this.ViewStatisticsStocksTab.Click += new System.EventHandler(this.ViewStatisticsStocksTab_Click);
            // 
            // btnShowStockStatistics
            // 
            this.btnShowStockStatistics.Location = new System.Drawing.Point(583, 100);
            this.btnShowStockStatistics.Name = "btnShowStockStatistics";
            this.btnShowStockStatistics.Size = new System.Drawing.Size(181, 35);
            this.btnShowStockStatistics.TabIndex = 5;
            this.btnShowStockStatistics.Text = "Show";
            this.btnShowStockStatistics.UseVisualStyleBackColor = true;
            // 
            // cbStatisticType
            // 
            this.cbStatisticType.FormattingEnabled = true;
            this.cbStatisticType.Items.AddRange(new object[] {
            "highest price",
            "lowest price",
            "biggest quantity",
            "smallest quantity",
            ""});
            this.cbStatisticType.Location = new System.Drawing.Point(212, 105);
            this.cbStatisticType.Name = "cbStatisticType";
            this.cbStatisticType.Size = new System.Drawing.Size(288, 26);
            this.cbStatisticType.TabIndex = 4;
            this.cbStatisticType.Text = "Sort based on statistic type";
            // 
            // lbxAllStocksStatistics
            // 
            this.lbxAllStocksStatistics.FormattingEnabled = true;
            this.lbxAllStocksStatistics.HorizontalScrollbar = true;
            this.lbxAllStocksStatistics.ItemHeight = 18;
            this.lbxAllStocksStatistics.Location = new System.Drawing.Point(212, 147);
            this.lbxAllStocksStatistics.Name = "lbxAllStocksStatistics";
            this.lbxAllStocksStatistics.Size = new System.Drawing.Size(552, 292);
            this.lbxAllStocksStatistics.TabIndex = 0;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 678);
            this.Controls.Add(this.tabControlAdministration);
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.tabControlAdministration.ResumeLayout(false);
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.AddEmpTab.ResumeLayout(false);
            this.gbxAddEmployee.ResumeLayout(false);
            this.gbxAddEmployee.PerformLayout();
            this.ManageEmpTab.ResumeLayout(false);
            this.gbxSearchEmp.ResumeLayout(false);
            this.gbxSearchEmp.PerformLayout();
            this.gbxShowAllEmp.ResumeLayout(false);
            this.ManageScheduleTab.ResumeLayout(false);
            this.ManageScheduleTab.PerformLayout();
            this.gbxAutoShiftsAssignPerDay.ResumeLayout(false);
            this.gbxAutoShiftsAssignPerDay.PerformLayout();
            this.gbxAutoShiftsAssignAllDays.ResumeLayout(false);
            this.gbxAutoShiftsAssignAllDays.PerformLayout();
            this.gbxAssignShiftsAuto.ResumeLayout(false);
            this.HolidayRequestsTab.ResumeLayout(false);
            this.HolidayRequestsTab.PerformLayout();
            this.ManageStocksTab.ResumeLayout(false);
            this.gbxSearchStock.ResumeLayout(false);
            this.gbxSearchStock.PerformLayout();
            this.gbxAddStock.ResumeLayout(false);
            this.gbxAddStock.PerformLayout();
            this.ManageShelfRestockRequestsTab.ResumeLayout(false);
            this.ManageShelfRestockRequestsTab.PerformLayout();
            this.ManageDepartmentsTab.ResumeLayout(false);
            this.ManageDepartmentsTab.PerformLayout();
            this.gbxEditDepartment.ResumeLayout(false);
            this.gbxEditDepartment.PerformLayout();
            this.gbxCreateDeparmtent.ResumeLayout(false);
            this.gbxCreateDeparmtent.PerformLayout();
            this.ViewStatisticsEmpTab.ResumeLayout(false);
            this.ViewStatisticsEmpTab.PerformLayout();
            this.ViewStatisticsStocksTab.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlAdministration;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbNotificationsShelfRestockRequests;
        private System.Windows.Forms.Label lbNotificationsHolidayRequests;
        private System.Windows.Forms.Label lbGreetingMsg;
        private System.Windows.Forms.TabPage AddEmpTab;
        private System.Windows.Forms.GroupBox gbxAddEmployee;
        private System.Windows.Forms.Button btnAddEmpoyee;
        private System.Windows.Forms.Label lbEmpEmployementType;
        private System.Windows.Forms.Label lbEmpPosition;
        private System.Windows.Forms.Label lbEmpDateOfBirth;
        private System.Windows.Forms.Label lbEmpHourlyWages;
        private System.Windows.Forms.TextBox tbxEmpPhone;
        private System.Windows.Forms.Label lbEmpPhone;
        private System.Windows.Forms.TextBox tbxEmpAddressStreet;
        private System.Windows.Forms.Label lbEmployeeAddress;
        private System.Windows.Forms.TextBox tbxEmpLname;
        private System.Windows.Forms.Label lbEmpLname;
        private System.Windows.Forms.TextBox tbxEmpFname;
        private System.Windows.Forms.Label lbEmpFname;
        private System.Windows.Forms.TabPage ManageScheduleTab;
        private System.Windows.Forms.TabPage HolidayRequestsTab;
        private System.Windows.Forms.TabPage ManageStocksTab;
        private System.Windows.Forms.TabPage ViewStatisticsEmpTab;
        private System.Windows.Forms.TabPage ManageShelfRestockRequestsTab;
        private System.Windows.Forms.DateTimePicker dtpEmpDateOfBirth;
        private System.Windows.Forms.Label lbEmpAddressPostCode;
        private System.Windows.Forms.TextBox tbxEmpAddressPostCode;
        private System.Windows.Forms.Label lbEmpAddressCountry;
        private System.Windows.Forms.TextBox tbxEmpAddressCountry;
        private System.Windows.Forms.Label lbEmpAddressCity;
        private System.Windows.Forms.TextBox tbxEmpAddressCity;
        private System.Windows.Forms.Label lbEmpAddressStreet;
        private System.Windows.Forms.TabPage ManageEmpTab;
        private System.Windows.Forms.ListBox lbxAllEmployees;
        private System.Windows.Forms.GroupBox gbxSearchEmp;
        private System.Windows.Forms.Button btnSearchEmp;
        private System.Windows.Forms.TextBox tbxSearchEmp;
        private System.Windows.Forms.GroupBox gbxShowAllEmp;
        private System.Windows.Forms.ComboBox cbSelectEmpType;
        private System.Windows.Forms.Button btnShowAllEmp;
        private System.Windows.Forms.Button btnClearSelectedEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.TextBox tbxEmpEmail;
        private System.Windows.Forms.Label lbEmpEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbEmpGender;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbEmpHourlyWages;
        private System.Windows.Forms.ComboBox cbEmpPosition;
        private System.Windows.Forms.ComboBox cbEmpEmploymentType;
        private System.Windows.Forms.ListBox lbxScheduleAllEmp;
        private System.Windows.Forms.Label lbScheduleAllEmp;
        private System.Windows.Forms.GroupBox gbxAutoShiftsAssignPerDay;
        private System.Windows.Forms.Button btnSubmitAutoShiftsAssignPerDay;
        private System.Windows.Forms.TextBox tbxSun;
        private System.Windows.Forms.Label lbSun;
        private System.Windows.Forms.TextBox tbxSat;
        private System.Windows.Forms.Label lbSat;
        private System.Windows.Forms.TextBox tbxFri;
        private System.Windows.Forms.Label lbFri;
        private System.Windows.Forms.TextBox tbxThurs;
        private System.Windows.Forms.Label lbThurs;
        private System.Windows.Forms.TextBox tbxWed;
        private System.Windows.Forms.Label lbWed;
        private System.Windows.Forms.TextBox tbxTues;
        private System.Windows.Forms.Label lbTues;
        private System.Windows.Forms.TextBox tbxMon;
        private System.Windows.Forms.Label lbMon;
        private System.Windows.Forms.GroupBox gbxAutoShiftsAssignAllDays;
        private System.Windows.Forms.Button btnSubmitAutoShiftsAssignAllDays;
        private System.Windows.Forms.Label lbNrWorkers;
        private System.Windows.Forms.TextBox tbxNrWorkers;
        private System.Windows.Forms.GroupBox gbxAssignShiftsAuto;
        private System.Windows.Forms.Button btnChooseAssignTypeAuto;
        private System.Windows.Forms.ComboBox cbAssignTypeAuto;
        private System.Windows.Forms.Button btnAssignShiftsManually;
        private System.Windows.Forms.Button btnScheduleClearSelected;
        private System.Windows.Forms.ListBox lbxAllHolidayRequests;
        private System.Windows.Forms.Label lbHolidayRequestsInfo;
        private System.Windows.Forms.Button btnHolidayRequestsClearSelected;
        private System.Windows.Forms.Button btnHolidayRequestsDecline;
        private System.Windows.Forms.Button btnHolidayRequestsAccept;
        private System.Windows.Forms.TabPage ManageDepartmentsTab;
        private System.Windows.Forms.ListBox lbxAllDepartments;
        private System.Windows.Forms.GroupBox gbxCreateDeparmtent;
        private System.Windows.Forms.Button btnCreateDepartment;
        private System.Windows.Forms.ComboBox cbDepartmentManager;
        private System.Windows.Forms.Label lbDepartmentManager;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.Label lbDepartmentName;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnDepartmentsClearSelected;
        private System.Windows.Forms.Label lbDepartmentsInfo;
        private System.Windows.Forms.GroupBox gbxEditDepartment;
        private System.Windows.Forms.Label lbDepartmentEditInfo;
        private System.Windows.Forms.Button btnApplyChangesDepartment;
        private System.Windows.Forms.ComboBox cbDepartmentManagerEdit;
        private System.Windows.Forms.Label lbDepartmentManagerEdit;
        private System.Windows.Forms.TextBox tbxDepartmentNameEdit;
        private System.Windows.Forms.Label lbDepartmentNameEdit;
        private System.Windows.Forms.Label lbShelfRestockRequestsInfo;
        private System.Windows.Forms.Button btnSehflRestockRequestsClearSelected;
        private System.Windows.Forms.Button btnShelftRestockRequestsMarkAsDone;
        private System.Windows.Forms.Button btnShelftRestockRequestsDecline;
        private System.Windows.Forms.ListBox lbxAllShelfRestockRequests;
        private System.Windows.Forms.GroupBox gbxAddStock;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.TextBox tbxStockQuantity;
        private System.Windows.Forms.Label lbStockQuantity;
        private System.Windows.Forms.TextBox tbxStockShortDescription;
        private System.Windows.Forms.Label lbStockShortDescription;
        private System.Windows.Forms.Label lbStockDimensions;
        private System.Windows.Forms.TextBox tbxStockPrice;
        private System.Windows.Forms.Label lbStockPrice;
        private System.Windows.Forms.TextBox tbxStockModel;
        private System.Windows.Forms.Label lbStockModel;
        private System.Windows.Forms.TextBox tbxStockBrand;
        private System.Windows.Forms.Label lbStockBrand;
        private System.Windows.Forms.Button btnShowAllStocks;
        private System.Windows.Forms.GroupBox gbxSearchStock;
        private System.Windows.Forms.Button btnSearchStock;
        private System.Windows.Forms.TextBox tbxSearchStock;
        private System.Windows.Forms.Button btnStocksClearSelected;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.ListBox lbAllStocks;
        private System.Windows.Forms.TabPage ViewStatisticsStocksTab;
        private System.Windows.Forms.TextBox tbxStockDepth;
        private System.Windows.Forms.Label lbStockDepth;
        private System.Windows.Forms.TextBox tbxStockHeight;
        private System.Windows.Forms.Label lbStockHeight;
        private System.Windows.Forms.TextBox tbxStockWidth;
        private System.Windows.Forms.Label lbStockWidth;
        private System.Windows.Forms.ComboBox cbEmpDepartment;
        private System.Windows.Forms.Label lbEmpDepartment;
        private System.Windows.Forms.Button btnEmpManageAttendance;
        private System.Windows.Forms.TextBox tbxNrEmp;
        private System.Windows.Forms.Label lbNrEmp;
        private System.Windows.Forms.Label lbNrEmpPerDepartment;
        private System.Windows.Forms.ListBox lbxNrEmpPerDepartment;
        private System.Windows.Forms.Label lbAvgWageEmpDepartment;
        private System.Windows.Forms.ListBox lbxAvgWageEmpDepartment;
        private System.Windows.Forms.TextBox tbxAvgWageEmp;
        private System.Windows.Forms.Label lbAvgWageEmp;
        private System.Windows.Forms.Button btnShowStockStatistics;
        private System.Windows.Forms.ComboBox cbStatisticType;
        private System.Windows.Forms.ListBox lbxAllStocksStatistics;
        private System.Windows.Forms.Label lbHistoryShelfRestockRequests;
        private System.Windows.Forms.ListBox lbxHistoryShelfRestockRequests;
    }
}

