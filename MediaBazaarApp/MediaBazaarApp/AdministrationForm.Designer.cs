
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministrationForm));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ManageDepartmentsTab = new System.Windows.Forms.TabPage();
            this.btnShowAllDep = new System.Windows.Forms.Button();
            this.dgvDepartments = new System.Windows.Forms.DataGridView();
            this.gbxSearchDep = new System.Windows.Forms.GroupBox();
            this.tbxSearchDep = new System.Windows.Forms.TextBox();
            this.gbxEditDepartment = new System.Windows.Forms.GroupBox();
            this.lbDepartmentCurrManagerEdit = new System.Windows.Forms.Label();
            this.lbDepartmentEditInfo = new System.Windows.Forms.Label();
            this.btnApplyChangesDepartment = new System.Windows.Forms.Button();
            this.cbDepartmentManagerEdit = new System.Windows.Forms.ComboBox();
            this.lbDepartmentManagerEdit = new System.Windows.Forms.Label();
            this.tbxDepartmentNameEdit = new System.Windows.Forms.TextBox();
            this.lbDepartmentNameEdit = new System.Windows.Forms.Label();
            this.btnRemoveDepartment = new System.Windows.Forms.Button();
            this.btnEditDepartment = new System.Windows.Forms.Button();
            this.btnDepartmentsClearSelected = new System.Windows.Forms.Button();
            this.gbxCreateDeparmtent = new System.Windows.Forms.GroupBox();
            this.btnCreateDepartment = new System.Windows.Forms.Button();
            this.cbDepartmentManager = new System.Windows.Forms.ComboBox();
            this.lbDepartmentManager = new System.Windows.Forms.Label();
            this.tbxDepartmentName = new System.Windows.Forms.TextBox();
            this.lbDepartmentName = new System.Windows.Forms.Label();
            this.StocksTab = new System.Windows.Forms.TabPage();
            this.tabControlStocks = new System.Windows.Forms.TabControl();
            this.AddStocksTab = new System.Windows.Forms.TabPage();
            this.kgLb = new System.Windows.Forms.Label();
            this.cmLb3 = new System.Windows.Forms.Label();
            this.lbStocksMainDetails = new System.Windows.Forms.Label();
            this.cmLb2 = new System.Windows.Forms.Label();
            this.lbStockShortDescription = new System.Windows.Forms.Label();
            this.cmLb1 = new System.Windows.Forms.Label();
            this.lbStockQuantity = new System.Windows.Forms.Label();
            this.tbxStockWeight = new System.Windows.Forms.TextBox();
            this.tbxStockWidth = new System.Windows.Forms.TextBox();
            this.stockWeightLb = new System.Windows.Forms.Label();
            this.tbxStockQuantity = new System.Windows.Forms.TextBox();
            this.lbStockDimensions = new System.Windows.Forms.Label();
            this.tbxStockDepth = new System.Windows.Forms.TextBox();
            this.lbStockWidth = new System.Windows.Forms.Label();
            this.btnAddStock = new System.Windows.Forms.Button();
            this.lbStockHeight = new System.Windows.Forms.Label();
            this.tbxStockPrice = new System.Windows.Forms.TextBox();
            this.lbStockBrand = new System.Windows.Forms.Label();
            this.tbxStockShortDescription = new System.Windows.Forms.TextBox();
            this.tbxStockBrand = new System.Windows.Forms.TextBox();
            this.lbStockPrice = new System.Windows.Forms.Label();
            this.tbxStockHeight = new System.Windows.Forms.TextBox();
            this.lbStockDepth = new System.Windows.Forms.Label();
            this.lbStockModel = new System.Windows.Forms.Label();
            this.tbxStockModel = new System.Windows.Forms.TextBox();
            this.ManageStocksTab = new System.Windows.Forms.TabPage();
            this.dgvStock = new System.Windows.Forms.DataGridView();
            this.btnShowAllStocks = new System.Windows.Forms.Button();
            this.gbxSearchStock = new System.Windows.Forms.GroupBox();
            this.tbxSearchStock = new System.Windows.Forms.TextBox();
            this.btnStocksClearSelected = new System.Windows.Forms.Button();
            this.btnEditStock = new System.Windows.Forms.Button();
            this.btnRemoveStock = new System.Windows.Forms.Button();
            this.SchedulingTab = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbWeeklySchedule = new System.Windows.Forms.TabPage();
            this.btnGenAS = new System.Windows.Forms.Button();
            this.lbWeekNrAS = new System.Windows.Forms.Label();
            this.cbWeekAS = new System.Windows.Forms.ComboBox();
            this.lbWeekNumber = new System.Windows.Forms.Label();
            this.cbWeekNumber = new System.Windows.Forms.ComboBox();
            this.lbxWeeklySchedule = new System.Windows.Forms.ListBox();
            this.tpManualSched = new System.Windows.Forms.TabPage();
            this.gbViewRemoveShifts = new System.Windows.Forms.GroupBox();
            this.btnRemoveShift = new System.Windows.Forms.Button();
            this.btnReturnViewRemove = new System.Windows.Forms.Button();
            this.lbxSelectedEmpShifts = new System.Windows.Forms.ListBox();
            this.btnScheduleClearSelected = new System.Windows.Forms.Button();
            this.gbAssignShiftManually = new System.Windows.Forms.GroupBox();
            this.btnReturnAssign = new System.Windows.Forms.Button();
            this.cbWFH = new System.Windows.Forms.CheckBox();
            this.lbEmpInfo = new System.Windows.Forms.Label();
            this.lbWFH = new System.Windows.Forms.Label();
            this.btnAssign = new System.Windows.Forms.Button();
            this.lbShiftType = new System.Windows.Forms.Label();
            this.dtpShiftDate = new System.Windows.Forms.DateTimePicker();
            this.lbShiftDate = new System.Windows.Forms.Label();
            this.cbShiftType = new System.Windows.Forms.ComboBox();
            this.gbChooseEmp = new System.Windows.Forms.GroupBox();
            this.lbEmp = new System.Windows.Forms.Label();
            this.lbDep = new System.Windows.Forms.Label();
            this.btnAddShift = new System.Windows.Forms.Button();
            this.btnViewRemoveShifts = new System.Windows.Forms.Button();
            this.cbEmps = new System.Windows.Forms.ComboBox();
            this.cbDeps = new System.Windows.Forms.ComboBox();
            this.tpManageAttendance = new System.Windows.Forms.TabPage();
            this.btnApplyAttendanceChanges = new System.Windows.Forms.Button();
            this.tbReasonForAbsence = new System.Windows.Forms.TextBox();
            this.cbHasAttended = new System.Windows.Forms.CheckBox();
            this.lbReason = new System.Windows.Forms.Label();
            this.lbHasAttended = new System.Windows.Forms.Label();
            this.lbShift = new System.Windows.Forms.Label();
            this.cbEmployeesShifts = new System.Windows.Forms.ComboBox();
            this.lbSelectedEmp = new System.Windows.Forms.Label();
            this.lbSelectedDep = new System.Windows.Forms.Label();
            this.cbSelectedEmp = new System.Windows.Forms.ComboBox();
            this.cbAllDeps = new System.Windows.Forms.ComboBox();
            this.EmployeesTab = new System.Windows.Forms.TabPage();
            this.tabControlEmployees = new System.Windows.Forms.TabControl();
            this.AddEmpTab = new System.Windows.Forms.TabPage();
            this.dtpEmpEndDate = new System.Windows.Forms.DateTimePicker();
            this.lbEmpEndDate = new System.Windows.Forms.Label();
            this.dtpEmpStartDate = new System.Windows.Forms.DateTimePicker();
            this.lbEmpStartDate = new System.Windows.Forms.Label();
            this.lbEmpNationality = new System.Windows.Forms.Label();
            this.tbxEmpNationality = new System.Windows.Forms.TextBox();
            this.cbEmConRelation = new System.Windows.Forms.ComboBox();
            this.lbEmConRelation = new System.Windows.Forms.Label();
            this.tbxEmConName = new System.Windows.Forms.TextBox();
            this.lbEmConName = new System.Windows.Forms.Label();
            this.tbxEmConEmail = new System.Windows.Forms.TextBox();
            this.lbEmConEmail = new System.Windows.Forms.Label();
            this.tbxEmConPhone = new System.Windows.Forms.TextBox();
            this.lbEmConPhone = new System.Windows.Forms.Label();
            this.lbEmpEmConDetails = new System.Windows.Forms.Label();
            this.lbEmpBsn = new System.Windows.Forms.Label();
            this.tbxEmpBsn = new System.Windows.Forms.TextBox();
            this.nudEmpHourlyWages = new System.Windows.Forms.NumericUpDown();
            this.cbEmpDepartment = new System.Windows.Forms.ComboBox();
            this.lbEmpDepartment = new System.Windows.Forms.Label();
            this.cbEmpEmploymentType = new System.Windows.Forms.ComboBox();
            this.lbEmpJobSpec = new System.Windows.Forms.Label();
            this.lbEmpAddressStreet = new System.Windows.Forms.Label();
            this.lbEmpPersonalInfo = new System.Windows.Forms.Label();
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
            this.dgvEmployees = new System.Windows.Forms.DataGridView();
            this.gbxShowEmp = new System.Windows.Forms.GroupBox();
            this.cbSelectEmpDepartment = new System.Windows.Forms.ComboBox();
            this.gbxSearchEmp = new System.Windows.Forms.GroupBox();
            this.tbxSearchEmp = new System.Windows.Forms.TextBox();
            this.btnClearSelectedEmp = new System.Windows.Forms.Button();
            this.btnEditEmp = new System.Windows.Forms.Button();
            this.btnRemoveEmp = new System.Windows.Forms.Button();
            this.HolidayRequestsTab = new System.Windows.Forms.TabPage();
            this.lbHolidayRequestsInfo = new System.Windows.Forms.Label();
            this.btnHolidayRequestsClearSelected = new System.Windows.Forms.Button();
            this.btnHolidayRequestsDecline = new System.Windows.Forms.Button();
            this.btnHolidayRequestsAccept = new System.Windows.Forms.Button();
            this.lbxAllHolidayRequests = new System.Windows.Forms.ListBox();
            this.HomeTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.manageDepartmentsShortcut = new System.Windows.Forms.Panel();
            this.manageDepLBL = new System.Windows.Forms.Label();
            this.manageDepPic = new System.Windows.Forms.PictureBox();
            this.manageStockShortcut = new System.Windows.Forms.Panel();
            this.manageStockLBL = new System.Windows.Forms.Label();
            this.manageStockPic = new System.Windows.Forms.PictureBox();
            this.manageAttendanceShortcut = new System.Windows.Forms.Panel();
            this.manageAttendanceLBL = new System.Windows.Forms.Label();
            this.manageAttendancePic = new System.Windows.Forms.PictureBox();
            this.weeklySchedukeShortcut = new System.Windows.Forms.Panel();
            this.weeklyScheduleLBL = new System.Windows.Forms.Label();
            this.weekSchedulePic = new System.Windows.Forms.PictureBox();
            this.holidayLeaveRequestsShortcut = new System.Windows.Forms.Panel();
            this.holidayLeaveLBL = new System.Windows.Forms.Label();
            this.holidayLeavePic = new System.Windows.Forms.PictureBox();
            this.manageEmpShortcut = new System.Windows.Forms.Panel();
            this.manageEmpLBL = new System.Windows.Forms.Label();
            this.manageEmpPic = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.lbTime = new System.Windows.Forms.Label();
            this.lbDateDayOfWeek = new System.Windows.Forms.Label();
            this.lbGreetingMsg = new System.Windows.Forms.Label();
            this.tabControlAdministration = new System.Windows.Forms.TabControl();
            this.settingsTab = new System.Windows.Forms.TabPage();
            this.applyShortcutsBTN = new System.Windows.Forms.Button();
            this.manageAttendanceCH = new System.Windows.Forms.CheckBox();
            this.manageStockCH = new System.Windows.Forms.CheckBox();
            this.manageDepCH = new System.Windows.Forms.CheckBox();
            this.weeklyScheduleCH = new System.Windows.Forms.CheckBox();
            this.holidayLeaveReqCH = new System.Windows.Forms.CheckBox();
            this.manageEmpCH = new System.Windows.Forms.CheckBox();
            this.ManageDepartmentsTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).BeginInit();
            this.gbxSearchDep.SuspendLayout();
            this.gbxEditDepartment.SuspendLayout();
            this.gbxCreateDeparmtent.SuspendLayout();
            this.StocksTab.SuspendLayout();
            this.tabControlStocks.SuspendLayout();
            this.AddStocksTab.SuspendLayout();
            this.ManageStocksTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).BeginInit();
            this.gbxSearchStock.SuspendLayout();
            this.SchedulingTab.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tbWeeklySchedule.SuspendLayout();
            this.tpManualSched.SuspendLayout();
            this.gbViewRemoveShifts.SuspendLayout();
            this.gbAssignShiftManually.SuspendLayout();
            this.gbChooseEmp.SuspendLayout();
            this.tpManageAttendance.SuspendLayout();
            this.EmployeesTab.SuspendLayout();
            this.tabControlEmployees.SuspendLayout();
            this.AddEmpTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpHourlyWages)).BeginInit();
            this.ManageEmpTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
            this.gbxShowEmp.SuspendLayout();
            this.gbxSearchEmp.SuspendLayout();
            this.HolidayRequestsTab.SuspendLayout();
            this.HomeTab.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.manageDepartmentsShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDepPic)).BeginInit();
            this.manageStockShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageStockPic)).BeginInit();
            this.manageAttendanceShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageAttendancePic)).BeginInit();
            this.weeklySchedukeShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekSchedulePic)).BeginInit();
            this.holidayLeaveRequestsShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holidayLeavePic)).BeginInit();
            this.manageEmpShortcut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmpPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.tabControlAdministration.SuspendLayout();
            this.settingsTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // ManageDepartmentsTab
            // 
            this.ManageDepartmentsTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ManageDepartmentsTab.Controls.Add(this.btnShowAllDep);
            this.ManageDepartmentsTab.Controls.Add(this.dgvDepartments);
            this.ManageDepartmentsTab.Controls.Add(this.gbxSearchDep);
            this.ManageDepartmentsTab.Controls.Add(this.gbxEditDepartment);
            this.ManageDepartmentsTab.Controls.Add(this.btnRemoveDepartment);
            this.ManageDepartmentsTab.Controls.Add(this.btnEditDepartment);
            this.ManageDepartmentsTab.Controls.Add(this.btnDepartmentsClearSelected);
            this.ManageDepartmentsTab.Controls.Add(this.gbxCreateDeparmtent);
            this.ManageDepartmentsTab.Location = new System.Drawing.Point(4, 34);
            this.ManageDepartmentsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageDepartmentsTab.Name = "ManageDepartmentsTab";
            this.ManageDepartmentsTab.Size = new System.Drawing.Size(1097, 694);
            this.ManageDepartmentsTab.TabIndex = 6;
            this.ManageDepartmentsTab.Text = "Departments";
            // 
            // btnShowAllDep
            // 
            this.btnShowAllDep.BackColor = System.Drawing.Color.LightSalmon;
            this.btnShowAllDep.Location = new System.Drawing.Point(391, 56);
            this.btnShowAllDep.Name = "btnShowAllDep";
            this.btnShowAllDep.Size = new System.Drawing.Size(167, 77);
            this.btnShowAllDep.TabIndex = 8;
            this.btnShowAllDep.Text = "Show all";
            this.btnShowAllDep.UseVisualStyleBackColor = false;
            this.btnShowAllDep.Click += new System.EventHandler(this.btnShowAllDep_Click);
            // 
            // dgvDepartments
            // 
            this.dgvDepartments.AllowUserToAddRows = false;
            this.dgvDepartments.AllowUserToDeleteRows = false;
            this.dgvDepartments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDepartments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDepartments.Location = new System.Drawing.Point(15, 166);
            this.dgvDepartments.Name = "dgvDepartments";
            this.dgvDepartments.ReadOnly = true;
            this.dgvDepartments.RowHeadersWidth = 51;
            this.dgvDepartments.RowTemplate.Height = 24;
            this.dgvDepartments.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDepartments.Size = new System.Drawing.Size(591, 438);
            this.dgvDepartments.TabIndex = 25;
            // 
            // gbxSearchDep
            // 
            this.gbxSearchDep.BackColor = System.Drawing.Color.Transparent;
            this.gbxSearchDep.Controls.Add(this.tbxSearchDep);
            this.gbxSearchDep.Location = new System.Drawing.Point(22, 28);
            this.gbxSearchDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchDep.Name = "gbxSearchDep";
            this.gbxSearchDep.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchDep.Size = new System.Drawing.Size(363, 113);
            this.gbxSearchDep.TabIndex = 18;
            this.gbxSearchDep.TabStop = false;
            this.gbxSearchDep.Text = "Search for specific department";
            // 
            // tbxSearchDep
            // 
            this.tbxSearchDep.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxSearchDep.Location = new System.Drawing.Point(24, 53);
            this.tbxSearchDep.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearchDep.Name = "tbxSearchDep";
            this.tbxSearchDep.Size = new System.Drawing.Size(209, 31);
            this.tbxSearchDep.TabIndex = 7;
            this.tbxSearchDep.Click += new System.EventHandler(this.tbxSearchDep_Click);
            this.tbxSearchDep.TextChanged += new System.EventHandler(this.tbxSearchDep_TextChanged);
            // 
            // gbxEditDepartment
            // 
            this.gbxEditDepartment.BackColor = System.Drawing.Color.Transparent;
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentCurrManagerEdit);
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentEditInfo);
            this.gbxEditDepartment.Controls.Add(this.btnApplyChangesDepartment);
            this.gbxEditDepartment.Controls.Add(this.cbDepartmentManagerEdit);
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentManagerEdit);
            this.gbxEditDepartment.Controls.Add(this.tbxDepartmentNameEdit);
            this.gbxEditDepartment.Controls.Add(this.lbDepartmentNameEdit);
            this.gbxEditDepartment.Location = new System.Drawing.Point(622, 353);
            this.gbxEditDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEditDepartment.Name = "gbxEditDepartment";
            this.gbxEditDepartment.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxEditDepartment.Size = new System.Drawing.Size(457, 350);
            this.gbxEditDepartment.TabIndex = 11;
            this.gbxEditDepartment.TabStop = false;
            this.gbxEditDepartment.Text = "Edit department";
            // 
            // lbDepartmentCurrManagerEdit
            // 
            this.lbDepartmentCurrManagerEdit.AutoSize = true;
            this.lbDepartmentCurrManagerEdit.Location = new System.Drawing.Point(103, 52);
            this.lbDepartmentCurrManagerEdit.Name = "lbDepartmentCurrManagerEdit";
            this.lbDepartmentCurrManagerEdit.Size = new System.Drawing.Size(149, 25);
            this.lbDepartmentCurrManagerEdit.TabIndex = 6;
            this.lbDepartmentCurrManagerEdit.Text = "Current manager:";
            // 
            // lbDepartmentEditInfo
            // 
            this.lbDepartmentEditInfo.AutoSize = true;
            this.lbDepartmentEditInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbDepartmentEditInfo.Location = new System.Drawing.Point(102, 24);
            this.lbDepartmentEditInfo.Name = "lbDepartmentEditInfo";
            this.lbDepartmentEditInfo.Size = new System.Drawing.Size(272, 32);
            this.lbDepartmentEditInfo.TabIndex = 5;
            this.lbDepartmentEditInfo.Text = "Department with Id:(id)";
            // 
            // btnApplyChangesDepartment
            // 
            this.btnApplyChangesDepartment.BackColor = System.Drawing.Color.LightSalmon;
            this.btnApplyChangesDepartment.Location = new System.Drawing.Point(107, 249);
            this.btnApplyChangesDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnApplyChangesDepartment.Name = "btnApplyChangesDepartment";
            this.btnApplyChangesDepartment.Size = new System.Drawing.Size(205, 54);
            this.btnApplyChangesDepartment.TabIndex = 4;
            this.btnApplyChangesDepartment.Text = "Apply changes";
            this.btnApplyChangesDepartment.UseVisualStyleBackColor = false;
            this.btnApplyChangesDepartment.Click += new System.EventHandler(this.btnApplyChangesDepartment_Click);
            // 
            // cbDepartmentManagerEdit
            // 
            this.cbDepartmentManagerEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartmentManagerEdit.FormattingEnabled = true;
            this.cbDepartmentManagerEdit.Location = new System.Drawing.Point(107, 199);
            this.cbDepartmentManagerEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDepartmentManagerEdit.Name = "cbDepartmentManagerEdit";
            this.cbDepartmentManagerEdit.Size = new System.Drawing.Size(204, 33);
            this.cbDepartmentManagerEdit.TabIndex = 1;
            this.cbDepartmentManagerEdit.Text = "Choose a manager";
            // 
            // lbDepartmentManagerEdit
            // 
            this.lbDepartmentManagerEdit.AutoSize = true;
            this.lbDepartmentManagerEdit.Location = new System.Drawing.Point(103, 162);
            this.lbDepartmentManagerEdit.Name = "lbDepartmentManagerEdit";
            this.lbDepartmentManagerEdit.Size = new System.Drawing.Size(186, 25);
            this.lbDepartmentManagerEdit.TabIndex = 3;
            this.lbDepartmentManagerEdit.Text = "Department manager:";
            // 
            // tbxDepartmentNameEdit
            // 
            this.tbxDepartmentNameEdit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxDepartmentNameEdit.Location = new System.Drawing.Point(107, 120);
            this.tbxDepartmentNameEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDepartmentNameEdit.Name = "tbxDepartmentNameEdit";
            this.tbxDepartmentNameEdit.Size = new System.Drawing.Size(204, 31);
            this.tbxDepartmentNameEdit.TabIndex = 1;
            // 
            // lbDepartmentNameEdit
            // 
            this.lbDepartmentNameEdit.AutoSize = true;
            this.lbDepartmentNameEdit.Location = new System.Drawing.Point(103, 96);
            this.lbDepartmentNameEdit.Name = "lbDepartmentNameEdit";
            this.lbDepartmentNameEdit.Size = new System.Drawing.Size(63, 25);
            this.lbDepartmentNameEdit.TabIndex = 1;
            this.lbDepartmentNameEdit.Text = "Name:";
            // 
            // btnRemoveDepartment
            // 
            this.btnRemoveDepartment.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveDepartment.Location = new System.Drawing.Point(465, 632);
            this.btnRemoveDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveDepartment.Name = "btnRemoveDepartment";
            this.btnRemoveDepartment.Size = new System.Drawing.Size(130, 54);
            this.btnRemoveDepartment.TabIndex = 12;
            this.btnRemoveDepartment.Text = "Remove";
            this.btnRemoveDepartment.UseVisualStyleBackColor = false;
            this.btnRemoveDepartment.Click += new System.EventHandler(this.btnRemoveDepartment_Click);
            // 
            // btnEditDepartment
            // 
            this.btnEditDepartment.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditDepartment.Location = new System.Drawing.Point(329, 632);
            this.btnEditDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditDepartment.Name = "btnEditDepartment";
            this.btnEditDepartment.Size = new System.Drawing.Size(130, 54);
            this.btnEditDepartment.TabIndex = 10;
            this.btnEditDepartment.Text = "Edit";
            this.btnEditDepartment.UseVisualStyleBackColor = false;
            this.btnEditDepartment.Click += new System.EventHandler(this.btnEditDepartment_Click);
            // 
            // btnDepartmentsClearSelected
            // 
            this.btnDepartmentsClearSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.btnDepartmentsClearSelected.Location = new System.Drawing.Point(22, 632);
            this.btnDepartmentsClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDepartmentsClearSelected.Name = "btnDepartmentsClearSelected";
            this.btnDepartmentsClearSelected.Size = new System.Drawing.Size(171, 54);
            this.btnDepartmentsClearSelected.TabIndex = 9;
            this.btnDepartmentsClearSelected.Text = "Unmark selected";
            this.btnDepartmentsClearSelected.UseVisualStyleBackColor = false;
            this.btnDepartmentsClearSelected.Click += new System.EventHandler(this.btnDepartmentsClearSelected_Click);
            // 
            // gbxCreateDeparmtent
            // 
            this.gbxCreateDeparmtent.BackColor = System.Drawing.Color.Transparent;
            this.gbxCreateDeparmtent.Controls.Add(this.btnCreateDepartment);
            this.gbxCreateDeparmtent.Controls.Add(this.cbDepartmentManager);
            this.gbxCreateDeparmtent.Controls.Add(this.lbDepartmentManager);
            this.gbxCreateDeparmtent.Controls.Add(this.tbxDepartmentName);
            this.gbxCreateDeparmtent.Controls.Add(this.lbDepartmentName);
            this.gbxCreateDeparmtent.Location = new System.Drawing.Point(622, 28);
            this.gbxCreateDeparmtent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCreateDeparmtent.Name = "gbxCreateDeparmtent";
            this.gbxCreateDeparmtent.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxCreateDeparmtent.Size = new System.Drawing.Size(457, 306);
            this.gbxCreateDeparmtent.TabIndex = 6;
            this.gbxCreateDeparmtent.TabStop = false;
            this.gbxCreateDeparmtent.Text = "Create new department";
            // 
            // btnCreateDepartment
            // 
            this.btnCreateDepartment.BackColor = System.Drawing.Color.LightSalmon;
            this.btnCreateDepartment.Location = new System.Drawing.Point(137, 193);
            this.btnCreateDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCreateDepartment.Name = "btnCreateDepartment";
            this.btnCreateDepartment.Size = new System.Drawing.Size(205, 54);
            this.btnCreateDepartment.TabIndex = 4;
            this.btnCreateDepartment.Text = "Create new department";
            this.btnCreateDepartment.UseVisualStyleBackColor = false;
            this.btnCreateDepartment.Click += new System.EventHandler(this.btnCreateDepartment_Click);
            // 
            // cbDepartmentManager
            // 
            this.cbDepartmentManager.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDepartmentManager.FormattingEnabled = true;
            this.cbDepartmentManager.Location = new System.Drawing.Point(137, 141);
            this.cbDepartmentManager.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbDepartmentManager.Name = "cbDepartmentManager";
            this.cbDepartmentManager.Size = new System.Drawing.Size(204, 33);
            this.cbDepartmentManager.TabIndex = 1;
            this.cbDepartmentManager.Text = "Choose a manager";
            // 
            // lbDepartmentManager
            // 
            this.lbDepartmentManager.AutoSize = true;
            this.lbDepartmentManager.Location = new System.Drawing.Point(133, 117);
            this.lbDepartmentManager.Name = "lbDepartmentManager";
            this.lbDepartmentManager.Size = new System.Drawing.Size(186, 25);
            this.lbDepartmentManager.TabIndex = 3;
            this.lbDepartmentManager.Text = "Department manager:";
            // 
            // tbxDepartmentName
            // 
            this.tbxDepartmentName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxDepartmentName.Location = new System.Drawing.Point(137, 75);
            this.tbxDepartmentName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxDepartmentName.Name = "tbxDepartmentName";
            this.tbxDepartmentName.Size = new System.Drawing.Size(204, 31);
            this.tbxDepartmentName.TabIndex = 1;
            // 
            // lbDepartmentName
            // 
            this.lbDepartmentName.AutoSize = true;
            this.lbDepartmentName.Location = new System.Drawing.Point(135, 51);
            this.lbDepartmentName.Name = "lbDepartmentName";
            this.lbDepartmentName.Size = new System.Drawing.Size(63, 25);
            this.lbDepartmentName.TabIndex = 1;
            this.lbDepartmentName.Text = "Name:";
            // 
            // StocksTab
            // 
            this.StocksTab.Controls.Add(this.tabControlStocks);
            this.StocksTab.Location = new System.Drawing.Point(4, 34);
            this.StocksTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.StocksTab.Name = "StocksTab";
            this.StocksTab.Size = new System.Drawing.Size(1097, 694);
            this.StocksTab.TabIndex = 2;
            this.StocksTab.Text = "Stocks";
            this.StocksTab.UseVisualStyleBackColor = true;
            // 
            // tabControlStocks
            // 
            this.tabControlStocks.Controls.Add(this.AddStocksTab);
            this.tabControlStocks.Controls.Add(this.ManageStocksTab);
            this.tabControlStocks.Location = new System.Drawing.Point(4, 4);
            this.tabControlStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlStocks.Name = "tabControlStocks";
            this.tabControlStocks.SelectedIndex = 0;
            this.tabControlStocks.Size = new System.Drawing.Size(1090, 771);
            this.tabControlStocks.TabIndex = 1;
            // 
            // AddStocksTab
            // 
            this.AddStocksTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddStocksTab.Controls.Add(this.kgLb);
            this.AddStocksTab.Controls.Add(this.cmLb3);
            this.AddStocksTab.Controls.Add(this.lbStocksMainDetails);
            this.AddStocksTab.Controls.Add(this.cmLb2);
            this.AddStocksTab.Controls.Add(this.lbStockShortDescription);
            this.AddStocksTab.Controls.Add(this.cmLb1);
            this.AddStocksTab.Controls.Add(this.lbStockQuantity);
            this.AddStocksTab.Controls.Add(this.tbxStockWeight);
            this.AddStocksTab.Controls.Add(this.tbxStockWidth);
            this.AddStocksTab.Controls.Add(this.stockWeightLb);
            this.AddStocksTab.Controls.Add(this.tbxStockQuantity);
            this.AddStocksTab.Controls.Add(this.lbStockDimensions);
            this.AddStocksTab.Controls.Add(this.tbxStockDepth);
            this.AddStocksTab.Controls.Add(this.lbStockWidth);
            this.AddStocksTab.Controls.Add(this.btnAddStock);
            this.AddStocksTab.Controls.Add(this.lbStockHeight);
            this.AddStocksTab.Controls.Add(this.tbxStockPrice);
            this.AddStocksTab.Controls.Add(this.lbStockBrand);
            this.AddStocksTab.Controls.Add(this.tbxStockShortDescription);
            this.AddStocksTab.Controls.Add(this.tbxStockBrand);
            this.AddStocksTab.Controls.Add(this.lbStockPrice);
            this.AddStocksTab.Controls.Add(this.tbxStockHeight);
            this.AddStocksTab.Controls.Add(this.lbStockDepth);
            this.AddStocksTab.Controls.Add(this.lbStockModel);
            this.AddStocksTab.Controls.Add(this.tbxStockModel);
            this.AddStocksTab.Location = new System.Drawing.Point(4, 34);
            this.AddStocksTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddStocksTab.Name = "AddStocksTab";
            this.AddStocksTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddStocksTab.Size = new System.Drawing.Size(1082, 733);
            this.AddStocksTab.TabIndex = 0;
            this.AddStocksTab.Text = "Add stocks";
            // 
            // kgLb
            // 
            this.kgLb.AutoSize = true;
            this.kgLb.Location = new System.Drawing.Point(769, 317);
            this.kgLb.Name = "kgLb";
            this.kgLb.Size = new System.Drawing.Size(36, 25);
            this.kgLb.TabIndex = 26;
            this.kgLb.Text = "kg.";
            // 
            // cmLb3
            // 
            this.cmLb3.AutoSize = true;
            this.cmLb3.Location = new System.Drawing.Point(769, 249);
            this.cmLb3.Name = "cmLb3";
            this.cmLb3.Size = new System.Drawing.Size(40, 25);
            this.cmLb3.TabIndex = 25;
            this.cmLb3.Text = "cm.";
            // 
            // lbStocksMainDetails
            // 
            this.lbStocksMainDetails.AutoSize = true;
            this.lbStocksMainDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbStocksMainDetails.Location = new System.Drawing.Point(280, 51);
            this.lbStocksMainDetails.Name = "lbStocksMainDetails";
            this.lbStocksMainDetails.Size = new System.Drawing.Size(148, 32);
            this.lbStocksMainDetails.TabIndex = 21;
            this.lbStocksMainDetails.Text = "Main details";
            // 
            // cmLb2
            // 
            this.cmLb2.AutoSize = true;
            this.cmLb2.Location = new System.Drawing.Point(769, 189);
            this.cmLb2.Name = "cmLb2";
            this.cmLb2.Size = new System.Drawing.Size(40, 25);
            this.cmLb2.TabIndex = 24;
            this.cmLb2.Text = "cm.";
            // 
            // lbStockShortDescription
            // 
            this.lbStockShortDescription.AutoSize = true;
            this.lbStockShortDescription.Location = new System.Drawing.Point(280, 372);
            this.lbStockShortDescription.Name = "lbStockShortDescription";
            this.lbStockShortDescription.Size = new System.Drawing.Size(152, 25);
            this.lbStockShortDescription.TabIndex = 8;
            this.lbStockShortDescription.Text = "Short description:";
            // 
            // cmLb1
            // 
            this.cmLb1.AutoSize = true;
            this.cmLb1.Location = new System.Drawing.Point(769, 130);
            this.cmLb1.Name = "cmLb1";
            this.cmLb1.Size = new System.Drawing.Size(40, 25);
            this.cmLb1.TabIndex = 23;
            this.cmLb1.Text = "cm.";
            // 
            // lbStockQuantity
            // 
            this.lbStockQuantity.AutoSize = true;
            this.lbStockQuantity.Location = new System.Drawing.Point(280, 283);
            this.lbStockQuantity.Name = "lbStockQuantity";
            this.lbStockQuantity.Size = new System.Drawing.Size(84, 25);
            this.lbStockQuantity.TabIndex = 12;
            this.lbStockQuantity.Text = "Quantity:";
            // 
            // tbxStockWeight
            // 
            this.tbxStockWeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockWeight.Location = new System.Drawing.Point(610, 310);
            this.tbxStockWeight.Name = "tbxStockWeight";
            this.tbxStockWeight.Size = new System.Drawing.Size(154, 31);
            this.tbxStockWeight.TabIndex = 22;
            // 
            // tbxStockWidth
            // 
            this.tbxStockWidth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockWidth.Location = new System.Drawing.Point(610, 127);
            this.tbxStockWidth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockWidth.Name = "tbxStockWidth";
            this.tbxStockWidth.Size = new System.Drawing.Size(154, 31);
            this.tbxStockWidth.TabIndex = 16;
            // 
            // stockWeightLb
            // 
            this.stockWeightLb.AutoSize = true;
            this.stockWeightLb.Location = new System.Drawing.Point(606, 287);
            this.stockWeightLb.Name = "stockWeightLb";
            this.stockWeightLb.Size = new System.Drawing.Size(72, 25);
            this.stockWeightLb.TabIndex = 2;
            this.stockWeightLb.Text = "Weight:";
            // 
            // tbxStockQuantity
            // 
            this.tbxStockQuantity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockQuantity.Location = new System.Drawing.Point(284, 307);
            this.tbxStockQuantity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockQuantity.Name = "tbxStockQuantity";
            this.tbxStockQuantity.Size = new System.Drawing.Size(154, 31);
            this.tbxStockQuantity.TabIndex = 13;
            // 
            // lbStockDimensions
            // 
            this.lbStockDimensions.AutoSize = true;
            this.lbStockDimensions.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbStockDimensions.Location = new System.Drawing.Point(606, 51);
            this.lbStockDimensions.Name = "lbStockDimensions";
            this.lbStockDimensions.Size = new System.Drawing.Size(140, 32);
            this.lbStockDimensions.TabIndex = 6;
            this.lbStockDimensions.Text = "Dimensions";
            // 
            // tbxStockDepth
            // 
            this.tbxStockDepth.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockDepth.Location = new System.Drawing.Point(610, 245);
            this.tbxStockDepth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockDepth.Name = "tbxStockDepth";
            this.tbxStockDepth.Size = new System.Drawing.Size(154, 31);
            this.tbxStockDepth.TabIndex = 20;
            // 
            // lbStockWidth
            // 
            this.lbStockWidth.AutoSize = true;
            this.lbStockWidth.Location = new System.Drawing.Point(606, 103);
            this.lbStockWidth.Name = "lbStockWidth";
            this.lbStockWidth.Size = new System.Drawing.Size(64, 25);
            this.lbStockWidth.TabIndex = 15;
            this.lbStockWidth.Text = "Width:";
            // 
            // btnAddStock
            // 
            this.btnAddStock.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddStock.Location = new System.Drawing.Point(399, 513);
            this.btnAddStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddStock.Name = "btnAddStock";
            this.btnAddStock.Size = new System.Drawing.Size(259, 61);
            this.btnAddStock.TabIndex = 14;
            this.btnAddStock.Text = "Add new stock";
            this.btnAddStock.UseVisualStyleBackColor = false;
            this.btnAddStock.Click += new System.EventHandler(this.BtnAddStock_Click);
            // 
            // lbStockHeight
            // 
            this.lbStockHeight.AutoSize = true;
            this.lbStockHeight.Location = new System.Drawing.Point(606, 158);
            this.lbStockHeight.Name = "lbStockHeight";
            this.lbStockHeight.Size = new System.Drawing.Size(69, 25);
            this.lbStockHeight.TabIndex = 17;
            this.lbStockHeight.Text = "Height:";
            // 
            // tbxStockPrice
            // 
            this.tbxStockPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockPrice.Location = new System.Drawing.Point(284, 252);
            this.tbxStockPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockPrice.Name = "tbxStockPrice";
            this.tbxStockPrice.Size = new System.Drawing.Size(154, 31);
            this.tbxStockPrice.TabIndex = 5;
            // 
            // lbStockBrand
            // 
            this.lbStockBrand.AutoSize = true;
            this.lbStockBrand.Location = new System.Drawing.Point(280, 109);
            this.lbStockBrand.Name = "lbStockBrand";
            this.lbStockBrand.Size = new System.Drawing.Size(62, 25);
            this.lbStockBrand.TabIndex = 0;
            this.lbStockBrand.Text = "Brand:";
            // 
            // tbxStockShortDescription
            // 
            this.tbxStockShortDescription.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockShortDescription.Location = new System.Drawing.Point(284, 405);
            this.tbxStockShortDescription.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockShortDescription.Multiline = true;
            this.tbxStockShortDescription.Name = "tbxStockShortDescription";
            this.tbxStockShortDescription.Size = new System.Drawing.Size(488, 74);
            this.tbxStockShortDescription.TabIndex = 9;
            // 
            // tbxStockBrand
            // 
            this.tbxStockBrand.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockBrand.Location = new System.Drawing.Point(284, 133);
            this.tbxStockBrand.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockBrand.Name = "tbxStockBrand";
            this.tbxStockBrand.Size = new System.Drawing.Size(230, 31);
            this.tbxStockBrand.TabIndex = 1;
            // 
            // lbStockPrice
            // 
            this.lbStockPrice.AutoSize = true;
            this.lbStockPrice.Location = new System.Drawing.Point(280, 228);
            this.lbStockPrice.Name = "lbStockPrice";
            this.lbStockPrice.Size = new System.Drawing.Size(53, 25);
            this.lbStockPrice.TabIndex = 4;
            this.lbStockPrice.Text = "Price:";
            // 
            // tbxStockHeight
            // 
            this.tbxStockHeight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockHeight.Location = new System.Drawing.Point(610, 185);
            this.tbxStockHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockHeight.Name = "tbxStockHeight";
            this.tbxStockHeight.Size = new System.Drawing.Size(154, 31);
            this.tbxStockHeight.TabIndex = 18;
            // 
            // lbStockDepth
            // 
            this.lbStockDepth.AutoSize = true;
            this.lbStockDepth.Location = new System.Drawing.Point(606, 221);
            this.lbStockDepth.Name = "lbStockDepth";
            this.lbStockDepth.Size = new System.Drawing.Size(65, 25);
            this.lbStockDepth.TabIndex = 19;
            this.lbStockDepth.Text = "Depth:";
            // 
            // lbStockModel
            // 
            this.lbStockModel.AutoSize = true;
            this.lbStockModel.Location = new System.Drawing.Point(280, 164);
            this.lbStockModel.Name = "lbStockModel";
            this.lbStockModel.Size = new System.Drawing.Size(67, 25);
            this.lbStockModel.TabIndex = 2;
            this.lbStockModel.Text = "Model:";
            // 
            // tbxStockModel
            // 
            this.tbxStockModel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxStockModel.Location = new System.Drawing.Point(284, 190);
            this.tbxStockModel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxStockModel.Name = "tbxStockModel";
            this.tbxStockModel.Size = new System.Drawing.Size(230, 31);
            this.tbxStockModel.TabIndex = 3;
            // 
            // ManageStocksTab
            // 
            this.ManageStocksTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ManageStocksTab.Controls.Add(this.dgvStock);
            this.ManageStocksTab.Controls.Add(this.btnShowAllStocks);
            this.ManageStocksTab.Controls.Add(this.gbxSearchStock);
            this.ManageStocksTab.Controls.Add(this.btnStocksClearSelected);
            this.ManageStocksTab.Controls.Add(this.btnEditStock);
            this.ManageStocksTab.Controls.Add(this.btnRemoveStock);
            this.ManageStocksTab.Location = new System.Drawing.Point(4, 34);
            this.ManageStocksTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageStocksTab.Name = "ManageStocksTab";
            this.ManageStocksTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageStocksTab.Size = new System.Drawing.Size(1082, 733);
            this.ManageStocksTab.TabIndex = 1;
            this.ManageStocksTab.Text = "Manage stocks";
            // 
            // dgvStock
            // 
            this.dgvStock.AllowUserToAddRows = false;
            this.dgvStock.AllowUserToDeleteRows = false;
            this.dgvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStock.Location = new System.Drawing.Point(10, 165);
            this.dgvStock.Name = "dgvStock";
            this.dgvStock.ReadOnly = true;
            this.dgvStock.RowHeadersWidth = 51;
            this.dgvStock.RowTemplate.Height = 24;
            this.dgvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStock.Size = new System.Drawing.Size(1066, 366);
            this.dgvStock.TabIndex = 24;
            // 
            // btnShowAllStocks
            // 
            this.btnShowAllStocks.BackColor = System.Drawing.Color.LightSalmon;
            this.btnShowAllStocks.Location = new System.Drawing.Point(42, 59);
            this.btnShowAllStocks.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnShowAllStocks.Name = "btnShowAllStocks";
            this.btnShowAllStocks.Size = new System.Drawing.Size(219, 51);
            this.btnShowAllStocks.TabIndex = 23;
            this.btnShowAllStocks.Text = "Show all stocks";
            this.btnShowAllStocks.UseVisualStyleBackColor = false;
            this.btnShowAllStocks.Click += new System.EventHandler(this.BtnShowAllStocks_Click);
            // 
            // gbxSearchStock
            // 
            this.gbxSearchStock.Controls.Add(this.tbxSearchStock);
            this.gbxSearchStock.Location = new System.Drawing.Point(333, 21);
            this.gbxSearchStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchStock.Name = "gbxSearchStock";
            this.gbxSearchStock.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchStock.Size = new System.Drawing.Size(403, 126);
            this.gbxSearchStock.TabIndex = 22;
            this.gbxSearchStock.TabStop = false;
            this.gbxSearchStock.Text = "Search for specific stock";
            // 
            // tbxSearchStock
            // 
            this.tbxSearchStock.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxSearchStock.Location = new System.Drawing.Point(11, 50);
            this.tbxSearchStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearchStock.Name = "tbxSearchStock";
            this.tbxSearchStock.Size = new System.Drawing.Size(344, 31);
            this.tbxSearchStock.TabIndex = 7;
            this.tbxSearchStock.TextChanged += new System.EventHandler(this.tbxSearchStock_TextChanged);
            // 
            // btnStocksClearSelected
            // 
            this.btnStocksClearSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.btnStocksClearSelected.Location = new System.Drawing.Point(42, 564);
            this.btnStocksClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnStocksClearSelected.Name = "btnStocksClearSelected";
            this.btnStocksClearSelected.Size = new System.Drawing.Size(219, 60);
            this.btnStocksClearSelected.TabIndex = 21;
            this.btnStocksClearSelected.Text = "Unmark selected";
            this.btnStocksClearSelected.UseVisualStyleBackColor = false;
            this.btnStocksClearSelected.Click += new System.EventHandler(this.btnStocksClearSelected_Click);
            // 
            // btnEditStock
            // 
            this.btnEditStock.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditStock.Location = new System.Drawing.Point(542, 564);
            this.btnEditStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditStock.Name = "btnEditStock";
            this.btnEditStock.Size = new System.Drawing.Size(219, 60);
            this.btnEditStock.TabIndex = 20;
            this.btnEditStock.Text = "Edit stock";
            this.btnEditStock.UseVisualStyleBackColor = false;
            this.btnEditStock.Click += new System.EventHandler(this.BtnEditStock_Click);
            // 
            // btnRemoveStock
            // 
            this.btnRemoveStock.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveStock.Location = new System.Drawing.Point(779, 564);
            this.btnRemoveStock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveStock.Name = "btnRemoveStock";
            this.btnRemoveStock.Size = new System.Drawing.Size(219, 60);
            this.btnRemoveStock.TabIndex = 19;
            this.btnRemoveStock.Text = "Remove stock";
            this.btnRemoveStock.UseVisualStyleBackColor = false;
            this.btnRemoveStock.Click += new System.EventHandler(this.BtnRemoveStock_Click);
            // 
            // SchedulingTab
            // 
            this.SchedulingTab.Controls.Add(this.tabControl1);
            this.SchedulingTab.Location = new System.Drawing.Point(4, 34);
            this.SchedulingTab.Name = "SchedulingTab";
            this.SchedulingTab.Size = new System.Drawing.Size(1097, 694);
            this.SchedulingTab.TabIndex = 7;
            this.SchedulingTab.Text = "Scheduling";
            this.SchedulingTab.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbWeeklySchedule);
            this.tabControl1.Controls.Add(this.tpManualSched);
            this.tabControl1.Controls.Add(this.tpManageAttendance);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1092, 820);
            this.tabControl1.TabIndex = 0;
            // 
            // tbWeeklySchedule
            // 
            this.tbWeeklySchedule.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tbWeeklySchedule.Controls.Add(this.btnGenAS);
            this.tbWeeklySchedule.Controls.Add(this.lbWeekNrAS);
            this.tbWeeklySchedule.Controls.Add(this.cbWeekAS);
            this.tbWeeklySchedule.Controls.Add(this.lbWeekNumber);
            this.tbWeeklySchedule.Controls.Add(this.cbWeekNumber);
            this.tbWeeklySchedule.Controls.Add(this.lbxWeeklySchedule);
            this.tbWeeklySchedule.Location = new System.Drawing.Point(4, 34);
            this.tbWeeklySchedule.Name = "tbWeeklySchedule";
            this.tbWeeklySchedule.Size = new System.Drawing.Size(1084, 782);
            this.tbWeeklySchedule.TabIndex = 3;
            this.tbWeeklySchedule.Text = "Weekly schedule";
            // 
            // btnGenAS
            // 
            this.btnGenAS.BackColor = System.Drawing.Color.LightSalmon;
            this.btnGenAS.Location = new System.Drawing.Point(858, 35);
            this.btnGenAS.Name = "btnGenAS";
            this.btnGenAS.Size = new System.Drawing.Size(170, 66);
            this.btnGenAS.TabIndex = 11;
            this.btnGenAS.Text = "Generate schedule";
            this.btnGenAS.UseVisualStyleBackColor = false;
            this.btnGenAS.Click += new System.EventHandler(this.btnGenAS_Click_1);
            // 
            // lbWeekNrAS
            // 
            this.lbWeekNrAS.AutoSize = true;
            this.lbWeekNrAS.Location = new System.Drawing.Point(731, 35);
            this.lbWeekNrAS.Name = "lbWeekNrAS";
            this.lbWeekNrAS.Size = new System.Drawing.Size(59, 25);
            this.lbWeekNrAS.TabIndex = 10;
            this.lbWeekNrAS.Text = "Week:";
            // 
            // cbWeekAS
            // 
            this.cbWeekAS.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbWeekAS.FormattingEnabled = true;
            this.cbWeekAS.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31",
            "32",
            "33",
            "34",
            "35",
            "36",
            "37",
            "38",
            "39",
            "40",
            "41",
            "42",
            "43",
            "44",
            "45",
            "46",
            "47",
            "48",
            "49",
            "50",
            "51",
            "52"});
            this.cbWeekAS.Location = new System.Drawing.Point(735, 58);
            this.cbWeekAS.Name = "cbWeekAS";
            this.cbWeekAS.Size = new System.Drawing.Size(108, 33);
            this.cbWeekAS.TabIndex = 9;
            // 
            // lbWeekNumber
            // 
            this.lbWeekNumber.AutoSize = true;
            this.lbWeekNumber.Location = new System.Drawing.Point(48, 35);
            this.lbWeekNumber.Name = "lbWeekNumber";
            this.lbWeekNumber.Size = new System.Drawing.Size(59, 25);
            this.lbWeekNumber.TabIndex = 5;
            this.lbWeekNumber.Text = "Week:";
            // 
            // cbWeekNumber
            // 
            this.cbWeekNumber.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbWeekNumber.FormattingEnabled = true;
            this.cbWeekNumber.Location = new System.Drawing.Point(52, 58);
            this.cbWeekNumber.Name = "cbWeekNumber";
            this.cbWeekNumber.Size = new System.Drawing.Size(108, 33);
            this.cbWeekNumber.TabIndex = 4;
            this.cbWeekNumber.SelectedIndexChanged += new System.EventHandler(this.cbWeekNumber_SelectedIndexChanged);
            // 
            // lbxWeeklySchedule
            // 
            this.lbxWeeklySchedule.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxWeeklySchedule.FormattingEnabled = true;
            this.lbxWeeklySchedule.ItemHeight = 25;
            this.lbxWeeklySchedule.Location = new System.Drawing.Point(52, 119);
            this.lbxWeeklySchedule.Name = "lbxWeeklySchedule";
            this.lbxWeeklySchedule.Size = new System.Drawing.Size(995, 479);
            this.lbxWeeklySchedule.TabIndex = 3;
            // 
            // tpManualSched
            // 
            this.tpManualSched.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tpManualSched.Controls.Add(this.gbViewRemoveShifts);
            this.tpManualSched.Controls.Add(this.gbAssignShiftManually);
            this.tpManualSched.Controls.Add(this.gbChooseEmp);
            this.tpManualSched.Location = new System.Drawing.Point(4, 34);
            this.tpManualSched.Name = "tpManualSched";
            this.tpManualSched.Size = new System.Drawing.Size(1084, 782);
            this.tpManualSched.TabIndex = 1;
            this.tpManualSched.Text = "Manual scheduling";
            // 
            // gbViewRemoveShifts
            // 
            this.gbViewRemoveShifts.Controls.Add(this.btnRemoveShift);
            this.gbViewRemoveShifts.Controls.Add(this.btnReturnViewRemove);
            this.gbViewRemoveShifts.Controls.Add(this.lbxSelectedEmpShifts);
            this.gbViewRemoveShifts.Controls.Add(this.btnScheduleClearSelected);
            this.gbViewRemoveShifts.Location = new System.Drawing.Point(404, 23);
            this.gbViewRemoveShifts.Name = "gbViewRemoveShifts";
            this.gbViewRemoveShifts.Size = new System.Drawing.Size(642, 634);
            this.gbViewRemoveShifts.TabIndex = 26;
            this.gbViewRemoveShifts.TabStop = false;
            this.gbViewRemoveShifts.Text = "View shifts";
            // 
            // btnRemoveShift
            // 
            this.btnRemoveShift.BackColor = System.Drawing.Color.OrangeRed;
            this.btnRemoveShift.Location = new System.Drawing.Point(340, 484);
            this.btnRemoveShift.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveShift.Name = "btnRemoveShift";
            this.btnRemoveShift.Size = new System.Drawing.Size(261, 49);
            this.btnRemoveShift.TabIndex = 27;
            this.btnRemoveShift.Text = "Remove selected";
            this.btnRemoveShift.UseVisualStyleBackColor = false;
            this.btnRemoveShift.Click += new System.EventHandler(this.btnShift_Click);
            // 
            // btnReturnViewRemove
            // 
            this.btnReturnViewRemove.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReturnViewRemove.Location = new System.Drawing.Point(25, 484);
            this.btnReturnViewRemove.Name = "btnReturnViewRemove";
            this.btnReturnViewRemove.Size = new System.Drawing.Size(172, 39);
            this.btnReturnViewRemove.TabIndex = 26;
            this.btnReturnViewRemove.Text = "Return to previous menu";
            this.btnReturnViewRemove.UseVisualStyleBackColor = false;
            this.btnReturnViewRemove.Click += new System.EventHandler(this.btnReturnViewRemove_Click);
            // 
            // lbxSelectedEmpShifts
            // 
            this.lbxSelectedEmpShifts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lbxSelectedEmpShifts.FormattingEnabled = true;
            this.lbxSelectedEmpShifts.HorizontalScrollbar = true;
            this.lbxSelectedEmpShifts.ItemHeight = 25;
            this.lbxSelectedEmpShifts.Location = new System.Drawing.Point(25, 51);
            this.lbxSelectedEmpShifts.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxSelectedEmpShifts.Name = "lbxSelectedEmpShifts";
            this.lbxSelectedEmpShifts.Size = new System.Drawing.Size(576, 404);
            this.lbxSelectedEmpShifts.TabIndex = 15;
            // 
            // btnScheduleClearSelected
            // 
            this.btnScheduleClearSelected.BackColor = System.Drawing.Color.LightSalmon;
            this.btnScheduleClearSelected.Location = new System.Drawing.Point(25, 530);
            this.btnScheduleClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnScheduleClearSelected.Name = "btnScheduleClearSelected";
            this.btnScheduleClearSelected.Size = new System.Drawing.Size(172, 39);
            this.btnScheduleClearSelected.TabIndex = 10;
            this.btnScheduleClearSelected.Text = "Unmark selections";
            this.btnScheduleClearSelected.UseVisualStyleBackColor = false;
            this.btnScheduleClearSelected.Click += new System.EventHandler(this.btnScheduleClearSelected_Click_1);
            // 
            // gbAssignShiftManually
            // 
            this.gbAssignShiftManually.Controls.Add(this.btnReturnAssign);
            this.gbAssignShiftManually.Controls.Add(this.cbWFH);
            this.gbAssignShiftManually.Controls.Add(this.lbEmpInfo);
            this.gbAssignShiftManually.Controls.Add(this.lbWFH);
            this.gbAssignShiftManually.Controls.Add(this.btnAssign);
            this.gbAssignShiftManually.Controls.Add(this.lbShiftType);
            this.gbAssignShiftManually.Controls.Add(this.dtpShiftDate);
            this.gbAssignShiftManually.Controls.Add(this.lbShiftDate);
            this.gbAssignShiftManually.Controls.Add(this.cbShiftType);
            this.gbAssignShiftManually.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbAssignShiftManually.Location = new System.Drawing.Point(3, 288);
            this.gbAssignShiftManually.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAssignShiftManually.Name = "gbAssignShiftManually";
            this.gbAssignShiftManually.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbAssignShiftManually.Size = new System.Drawing.Size(384, 369);
            this.gbAssignShiftManually.TabIndex = 25;
            this.gbAssignShiftManually.TabStop = false;
            this.gbAssignShiftManually.Text = "Assign work shift";
            // 
            // btnReturnAssign
            // 
            this.btnReturnAssign.BackColor = System.Drawing.Color.LightSalmon;
            this.btnReturnAssign.Location = new System.Drawing.Point(8, 303);
            this.btnReturnAssign.Name = "btnReturnAssign";
            this.btnReturnAssign.Size = new System.Drawing.Size(139, 39);
            this.btnReturnAssign.TabIndex = 25;
            this.btnReturnAssign.Text = "Return to previous menu";
            this.btnReturnAssign.UseVisualStyleBackColor = false;
            this.btnReturnAssign.Click += new System.EventHandler(this.btnReturnAssign_Click);
            // 
            // cbWFH
            // 
            this.cbWFH.AutoSize = true;
            this.cbWFH.Location = new System.Drawing.Point(83, 239);
            this.cbWFH.Name = "cbWFH";
            this.cbWFH.Size = new System.Drawing.Size(191, 26);
            this.cbWFH.TabIndex = 9;
            this.cbWFH.Text = "Working from home";
            this.cbWFH.UseVisualStyleBackColor = true;
            // 
            // lbEmpInfo
            // 
            this.lbEmpInfo.AutoSize = true;
            this.lbEmpInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.lbEmpInfo.Location = new System.Drawing.Point(78, 39);
            this.lbEmpInfo.Name = "lbEmpInfo";
            this.lbEmpInfo.Size = new System.Drawing.Size(244, 32);
            this.lbEmpInfo.TabIndex = 24;
            this.lbEmpInfo.Text = "Employee with Id:(id)";
            // 
            // lbWFH
            // 
            this.lbWFH.AutoSize = true;
            this.lbWFH.Location = new System.Drawing.Point(5, 176);
            this.lbWFH.Name = "lbWFH";
            this.lbWFH.Size = new System.Drawing.Size(0, 22);
            this.lbWFH.TabIndex = 8;
            // 
            // btnAssign
            // 
            this.btnAssign.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAssign.Location = new System.Drawing.Point(153, 303);
            this.btnAssign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAssign.Name = "btnAssign";
            this.btnAssign.Size = new System.Drawing.Size(210, 39);
            this.btnAssign.TabIndex = 7;
            this.btnAssign.Text = "Assign shift to employee";
            this.btnAssign.UseVisualStyleBackColor = false;
            this.btnAssign.Click += new System.EventHandler(this.btnAssign_Click);
            // 
            // lbShiftType
            // 
            this.lbShiftType.AutoSize = true;
            this.lbShiftType.Location = new System.Drawing.Point(80, 112);
            this.lbShiftType.Name = "lbShiftType";
            this.lbShiftType.Size = new System.Drawing.Size(90, 22);
            this.lbShiftType.TabIndex = 1;
            this.lbShiftType.Text = "Shift type:";
            // 
            // dtpShiftDate
            // 
            this.dtpShiftDate.Location = new System.Drawing.Point(83, 197);
            this.dtpShiftDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpShiftDate.Name = "dtpShiftDate";
            this.dtpShiftDate.Size = new System.Drawing.Size(200, 28);
            this.dtpShiftDate.TabIndex = 6;
            // 
            // lbShiftDate
            // 
            this.lbShiftDate.AutoSize = true;
            this.lbShiftDate.Location = new System.Drawing.Point(80, 175);
            this.lbShiftDate.Name = "lbShiftDate";
            this.lbShiftDate.Size = new System.Drawing.Size(147, 22);
            this.lbShiftDate.TabIndex = 3;
            this.lbShiftDate.Text = "Date for the shift:";
            // 
            // cbShiftType
            // 
            this.cbShiftType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbShiftType.FormattingEnabled = true;
            this.cbShiftType.Items.AddRange(new object[] {
            "Morning",
            "Afternoon",
            "Evening"});
            this.cbShiftType.Location = new System.Drawing.Point(83, 134);
            this.cbShiftType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbShiftType.Name = "cbShiftType";
            this.cbShiftType.Size = new System.Drawing.Size(200, 30);
            this.cbShiftType.TabIndex = 5;
            this.cbShiftType.Text = "Choose shift type";
            // 
            // gbChooseEmp
            // 
            this.gbChooseEmp.Controls.Add(this.lbEmp);
            this.gbChooseEmp.Controls.Add(this.lbDep);
            this.gbChooseEmp.Controls.Add(this.btnAddShift);
            this.gbChooseEmp.Controls.Add(this.btnViewRemoveShifts);
            this.gbChooseEmp.Controls.Add(this.cbEmps);
            this.gbChooseEmp.Controls.Add(this.cbDeps);
            this.gbChooseEmp.Location = new System.Drawing.Point(3, 13);
            this.gbChooseEmp.Name = "gbChooseEmp";
            this.gbChooseEmp.Size = new System.Drawing.Size(384, 267);
            this.gbChooseEmp.TabIndex = 23;
            this.gbChooseEmp.TabStop = false;
            this.gbChooseEmp.Text = "Choose employee to manage";
            // 
            // lbEmp
            // 
            this.lbEmp.AutoSize = true;
            this.lbEmp.Location = new System.Drawing.Point(69, 109);
            this.lbEmp.Name = "lbEmp";
            this.lbEmp.Size = new System.Drawing.Size(94, 25);
            this.lbEmp.TabIndex = 5;
            this.lbEmp.Text = "Employee:";
            // 
            // lbDep
            // 
            this.lbDep.AutoSize = true;
            this.lbDep.Location = new System.Drawing.Point(66, 51);
            this.lbDep.Name = "lbDep";
            this.lbDep.Size = new System.Drawing.Size(111, 25);
            this.lbDep.TabIndex = 4;
            this.lbDep.Text = "Department:";
            // 
            // btnAddShift
            // 
            this.btnAddShift.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddShift.Location = new System.Drawing.Point(31, 186);
            this.btnAddShift.Name = "btnAddShift";
            this.btnAddShift.Size = new System.Drawing.Size(127, 41);
            this.btnAddShift.TabIndex = 3;
            this.btnAddShift.Text = "Add shift";
            this.btnAddShift.UseVisualStyleBackColor = false;
            this.btnAddShift.Click += new System.EventHandler(this.btnAddShift_Click);
            // 
            // btnViewRemoveShifts
            // 
            this.btnViewRemoveShifts.BackColor = System.Drawing.Color.LightSalmon;
            this.btnViewRemoveShifts.Location = new System.Drawing.Point(164, 186);
            this.btnViewRemoveShifts.Name = "btnViewRemoveShifts";
            this.btnViewRemoveShifts.Size = new System.Drawing.Size(157, 41);
            this.btnViewRemoveShifts.TabIndex = 2;
            this.btnViewRemoveShifts.Text = "View shifts";
            this.btnViewRemoveShifts.UseVisualStyleBackColor = false;
            this.btnViewRemoveShifts.Click += new System.EventHandler(this.btnViewRemoveShifts_Click);
            // 
            // cbEmps
            // 
            this.cbEmps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmps.FormattingEnabled = true;
            this.cbEmps.Location = new System.Drawing.Point(70, 132);
            this.cbEmps.Name = "cbEmps";
            this.cbEmps.Size = new System.Drawing.Size(202, 33);
            this.cbEmps.TabIndex = 1;
            // 
            // cbDeps
            // 
            this.cbDeps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDeps.FormattingEnabled = true;
            this.cbDeps.Location = new System.Drawing.Point(70, 74);
            this.cbDeps.Name = "cbDeps";
            this.cbDeps.Size = new System.Drawing.Size(202, 33);
            this.cbDeps.TabIndex = 0;
            this.cbDeps.SelectedIndexChanged += new System.EventHandler(this.cbDeps_SelectedIndexChanged);
            // 
            // tpManageAttendance
            // 
            this.tpManageAttendance.BackColor = System.Drawing.Color.MediumTurquoise;
            this.tpManageAttendance.Controls.Add(this.btnApplyAttendanceChanges);
            this.tpManageAttendance.Controls.Add(this.tbReasonForAbsence);
            this.tpManageAttendance.Controls.Add(this.cbHasAttended);
            this.tpManageAttendance.Controls.Add(this.lbReason);
            this.tpManageAttendance.Controls.Add(this.lbHasAttended);
            this.tpManageAttendance.Controls.Add(this.lbShift);
            this.tpManageAttendance.Controls.Add(this.cbEmployeesShifts);
            this.tpManageAttendance.Controls.Add(this.lbSelectedEmp);
            this.tpManageAttendance.Controls.Add(this.lbSelectedDep);
            this.tpManageAttendance.Controls.Add(this.cbSelectedEmp);
            this.tpManageAttendance.Controls.Add(this.cbAllDeps);
            this.tpManageAttendance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpManageAttendance.Location = new System.Drawing.Point(4, 34);
            this.tpManageAttendance.Name = "tpManageAttendance";
            this.tpManageAttendance.Size = new System.Drawing.Size(1084, 782);
            this.tpManageAttendance.TabIndex = 2;
            this.tpManageAttendance.Text = "Manage attendance";
            // 
            // btnApplyAttendanceChanges
            // 
            this.btnApplyAttendanceChanges.BackColor = System.Drawing.Color.OrangeRed;
            this.btnApplyAttendanceChanges.Location = new System.Drawing.Point(395, 385);
            this.btnApplyAttendanceChanges.Name = "btnApplyAttendanceChanges";
            this.btnApplyAttendanceChanges.Size = new System.Drawing.Size(254, 52);
            this.btnApplyAttendanceChanges.TabIndex = 17;
            this.btnApplyAttendanceChanges.Text = "Apply changes";
            this.btnApplyAttendanceChanges.UseVisualStyleBackColor = false;
            this.btnApplyAttendanceChanges.Click += new System.EventHandler(this.btnApplyAttendanceChanges_Click);
            // 
            // tbReasonForAbsence
            // 
            this.tbReasonForAbsence.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbReasonForAbsence.Location = new System.Drawing.Point(395, 340);
            this.tbReasonForAbsence.Name = "tbReasonForAbsence";
            this.tbReasonForAbsence.Size = new System.Drawing.Size(254, 31);
            this.tbReasonForAbsence.TabIndex = 16;
            this.tbReasonForAbsence.Visible = false;
            // 
            // cbHasAttended
            // 
            this.cbHasAttended.AutoSize = true;
            this.cbHasAttended.BackColor = System.Drawing.Color.Transparent;
            this.cbHasAttended.Location = new System.Drawing.Point(395, 290);
            this.cbHasAttended.Name = "cbHasAttended";
            this.cbHasAttended.Size = new System.Drawing.Size(257, 29);
            this.cbHasAttended.TabIndex = 15;
            this.cbHasAttended.Text = "The employee has attended";
            this.cbHasAttended.UseVisualStyleBackColor = false;
            this.cbHasAttended.Visible = false;
            // 
            // lbReason
            // 
            this.lbReason.AutoSize = true;
            this.lbReason.Location = new System.Drawing.Point(391, 317);
            this.lbReason.Name = "lbReason";
            this.lbReason.Size = new System.Drawing.Size(73, 25);
            this.lbReason.TabIndex = 14;
            this.lbReason.Text = "Reason:";
            this.lbReason.Visible = false;
            // 
            // lbHasAttended
            // 
            this.lbHasAttended.AutoSize = true;
            this.lbHasAttended.Location = new System.Drawing.Point(391, 262);
            this.lbHasAttended.Name = "lbHasAttended";
            this.lbHasAttended.Size = new System.Drawing.Size(90, 25);
            this.lbHasAttended.TabIndex = 13;
            this.lbHasAttended.Text = "Attended:";
            this.lbHasAttended.Visible = false;
            // 
            // lbShift
            // 
            this.lbShift.AutoSize = true;
            this.lbShift.Location = new System.Drawing.Point(391, 208);
            this.lbShift.Name = "lbShift";
            this.lbShift.Size = new System.Drawing.Size(52, 25);
            this.lbShift.TabIndex = 12;
            this.lbShift.Text = "Shift:";
            // 
            // cbEmployeesShifts
            // 
            this.cbEmployeesShifts.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmployeesShifts.FormattingEnabled = true;
            this.cbEmployeesShifts.Location = new System.Drawing.Point(395, 231);
            this.cbEmployeesShifts.Name = "cbEmployeesShifts";
            this.cbEmployeesShifts.Size = new System.Drawing.Size(254, 33);
            this.cbEmployeesShifts.TabIndex = 10;
            this.cbEmployeesShifts.SelectedIndexChanged += new System.EventHandler(this.cbEmployeesShifts_SelectedIndexChanged);
            // 
            // lbSelectedEmp
            // 
            this.lbSelectedEmp.AutoSize = true;
            this.lbSelectedEmp.Location = new System.Drawing.Point(391, 154);
            this.lbSelectedEmp.Name = "lbSelectedEmp";
            this.lbSelectedEmp.Size = new System.Drawing.Size(94, 25);
            this.lbSelectedEmp.TabIndex = 9;
            this.lbSelectedEmp.Text = "Employee:";
            // 
            // lbSelectedDep
            // 
            this.lbSelectedDep.AutoSize = true;
            this.lbSelectedDep.Location = new System.Drawing.Point(391, 95);
            this.lbSelectedDep.Name = "lbSelectedDep";
            this.lbSelectedDep.Size = new System.Drawing.Size(111, 25);
            this.lbSelectedDep.TabIndex = 8;
            this.lbSelectedDep.Text = "Department:";
            // 
            // cbSelectedEmp
            // 
            this.cbSelectedEmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSelectedEmp.FormattingEnabled = true;
            this.cbSelectedEmp.Location = new System.Drawing.Point(395, 177);
            this.cbSelectedEmp.Name = "cbSelectedEmp";
            this.cbSelectedEmp.Size = new System.Drawing.Size(254, 33);
            this.cbSelectedEmp.TabIndex = 7;
            this.cbSelectedEmp.SelectedIndexChanged += new System.EventHandler(this.cbSelectedEmp_SelectedIndexChanged);
            // 
            // cbAllDeps
            // 
            this.cbAllDeps.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbAllDeps.FormattingEnabled = true;
            this.cbAllDeps.Location = new System.Drawing.Point(395, 118);
            this.cbAllDeps.Name = "cbAllDeps";
            this.cbAllDeps.Size = new System.Drawing.Size(254, 33);
            this.cbAllDeps.TabIndex = 6;
            this.cbAllDeps.SelectedIndexChanged += new System.EventHandler(this.cbAllDeps_SelectedIndexChanged);
            // 
            // EmployeesTab
            // 
            this.EmployeesTab.Controls.Add(this.tabControlEmployees);
            this.EmployeesTab.Location = new System.Drawing.Point(4, 34);
            this.EmployeesTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeesTab.Name = "EmployeesTab";
            this.EmployeesTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.EmployeesTab.Size = new System.Drawing.Size(1097, 694);
            this.EmployeesTab.TabIndex = 1;
            this.EmployeesTab.Text = "Employees";
            this.EmployeesTab.UseVisualStyleBackColor = true;
            // 
            // tabControlEmployees
            // 
            this.tabControlEmployees.Controls.Add(this.AddEmpTab);
            this.tabControlEmployees.Controls.Add(this.ManageEmpTab);
            this.tabControlEmployees.Controls.Add(this.HolidayRequestsTab);
            this.tabControlEmployees.Location = new System.Drawing.Point(0, 8);
            this.tabControlEmployees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlEmployees.Name = "tabControlEmployees";
            this.tabControlEmployees.SelectedIndex = 0;
            this.tabControlEmployees.Size = new System.Drawing.Size(1101, 821);
            this.tabControlEmployees.TabIndex = 0;
            this.tabControlEmployees.Selected += new System.Windows.Forms.TabControlEventHandler(this.tabControlEmployees_Selected);
            // 
            // AddEmpTab
            // 
            this.AddEmpTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.AddEmpTab.Controls.Add(this.dtpEmpEndDate);
            this.AddEmpTab.Controls.Add(this.lbEmpEndDate);
            this.AddEmpTab.Controls.Add(this.dtpEmpStartDate);
            this.AddEmpTab.Controls.Add(this.lbEmpStartDate);
            this.AddEmpTab.Controls.Add(this.lbEmpNationality);
            this.AddEmpTab.Controls.Add(this.tbxEmpNationality);
            this.AddEmpTab.Controls.Add(this.cbEmConRelation);
            this.AddEmpTab.Controls.Add(this.lbEmConRelation);
            this.AddEmpTab.Controls.Add(this.tbxEmConName);
            this.AddEmpTab.Controls.Add(this.lbEmConName);
            this.AddEmpTab.Controls.Add(this.tbxEmConEmail);
            this.AddEmpTab.Controls.Add(this.lbEmConEmail);
            this.AddEmpTab.Controls.Add(this.tbxEmConPhone);
            this.AddEmpTab.Controls.Add(this.lbEmConPhone);
            this.AddEmpTab.Controls.Add(this.lbEmpEmConDetails);
            this.AddEmpTab.Controls.Add(this.lbEmpBsn);
            this.AddEmpTab.Controls.Add(this.tbxEmpBsn);
            this.AddEmpTab.Controls.Add(this.nudEmpHourlyWages);
            this.AddEmpTab.Controls.Add(this.cbEmpDepartment);
            this.AddEmpTab.Controls.Add(this.lbEmpDepartment);
            this.AddEmpTab.Controls.Add(this.cbEmpEmploymentType);
            this.AddEmpTab.Controls.Add(this.lbEmpJobSpec);
            this.AddEmpTab.Controls.Add(this.lbEmpAddressStreet);
            this.AddEmpTab.Controls.Add(this.lbEmpPersonalInfo);
            this.AddEmpTab.Controls.Add(this.tbxEmpAddressStreet);
            this.AddEmpTab.Controls.Add(this.tbxEmpAddressCity);
            this.AddEmpTab.Controls.Add(this.cbEmpGender);
            this.AddEmpTab.Controls.Add(this.lbEmpAddressCity);
            this.AddEmpTab.Controls.Add(this.tbxEmpEmail);
            this.AddEmpTab.Controls.Add(this.tbxEmpAddressCountry);
            this.AddEmpTab.Controls.Add(this.lbEmpEmail);
            this.AddEmpTab.Controls.Add(this.lbEmpAddressPostCode);
            this.AddEmpTab.Controls.Add(this.label1);
            this.AddEmpTab.Controls.Add(this.lbEmpAddressCountry);
            this.AddEmpTab.Controls.Add(this.dtpEmpDateOfBirth);
            this.AddEmpTab.Controls.Add(this.tbxEmpAddressPostCode);
            this.AddEmpTab.Controls.Add(this.btnAddEmpoyee);
            this.AddEmpTab.Controls.Add(this.lbEmpEmployementType);
            this.AddEmpTab.Controls.Add(this.lbEmpDateOfBirth);
            this.AddEmpTab.Controls.Add(this.lbEmpHourlyWages);
            this.AddEmpTab.Controls.Add(this.tbxEmpPhone);
            this.AddEmpTab.Controls.Add(this.lbEmpPhone);
            this.AddEmpTab.Controls.Add(this.lbEmployeeAddress);
            this.AddEmpTab.Controls.Add(this.tbxEmpLname);
            this.AddEmpTab.Controls.Add(this.lbEmpLname);
            this.AddEmpTab.Controls.Add(this.tbxEmpFname);
            this.AddEmpTab.Controls.Add(this.lbEmpFname);
            this.AddEmpTab.Location = new System.Drawing.Point(4, 34);
            this.AddEmpTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmpTab.Name = "AddEmpTab";
            this.AddEmpTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.AddEmpTab.Size = new System.Drawing.Size(1093, 783);
            this.AddEmpTab.TabIndex = 0;
            this.AddEmpTab.Text = "AddEmployees";
            // 
            // dtpEmpEndDate
            // 
            this.dtpEmpEndDate.Location = new System.Drawing.Point(266, 364);
            this.dtpEmpEndDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpEndDate.Name = "dtpEmpEndDate";
            this.dtpEmpEndDate.Size = new System.Drawing.Size(161, 31);
            this.dtpEmpEndDate.TabIndex = 81;
            // 
            // lbEmpEndDate
            // 
            this.lbEmpEndDate.AutoSize = true;
            this.lbEmpEndDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEndDate.Location = new System.Drawing.Point(261, 333);
            this.lbEmpEndDate.Name = "lbEmpEndDate";
            this.lbEmpEndDate.Size = new System.Drawing.Size(80, 25);
            this.lbEmpEndDate.TabIndex = 80;
            this.lbEmpEndDate.Text = "End date";
            // 
            // dtpEmpStartDate
            // 
            this.dtpEmpStartDate.Location = new System.Drawing.Point(266, 291);
            this.dtpEmpStartDate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpStartDate.Name = "dtpEmpStartDate";
            this.dtpEmpStartDate.Size = new System.Drawing.Size(161, 31);
            this.dtpEmpStartDate.TabIndex = 79;
            // 
            // lbEmpStartDate
            // 
            this.lbEmpStartDate.AutoSize = true;
            this.lbEmpStartDate.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpStartDate.Location = new System.Drawing.Point(261, 262);
            this.lbEmpStartDate.Name = "lbEmpStartDate";
            this.lbEmpStartDate.Size = new System.Drawing.Size(87, 25);
            this.lbEmpStartDate.TabIndex = 78;
            this.lbEmpStartDate.Text = "Start date";
            // 
            // lbEmpNationality
            // 
            this.lbEmpNationality.AutoSize = true;
            this.lbEmpNationality.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpNationality.Location = new System.Drawing.Point(14, 391);
            this.lbEmpNationality.Name = "lbEmpNationality";
            this.lbEmpNationality.Size = new System.Drawing.Size(95, 25);
            this.lbEmpNationality.TabIndex = 72;
            this.lbEmpNationality.Text = "Nationality";
            // 
            // tbxEmpNationality
            // 
            this.tbxEmpNationality.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpNationality.Location = new System.Drawing.Point(19, 420);
            this.tbxEmpNationality.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpNationality.Name = "tbxEmpNationality";
            this.tbxEmpNationality.Size = new System.Drawing.Size(161, 31);
            this.tbxEmpNationality.TabIndex = 73;
            // 
            // cbEmConRelation
            // 
            this.cbEmConRelation.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmConRelation.FormattingEnabled = true;
            this.cbEmConRelation.Items.AddRange(new object[] {
            "Family",
            "Friend",
            "Colleague",
            "Other"});
            this.cbEmConRelation.Location = new System.Drawing.Point(757, 154);
            this.cbEmConRelation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmConRelation.Name = "cbEmConRelation";
            this.cbEmConRelation.Size = new System.Drawing.Size(167, 33);
            this.cbEmConRelation.TabIndex = 58;
            // 
            // lbEmConRelation
            // 
            this.lbEmConRelation.AutoSize = true;
            this.lbEmConRelation.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmConRelation.Location = new System.Drawing.Point(752, 131);
            this.lbEmConRelation.Name = "lbEmConRelation";
            this.lbEmConRelation.Size = new System.Drawing.Size(73, 25);
            this.lbEmConRelation.TabIndex = 56;
            this.lbEmConRelation.Text = "Relation";
            // 
            // tbxEmConName
            // 
            this.tbxEmConName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmConName.Location = new System.Drawing.Point(756, 99);
            this.tbxEmConName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmConName.Name = "tbxEmConName";
            this.tbxEmConName.Size = new System.Drawing.Size(168, 31);
            this.tbxEmConName.TabIndex = 55;
            // 
            // lbEmConName
            // 
            this.lbEmConName.AutoSize = true;
            this.lbEmConName.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmConName.Location = new System.Drawing.Point(752, 75);
            this.lbEmConName.Name = "lbEmConName";
            this.lbEmConName.Size = new System.Drawing.Size(58, 25);
            this.lbEmConName.TabIndex = 54;
            this.lbEmConName.Text = "Name";
            // 
            // tbxEmConEmail
            // 
            this.tbxEmConEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmConEmail.Location = new System.Drawing.Point(756, 220);
            this.tbxEmConEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmConEmail.Name = "tbxEmConEmail";
            this.tbxEmConEmail.Size = new System.Drawing.Size(168, 31);
            this.tbxEmConEmail.TabIndex = 61;
            // 
            // lbEmConEmail
            // 
            this.lbEmConEmail.AutoSize = true;
            this.lbEmConEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmConEmail.Location = new System.Drawing.Point(755, 196);
            this.lbEmConEmail.Name = "lbEmConEmail";
            this.lbEmConEmail.Size = new System.Drawing.Size(53, 25);
            this.lbEmConEmail.TabIndex = 57;
            this.lbEmConEmail.Text = "Email";
            // 
            // tbxEmConPhone
            // 
            this.tbxEmConPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmConPhone.Location = new System.Drawing.Point(756, 284);
            this.tbxEmConPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmConPhone.Name = "tbxEmConPhone";
            this.tbxEmConPhone.Size = new System.Drawing.Size(168, 31);
            this.tbxEmConPhone.TabIndex = 59;
            // 
            // lbEmConPhone
            // 
            this.lbEmConPhone.AutoSize = true;
            this.lbEmConPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmConPhone.Location = new System.Drawing.Point(755, 260);
            this.lbEmConPhone.Name = "lbEmConPhone";
            this.lbEmConPhone.Size = new System.Drawing.Size(61, 25);
            this.lbEmConPhone.TabIndex = 60;
            this.lbEmConPhone.Text = "Phone";
            // 
            // lbEmpEmConDetails
            // 
            this.lbEmpEmConDetails.AutoSize = true;
            this.lbEmpEmConDetails.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEmConDetails.Location = new System.Drawing.Point(754, 35);
            this.lbEmpEmConDetails.Name = "lbEmpEmConDetails";
            this.lbEmpEmConDetails.Size = new System.Drawing.Size(300, 32);
            this.lbEmpEmConDetails.TabIndex = 63;
            this.lbEmpEmConDetails.Text = "Emergency contact details";
            // 
            // lbEmpBsn
            // 
            this.lbEmpBsn.AutoSize = true;
            this.lbEmpBsn.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpBsn.Location = new System.Drawing.Point(15, 325);
            this.lbEmpBsn.Name = "lbEmpBsn";
            this.lbEmpBsn.Size = new System.Drawing.Size(44, 25);
            this.lbEmpBsn.TabIndex = 52;
            this.lbEmpBsn.Text = "BSN";
            // 
            // tbxEmpBsn
            // 
            this.tbxEmpBsn.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpBsn.Location = new System.Drawing.Point(19, 349);
            this.tbxEmpBsn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpBsn.Name = "tbxEmpBsn";
            this.tbxEmpBsn.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpBsn.TabIndex = 53;
            // 
            // nudEmpHourlyWages
            // 
            this.nudEmpHourlyWages.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nudEmpHourlyWages.Location = new System.Drawing.Point(265, 159);
            this.nudEmpHourlyWages.Name = "nudEmpHourlyWages";
            this.nudEmpHourlyWages.Size = new System.Drawing.Size(160, 31);
            this.nudEmpHourlyWages.TabIndex = 35;
            this.nudEmpHourlyWages.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nudEmpHourlyWages.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // cbEmpDepartment
            // 
            this.cbEmpDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmpDepartment.FormattingEnabled = true;
            this.cbEmpDepartment.Location = new System.Drawing.Point(265, 222);
            this.cbEmpDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpDepartment.Name = "cbEmpDepartment";
            this.cbEmpDepartment.Size = new System.Drawing.Size(160, 33);
            this.cbEmpDepartment.TabIndex = 37;
            // 
            // lbEmpDepartment
            // 
            this.lbEmpDepartment.AutoSize = true;
            this.lbEmpDepartment.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpDepartment.Location = new System.Drawing.Point(261, 198);
            this.lbEmpDepartment.Name = "lbEmpDepartment";
            this.lbEmpDepartment.Size = new System.Drawing.Size(105, 25);
            this.lbEmpDepartment.TabIndex = 38;
            this.lbEmpDepartment.Text = "Department";
            // 
            // cbEmpEmploymentType
            // 
            this.cbEmpEmploymentType.AutoCompleteCustomSource.AddRange(new string[] {
            "Full-time",
            "Part-time"});
            this.cbEmpEmploymentType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmpEmploymentType.FormattingEnabled = true;
            this.cbEmpEmploymentType.Items.AddRange(new object[] {
            "FULLTIME",
            "PARTTIME1",
            "PARTTIME2"});
            this.cbEmpEmploymentType.Location = new System.Drawing.Point(265, 102);
            this.cbEmpEmploymentType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpEmploymentType.Name = "cbEmpEmploymentType";
            this.cbEmpEmploymentType.Size = new System.Drawing.Size(160, 33);
            this.cbEmpEmploymentType.TabIndex = 32;
            // 
            // lbEmpJobSpec
            // 
            this.lbEmpJobSpec.AutoSize = true;
            this.lbEmpJobSpec.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpJobSpec.Location = new System.Drawing.Point(260, 35);
            this.lbEmpJobSpec.Name = "lbEmpJobSpec";
            this.lbEmpJobSpec.Size = new System.Drawing.Size(205, 32);
            this.lbEmpJobSpec.TabIndex = 33;
            this.lbEmpJobSpec.Text = "Job specifications";
            // 
            // lbEmpAddressStreet
            // 
            this.lbEmpAddressStreet.AutoSize = true;
            this.lbEmpAddressStreet.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpAddressStreet.Location = new System.Drawing.Point(498, 195);
            this.lbEmpAddressStreet.Name = "lbEmpAddressStreet";
            this.lbEmpAddressStreet.Size = new System.Drawing.Size(211, 25);
            this.lbEmpAddressStreet.TabIndex = 45;
            this.lbEmpAddressStreet.Text = "Address(Street + Number)";
            // 
            // lbEmpPersonalInfo
            // 
            this.lbEmpPersonalInfo.AutoSize = true;
            this.lbEmpPersonalInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpPersonalInfo.Location = new System.Drawing.Point(13, 35);
            this.lbEmpPersonalInfo.Name = "lbEmpPersonalInfo";
            this.lbEmpPersonalInfo.Size = new System.Drawing.Size(242, 32);
            this.lbEmpPersonalInfo.TabIndex = 25;
            this.lbEmpPersonalInfo.Text = "Personal information";
            // 
            // tbxEmpAddressStreet
            // 
            this.tbxEmpAddressStreet.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressStreet.Location = new System.Drawing.Point(502, 221);
            this.tbxEmpAddressStreet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressStreet.Name = "tbxEmpAddressStreet";
            this.tbxEmpAddressStreet.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpAddressStreet.TabIndex = 44;
            // 
            // tbxEmpAddressCity
            // 
            this.tbxEmpAddressCity.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressCity.Location = new System.Drawing.Point(502, 284);
            this.tbxEmpAddressCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressCity.Name = "tbxEmpAddressCity";
            this.tbxEmpAddressCity.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpAddressCity.TabIndex = 46;
            // 
            // cbEmpGender
            // 
            this.cbEmpGender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbEmpGender.FormattingEnabled = true;
            this.cbEmpGender.Items.AddRange(new object[] {
            "MALE",
            "FEMALE",
            "NONBINARY",
            "OTHER"});
            this.cbEmpGender.Location = new System.Drawing.Point(19, 289);
            this.cbEmpGender.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbEmpGender.Name = "cbEmpGender";
            this.cbEmpGender.Size = new System.Drawing.Size(161, 33);
            this.cbEmpGender.TabIndex = 31;
            this.cbEmpGender.Text = "Choose gender";
            // 
            // lbEmpAddressCity
            // 
            this.lbEmpAddressCity.AutoSize = true;
            this.lbEmpAddressCity.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpAddressCity.Location = new System.Drawing.Point(498, 259);
            this.lbEmpAddressCity.Name = "lbEmpAddressCity";
            this.lbEmpAddressCity.Size = new System.Drawing.Size(41, 25);
            this.lbEmpAddressCity.TabIndex = 47;
            this.lbEmpAddressCity.Text = "City";
            // 
            // tbxEmpEmail
            // 
            this.tbxEmpEmail.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpEmail.Location = new System.Drawing.Point(502, 98);
            this.tbxEmpEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpEmail.Name = "tbxEmpEmail";
            this.tbxEmpEmail.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpEmail.TabIndex = 41;
            // 
            // tbxEmpAddressCountry
            // 
            this.tbxEmpAddressCountry.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressCountry.Location = new System.Drawing.Point(502, 349);
            this.tbxEmpAddressCountry.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressCountry.Name = "tbxEmpAddressCountry";
            this.tbxEmpAddressCountry.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpAddressCountry.TabIndex = 48;
            // 
            // lbEmpEmail
            // 
            this.lbEmpEmail.AutoSize = true;
            this.lbEmpEmail.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEmail.Location = new System.Drawing.Point(498, 74);
            this.lbEmpEmail.Name = "lbEmpEmail";
            this.lbEmpEmail.Size = new System.Drawing.Size(53, 25);
            this.lbEmpEmail.TabIndex = 39;
            this.lbEmpEmail.Text = "Email";
            // 
            // lbEmpAddressPostCode
            // 
            this.lbEmpAddressPostCode.AutoSize = true;
            this.lbEmpAddressPostCode.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpAddressPostCode.Location = new System.Drawing.Point(498, 389);
            this.lbEmpAddressPostCode.Name = "lbEmpAddressPostCode";
            this.lbEmpAddressPostCode.Size = new System.Drawing.Size(84, 25);
            this.lbEmpAddressPostCode.TabIndex = 50;
            this.lbEmpAddressPostCode.Text = "PostCode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 30;
            this.label1.Text = "Gender";
            // 
            // lbEmpAddressCountry
            // 
            this.lbEmpAddressCountry.AutoSize = true;
            this.lbEmpAddressCountry.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpAddressCountry.Location = new System.Drawing.Point(498, 325);
            this.lbEmpAddressCountry.Name = "lbEmpAddressCountry";
            this.lbEmpAddressCountry.Size = new System.Drawing.Size(74, 25);
            this.lbEmpAddressCountry.TabIndex = 49;
            this.lbEmpAddressCountry.Text = "Country";
            // 
            // dtpEmpDateOfBirth
            // 
            this.dtpEmpDateOfBirth.Location = new System.Drawing.Point(22, 225);
            this.dtpEmpDateOfBirth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpEmpDateOfBirth.Name = "dtpEmpDateOfBirth";
            this.dtpEmpDateOfBirth.Size = new System.Drawing.Size(161, 31);
            this.dtpEmpDateOfBirth.TabIndex = 29;
            // 
            // tbxEmpAddressPostCode
            // 
            this.tbxEmpAddressPostCode.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpAddressPostCode.Location = new System.Drawing.Point(502, 420);
            this.tbxEmpAddressPostCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpAddressPostCode.Name = "tbxEmpAddressPostCode";
            this.tbxEmpAddressPostCode.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpAddressPostCode.TabIndex = 51;
            // 
            // btnAddEmpoyee
            // 
            this.btnAddEmpoyee.BackColor = System.Drawing.Color.LightSalmon;
            this.btnAddEmpoyee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold);
            this.btnAddEmpoyee.Location = new System.Drawing.Point(409, 496);
            this.btnAddEmpoyee.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddEmpoyee.Name = "btnAddEmpoyee";
            this.btnAddEmpoyee.Size = new System.Drawing.Size(303, 63);
            this.btnAddEmpoyee.TabIndex = 62;
            this.btnAddEmpoyee.Text = "Add employee";
            this.btnAddEmpoyee.UseVisualStyleBackColor = false;
            this.btnAddEmpoyee.Click += new System.EventHandler(this.btnAddEmpoyee_Click);
            // 
            // lbEmpEmployementType
            // 
            this.lbEmpEmployementType.AutoSize = true;
            this.lbEmpEmployementType.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpEmployementType.Location = new System.Drawing.Point(261, 77);
            this.lbEmpEmployementType.Name = "lbEmpEmployementType";
            this.lbEmpEmployementType.Size = new System.Drawing.Size(131, 25);
            this.lbEmpEmployementType.TabIndex = 34;
            this.lbEmpEmployementType.Text = "Eployment type";
            // 
            // lbEmpDateOfBirth
            // 
            this.lbEmpDateOfBirth.AutoSize = true;
            this.lbEmpDateOfBirth.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpDateOfBirth.Location = new System.Drawing.Point(18, 201);
            this.lbEmpDateOfBirth.Name = "lbEmpDateOfBirth";
            this.lbEmpDateOfBirth.Size = new System.Drawing.Size(110, 25);
            this.lbEmpDateOfBirth.TabIndex = 28;
            this.lbEmpDateOfBirth.Text = "Date of birth";
            // 
            // lbEmpHourlyWages
            // 
            this.lbEmpHourlyWages.AutoSize = true;
            this.lbEmpHourlyWages.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpHourlyWages.Location = new System.Drawing.Point(261, 136);
            this.lbEmpHourlyWages.Name = "lbEmpHourlyWages";
            this.lbEmpHourlyWages.Size = new System.Drawing.Size(165, 25);
            this.lbEmpHourlyWages.TabIndex = 36;
            this.lbEmpHourlyWages.Text = "Hourly wages (euro)";
            // 
            // tbxEmpPhone
            // 
            this.tbxEmpPhone.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpPhone.Location = new System.Drawing.Point(502, 154);
            this.tbxEmpPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpPhone.Name = "tbxEmpPhone";
            this.tbxEmpPhone.Size = new System.Drawing.Size(168, 31);
            this.tbxEmpPhone.TabIndex = 43;
            // 
            // lbEmpPhone
            // 
            this.lbEmpPhone.AutoSize = true;
            this.lbEmpPhone.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpPhone.Location = new System.Drawing.Point(498, 130);
            this.lbEmpPhone.Name = "lbEmpPhone";
            this.lbEmpPhone.Size = new System.Drawing.Size(61, 25);
            this.lbEmpPhone.TabIndex = 42;
            this.lbEmpPhone.Text = "Phone";
            // 
            // lbEmployeeAddress
            // 
            this.lbEmployeeAddress.AutoSize = true;
            this.lbEmployeeAddress.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmployeeAddress.Location = new System.Drawing.Point(497, 35);
            this.lbEmployeeAddress.Name = "lbEmployeeAddress";
            this.lbEmployeeAddress.Size = new System.Drawing.Size(178, 32);
            this.lbEmployeeAddress.TabIndex = 40;
            this.lbEmployeeAddress.Text = "Contact details";
            // 
            // tbxEmpLname
            // 
            this.tbxEmpLname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpLname.Location = new System.Drawing.Point(22, 160);
            this.tbxEmpLname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpLname.Name = "tbxEmpLname";
            this.tbxEmpLname.Size = new System.Drawing.Size(160, 31);
            this.tbxEmpLname.TabIndex = 27;
            // 
            // lbEmpLname
            // 
            this.lbEmpLname.AutoSize = true;
            this.lbEmpLname.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpLname.Location = new System.Drawing.Point(18, 136);
            this.lbEmpLname.Name = "lbEmpLname";
            this.lbEmpLname.Size = new System.Drawing.Size(90, 25);
            this.lbEmpLname.TabIndex = 26;
            this.lbEmpLname.Text = "Last name";
            // 
            // tbxEmpFname
            // 
            this.tbxEmpFname.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxEmpFname.Location = new System.Drawing.Point(22, 98);
            this.tbxEmpFname.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxEmpFname.Name = "tbxEmpFname";
            this.tbxEmpFname.Size = new System.Drawing.Size(160, 31);
            this.tbxEmpFname.TabIndex = 24;
            // 
            // lbEmpFname
            // 
            this.lbEmpFname.AutoSize = true;
            this.lbEmpFname.Font = new System.Drawing.Font("Segoe UI Semilight", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmpFname.Location = new System.Drawing.Point(17, 74);
            this.lbEmpFname.Name = "lbEmpFname";
            this.lbEmpFname.Size = new System.Drawing.Size(92, 25);
            this.lbEmpFname.TabIndex = 23;
            this.lbEmpFname.Text = "First name";
            // 
            // ManageEmpTab
            // 
            this.ManageEmpTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ManageEmpTab.Controls.Add(this.dgvEmployees);
            this.ManageEmpTab.Controls.Add(this.gbxShowEmp);
            this.ManageEmpTab.Controls.Add(this.gbxSearchEmp);
            this.ManageEmpTab.Controls.Add(this.btnClearSelectedEmp);
            this.ManageEmpTab.Controls.Add(this.btnEditEmp);
            this.ManageEmpTab.Controls.Add(this.btnRemoveEmp);
            this.ManageEmpTab.Location = new System.Drawing.Point(4, 34);
            this.ManageEmpTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageEmpTab.Name = "ManageEmpTab";
            this.ManageEmpTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ManageEmpTab.Size = new System.Drawing.Size(1093, 783);
            this.ManageEmpTab.TabIndex = 1;
            this.ManageEmpTab.Text = "Manage employees";
            // 
            // dgvEmployees
            // 
            this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEmployees.Location = new System.Drawing.Point(35, 176);
            this.dgvEmployees.Name = "dgvEmployees";
            this.dgvEmployees.RowHeadersWidth = 62;
            this.dgvEmployees.RowTemplate.Height = 28;
            this.dgvEmployees.Size = new System.Drawing.Size(998, 352);
            this.dgvEmployees.TabIndex = 20;
            // 
            // gbxShowEmp
            // 
            this.gbxShowEmp.Controls.Add(this.cbSelectEmpDepartment);
            this.gbxShowEmp.Location = new System.Drawing.Point(35, 24);
            this.gbxShowEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxShowEmp.Name = "gbxShowEmp";
            this.gbxShowEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxShowEmp.Size = new System.Drawing.Size(454, 126);
            this.gbxShowEmp.TabIndex = 19;
            this.gbxShowEmp.TabStop = false;
            this.gbxShowEmp.Text = "Show employees by department";
            // 
            // cbSelectEmpDepartment
            // 
            this.cbSelectEmpDepartment.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSelectEmpDepartment.FormattingEnabled = true;
            this.cbSelectEmpDepartment.Items.AddRange(new object[] {
            "All",
            "Administration",
            "Management",
            "Sales",
            "Depot"});
            this.cbSelectEmpDepartment.Location = new System.Drawing.Point(21, 51);
            this.cbSelectEmpDepartment.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbSelectEmpDepartment.Name = "cbSelectEmpDepartment";
            this.cbSelectEmpDepartment.Size = new System.Drawing.Size(209, 33);
            this.cbSelectEmpDepartment.TabIndex = 8;
            this.cbSelectEmpDepartment.Text = "All";
            this.cbSelectEmpDepartment.SelectedIndexChanged += new System.EventHandler(this.cbSelectEmpDepartment_SelectedIndexChanged);
            // 
            // gbxSearchEmp
            // 
            this.gbxSearchEmp.BackColor = System.Drawing.Color.Transparent;
            this.gbxSearchEmp.Controls.Add(this.tbxSearchEmp);
            this.gbxSearchEmp.Location = new System.Drawing.Point(528, 24);
            this.gbxSearchEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchEmp.Name = "gbxSearchEmp";
            this.gbxSearchEmp.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbxSearchEmp.Size = new System.Drawing.Size(505, 126);
            this.gbxSearchEmp.TabIndex = 17;
            this.gbxSearchEmp.TabStop = false;
            this.gbxSearchEmp.Text = "Search for specific employee";
            // 
            // tbxSearchEmp
            // 
            this.tbxSearchEmp.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbxSearchEmp.Location = new System.Drawing.Point(14, 53);
            this.tbxSearchEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxSearchEmp.Name = "tbxSearchEmp";
            this.tbxSearchEmp.Size = new System.Drawing.Size(247, 31);
            this.tbxSearchEmp.TabIndex = 7;
            this.tbxSearchEmp.Text = "Search...";
            this.tbxSearchEmp.Click += new System.EventHandler(this.tbxSearchEmp_Click);
            this.tbxSearchEmp.TextChanged += new System.EventHandler(this.tbxSearchEmp_TextChanged);
            // 
            // btnClearSelectedEmp
            // 
            this.btnClearSelectedEmp.BackColor = System.Drawing.Color.LightSalmon;
            this.btnClearSelectedEmp.Location = new System.Drawing.Point(46, 579);
            this.btnClearSelectedEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClearSelectedEmp.Name = "btnClearSelectedEmp";
            this.btnClearSelectedEmp.Size = new System.Drawing.Size(219, 54);
            this.btnClearSelectedEmp.TabIndex = 15;
            this.btnClearSelectedEmp.Text = "Unmark selected";
            this.btnClearSelectedEmp.UseVisualStyleBackColor = false;
            this.btnClearSelectedEmp.Click += new System.EventHandler(this.btnClearSelectedEmp_Click);
            // 
            // btnEditEmp
            // 
            this.btnEditEmp.BackColor = System.Drawing.Color.LightSalmon;
            this.btnEditEmp.Location = new System.Drawing.Point(570, 579);
            this.btnEditEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEditEmp.Name = "btnEditEmp";
            this.btnEditEmp.Size = new System.Drawing.Size(219, 54);
            this.btnEditEmp.TabIndex = 14;
            this.btnEditEmp.Text = "Edit employee";
            this.btnEditEmp.UseVisualStyleBackColor = false;
            this.btnEditEmp.Click += new System.EventHandler(this.btnEditEmp_Click);
            // 
            // btnRemoveEmp
            // 
            this.btnRemoveEmp.BackColor = System.Drawing.Color.Coral;
            this.btnRemoveEmp.Location = new System.Drawing.Point(814, 579);
            this.btnRemoveEmp.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRemoveEmp.Name = "btnRemoveEmp";
            this.btnRemoveEmp.Size = new System.Drawing.Size(219, 54);
            this.btnRemoveEmp.TabIndex = 13;
            this.btnRemoveEmp.Text = "Remove employee";
            this.btnRemoveEmp.UseVisualStyleBackColor = false;
            this.btnRemoveEmp.Click += new System.EventHandler(this.btnRemoveEmp_Click);
            // 
            // HolidayRequestsTab
            // 
            this.HolidayRequestsTab.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.HolidayRequestsTab.Controls.Add(this.lbHolidayRequestsInfo);
            this.HolidayRequestsTab.Controls.Add(this.btnHolidayRequestsClearSelected);
            this.HolidayRequestsTab.Controls.Add(this.btnHolidayRequestsDecline);
            this.HolidayRequestsTab.Controls.Add(this.btnHolidayRequestsAccept);
            this.HolidayRequestsTab.Controls.Add(this.lbxAllHolidayRequests);
            this.HolidayRequestsTab.Location = new System.Drawing.Point(4, 34);
            this.HolidayRequestsTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HolidayRequestsTab.Name = "HolidayRequestsTab";
            this.HolidayRequestsTab.Size = new System.Drawing.Size(1093, 783);
            this.HolidayRequestsTab.TabIndex = 2;
            this.HolidayRequestsTab.Text = "Holiday requests";
            // 
            // lbHolidayRequestsInfo
            // 
            this.lbHolidayRequestsInfo.AutoSize = true;
            this.lbHolidayRequestsInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHolidayRequestsInfo.Location = new System.Drawing.Point(429, 58);
            this.lbHolidayRequestsInfo.Name = "lbHolidayRequestsInfo";
            this.lbHolidayRequestsInfo.Size = new System.Drawing.Size(192, 22);
            this.lbHolidayRequestsInfo.TabIndex = 9;
            this.lbHolidayRequestsInfo.Text = "New holiday request";
            // 
            // btnHolidayRequestsClearSelected
            // 
            this.btnHolidayRequestsClearSelected.Location = new System.Drawing.Point(229, 599);
            this.btnHolidayRequestsClearSelected.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHolidayRequestsClearSelected.Name = "btnHolidayRequestsClearSelected";
            this.btnHolidayRequestsClearSelected.Size = new System.Drawing.Size(163, 54);
            this.btnHolidayRequestsClearSelected.TabIndex = 8;
            this.btnHolidayRequestsClearSelected.Text = "Unmark selected";
            this.btnHolidayRequestsClearSelected.UseVisualStyleBackColor = true;
            // 
            // btnHolidayRequestsDecline
            // 
            this.btnHolidayRequestsDecline.Location = new System.Drawing.Point(628, 599);
            this.btnHolidayRequestsDecline.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHolidayRequestsDecline.Name = "btnHolidayRequestsDecline";
            this.btnHolidayRequestsDecline.Size = new System.Drawing.Size(163, 54);
            this.btnHolidayRequestsDecline.TabIndex = 7;
            this.btnHolidayRequestsDecline.Text = "Decline";
            this.btnHolidayRequestsDecline.UseVisualStyleBackColor = true;
            // 
            // btnHolidayRequestsAccept
            // 
            this.btnHolidayRequestsAccept.Location = new System.Drawing.Point(425, 599);
            this.btnHolidayRequestsAccept.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnHolidayRequestsAccept.Name = "btnHolidayRequestsAccept";
            this.btnHolidayRequestsAccept.Size = new System.Drawing.Size(163, 54);
            this.btnHolidayRequestsAccept.TabIndex = 6;
            this.btnHolidayRequestsAccept.Text = "Accept";
            this.btnHolidayRequestsAccept.UseVisualStyleBackColor = true;
            // 
            // lbxAllHolidayRequests
            // 
            this.lbxAllHolidayRequests.FormattingEnabled = true;
            this.lbxAllHolidayRequests.HorizontalScrollbar = true;
            this.lbxAllHolidayRequests.ItemHeight = 25;
            this.lbxAllHolidayRequests.Location = new System.Drawing.Point(229, 118);
            this.lbxAllHolidayRequests.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lbxAllHolidayRequests.Name = "lbxAllHolidayRequests";
            this.lbxAllHolidayRequests.Size = new System.Drawing.Size(562, 354);
            this.lbxAllHolidayRequests.TabIndex = 5;
            // 
            // HomeTab
            // 
            this.HomeTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.HomeTab.Controls.Add(this.panel1);
            this.HomeTab.Controls.Add(this.manageDepartmentsShortcut);
            this.HomeTab.Controls.Add(this.manageStockShortcut);
            this.HomeTab.Controls.Add(this.manageAttendanceShortcut);
            this.HomeTab.Controls.Add(this.weeklySchedukeShortcut);
            this.HomeTab.Controls.Add(this.holidayLeaveRequestsShortcut);
            this.HomeTab.Controls.Add(this.manageEmpShortcut);
            this.HomeTab.Controls.Add(this.pictureBox7);
            this.HomeTab.Controls.Add(this.lbTime);
            this.HomeTab.Controls.Add(this.lbDateDayOfWeek);
            this.HomeTab.Controls.Add(this.lbGreetingMsg);
            this.HomeTab.ForeColor = System.Drawing.SystemColors.ControlText;
            this.HomeTab.Location = new System.Drawing.Point(4, 34);
            this.HomeTab.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeTab.Name = "HomeTab";
            this.HomeTab.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HomeTab.Size = new System.Drawing.Size(1097, 694);
            this.HomeTab.TabIndex = 0;
            this.HomeTab.Text = "Home";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Location = new System.Drawing.Point(47, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(557, 63);
            this.panel1.TabIndex = 13;
            this.panel1.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(74, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(577, 32);
            this.label8.TabIndex = 1;
            this.label8.Text = "There are 3 new holiday requests (click to manange).";
            // 
            // pictureBox8
            // 
            this.pictureBox8.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox8.Image = global::MediaBazaarApp.Properties.Resources.round_circle_notifications_black_48dp;
            this.pictureBox8.Location = new System.Drawing.Point(12, 11);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(56, 44);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 0;
            this.pictureBox8.TabStop = false;
            // 
            // manageDepartmentsShortcut
            // 
            this.manageDepartmentsShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.manageDepartmentsShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageDepartmentsShortcut.Controls.Add(this.manageDepLBL);
            this.manageDepartmentsShortcut.Controls.Add(this.manageDepPic);
            this.manageDepartmentsShortcut.Location = new System.Drawing.Point(704, 535);
            this.manageDepartmentsShortcut.Name = "manageDepartmentsShortcut";
            this.manageDepartmentsShortcut.Size = new System.Drawing.Size(362, 80);
            this.manageDepartmentsShortcut.TabIndex = 13;
            this.manageDepartmentsShortcut.Visible = false;
            this.manageDepartmentsShortcut.Click += new System.EventHandler(this.ManageDepartmentsShortcut_Click);
            // 
            // manageDepLBL
            // 
            this.manageDepLBL.AutoSize = true;
            this.manageDepLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageDepLBL.Location = new System.Drawing.Point(74, 22);
            this.manageDepLBL.Name = "manageDepLBL";
            this.manageDepLBL.Size = new System.Drawing.Size(244, 32);
            this.manageDepLBL.TabIndex = 1;
            this.manageDepLBL.Text = "Manage departments";
            this.manageDepLBL.Click += new System.EventHandler(this.ManageDepLBL_Click);
            // 
            // manageDepPic
            // 
            this.manageDepPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageDepPic.Image = global::MediaBazaarApp.Properties.Resources.round_supervisor_account_black_48dp;
            this.manageDepPic.Location = new System.Drawing.Point(12, 11);
            this.manageDepPic.Name = "manageDepPic";
            this.manageDepPic.Size = new System.Drawing.Size(56, 57);
            this.manageDepPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manageDepPic.TabIndex = 0;
            this.manageDepPic.TabStop = false;
            this.manageDepPic.Click += new System.EventHandler(this.ManageDepPic_Click);
            // 
            // manageStockShortcut
            // 
            this.manageStockShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.manageStockShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageStockShortcut.Controls.Add(this.manageStockLBL);
            this.manageStockShortcut.Controls.Add(this.manageStockPic);
            this.manageStockShortcut.Location = new System.Drawing.Point(704, 448);
            this.manageStockShortcut.Name = "manageStockShortcut";
            this.manageStockShortcut.Size = new System.Drawing.Size(362, 80);
            this.manageStockShortcut.TabIndex = 14;
            this.manageStockShortcut.Visible = false;
            this.manageStockShortcut.Click += new System.EventHandler(this.ManageStockShortcut_Click);
            // 
            // manageStockLBL
            // 
            this.manageStockLBL.AutoSize = true;
            this.manageStockLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageStockLBL.Location = new System.Drawing.Point(74, 22);
            this.manageStockLBL.Name = "manageStockLBL";
            this.manageStockLBL.Size = new System.Drawing.Size(164, 32);
            this.manageStockLBL.TabIndex = 1;
            this.manageStockLBL.Text = "Manage stock";
            this.manageStockLBL.Click += new System.EventHandler(this.ManageStockLBL_Click);
            // 
            // manageStockPic
            // 
            this.manageStockPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageStockPic.Image = global::MediaBazaarApp.Properties.Resources.round_shopping_cart_black_48dp;
            this.manageStockPic.Location = new System.Drawing.Point(12, 11);
            this.manageStockPic.Name = "manageStockPic";
            this.manageStockPic.Size = new System.Drawing.Size(56, 57);
            this.manageStockPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manageStockPic.TabIndex = 0;
            this.manageStockPic.TabStop = false;
            this.manageStockPic.Click += new System.EventHandler(this.ManageStockPic_Click);
            // 
            // manageAttendanceShortcut
            // 
            this.manageAttendanceShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.manageAttendanceShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageAttendanceShortcut.Controls.Add(this.manageAttendanceLBL);
            this.manageAttendanceShortcut.Controls.Add(this.manageAttendancePic);
            this.manageAttendanceShortcut.Location = new System.Drawing.Point(704, 362);
            this.manageAttendanceShortcut.Name = "manageAttendanceShortcut";
            this.manageAttendanceShortcut.Size = new System.Drawing.Size(362, 80);
            this.manageAttendanceShortcut.TabIndex = 15;
            this.manageAttendanceShortcut.Visible = false;
            this.manageAttendanceShortcut.Click += new System.EventHandler(this.ManageAttendanceShortcut_Click);
            // 
            // manageAttendanceLBL
            // 
            this.manageAttendanceLBL.AutoSize = true;
            this.manageAttendanceLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageAttendanceLBL.Location = new System.Drawing.Point(74, 22);
            this.manageAttendanceLBL.Name = "manageAttendanceLBL";
            this.manageAttendanceLBL.Size = new System.Drawing.Size(228, 32);
            this.manageAttendanceLBL.TabIndex = 1;
            this.manageAttendanceLBL.Text = "Manage attendance";
            this.manageAttendanceLBL.Click += new System.EventHandler(this.ManageAttendanceLBL_Click);
            // 
            // manageAttendancePic
            // 
            this.manageAttendancePic.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageAttendancePic.Image = global::MediaBazaarApp.Properties.Resources.round_event_available_black_48dp;
            this.manageAttendancePic.Location = new System.Drawing.Point(12, 11);
            this.manageAttendancePic.Name = "manageAttendancePic";
            this.manageAttendancePic.Size = new System.Drawing.Size(56, 57);
            this.manageAttendancePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manageAttendancePic.TabIndex = 0;
            this.manageAttendancePic.TabStop = false;
            this.manageAttendancePic.Click += new System.EventHandler(this.ManageAttendancePic_Click);
            // 
            // weeklySchedukeShortcut
            // 
            this.weeklySchedukeShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.weeklySchedukeShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.weeklySchedukeShortcut.Controls.Add(this.weeklyScheduleLBL);
            this.weeklySchedukeShortcut.Controls.Add(this.weekSchedulePic);
            this.weeklySchedukeShortcut.Location = new System.Drawing.Point(704, 275);
            this.weeklySchedukeShortcut.Name = "weeklySchedukeShortcut";
            this.weeklySchedukeShortcut.Size = new System.Drawing.Size(362, 80);
            this.weeklySchedukeShortcut.TabIndex = 16;
            this.weeklySchedukeShortcut.Visible = false;
            this.weeklySchedukeShortcut.Click += new System.EventHandler(this.WeeklySchedukeShortcut_Click);
            // 
            // weeklyScheduleLBL
            // 
            this.weeklyScheduleLBL.AutoSize = true;
            this.weeklyScheduleLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weeklyScheduleLBL.Location = new System.Drawing.Point(74, 22);
            this.weeklyScheduleLBL.Name = "weeklyScheduleLBL";
            this.weeklyScheduleLBL.Size = new System.Drawing.Size(194, 32);
            this.weeklyScheduleLBL.TabIndex = 1;
            this.weeklyScheduleLBL.Text = "Weekly schedule";
            this.weeklyScheduleLBL.Click += new System.EventHandler(this.WeeklyScheduleLBL_Click);
            // 
            // weekSchedulePic
            // 
            this.weekSchedulePic.Cursor = System.Windows.Forms.Cursors.Default;
            this.weekSchedulePic.Image = global::MediaBazaarApp.Properties.Resources.round_calendar_today_black_48dp;
            this.weekSchedulePic.Location = new System.Drawing.Point(12, 11);
            this.weekSchedulePic.Name = "weekSchedulePic";
            this.weekSchedulePic.Size = new System.Drawing.Size(56, 57);
            this.weekSchedulePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.weekSchedulePic.TabIndex = 0;
            this.weekSchedulePic.TabStop = false;
            this.weekSchedulePic.Click += new System.EventHandler(this.WeekSchedulePic_Click);
            // 
            // holidayLeaveRequestsShortcut
            // 
            this.holidayLeaveRequestsShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.holidayLeaveRequestsShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.holidayLeaveRequestsShortcut.Controls.Add(this.holidayLeaveLBL);
            this.holidayLeaveRequestsShortcut.Controls.Add(this.holidayLeavePic);
            this.holidayLeaveRequestsShortcut.Location = new System.Drawing.Point(704, 188);
            this.holidayLeaveRequestsShortcut.Name = "holidayLeaveRequestsShortcut";
            this.holidayLeaveRequestsShortcut.Size = new System.Drawing.Size(362, 80);
            this.holidayLeaveRequestsShortcut.TabIndex = 17;
            this.holidayLeaveRequestsShortcut.Visible = false;
            this.holidayLeaveRequestsShortcut.Click += new System.EventHandler(this.HolidayLeaveRequestsShortcut_Click);
            // 
            // holidayLeaveLBL
            // 
            this.holidayLeaveLBL.AutoSize = true;
            this.holidayLeaveLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.holidayLeaveLBL.Location = new System.Drawing.Point(74, 22);
            this.holidayLeaveLBL.Name = "holidayLeaveLBL";
            this.holidayLeaveLBL.Size = new System.Drawing.Size(256, 32);
            this.holidayLeaveLBL.TabIndex = 1;
            this.holidayLeaveLBL.Text = "Holiday leave requests";
            this.holidayLeaveLBL.Click += new System.EventHandler(this.HolidayLeaveLBL_Click);
            // 
            // holidayLeavePic
            // 
            this.holidayLeavePic.Cursor = System.Windows.Forms.Cursors.Default;
            this.holidayLeavePic.Image = global::MediaBazaarApp.Properties.Resources.round_flight_takeoff_black_48dp;
            this.holidayLeavePic.Location = new System.Drawing.Point(12, 11);
            this.holidayLeavePic.Name = "holidayLeavePic";
            this.holidayLeavePic.Size = new System.Drawing.Size(56, 57);
            this.holidayLeavePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.holidayLeavePic.TabIndex = 0;
            this.holidayLeavePic.TabStop = false;
            this.holidayLeavePic.Click += new System.EventHandler(this.HolidayLeavePic_Click);
            // 
            // manageEmpShortcut
            // 
            this.manageEmpShortcut.BackColor = System.Drawing.Color.LightSalmon;
            this.manageEmpShortcut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.manageEmpShortcut.Controls.Add(this.manageEmpLBL);
            this.manageEmpShortcut.Controls.Add(this.manageEmpPic);
            this.manageEmpShortcut.Location = new System.Drawing.Point(704, 102);
            this.manageEmpShortcut.Name = "manageEmpShortcut";
            this.manageEmpShortcut.Size = new System.Drawing.Size(362, 80);
            this.manageEmpShortcut.TabIndex = 12;
            this.manageEmpShortcut.Visible = false;
            this.manageEmpShortcut.Click += new System.EventHandler(this.ManageEmpShortcut_Click);
            // 
            // manageEmpLBL
            // 
            this.manageEmpLBL.AutoSize = true;
            this.manageEmpLBL.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manageEmpLBL.Location = new System.Drawing.Point(74, 22);
            this.manageEmpLBL.Name = "manageEmpLBL";
            this.manageEmpLBL.Size = new System.Drawing.Size(225, 32);
            this.manageEmpLBL.TabIndex = 1;
            this.manageEmpLBL.Text = "Manage employees";
            this.manageEmpLBL.Click += new System.EventHandler(this.ManageEmpLBL_Click);
            // 
            // manageEmpPic
            // 
            this.manageEmpPic.Cursor = System.Windows.Forms.Cursors.Default;
            this.manageEmpPic.Image = global::MediaBazaarApp.Properties.Resources.round_person_add_black_48dp;
            this.manageEmpPic.Location = new System.Drawing.Point(12, 11);
            this.manageEmpPic.Name = "manageEmpPic";
            this.manageEmpPic.Size = new System.Drawing.Size(56, 57);
            this.manageEmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.manageEmpPic.TabIndex = 0;
            this.manageEmpPic.TabStop = false;
            this.manageEmpPic.Click += new System.EventHandler(this.ManageEmpPic_Click);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::MediaBazaarApp.Properties.Resources.MediaBazaarLogo;
            this.pictureBox7.Location = new System.Drawing.Point(6, 501);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(223, 191);
            this.pictureBox7.TabIndex = 11;
            this.pictureBox7.TabStop = false;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbTime.Location = new System.Drawing.Point(38, 323);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(142, 65);
            this.lbTime.TabIndex = 9;
            this.lbTime.Text = "12:30";
            // 
            // lbDateDayOfWeek
            // 
            this.lbDateDayOfWeek.AutoSize = true;
            this.lbDateDayOfWeek.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDateDayOfWeek.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbDateDayOfWeek.Location = new System.Drawing.Point(38, 383);
            this.lbDateDayOfWeek.Name = "lbDateDayOfWeek";
            this.lbDateDayOfWeek.Size = new System.Drawing.Size(331, 65);
            this.lbDateDayOfWeek.TabIndex = 8;
            this.lbDateDayOfWeek.Text = "Monday, 1 Jan";
            // 
            // lbGreetingMsg
            // 
            this.lbGreetingMsg.AutoSize = true;
            this.lbGreetingMsg.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGreetingMsg.Location = new System.Drawing.Point(36, 248);
            this.lbGreetingMsg.Name = "lbGreetingMsg";
            this.lbGreetingMsg.Size = new System.Drawing.Size(633, 76);
            this.lbGreetingMsg.TabIndex = 5;
            this.lbGreetingMsg.Text = "Good morning, Name!";
            // 
            // tabControlAdministration
            // 
            this.tabControlAdministration.Controls.Add(this.HomeTab);
            this.tabControlAdministration.Controls.Add(this.EmployeesTab);
            this.tabControlAdministration.Controls.Add(this.SchedulingTab);
            this.tabControlAdministration.Controls.Add(this.StocksTab);
            this.tabControlAdministration.Controls.Add(this.ManageDepartmentsTab);
            this.tabControlAdministration.Controls.Add(this.settingsTab);
            this.tabControlAdministration.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControlAdministration.Location = new System.Drawing.Point(-3, -2);
            this.tabControlAdministration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControlAdministration.Multiline = true;
            this.tabControlAdministration.Name = "tabControlAdministration";
            this.tabControlAdministration.SelectedIndex = 0;
            this.tabControlAdministration.Size = new System.Drawing.Size(1105, 732);
            this.tabControlAdministration.TabIndex = 0;
            this.tabControlAdministration.SelectedIndexChanged += new System.EventHandler(this.tabControlAdministration_SelectedIndexChanged);
            // 
            // settingsTab
            // 
            this.settingsTab.BackColor = System.Drawing.Color.MediumTurquoise;
            this.settingsTab.Controls.Add(this.applyShortcutsBTN);
            this.settingsTab.Controls.Add(this.manageAttendanceCH);
            this.settingsTab.Controls.Add(this.manageStockCH);
            this.settingsTab.Controls.Add(this.manageDepCH);
            this.settingsTab.Controls.Add(this.weeklyScheduleCH);
            this.settingsTab.Controls.Add(this.holidayLeaveReqCH);
            this.settingsTab.Controls.Add(this.manageEmpCH);
            this.settingsTab.Location = new System.Drawing.Point(4, 34);
            this.settingsTab.Name = "settingsTab";
            this.settingsTab.Padding = new System.Windows.Forms.Padding(3);
            this.settingsTab.Size = new System.Drawing.Size(1097, 694);
            this.settingsTab.TabIndex = 8;
            this.settingsTab.Text = "Settings";
            // 
            // applyShortcutsBTN
            // 
            this.applyShortcutsBTN.Location = new System.Drawing.Point(6, 114);
            this.applyShortcutsBTN.Name = "applyShortcutsBTN";
            this.applyShortcutsBTN.Size = new System.Drawing.Size(75, 23);
            this.applyShortcutsBTN.TabIndex = 12;
            this.applyShortcutsBTN.Text = "Apply ";
            this.applyShortcutsBTN.UseVisualStyleBackColor = true;
            this.applyShortcutsBTN.Click += new System.EventHandler(this.ApplyShortcutsBTN_Click);
            // 
            // manageAttendanceCH
            // 
            this.manageAttendanceCH.AutoSize = true;
            this.manageAttendanceCH.Location = new System.Drawing.Point(188, 6);
            this.manageAttendanceCH.Name = "manageAttendanceCH";
            this.manageAttendanceCH.Size = new System.Drawing.Size(264, 29);
            this.manageAttendanceCH.TabIndex = 11;
            this.manageAttendanceCH.Text = "Manage attendance shortcut";
            this.manageAttendanceCH.UseVisualStyleBackColor = true;
            // 
            // manageStockCH
            // 
            this.manageStockCH.AutoSize = true;
            this.manageStockCH.Location = new System.Drawing.Point(188, 42);
            this.manageStockCH.Name = "manageStockCH";
            this.manageStockCH.Size = new System.Drawing.Size(219, 29);
            this.manageStockCH.TabIndex = 10;
            this.manageStockCH.Text = "Manage stock shortcut";
            this.manageStockCH.UseVisualStyleBackColor = true;
            // 
            // manageDepCH
            // 
            this.manageDepCH.AutoSize = true;
            this.manageDepCH.Location = new System.Drawing.Point(188, 76);
            this.manageDepCH.Name = "manageDepCH";
            this.manageDepCH.Size = new System.Drawing.Size(278, 29);
            this.manageDepCH.TabIndex = 9;
            this.manageDepCH.Text = "Manage departments shortcut";
            this.manageDepCH.UseVisualStyleBackColor = true;
            // 
            // weeklyScheduleCH
            // 
            this.weeklyScheduleCH.AutoSize = true;
            this.weeklyScheduleCH.Location = new System.Drawing.Point(6, 76);
            this.weeklyScheduleCH.Name = "weeklyScheduleCH";
            this.weeklyScheduleCH.Size = new System.Drawing.Size(238, 29);
            this.weeklyScheduleCH.TabIndex = 8;
            this.weeklyScheduleCH.Text = "Weekly schedule shortcut";
            this.weeklyScheduleCH.UseVisualStyleBackColor = true;
            // 
            // holidayLeaveReqCH
            // 
            this.holidayLeaveReqCH.AutoSize = true;
            this.holidayLeaveReqCH.Location = new System.Drawing.Point(6, 42);
            this.holidayLeaveReqCH.Name = "holidayLeaveReqCH";
            this.holidayLeaveReqCH.Size = new System.Drawing.Size(214, 29);
            this.holidayLeaveReqCH.TabIndex = 7;
            this.holidayLeaveReqCH.Text = "Holiday leave shortcut";
            this.holidayLeaveReqCH.UseVisualStyleBackColor = true;
            // 
            // manageEmpCH
            // 
            this.manageEmpCH.AutoSize = true;
            this.manageEmpCH.Location = new System.Drawing.Point(6, 6);
            this.manageEmpCH.Name = "manageEmpCH";
            this.manageEmpCH.Size = new System.Drawing.Size(263, 29);
            this.manageEmpCH.TabIndex = 6;
            this.manageEmpCH.Text = "Manage employees shortcut";
            this.manageEmpCH.UseVisualStyleBackColor = true;
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1114, 743);
            this.Controls.Add(this.tabControlAdministration);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AdministrationForm";
            this.Text = "AdministrationForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdministrationForm_FormClosed);
            this.ManageDepartmentsTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDepartments)).EndInit();
            this.gbxSearchDep.ResumeLayout(false);
            this.gbxSearchDep.PerformLayout();
            this.gbxEditDepartment.ResumeLayout(false);
            this.gbxEditDepartment.PerformLayout();
            this.gbxCreateDeparmtent.ResumeLayout(false);
            this.gbxCreateDeparmtent.PerformLayout();
            this.StocksTab.ResumeLayout(false);
            this.tabControlStocks.ResumeLayout(false);
            this.AddStocksTab.ResumeLayout(false);
            this.AddStocksTab.PerformLayout();
            this.ManageStocksTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStock)).EndInit();
            this.gbxSearchStock.ResumeLayout(false);
            this.gbxSearchStock.PerformLayout();
            this.SchedulingTab.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tbWeeklySchedule.ResumeLayout(false);
            this.tbWeeklySchedule.PerformLayout();
            this.tpManualSched.ResumeLayout(false);
            this.gbViewRemoveShifts.ResumeLayout(false);
            this.gbAssignShiftManually.ResumeLayout(false);
            this.gbAssignShiftManually.PerformLayout();
            this.gbChooseEmp.ResumeLayout(false);
            this.gbChooseEmp.PerformLayout();
            this.tpManageAttendance.ResumeLayout(false);
            this.tpManageAttendance.PerformLayout();
            this.EmployeesTab.ResumeLayout(false);
            this.tabControlEmployees.ResumeLayout(false);
            this.AddEmpTab.ResumeLayout(false);
            this.AddEmpTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEmpHourlyWages)).EndInit();
            this.ManageEmpTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
            this.gbxShowEmp.ResumeLayout(false);
            this.gbxSearchEmp.ResumeLayout(false);
            this.gbxSearchEmp.PerformLayout();
            this.HolidayRequestsTab.ResumeLayout(false);
            this.HolidayRequestsTab.PerformLayout();
            this.HomeTab.ResumeLayout(false);
            this.HomeTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.manageDepartmentsShortcut.ResumeLayout(false);
            this.manageDepartmentsShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageDepPic)).EndInit();
            this.manageStockShortcut.ResumeLayout(false);
            this.manageStockShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageStockPic)).EndInit();
            this.manageAttendanceShortcut.ResumeLayout(false);
            this.manageAttendanceShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageAttendancePic)).EndInit();
            this.weeklySchedukeShortcut.ResumeLayout(false);
            this.weeklySchedukeShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.weekSchedulePic)).EndInit();
            this.holidayLeaveRequestsShortcut.ResumeLayout(false);
            this.holidayLeaveRequestsShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.holidayLeavePic)).EndInit();
            this.manageEmpShortcut.ResumeLayout(false);
            this.manageEmpShortcut.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.manageEmpPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.tabControlAdministration.ResumeLayout(false);
            this.settingsTab.ResumeLayout(false);
            this.settingsTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnShift;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TabPage ManageDepartmentsTab;
        private System.Windows.Forms.GroupBox gbxSearchDep;
        private System.Windows.Forms.Button btnShowAllDep;
        private System.Windows.Forms.TextBox tbxSearchDep;
        private System.Windows.Forms.GroupBox gbxEditDepartment;
        private System.Windows.Forms.Label lbDepartmentCurrManagerEdit;
        private System.Windows.Forms.Label lbDepartmentEditInfo;
        private System.Windows.Forms.Button btnApplyChangesDepartment;
        private System.Windows.Forms.ComboBox cbDepartmentManagerEdit;
        private System.Windows.Forms.Label lbDepartmentManagerEdit;
        private System.Windows.Forms.TextBox tbxDepartmentNameEdit;
        private System.Windows.Forms.Label lbDepartmentNameEdit;
        private System.Windows.Forms.Button btnRemoveDepartment;
        private System.Windows.Forms.Button btnEditDepartment;
        private System.Windows.Forms.Button btnDepartmentsClearSelected;
        private System.Windows.Forms.GroupBox gbxCreateDeparmtent;
        private System.Windows.Forms.Button btnCreateDepartment;
        private System.Windows.Forms.ComboBox cbDepartmentManager;
        private System.Windows.Forms.Label lbDepartmentManager;
        private System.Windows.Forms.TextBox tbxDepartmentName;
        private System.Windows.Forms.Label lbDepartmentName;
        private System.Windows.Forms.TabPage StocksTab;
        private System.Windows.Forms.TabControl tabControlStocks;
        private System.Windows.Forms.TabPage AddStocksTab;
        private System.Windows.Forms.Label kgLb;
        private System.Windows.Forms.Label cmLb3;
        private System.Windows.Forms.Label lbStocksMainDetails;
        private System.Windows.Forms.Label cmLb2;
        private System.Windows.Forms.Label lbStockShortDescription;
        private System.Windows.Forms.Label cmLb1;
        private System.Windows.Forms.Label lbStockQuantity;
        private System.Windows.Forms.TextBox tbxStockWeight;
        private System.Windows.Forms.TextBox tbxStockWidth;
        private System.Windows.Forms.Label stockWeightLb;
        private System.Windows.Forms.TextBox tbxStockQuantity;
        private System.Windows.Forms.Label lbStockDimensions;
        private System.Windows.Forms.TextBox tbxStockDepth;
        private System.Windows.Forms.Label lbStockWidth;
        private System.Windows.Forms.Button btnAddStock;
        private System.Windows.Forms.Label lbStockHeight;
        private System.Windows.Forms.TextBox tbxStockPrice;
        private System.Windows.Forms.Label lbStockBrand;
        private System.Windows.Forms.TextBox tbxStockShortDescription;
        private System.Windows.Forms.TextBox tbxStockBrand;
        private System.Windows.Forms.Label lbStockPrice;
        private System.Windows.Forms.TextBox tbxStockHeight;
        private System.Windows.Forms.Label lbStockDepth;
        private System.Windows.Forms.Label lbStockModel;
        private System.Windows.Forms.TextBox tbxStockModel;
        private System.Windows.Forms.TabPage ManageStocksTab;
        private System.Windows.Forms.Button btnShowAllStocks;
        private System.Windows.Forms.GroupBox gbxSearchStock;
        private System.Windows.Forms.TextBox tbxSearchStock;
        private System.Windows.Forms.Button btnStocksClearSelected;
        private System.Windows.Forms.Button btnEditStock;
        private System.Windows.Forms.Button btnRemoveStock;
        private System.Windows.Forms.TabPage SchedulingTab;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbWeeklySchedule;
        private System.Windows.Forms.Label lbWeekNumber;
        private System.Windows.Forms.ComboBox cbWeekNumber;
        private System.Windows.Forms.ListBox lbxWeeklySchedule;
        private System.Windows.Forms.TabPage tpManualSched;
        private System.Windows.Forms.GroupBox gbViewRemoveShifts;
        private System.Windows.Forms.Button btnRemoveShift;
        private System.Windows.Forms.Button btnReturnViewRemove;
        private System.Windows.Forms.ListBox lbxSelectedEmpShifts;
        private System.Windows.Forms.Button btnScheduleClearSelected;
        private System.Windows.Forms.GroupBox gbAssignShiftManually;
        private System.Windows.Forms.Button btnReturnAssign;
        private System.Windows.Forms.CheckBox cbWFH;
        private System.Windows.Forms.Label lbEmpInfo;
        private System.Windows.Forms.Label lbWFH;
        private System.Windows.Forms.Button btnAssign;
        private System.Windows.Forms.Label lbShiftType;
        private System.Windows.Forms.DateTimePicker dtpShiftDate;
        private System.Windows.Forms.Label lbShiftDate;
        private System.Windows.Forms.ComboBox cbShiftType;
        private System.Windows.Forms.GroupBox gbChooseEmp;
        private System.Windows.Forms.Label lbEmp;
        private System.Windows.Forms.Label lbDep;
        private System.Windows.Forms.Button btnAddShift;
        private System.Windows.Forms.Button btnViewRemoveShifts;
        private System.Windows.Forms.ComboBox cbEmps;
        private System.Windows.Forms.ComboBox cbDeps;
        private System.Windows.Forms.TabPage tpManageAttendance;
        private System.Windows.Forms.Button btnApplyAttendanceChanges;
        private System.Windows.Forms.TextBox tbReasonForAbsence;
        private System.Windows.Forms.CheckBox cbHasAttended;
        private System.Windows.Forms.Label lbReason;
        private System.Windows.Forms.Label lbHasAttended;
        private System.Windows.Forms.Label lbShift;
        private System.Windows.Forms.ComboBox cbEmployeesShifts;
        private System.Windows.Forms.Label lbSelectedEmp;
        private System.Windows.Forms.Label lbSelectedDep;
        private System.Windows.Forms.ComboBox cbSelectedEmp;
        private System.Windows.Forms.ComboBox cbAllDeps;
        private System.Windows.Forms.TabPage EmployeesTab;
        private System.Windows.Forms.TabControl tabControlEmployees;
        private System.Windows.Forms.TabPage AddEmpTab;
        private System.Windows.Forms.ComboBox cbEmConRelation;
        private System.Windows.Forms.Label lbEmConRelation;
        private System.Windows.Forms.TextBox tbxEmConName;
        private System.Windows.Forms.Label lbEmConName;
        private System.Windows.Forms.TextBox tbxEmConEmail;
        private System.Windows.Forms.Label lbEmConEmail;
        private System.Windows.Forms.TextBox tbxEmConPhone;
        private System.Windows.Forms.Label lbEmConPhone;
        private System.Windows.Forms.Label lbEmpEmConDetails;
        private System.Windows.Forms.Label lbEmpBsn;
        private System.Windows.Forms.TextBox tbxEmpBsn;
        private System.Windows.Forms.NumericUpDown nudEmpHourlyWages;
        private System.Windows.Forms.ComboBox cbEmpDepartment;
        private System.Windows.Forms.Label lbEmpDepartment;
        private System.Windows.Forms.ComboBox cbEmpEmploymentType;
        private System.Windows.Forms.Label lbEmpJobSpec;
        private System.Windows.Forms.Label lbEmpAddressStreet;
        private System.Windows.Forms.Label lbEmpPersonalInfo;
        private System.Windows.Forms.TextBox tbxEmpAddressStreet;
        private System.Windows.Forms.TextBox tbxEmpAddressCity;
        private System.Windows.Forms.ComboBox cbEmpGender;
        private System.Windows.Forms.Label lbEmpAddressCity;
        private System.Windows.Forms.TextBox tbxEmpEmail;
        private System.Windows.Forms.TextBox tbxEmpAddressCountry;
        private System.Windows.Forms.Label lbEmpEmail;
        private System.Windows.Forms.Label lbEmpAddressPostCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbEmpAddressCountry;
        private System.Windows.Forms.DateTimePicker dtpEmpDateOfBirth;
        private System.Windows.Forms.TextBox tbxEmpAddressPostCode;
        private System.Windows.Forms.Button btnAddEmpoyee;
        private System.Windows.Forms.Label lbEmpEmployementType;
        private System.Windows.Forms.Label lbEmpDateOfBirth;
        private System.Windows.Forms.Label lbEmpHourlyWages;
        private System.Windows.Forms.TextBox tbxEmpPhone;
        private System.Windows.Forms.Label lbEmpPhone;
        private System.Windows.Forms.Label lbEmployeeAddress;
        private System.Windows.Forms.TextBox tbxEmpLname;
        private System.Windows.Forms.Label lbEmpLname;
        private System.Windows.Forms.TextBox tbxEmpFname;
        private System.Windows.Forms.Label lbEmpFname;
        private System.Windows.Forms.TabPage ManageEmpTab;
        private System.Windows.Forms.GroupBox gbxShowEmp;
        private System.Windows.Forms.ComboBox cbSelectEmpDepartment;
        private System.Windows.Forms.GroupBox gbxSearchEmp;
        private System.Windows.Forms.TextBox tbxSearchEmp;
        private System.Windows.Forms.Button btnClearSelectedEmp;
        private System.Windows.Forms.Button btnEditEmp;
        private System.Windows.Forms.Button btnRemoveEmp;
        private System.Windows.Forms.TabPage HolidayRequestsTab;
        private System.Windows.Forms.Label lbHolidayRequestsInfo;
        private System.Windows.Forms.Button btnHolidayRequestsClearSelected;
        private System.Windows.Forms.Button btnHolidayRequestsDecline;
        private System.Windows.Forms.Button btnHolidayRequestsAccept;
        private System.Windows.Forms.ListBox lbxAllHolidayRequests;
        private System.Windows.Forms.TabPage HomeTab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel manageDepartmentsShortcut;
        private System.Windows.Forms.Label manageDepLBL;
        private System.Windows.Forms.PictureBox manageDepPic;
        private System.Windows.Forms.Panel manageStockShortcut;
        private System.Windows.Forms.Label manageStockLBL;
        private System.Windows.Forms.PictureBox manageStockPic;
        private System.Windows.Forms.Panel manageAttendanceShortcut;
        private System.Windows.Forms.Label manageAttendanceLBL;
        private System.Windows.Forms.PictureBox manageAttendancePic;
        private System.Windows.Forms.Panel weeklySchedukeShortcut;
        private System.Windows.Forms.Label weeklyScheduleLBL;
        private System.Windows.Forms.PictureBox weekSchedulePic;
        private System.Windows.Forms.Panel holidayLeaveRequestsShortcut;
        private System.Windows.Forms.Label holidayLeaveLBL;
        private System.Windows.Forms.PictureBox holidayLeavePic;
        private System.Windows.Forms.Panel manageEmpShortcut;
        private System.Windows.Forms.Label manageEmpLBL;
        private System.Windows.Forms.PictureBox manageEmpPic;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.Label lbDateDayOfWeek;
        private System.Windows.Forms.Label lbGreetingMsg;
        private System.Windows.Forms.TabControl tabControlAdministration;
        private System.Windows.Forms.Button btnGenAS;
        private System.Windows.Forms.Label lbWeekNrAS;
        private System.Windows.Forms.ComboBox cbWeekAS;
        private System.Windows.Forms.DataGridView dgvStock;
        private System.Windows.Forms.TabPage settingsTab;
        private System.Windows.Forms.Button applyShortcutsBTN;
        private System.Windows.Forms.CheckBox manageAttendanceCH;
        private System.Windows.Forms.CheckBox manageStockCH;
        private System.Windows.Forms.CheckBox manageDepCH;
        private System.Windows.Forms.CheckBox weeklyScheduleCH;
        private System.Windows.Forms.CheckBox holidayLeaveReqCH;
        private System.Windows.Forms.CheckBox manageEmpCH;
        private System.Windows.Forms.DataGridView dgvDepartments;
        private System.Windows.Forms.Label lbEmpNationality;
        private System.Windows.Forms.TextBox tbxEmpNationality;
        private System.Windows.Forms.DateTimePicker dtpEmpEndDate;
        private System.Windows.Forms.Label lbEmpEndDate;
        private System.Windows.Forms.DateTimePicker dtpEmpStartDate;
        private System.Windows.Forms.Label lbEmpStartDate;
        private System.Windows.Forms.DataGridView dgvEmployees;
    }
}