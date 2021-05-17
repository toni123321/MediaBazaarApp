using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaBazaarApp.Custom_exceptions;
using System.Globalization;

namespace MediaBazaarApp
{
    public partial class AdministrationForm : Form
    {
        private bool openOtherForm = false;
        private DepartmentManagement departmentManagement;
        private Employee currentEmp;
        private StockManagement stockManagement;
        private Dictionary<string, bool> stockSotrage;
        private Stock selectedStock;
        private SalesManagement salesManagement;
        private DBControl dbc;

        private double price = 0;
        private int quantity = 0;
        private double height = 0;
        private double width = 0;
        private double depth = 0;
        private double weight = 0;
        Point last;
        int afk;

        public AdministrationForm(DepartmentManagement departmentManagement, Employee currentEmp,
            SalesManagement salesManagement, StockManagement stockManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.stockManagement = stockManagement;
            this.stockSotrage = this.stockManagement.GetStorage();
            this.salesManagement = salesManagement;
            dbc = new DBControl();

            gbChooseEmp.Visible = true;
            gbAssignShiftManually.Visible = false;
            gbViewRemoveShifts.Visible = false;

            UpdateWeekNumberCB();
            cbWeekNumber.SelectedIndex = 1;

            RefreshWeeklySchedule();
            UpdateDepartments();
            UpdateCBXDepManager(cbDepartmentManager);
            UpdateDepsManualShiftPlanning();

            //Made groupBox for editDepartment invisible
            gbxEditDepartment.Visible = false;

            // Greeting msg

            //lbGreetingMsg.Text = $"Welcome, {currentEmp.FirstName}";
            RefreshCbSelectEmpDepartment();

            EmpFillDefaultValues();

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

        private void RefreshCbSelectEmpDepartment()
        {
            cbSelectEmpDepartment.Items.Clear();
            cbSelectEmpDepartment.Items.Add("All");
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                cbSelectEmpDepartment.Items.Add(dep.Name);
            }
        }


        private void UpdateDepartments()
        {
            lbxAllDepartments.Items.Clear();

            foreach (Department dep in this.departmentManagement.GetAllDepartments())
            {
                lbxAllDepartments.Items.Add(dep);
            }
        }

        public bool CheckIsSuperuser()
        {
            bool isSuperuser = false;
            if (currentEmp.Email == "john@gmail.com" && currentEmp.Id == 1)
            {
                isSuperuser = true;
            }

            return isSuperuser;
        }

