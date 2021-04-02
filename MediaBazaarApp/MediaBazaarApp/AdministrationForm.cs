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

namespace MediaBazaarApp
{
    public partial class AdministrationForm : Form
    {
        private bool openOtherForm = false;
        private DepartmentManagement departmentManagement;
        private Employee currentEmp;
        private StockManagement stockManagement;
        private Stock selectedStock;
        SalesManagement salesManagement;

        public AdministrationForm(DepartmentManagement departmentManagement, Employee currentEmp, SalesManagement salesManagement, StockManagement stockManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.stockManagement = stockManagement;
            this.salesManagement = salesManagement;

            UpdateScheduleLBX();
            UpdateDepartments();
            UpdateCBXDepManager(cbDepartmentManager);

            //Made groupBox for editDepartment invisible
            gbxEditDepartment.Visible = false;

            // Greeting msg

            lbGreetingMsg.Text = $"Welcome, {currentEmp.FirstName}";
            RefreshCbSelectEmpDepartment();

            EmpFillDefaultValues();
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
                emConRelation = (EmergencyContactRelation)Enum.Parse(typeof(EmergencyContactRelation), cbEmConRelation.Text.ToString());
                emConEmail = tbxEmConEmail.Text;
                emConPhone = tbxEmConPhone.Text;

                empType = (EmploymentType)(Enum.Parse(typeof(EmploymentType), cbEmpEmploymentType.SelectedItem.ToString()));
                
                hourlyWages = Convert.ToInt32(nudEmpHourlyWages.Text);
                department = departmentManagement.GetDepartment(cbEmpDepartment.Text);

                DBControl dbControl = new DBControl();

                // TODO: Here catch exceptions
                try
                {
                    if (department.AddEmployee(fname, lname, dateOfBirth, gender, email, phone, street, city, country,
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
                catch(EmpAgeException ex)
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

                    RefreshEmployeesList();
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
                EditEmployeeForm editEmployeeForm = new EditEmployeeForm(this, departmentManagement,
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

        private void btnAssignShiftsManually_Click(object sender, EventArgs e)
        {
            Employee selectedEmp = (Employee)lbxScheduleAllEmp.SelectedItem;

            AssignWorkShiftsManuallyForm manualSchedule = new AssignWorkShiftsManuallyForm(departmentManagement, currentEmp, selectedEmp, salesManagement);
            manualSchedule.Show();
        }

        private void BtnAddStock_Click(object sender, EventArgs e)
        {
            if (StockTBXCheck() == false)
            {
                MessageBox.Show("Please fill in all text boxes before adding stock.");
            }
            else
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

        public void UpdateScheduleLBX()
        {
            lbxScheduleAllEmp.Items.Clear();

            foreach (Employee e in departmentManagement.GetAllEmployees())
            {
                lbxScheduleAllEmp.Items.Add(e);
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

            emp = (Employee)lbxScheduleAllEmp.SelectedItem;
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
            Employee emp = (Employee)lbxScheduleAllEmp.SelectedItem;

            DBControl dbc = new DBControl();

            dbc.RemoveShift(shift);
            dbc.GetShifts(departmentManagement);

            emp.RemoveShift(shift.ID); // to improve
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

        private void UpdateCBXDepManager(ComboBox cbx)
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
                    if (cbDepartmentManager.SelectedIndex != -1)
                    {
                        //dep with manager
                        manager = (Employee) cbDepartmentManager.SelectedItem;
                        //add locally and catch exceptions
                        departmentManagement.AddDepartment(depName);
                        //add to DB
                        dbControl.AddDepartment(depName, manager);
                        dbControl.GetDepartments(this.departmentManagement);
                        dbControl.SetDepartmentManagers(this.departmentManagement);
                    }
                    else
                    {
                        //add locally and catch exceptions
                        departmentManagement.AddDepartment(depName);
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
                dbControl.RemoveDepartment(dep.Name);
                departmentManagement.RemoveDepartment(dep.Name);
                //dbControl.GetDepartments(this.departmentManagement);
                MessageBox.Show($"You have successfully removed branch with name:{dep.Name}");
                
                UpdateDepartments();
                UpdateCBXDepManager(cbDepartmentManager);
                RefreshCbSelectEmpDepartment();
                FillComboBoxDepartments();

                //refresh employee list
                RefreshEmployeesList();

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
                        manager = (Employee) cbDepartmentManagerEdit.SelectedItem;
                        //Update department locally and catch exceptions
                        departmentManagement.GetDepartment(depId).Name = newName;
                        //Update department into DB
                        dbControl.UpdateDepartment(depId, newName, manager.Id);
                    }
                    else
                    {
                        departmentManagement.GetDepartment(depId).Name = newName;
                        dbControl.UpdateDepartment(depId, newName);
                    }

                    departmentManagement.RemoveDepartment(dep.Name);
                    dbControl.GetDepartments(departmentManagement);
                    dbControl.SetDepartmentManagers(departmentManagement);
                    //UpdateDepartments();
                    MessageBox.Show("The new changes are successfully applied!");
                    gbxEditDepartment.Visible = false;
                    //RefreshCbSelectEmpDepartment();
                    //FillComboBoxDepartments();

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
            if(lbxAllDepartments.SelectedIndex != -1)
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
    }
}
