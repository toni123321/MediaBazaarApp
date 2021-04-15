using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MediaBazaarApp
{
    public partial class AdministrationForm : Form
    {
        private bool openOtherForm = false;
        private DepartmentManagement departmentManagement;
        private Employee currentEmp;
        private StockManagement stockManagement;
        private Stock selectedStock;
        private SalesManagement salesManagement;
        private DBControl dbc;

        public AdministrationForm(DepartmentManagement departmentManagement, Employee currentEmp, SalesManagement salesManagement, StockManagement stockManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.stockManagement = stockManagement;
            this.salesManagement = salesManagement;
            dbc = new DBControl();

            gbChooseEmp.Visible = true;
            gbAssignShiftManually.Visible = false;
            gbViewRemoveShifts.Visible = false;

            UpdateWeekNumberCB();
            cbWeekNumber.SelectedIndex = 1;

            RefreshWeeklySchedule();
            UpdateDepartments();
            UpdateCBXDepManager();
            UpdateDepsManualShiftPlanning();
        }


        private void UpdateDepartments()
        {
            lbxAllDepartments.Items.Clear();

            foreach (Department dep in this.departmentManagement.GetAllDepartments())
            {
                lbxAllDepartments.Items.Add(dep);
            }
        }

        public void FillComboBoxDepartments(bool isSuperuser)
        {
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                if (!isSuperuser && dep.Name == "Administration")
                {
                    continue;
                }
                cbEmpDepartment.Items.Add(dep.Name);
            }
            
        }

        private void AdministrationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!openOtherForm)
            {
                LoginForm loginForm = new LoginForm(departmentManagement, stockManagement, salesManagement);
                loginForm.Show();
            }
        }

        private void ClearFields()
        {
            //Personal information
            tbxEmpFname.Clear();
            tbxEmpLname.Clear();
            dtpEmpDateOfBirth.Value = DateTime.Today.Date;
            cbEmpGender.Text = "Choose gender";

            //Contact details
            tbxEmpEmail.Clear();
            tbxEmpPhone.Clear();
            tbxEmpAddressStreet.Clear();
            tbxEmpAddressCity.Clear();
            tbxEmpAddressCountry.Clear();
            tbxEmpAddressPostCode.Clear();
            tbxEmpBsn.Clear();

            //Emergency contact details
            tbxEmConName.Clear();
            cbEmConRelation.Text = "";
            tbxEmConEmail.Clear();
            tbxEmConPhone.Clear();

            //Job specifications
            cbEmpEmploymentType.Text = "";
            nudEmpHourlyWages.Value = 10;
            cbEmpDepartment.Text = "";
        }

        private void btnAddEmpoyee_Click(object sender, EventArgs e)
        {
            string fname;
            string lname;
            DateTime dateOfBirth;
            Gender gender;

            string email;
            string phone;
            string street;
            string city;
            string country;
            string postcode;
            string bsn;

            string emConName;
            EmergencyContactRelation emConRelation;
            string emConEmail;
            string emConPhone;

            EmploymentType empType;
            int hourlyWages;
            Department department;

            if (!String.IsNullOrEmpty(tbxEmpFname.Text) && !String.IsNullOrEmpty(tbxEmpLname.Text) &&
                !String.IsNullOrEmpty(dtpEmpDateOfBirth.Text) && cbEmpGender.Items.Contains(cbEmpGender.Text) &&
                !String.IsNullOrEmpty(tbxEmpEmail.Text) && !String.IsNullOrEmpty(tbxEmpPhone.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressStreet.Text) && !String.IsNullOrEmpty(tbxEmpAddressCity.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressCountry.Text) && !String.IsNullOrEmpty(tbxEmpAddressPostCode.Text) &&
                !String.IsNullOrEmpty(tbxEmConName.Text) && cbEmConRelation.Items.Contains(cbEmConRelation.Text) &&
                !String.IsNullOrEmpty(tbxEmConEmail.Text) && !String.IsNullOrEmpty(tbxEmConPhone.Text) &&
                cbEmpEmploymentType.Items.Contains(cbEmpEmploymentType.Text) && cbEmpDepartment.Items.Contains(cbEmpDepartment.Text))
            {
                fname = tbxEmpFname.Text;
                lname = tbxEmpLname.Text;
                dateOfBirth = dtpEmpDateOfBirth.Value;
                gender = (Gender)(Enum.Parse(typeof(Gender), cbEmpGender.SelectedItem.ToString()));

                email = tbxEmpEmail.Text;
                phone = tbxEmpPhone.Text;
                street = tbxEmpAddressStreet.Text;
                city = tbxEmpAddressCity.Text;
                country = tbxEmpAddressCountry.Text;
                postcode = tbxEmpAddressPostCode.Text;
                bsn = tbxEmpBsn.Text;

                emConName = tbxEmConName.Text;
                emConRelation = (EmergencyContactRelation)Enum.Parse(typeof(EmergencyContactRelation), cbEmConRelation.Text.ToString());
                emConEmail = tbxEmConEmail.Text;
                emConPhone = tbxEmConPhone.Text;

                empType = (EmploymentType)(Enum.Parse(typeof(EmploymentType), cbEmpEmploymentType.SelectedItem.ToString()));
                
                hourlyWages = Convert.ToInt32(nudEmpHourlyWages.Text);
                department = departmentManagement.GetDepartment(cbEmpDepartment.Text);

                //Department currentDep = departmentManagement.GetDepartment(department.Name);
                // if (department.AddEmployee(fname, lname, dateOfBirth, gender, email, phone, street, city, country,
                //   postcode, bsn, emConName, emConRelation, emConEmail, emConPhone, empType, hourlyWages, department))
                DBControl dbControl = new DBControl();

                if(department.GetEmployeeByEmail(email) == null)
                {
                    dbControl.AddEmployee(fname, lname, dateOfBirth, gender, email, phone, street, city, country, 
                        postcode, bsn, emConName, emConRelation, emConEmail, emConPhone, empType, hourlyWages, department);
                    dbControl.GetEmployees(this.departmentManagement);
                    MessageBox.Show("You have successfully hired a new employee!");
                    ClearFields();
                }
                else
                {
                    MessageBox.Show("There is already an employee with the same email!");
                }
            }
            else
            {
                MessageBox.Show("Please, fill all the fields in order to hire new employee!");
            }
        }

        public void ShowEmployeesList(List<Employee> employees)
        {
            lbxAllEmployees.Items.Clear();
            foreach (Employee emp in employees)
            {
                lbxAllEmployees.Items.Add(emp);
            }
        }

        private void btnShowEmp_Click(object sender, EventArgs e)
        {
            DBControl dbc = new DBControl();
            dbc.GetEmployees(this.departmentManagement);
            string departmentName;
            if (cbSelectEmpDepartment.Items.Contains(cbSelectEmpDepartment.Text))
            {
                if (cbSelectEmpDepartment.Text == "All")
                {
                    ShowEmployeesList(departmentManagement.GetAllEmployees());
                }
                else
                {
                    departmentName = cbSelectEmpDepartment.SelectedItem.ToString();
                    ShowEmployeesList(departmentManagement.GetEmployeesByDepartment(departmentName));
                }
            }
            else
            {
                MessageBox.Show("Please, choose a filter to show list of employees!");
            }

            
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            if (lbxAllEmployees.SelectedIndex != -1)
            {
                Employee selectedEmp = (Employee) lbxAllEmployees.SelectedItem;

                
                //Remove selected emp locally
                if (departmentManagement.GetDepartment(selectedEmp.Department.Name).RemoveEmployee(selectedEmp.Email))
                {
                    //Remove selected employee from db
                    DBControl dbControl = new DBControl();
                    dbControl.RemoveEmployee(selectedEmp.Id);
                    MessageBox.Show($"You have successfully removed employee with id:{selectedEmp.Id}");
                }
                else
                {
                    MessageBox.Show($"There is no employee with this id: {selectedEmp.Id}");
                }
            }
            else
            {
                MessageBox.Show("Please, select an employee from the list to remove it!");
            }
        }

        private void btnSearchEmp_Click(object sender, EventArgs e)
        {
            lbxAllEmployees.Items.Clear();

            string fullname;
            if (!String.IsNullOrEmpty(tbxSearchEmp.Text))
            {
                foreach (Employee emp in departmentManagement.GetAllEmployees())
                {
                    fullname = $"{emp.FirstName} {emp.LastName}";
                    // case first name
                    if (emp.FirstName == tbxSearchEmp.Text || emp.LastName == tbxSearchEmp.Text ||
                       fullname == tbxSearchEmp.Text)
                    {
                        lbxAllEmployees.Items.Add(emp);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please, write first name/last name or full name to search for employee!");
            }
        }

        private void tbxSearchEmp_Click(object sender, EventArgs e)
        {
            // Delete default description info in search bar to let user write
            // something without needed to delete default text
            tbxSearchEmp.Text = "";
        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            bool isSuperuser = false;
            if (lbxAllEmployees.SelectedIndex != -1)
            {
                if (currentEmp.Id == 1)
                {
                    isSuperuser = true;
                }
                Employee selectedEmp = (Employee)lbxAllEmployees.SelectedItem;
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(departmentManagement,
                    departmentManagement.GetDepartment(selectedEmp.Department.Name).GetEmployeeByEmail(selectedEmp.Email));
                editEmployeeForm.FillComboBoxDepartments(isSuperuser);
                editEmployeeForm.Show();
                /*openOtherForm = true;
                this.Close();*/
            }
            else
            {
                MessageBox.Show("Please, select an employee from the list to edit their information!");
            }
        }


        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            if (StockTBXCheck() == false)
            {
                MessageBox.Show("Please fill in all text boxes before adding stock.");
            }
            else
            {
                try
                {
                    string model = tbxStockModel.Text.ToUpper();
                    string brand = tbxStockBrand.Text.ToUpper();
                    double price = double.Parse(tbxStockPrice.Text);
                    int quantity = int.Parse(tbxStockQuantity.Text);
                    double height = double.Parse(tbxStockHeight.Text);
                    double width = double.Parse(tbxStockWidth.Text);
                    double depth = double.Parse(tbxStockDepth.Text);
                    double weight = double.Parse(tbxStockWeight.Text);
                    string shortDescription;

                    if (tbxStockShortDescription.Text == "")
                    {
                        shortDescription = "No description was added";
                    }
                    else
                    {
                        shortDescription = tbxStockShortDescription.Text;
                    }

                    //stockManagement.AddStock(model, brand, price, quantity, height, width, depth, weight, shortDescription);
                    DBControl dbControl = new DBControl();
                    if (stockManagement.SearchForStock(model, brand) == null)
                    {
                        dbControl.AddStock(model, brand, price, quantity, height, width, depth, weight, shortDescription);
                    }
                    else
                    {
                        Stock stock = stockManagement.SearchForStock(model, brand);
                        stock.Quantity += quantity;
                        dbControl.UpdateStockQuantity(stock);
                    }

                    dbControl.GetStocks(this.stockManagement);

                    ClearStockTbx();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please make sure that the values in the fields Price, Quantity, Width, Height, Depth and Weight are numeric. ");
                }
               
            }
        }

        private void BtnShowAllStocks_Click(object sender, EventArgs e)
        {
            lbAllStocks.Items.Clear();
            List<Stock> stocks = stockManagement.GetAllStocks();
            foreach (Stock stock in stocks)
            {
                lbAllStocks.Items.Add(stock);
            }
        }

        private void BtnSearchStock_Click(object sender, EventArgs e)
        {
            lbAllStocks.Items.Clear();
            List<Stock> stocks = stockManagement.GetAllStocks();
            string word = tbxSearchStock.Text;
            foreach (Stock stock in stocks)
            {
                if (stock.Brand.Contains(word.ToUpper()) || stock.Model.Contains(word.ToUpper()))
                {
                    lbAllStocks.Items.Add(stock);
                }
            }
        }

        private void SearchByIdBTN_Click(object sender, EventArgs e)
        {

            lbAllStocks.Items.Clear();
            List<Stock> stocks = stockManagement.GetAllStocks();
            string word = tbxSearchStock.Text;
            foreach (Stock stock in stocks)
            {
                if (word == stock.Id.ToString())
                {
                    lbAllStocks.Items.Add(stock);
                }
            }
        }

        private void BtnRemoveStock_Click(object sender, EventArgs e)
        {
            selectedStock = (Stock)lbAllStocks.SelectedItem;

            if (selectedStock != null)
            {
                RemoveStockForm removeStockForm = new RemoveStockForm(this);
                removeStockForm.Show();
            }
            else
            {
                MessageBox.Show("Please select the stock you wish to remove.");
            }
        }

        private void BtnEditStock_Click(object sender, EventArgs e)
        {
            selectedStock = (Stock)lbAllStocks.SelectedItem;
            if (selectedStock != null)
            {
                EditStockForm editStockForm = new EditStockForm(this);
                editStockForm.Show();
            }
            else
            {
                MessageBox.Show("Please select the stock you wish to edit");
            }
        }

        private void BtnStocksClearSelected_Click(object sender, EventArgs e)
        {
            lbAllStocks.ClearSelected();
        }
        private void ClearStockTbx()
        {
            tbxStockBrand.Clear();
            tbxStockModel.Clear();
            tbxStockPrice.Clear();
            tbxStockDepth.Clear();
            tbxStockQuantity.Clear();
            tbxStockHeight.Clear();
            tbxStockWeight.Clear();
            tbxStockWidth.Clear();
            tbxStockShortDescription.Clear();
        }
        private bool StockTBXCheck()
        {

            if (tbxStockModel.Text == "" || tbxStockBrand.Text == "" || tbxStockPrice.Text == "" || tbxStockQuantity.Text == "" || tbxStockWeight.Text == "" || tbxStockWidth.Text == "" || tbxStockHeight.Text == "" || tbxStockDepth.Text == "")
            {
                return false;
            }
            return true;
        }
        public Stock GetSelectedStock()
        {
            return selectedStock;
        }
        public StockManagement GetStockManagement()
        {
            return stockManagement;
        }
        public void StockListBoxRefresh()
        {
            lbAllStocks.Items.Clear();
            List<Stock> stocks = stockManagement.GetAllStocks();
            foreach (Stock stock in stocks)
            {
                lbAllStocks.Items.Add(stock);
            }
        }


        private void btnScheduleClearSelected_Click(object sender, EventArgs e)
        {
            ClearSelectionSchedule();
        }

        private void ClearSelectionSchedule()
        {
            lbxSelectedEmpShifts.Items.Clear();
            lbxAllEmployees.SelectedIndex = -1;
        }

        private void lbxScheduleAllEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee emp = null;
            DBControl dbc = new DBControl();

            emp = (Employee)cbEmps.SelectedItem;
            dbc.GetShifts(departmentManagement);

            lbxSelectedEmpShifts.Items.Clear();

            if (emp.GetAllShifts() != null)
            {
                foreach (Shift s in emp.GetAllShifts())
                {
                    lbxSelectedEmpShifts.Items.Add(s);
                }
            }
        }

        private void btnShift_Click(object sender, EventArgs e)
        {
            Shift shift = (Shift)lbxSelectedEmpShifts.SelectedItem;
            Employee emp = (Employee)cbEmps.SelectedItem;

            DBControl dbc = new DBControl();

            dbc.RemoveShift(shift);
            dbc.GetShifts(departmentManagement);

            emp.RemoveShift(shift.ID); // to improve

            dbc.GetShifts(departmentManagement);
            UpdateShiftsPerEmployee();
        }

        private List<Employee> GetDepManagers()
        {
            List<Employee> managers = new List<Employee>();
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                managers.Add(dep.Manager);
            }

            return managers;
        }

        private List<Employee> GetNotManagers()
        {
            List<Employee> notManagers = new List<Employee>();
            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                if (!GetDepManagers().Contains(emp))
                {
                    notManagers.Add(emp);
                }
            }

            return notManagers;
        }

        private void UpdateCBXDepManager()
        {
            cbDepartmentManager.Items.Clear();
            foreach (Employee emp in GetNotManagers())
            {
                cbDepartmentManager.Items.Add(emp);
            }
        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            string depName;
            Employee manager;
            DBControl dbControl = new DBControl();

            if (!String.IsNullOrEmpty(tbxDepartmentName.Text))
            {
                depName = tbxDepartmentName.Text;
                if (cbDepartmentManager.SelectedIndex != -1)
                {
                    //dep with manager
                    manager = (Employee)cbDepartmentManager.SelectedItem;
                    dbControl.AddDepartment(depName, manager);
                    dbControl.GetDepartments(this.departmentManagement);
                    dbControl.SetDepartmentManagers(this.departmentManagement);
                }
                else
                {
                    // dep without manager for now
                    dbControl.AddDepartment(depName);
                    dbControl.GetDepartments(this.departmentManagement);
                    
                }
                UpdateDepartments();
                tbxDepartmentName.Clear();
                UpdateCBXDepManager();
                cbDepartmentManager.Text = "Choose a manager";
                MessageBox.Show("You have successfully created new department!");
            }
            else
            {
                MessageBox.Show("Fill at least the name to create new department!");
            }

        }

        private void TbxSearchStock_Enter(object sender, EventArgs e)
        {
            if (tbxSearchStock.Text=="Search...")
            {
                tbxSearchStock.Text = "";
            }
        }

        private void UpdateDepsManualShiftPlanning()
        {
            cbDeps.Items.Clear();
            cbAllDeps.Items.Clear();

            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                cbDeps.Items.Add(dep.Name);
                cbAllDeps.Items.Add(dep.Name);
            }
        }


        private void btnAddShift_Click(object sender, EventArgs e)
        {
            gbChooseEmp.Visible = false;
            gbAssignShiftManually.Visible = true;
            gbViewRemoveShifts.Visible = false;
            
            Employee selectedEmp = (Employee)cbEmps.SelectedItem;

            lbEmpInfo.Text = $"Currently selected employee: {selectedEmp.FirstName} {selectedEmp.LastName} ({selectedEmp.Id})";
        }

        private void btnReturnAssign_Click(object sender, EventArgs e)
        {
            gbChooseEmp.Visible = true;
            gbAssignShiftManually.Visible = false;
            gbViewRemoveShifts.Visible = false;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            Employee selectedEmp = (Employee)cbEmps.SelectedItem;
            bool wfh;
            ShiftType type = new ShiftType();
            DateTime date = dtpShiftDate.Value;

            if (cbWFH.Checked)
            {
                wfh = true;
            }
            else
            {
                wfh = false;
            }

            if (cbShiftType.SelectedIndex == 0)
            {
                type = ShiftType.Morning;
            }
            else if (cbShiftType.SelectedIndex == 1)
            {
                type = ShiftType.Afternoon;
            }
            else if (cbShiftType.SelectedIndex == 2)
            {
                type = ShiftType.Evening;
            }
            dbc.AddShift(type, date, currentEmp.Id, wfh, selectedEmp);

            dbc.GetShifts(departmentManagement);
        }

        private void btnViewRemoveShifts_Click(object sender, EventArgs e)
        {
            lbxSelectedEmpShifts.Items.Clear();

            gbChooseEmp.Visible = false;
            gbAssignShiftManually.Visible = false;
            gbViewRemoveShifts.Visible = true;

            UpdateShiftsPerEmployee();
        }

        private void UpdateShiftsPerEmployee()
        {
            lbxSelectedEmpShifts.Items.Clear();

            Employee selectedEmp = (Employee)cbEmps.SelectedItem;

            foreach (Shift s in selectedEmp.GetAllShifts())
            {
                lbxSelectedEmpShifts.Items.Add(s);
            }
        }

        private void btnScheduleClearSelected_Click_1(object sender, EventArgs e)
        {
            lbxSelectedEmpShifts.SelectedIndex = -1;
        }

        private void btnReturnViewRemove_Click(object sender, EventArgs e)
        {
            gbChooseEmp.Visible = true;
            gbAssignShiftManually.Visible = false;
            gbViewRemoveShifts.Visible = false;
        }

        private void cbSelectedEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            Employee selectedEmp = (Employee)cbSelectedEmp.SelectedItem;

            cbEmployeesShifts.Items.Clear();

            foreach (Shift s in selectedEmp.GetAllShifts())
            {
                cbEmployeesShifts.Items.Add(s);
            }
        }

        private void cbAllDeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbSelectedEmp.Items.Clear();

            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                if (emp.Department.Name == cbAllDeps.SelectedItem)
                {
                    cbSelectedEmp.Items.Add(emp);
                }
            }
        }


        private void cbEmployeesShifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            Shift selectedShift = (Shift)cbEmployeesShifts.SelectedItem;

            if (selectedShift != null)
            {
                lbHasAttended.Visible = true;
                lbReason.Visible = true;
                cbHasAttended.Visible = true;
                tbReasonForAbsence.Visible = true;

                if (selectedShift.HasAttended == false)
                {
                    cbHasAttended.Checked = false;
                    tbReasonForAbsence.Text = selectedShift.NoShowReason;
                }
                else
                {
                    cbHasAttended.Checked = true;
                    tbReasonForAbsence.Text = null;
                }

            }
        }

        private void btnApplyAttendanceChanges_Click(object sender, EventArgs e)
        {
            Shift selectedShift = (Shift)cbEmployeesShifts.SelectedItem;
            bool attended;

            if(selectedShift != null)
            {

                if (cbHasAttended.Checked)
                {
                    attended = true;
                }
                else
                {
                    attended = false;
                }

                lbHasAttended.Visible = false;
                lbReason.Visible = false;
                cbHasAttended.Visible = false;
                tbReasonForAbsence.Visible = false;

                dbc.EditShiftAttendance(attended, tbReasonForAbsence.Text, selectedShift.ID);
                dbc.GetShifts(departmentManagement);
                RefreshWeeklySchedule();
            }
        }

        private void RefreshWeeklySchedule()
        {
            lbxWeeklySchedule.Items.Clear();

            foreach (Employee e in departmentManagement.GetAllEmployees())
            {
                foreach (Shift s in e.GetAllShifts())
                {
                    if(GetIso8601WeekOfYear(s.Date) == (int)cbWeekNumber.SelectedItem)
                    {
                        lbxWeeklySchedule.Items.Add($"{e.FirstName} {e.LastName} - {s.ToString()}");
                    }
                }
            }
        }

        private void UpdateWeekNumberCB()
        {
            for (int i = 0; i < 52; i++)
            {
                cbWeekNumber.Items.Add(i);
            }
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }

        private void cbWeekNumber_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshWeeklySchedule();
        }

        private void cbDeps_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbEmps.Items.Clear();

            foreach (Employee emp in departmentManagement.GetAllEmployees())
            {
                if (emp.Department.Name == cbDeps.SelectedItem)
                {
                    cbEmps.Items.Add(emp);
                }
            }
        }
    }

}