        public void FillComboBoxDepartments()
        {
            cbEmpDepartment.Items.Clear();
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                if (CheckIsSuperuser() && dep.Name == "Administration")
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

        private void EmpFillDefaultValues()
        {
            tbxEmpFname.Text = "Test";
            tbxEmpLname.Text = "Test";
            dtpEmpDateOfBirth.Value = new DateTime(1985, 5, 12);
            cbEmpGender.Text = Gender.MALE.ToString();

            //Contact details
            tbxEmpEmail.Text = "test@gmail.com";
            tbxEmpPhone.Text = "+31 456 789 899";
            tbxEmpAddressStreet.Text = "Henderson";
            tbxEmpAddressCity.Text = "Eindhoven";
            tbxEmpAddressCountry.Text = "Netherlands";
            tbxEmpAddressPostCode.Text = "2345HK";
            tbxEmpBsn.Text = "888999777";

            //Emergency contact details
            tbxEmConName.Text = "Testing Testing";
            cbEmConRelation.Text = EmergencyContactRelation.Colleague.ToString();
            tbxEmConEmail.Text = "test456@gmail.com";
            tbxEmConPhone.Text = "0031 876 456 112";

            //Job specifications
            cbEmpEmploymentType.Text = EmploymentType.PARTTIME1.ToString();
            nudEmpHourlyWages.Text = (19).ToString();
            cbEmpDepartment.Text = "Management";
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

        private bool CheckEmployeeFields()
        {
            if (!String.IsNullOrEmpty(tbxEmpFname.Text) && !String.IsNullOrEmpty(tbxEmpLname.Text) &&
                !String.IsNullOrEmpty(dtpEmpDateOfBirth.Text) && cbEmpGender.Items.Contains(cbEmpGender.Text) &&
                !String.IsNullOrEmpty(tbxEmpEmail.Text) && !String.IsNullOrEmpty(tbxEmpPhone.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressStreet.Text) && !String.IsNullOrEmpty(tbxEmpAddressCity.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressCountry.Text) && !String.IsNullOrEmpty(tbxEmpAddressPostCode.Text) &&
                !String.IsNullOrEmpty(tbxEmConName.Text) && cbEmConRelation.Items.Contains(cbEmConRelation.Text) &&
                !String.IsNullOrEmpty(tbxEmConEmail.Text) && !String.IsNullOrEmpty(tbxEmConPhone.Text) &&
                cbEmpEmploymentType.Items.Contains(cbEmpEmploymentType.Text) &&
                cbEmpDepartment.Items.Contains(cbEmpDepartment.Text))
            {
                return true;
            }

            return false;
        }

        private void btnAddEmpoyee_Click(object sender, EventArgs e)
        {
            string fname, lname;
            DateTime dateOfBirth;
            Gender gender;

            string email, phone, street, city, country, postcode, bsn, emConName;
            EmergencyContactRelation emConRelation;
            string emConEmail, emConPhone;

            EmploymentType empType;
            int hourlyWages;
            Department department;

            if (CheckEmployeeFields())
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
                emConRelation = (EmergencyContactRelation)Enum.Parse(typeof(EmergencyContactRelation),
                    cbEmConRelation.Text.ToString());
                emConEmail = tbxEmConEmail.Text;
                emConPhone = tbxEmConPhone.Text;

                empType = (EmploymentType)(Enum.Parse(typeof(EmploymentType),
                    cbEmpEmploymentType.SelectedItem.ToString()));

                hourlyWages = Convert.ToInt32(nudEmpHourlyWages.Text);
                department = departmentManagement.GetDepartment(cbEmpDepartment.Text);

                DBControl dbControl = new DBControl();

                // TODO: Here catch exceptions
                try
                {
                    if (department.AddEmployee(departmentManagement, fname, lname, dateOfBirth, gender, email, phone, street, city, country,
                        postcode, bsn, emConName, emConRelation, emConEmail, emConPhone, empType, hourlyWages,
                        department))
                    {
                        if (String.IsNullOrEmpty(bsn))
                        {
                            bsn = "999999990";
                        }

                        dbControl.AddEmployee(fname, lname, dateOfBirth, gender, email, phone, street, city, country,
                            postcode, bsn, emConName, emConRelation, emConEmail, emConPhone, empType, hourlyWages,
                            department);
                        dbControl.GetEmployees(this.departmentManagement);
                        MessageBox.Show("You have successfully hired a new employee!");
                        ClearFields();
                        UpdateCBXDepManager(cbDepartmentManager);
                        RefreshEmployeesList();
                    }
                    else
                    {
                        MessageBox.Show("There is already an employee with the same email!");
                    }
                }
                catch (EmpNameException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (EmpAgeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (EmpEmailException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (EmpPhoneException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (EmpStreetException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (EmpCityException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (EmpCountryException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (EmpPostcodeException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (EmpBsnException ex)
                {
                    MessageBox.Show(ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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
                if (emp.Email != currentEmp.Email) // Check if the emp is the currently logged user
                {
                    lbxAllEmployees.Items.Add(emp);
                }
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

        public void RefreshEmployeesList()
        {
            //Refresh automatically the list(show all employees)
            DBControl dbControl = new DBControl();
            dbControl.GetEmployees(this.departmentManagement);
            ShowEmployeesList(this.departmentManagement.GetAllEmployees());
            cbSelectEmpDepartment.SelectedIndex = 0;
        }

        public void RemoveDepManager(Employee selectedEmp)
        {
            foreach (Department dep in departmentManagement.GetAllDepartments())
            {
                if (dep.Manager != null && dep.Manager.Id == selectedEmp.Id)
                {
                    dep.Manager = null;
                }
            }
        }

        private void btnRemoveEmp_Click(object sender, EventArgs e)
        {
            if (lbxAllEmployees.SelectedIndex != -1)
            {
                Employee selectedEmp = (Employee)lbxAllEmployees.SelectedItem;


                //Remove selected emp locally
                if (departmentManagement.GetDepartment(selectedEmp.Department.Name).RemoveEmployee(selectedEmp.Email))
                {

                    //Remove selected employee from db
                    DBControl dbControl = new DBControl();
                    dbControl.RemoveEmployee(selectedEmp.Id);
                    MessageBox.Show($"You have successfully removed employee with id:{selectedEmp.Id}");

                    // remove manager locally
                    RemoveDepManager(selectedEmp);

                    RefreshEmployeesList();
                    UpdateCBXDepManager(cbDepartmentManager);
                    UpdateDepartments();
                    RefreshCbSelectEmpDepartment();
                    FillComboBoxDepartments();

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

                tbxSearchEmp.Text = "Search...";
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
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(this, departmentManagement,
                    departmentManagement.GetDepartment(selectedEmp.Department.Name)
                        .GetEmployeeByEmail(selectedEmp.Email));
                editEmployeeForm.FillComboBoxDepartments(isSuperuser);
                editEmployeeForm.Show();
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
                    price = double.Parse(tbxStockPrice.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field price is not numeric.");
                }
                try
                {
                    quantity = int.Parse(tbxStockQuantity.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field quantity is not a whole number.");
                }
                try
                {
                    height = double.Parse(tbxStockHeight.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field height is not numeric.");
                }
                try
                {
                    width = double.Parse(tbxStockWidth.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field width is not numeric.");
                }
                try
                {
                    depth = double.Parse(tbxStockDepth.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field depth is not numeric.");
                }
                try
                {
                    weight = double.Parse(tbxStockWeight.Text);
                }
                catch
                {
                    MessageBox.Show("The value you entered for the field weight is not numeric.");
                }

                string model = tbxStockModel.Text.ToUpper();
                string brand = tbxStockBrand.Text.ToUpper();

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

                if (price == 0 || quantity == 0 || height == 0 || width == 0 || depth == 0 || weight == 0)
                {
                    MessageBox.Show($"Some of the fields contain invalid values. (Non-numeric or 0)");
                }
                else
                {
                    DBControl dbControl = new DBControl();
                    if (stockManagement.SearchForStock(model, brand) == null)
                    {
                        dbControl.AddStock(model, brand, price, quantity, height, width, depth, weight, shortDescription, stockManagement);
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

            if (shift != null)
            {
                dbc.RemoveShift(shift);
                dbc.GetShifts(departmentManagement);

                emp.RemoveShift(shift.ID); // to improve

                dbc.GetShifts(departmentManagement);
                UpdateShiftsPerEmployee();
            }
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

        public void UpdateCBXDepManager(ComboBox cbx)
        {
            cbx.Items.Clear();
            foreach (Employee emp in GetNotManagers())
            {
                cbx.Items.Add(emp);
            }
        }

        private void btnCreateDepartment_Click(object sender, EventArgs e)
        {
            string depName;
            Employee manager;
            DBControl dbControl = new DBControl();

            if (!String.IsNullOrEmpty(tbxDepartmentName.Text))
            {
                try
                {
                    depName = tbxDepartmentName.Text;
                    if (departmentManagement.AddDepartment(depName))
                    {

                        if (cbDepartmentManager.SelectedIndex != -1)
                        {
                            //dep with manager
                            manager = (Employee)cbDepartmentManager.SelectedItem;
                            //add locally and catch exceptions

                            //add to DB
                            dbControl.AddDepartment(depName, manager);
                            dbControl.GetDepartments(this.departmentManagement);
                            dbControl.SetDepartmentManagers(this.departmentManagement);
                        }
                        else
                        {
                            //add locally and catch exceptions

                            //add to DB
                            // dep without manager for now
                            dbControl.AddDepartment(depName);
                            dbControl.GetDepartments(this.departmentManagement);

                        }

                        UpdateDepartments();
                        tbxDepartmentName.Clear();
                        UpdateCBXDepManager(cbDepartmentManager);
                        cbDepartmentManager.Text = "Choose a manager";
                        MessageBox.Show("You have successfully created new department!");
                        RefreshCbSelectEmpDepartment();
                        FillComboBoxDepartments();
                    }
                    else
                    {
                        MessageBox.Show($"Department with the same name: {depName} already exists!");
                    }
                }
                catch (DepNameException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Fill at least the name to create new department!");
            }

        }

        private void btnRemoveDepartment_Click(object sender, EventArgs e)
        {
            if (lbxAllDepartments.SelectedIndex != -1)
            {
                Department dep = (Department)lbxAllDepartments.SelectedItem;
                DBControl dbControl = new DBControl();

                if (dep.GetAllEmployees().Count == 0)
                {
                    dbControl.RemoveDepartment(dep.Name);
                    departmentManagement.RemoveDepartment(dep.Name);
                    //dbControl.GetDepartments(this.departmentManagement);
                    MessageBox.Show($"You have successfully removed department with name:{dep.Name}");

                    UpdateDepartments();
                    UpdateCBXDepManager(cbDepartmentManager);
                    RefreshCbSelectEmpDepartment();
                    FillComboBoxDepartments();

                    //refresh employee list
                    RefreshEmployeesList();
                }
                else
                {
                    MessageBox.Show("This department can't be deleted, because has employees!");
                }

                /*if (dep.GetAllEmployees().Count > 0)
                {
                    RemoveDepartmentForm removeDepartmentForm = new RemoveDepartmentForm(this, dep);
                    removeDepartmentForm.Show();
                }
                else
                {
                    DBControl dbControl = new DBControl();
                    dbControl.RemoveDepartment(dep.Name);
                    departmentManagement.RemoveDepartment(dep.Name);
                    //dbControl.GetDepartments(this.departmentManagement);
                    MessageBox.Show($"You have successfully removed branch with name:{dep.Name}");
                    RefreshCbSelectEmpDepartment();
                    FillComboBoxDepartments();
                }*/
            }
            else
            {
                MessageBox.Show("Please, select an department to remove it!");
            }
        }

        private void btnEditDepartment_Click(object sender, EventArgs e)
        {
            if (lbxAllDepartments.SelectedIndex != -1)
            {
                Department dep = (Department)lbxAllDepartments.SelectedItem;
                tbxDepartmentNameEdit.Text = dep.Name;
                UpdateCBXDepManager(cbDepartmentManagerEdit);
                if (dep.Manager != null)
                {
                    lbDepartmentCurrManagerEdit.Text = $"Current manager:{dep.Manager}";
                    cbDepartmentManagerEdit.Items.Add(dep.Manager);
                    cbDepartmentManagerEdit.SelectedIndex = cbDepartmentManagerEdit.Items.Count - 1;
                }
                else
                {
                    lbDepartmentCurrManagerEdit.Text = $"Current manager: there is no manager";
                }

                lbDepartmentEditInfo.Text = $"Department with Id:{dep.Id}";
                gbxEditDepartment.Visible = true;

            }
            else
            {
                MessageBox.Show("Please, select an department to edit it!");
            }
        }

        private void btnApplyChangesDepartment_Click(object sender, EventArgs e)
        {
            int depId = Convert.ToInt32(lbDepartmentEditInfo.Text.Split(':')[1]);
            Department dep = departmentManagement.GetDepartment(depId);
            string newName;
            Employee manager;

            DBControl dbControl = new DBControl();

            if (!String.IsNullOrEmpty(tbxDepartmentNameEdit.Text))
            {
                try
                {
                    newName = tbxDepartmentNameEdit.Text;
                    if (cbDepartmentManagerEdit.SelectedIndex != -1)
                    {
                        manager = (Employee)cbDepartmentManagerEdit.SelectedItem;
                        //Update department locally and catch exceptions
                        dep.Name = newName;
                        //Update department into DB
                        dbControl.UpdateDepartment(depId, newName, manager.Id);
                    }
                    else
                    {
                        dep.Name = newName;
                        if (dep.Manager != null)
                        {
                            int newIdManager = -1; // means the manager is removed
                            dep.Name = newName; // update dep name locally
                            dep.Manager = null; // update dep manager locally
                            dbControl.UpdateDepartment(depId, newName, newIdManager);
                        }
                        else
                        {
                            dep.Name = newName; // update dep name locally
                            dbControl.UpdateDepartment(depId, newName);
                        }
                    }

                    //departmentManagement.RemoveDepartment(dep.Name);

                    dbControl.GetDepartments(departmentManagement);
                    dbControl.SetDepartmentManagers(departmentManagement);

                    MessageBox.Show("The new changes are successfully applied!");
                    tbxDepartmentNameEdit.Clear();
                    cbDepartmentManagerEdit.Text = "Choose a manager";
                    gbxEditDepartment.Visible = false;

                    UpdateDepartments();
                    UpdateCBXDepManager(cbDepartmentManager);
                    RefreshCbSelectEmpDepartment();
                    FillComboBoxDepartments();

                    //refresh employee list
                    RefreshEmployeesList();
                }
                catch (DepNameException ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please, fill the text box to apply changes!");
            }
        }

        private void btnDepartmentsClearSelected_Click(object sender, EventArgs e)
        {
            if (lbxAllDepartments.SelectedIndex != -1)
            {
                lbxAllDepartments.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("To unmark a line, you should have selected one beforehand!");
            }
        }

        private void btnClearSelectedEmp_Click(object sender, EventArgs e)
        {
            if (lbxAllEmployees.SelectedIndex != -1)
            {
                lbxAllEmployees.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("To unmark a selected employee, choose one beforehand!");
            }
        }

        private void btnSearchDep_Click(object sender, EventArgs e)
        {
            lbxAllDepartments.Items.Clear();

            if (!String.IsNullOrEmpty(tbxSearchDep.Text))
            {
                foreach (Department dep in departmentManagement.GetAllDepartments())
                {
                    // case first name
                    if (dep.Name == tbxSearchDep.Text ||
                        dep.DeptId == tbxSearchDep.Text)
                    {
                        lbxAllDepartments.Items.Add(dep);
                    }
                    else if ((dep.Manager != null && dep.Manager.FirstName == tbxSearchDep.Text))
                    {
                        lbxAllDepartments.Items.Add(dep);
                    }
                }
                tbxSearchDep.Text = "Search...";
            }
            else
            {
                MessageBox.Show("Please, write down department Name to search!");
            }
        }


        private void tbxSearchDep_Click(object sender, EventArgs e)
        {

            // Delete default description info in search bar to let user write
            // something without needed to delete default text
            tbxSearchDep.Text = "";
        }

        private void btnShowAllDep_Click(object sender, EventArgs e)
        {
            UpdateDepartments();
        }

        private void TbxSearchStock_Enter(object sender, EventArgs e)
        {
            if (tbxSearchStock.Text == "Search...")
            {
                tbxSearchStock.Text = "";
            }
        }

        private void tabControlAdministration_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlAdministration.SelectedTab == ManageDepartmentsTab)
            {
                UpdateCBXDepManager(cbDepartmentManager);
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
            if (cbDeps.SelectedIndex < 0 || cbEmps.SelectedIndex < 0)
            {
                throw new NotAllFieldFilled();
            }
            else
            {
                gbChooseEmp.Visible = false;
                gbAssignShiftManually.Visible = true;
                gbViewRemoveShifts.Visible = false;

                Employee selectedEmp = (Employee)cbEmps.SelectedItem;

                lbEmpInfo.Text = $"Currently selected employee: {selectedEmp.FirstName} {selectedEmp.LastName} ({selectedEmp.Id})";
            }

        }

        private void btnReturnAssign_Click(object sender, EventArgs e)
        {
            gbChooseEmp.Visible = true;
            gbAssignShiftManually.Visible = false;
            gbViewRemoveShifts.Visible = false;
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            if (cbShiftType.SelectedIndex < 0)
            {
                throw new NotAllFieldFilled();
            }
            else
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


        }

        private void btnViewRemoveShifts_Click(object sender, EventArgs e)
        {
            if (cbDeps.SelectedIndex < 0 || cbEmps.SelectedIndex < 0)
            {
                throw new NotAllFieldFilled();
            }
            else
            {

                lbxSelectedEmpShifts.Items.Clear();

                gbChooseEmp.Visible = false;
                gbAssignShiftManually.Visible = false;
                gbViewRemoveShifts.Visible = true;

                UpdateShiftsPerEmployee();
            }
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

            dbc.GetShifts(departmentManagement);
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

            dbc.GetShifts(departmentManagement);
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

            dbc.GetShifts(departmentManagement);
        }

        private void btnApplyAttendanceChanges_Click(object sender, EventArgs e)
        {
            Shift selectedShift = (Shift)cbEmployeesShifts.SelectedItem;
            bool attended;

            if (selectedShift != null)
            {

                if (cbHasAttended.Checked)
                {
                    attended = true;
                    selectedShift.HasAttended = true;
                    selectedShift.NoShowReason = "";
                }
                else
                {
                    attended = false;
                    selectedShift.HasAttended = false;
                    selectedShift.NoShowReason = tbReasonForAbsence.Text;
                }

                lbHasAttended.Visible = false;
                lbReason.Visible = false;
                cbHasAttended.Visible = false;
                tbReasonForAbsence.Visible = false;

                cbAllDeps.SelectedIndex = -1;
                cbSelectedEmp.SelectedIndex = -1;

                dbc.EditShiftAttendance(attended, tbReasonForAbsence.Text, selectedShift.ID);
                dbc.GetShifts(departmentManagement);
                RefreshWeeklySchedule();
                UpdateDepsManualShiftPlanning();

            }
        }

        private void RefreshWeeklySchedule()
        {
            lbxWeeklySchedule.Items.Clear();

            foreach (Employee e in departmentManagement.GetAllEmployees())
            {
                foreach (Shift s in e.GetAllShifts())
                {
                    if (GetIso8601WeekOfYear(s.Date) == (int)cbWeekNumber.SelectedItem)
                    {
                        lbxWeeklySchedule.Items.Add($"{e.FirstName} {e.LastName} - {s.ToString()}");
                    }
                }
            }
        }

        private void UpdateWeekNumberCB()
        {
            for (int i = 1; i <= 52; i++)
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
            dbc.GetShifts(departmentManagement);
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            WelcomeMessage();

            Point current = Cursor.Position;
            if (current == last)
            {
                afk++;
                if(afk == 15)
                {
                    MessageBox.Show("You have been logged out due to being idle. Please, log in again.");
                    afk = 0;
                    this.Close();
                }
            }
            last = Cursor.Position;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AutomatedScheduleHandler ash = new AutomatedScheduleHandler(departmentManagement);

            ash.AssignShifts(20, 2021);
            RefreshWeeklySchedule();
        }
    }
 } 

            
  
 


