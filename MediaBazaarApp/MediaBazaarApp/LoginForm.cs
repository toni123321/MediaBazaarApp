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
    public partial class LoginForm : Form
    {
        private DepartmentManagement departmentManagement;
        private StockManagement stockManagement;
        private SalesManagement salesManagement;

        private void CreateAdministrationManager()
        {
            string fname = "John";
            string lname = "Brandon";
            DateTime dateOfBirth = new DateTime(1981, 3, 25);
            Gender gender = Gender.MALE;

            string email = "john@gmail.com";
            string phone = "+31 456 732 555";
            string street = "Robbenstraat 5";
            string city = "Eindhoven";
            string country = "Netherlands";
            string postcode = "4567FG";
            string bsn = "888756345";

            string emConName = "Elizabet";
            EmergencyContactRelation emConRelation = EmergencyContactRelation.Family;
            string emConEmail = "elizabet@gmail.com";
            string emConPhone = "+31 373 512 239";

            EmploymentType empType = EmploymentType.FULLTIME;
            int hourlyWages = 20;
            Department department = departmentManagement.GetDepartment("Administration");
            

            // departmentManagement.GetDepartment("Administration").AddEmployee(fname, lname,
            //     dateOfBirth, gender, email, phone, street, city, country, postcode, bsn, emConName, emConRelation,
            //     emConEmail, emConPhone, empType, hourlyWages, department);
        }

        public LoginForm()
        {
            InitializeComponent();

            
            departmentManagement = new DepartmentManagement();
            stockManagement = new StockManagement();
            salesManagement = new SalesManagement();
            
            // Succeed: Get deparments from DB 
            DBControl dbControl = new DBControl();
            dbControl.GetDepartments(this.departmentManagement);
            dbControl.GetEmployees(this.departmentManagement);
            dbControl.SetDepartmentManagers(this.departmentManagement);
            dbControl.GetShifts(this.departmentManagement);
            dbControl.GetStocks(this.stockManagement);
            dbControl.GetShelfRestockRequests(this.salesManagement, this.stockManagement);

            // departmentManagement.AddDepartment("Administration");
            // departmentManagement.AddDepartment("Management");
            // departmentManagement.AddDepartment("Depot");
            // departmentManagement.AddDepartment("Sales");
            //
            // CreateAdministrationManager();
            // Employee manager = departmentManagement.GetDepartment("Administration").GetEmployeeById(1);
            // departmentManagement.GetDepartment("Administration").Manager = manager;
        }

        public LoginForm(DepartmentManagement departmentManagement, StockManagement stockManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.stockManagement = stockManagement;
        }

        private string getDepartmentName(string userType)
        {
            string depName;

            switch (userType)
            {
                case "employeeAdministration":
                    depName = "Administration";
                    break;
                case "employeeManagement":
                    depName = "Management";
                    break;
                case "depotWorker":
                    depName = "Depot";
                    break;
                case "employeeSales":
                    depName = "Sales";
                    break;
                default:
                    depName = null;
                    break;
            }
            return depName;
        }

        private int checkForEmployeeCredentials(string email, int employeeId, string depName)
        {
            int index = -1;
            Department empDepartment = departmentManagement.GetDepartment(depName);

            if(empDepartment == null)
            {
                return -1;
            }

            List<Employee> allEmpInDepartment = empDepartment.GetAllEmployees();
            foreach (Employee emp in allEmpInDepartment)
            {
                if (emp.Email == email && emp.Id == employeeId)
                {
                    index = allEmpInDepartment.IndexOf(emp);
                }
            }
            return index;
        }


        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email;
            int empId;
            string departmentName;

            if (!String.IsNullOrEmpty(tbxEmpEmail.Text) && !String.IsNullOrEmpty(tbxEmpId.Text) 
                && cbDepartment.Items.Contains(cbDepartment.Text))
            {
                email = tbxEmpEmail.Text;
                empId = Convert.ToInt32(tbxEmpId.Text);
                departmentName = cbDepartment.Text;
                
                if (checkForEmployeeCredentials(email, empId, departmentName) != -1)
                {
                    int index = checkForEmployeeCredentials(email, empId, departmentName);
                    Employee currentEmp = departmentManagement.GetDepartment(departmentName).GetAllEmployees()[index];
                    
                    if (currentEmp.Department.Name == "Administration")
                    {
                        bool isSuperuser = false;
                        AdministrationForm administrationForm = new AdministrationForm(departmentManagement, currentEmp, salesManagement, stockManagement);
                        
                        if (currentEmp.Email == "john@gmail.com" && currentEmp.Id == 1)
                        {
                            isSuperuser = true;
                        }
                        administrationForm.FillComboBoxDepartments(isSuperuser);
                        administrationForm.Show();
                        this.Hide();


                    }
                    else if (currentEmp.Department.Name == "Management")
                    {
                        ManagementForm managementForm = new ManagementForm(departmentManagement, currentEmp, salesManagement, stockManagement);
                        managementForm.Show();
                        this.Hide();
                    }
                    else if (currentEmp.Department.Name == "Sales")
                    {
                        SalesForm salesForm = new SalesForm(departmentManagement, currentEmp, salesManagement, stockManagement);
                        salesForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        DepotWorkersForm depotWorkersForm = new DepotWorkersForm(departmentManagement, currentEmp, salesManagement, stockManagement);
                        depotWorkersForm.Show();
                        this.Hide();
                    }

                }
                else
                {
                    MessageBox.Show("The credentials you provide are incorrect!");
                }
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the whole application
            System.Windows.Forms.Application.Exit();
        }

        private void btnAddEmpDB_Click(object sender, EventArgs e)
        {
            // Add emp
            DBControl dbControl = new DBControl();
            // Employee emp = new Employee("Test", "Test", DateTime.Today, Gender.MALE, 
            //     "test@", "555", "test", "test", "test", "test",
            //     "test", "test", EmergencyContactRelation.Family, "test", "test",
            //     EmploymentType.FULLTIME, 12, departmentManagement.GetDepartment("Administration"));
            //
            //dbControl.AddEmployee(emp);
        }

        private void btnRemoveEmpDB_Click(object sender, EventArgs e)
        {
            DBControl dbControl = new DBControl();
            dbControl.RemoveEmployee(3);
        }



        private void btnAddDepDB_Click(object sender, EventArgs e)
        {
            // Add dep
            DBControl dbControl = new DBControl();
            //Department dep = new Department("TestDep");
            //dbControl.AddDepartment(dep);
        }

        private void btnUpdateDepDB_Click(object sender, EventArgs e)
        {
            // Update dep
            DBControl dbControl = new DBControl();
            dbControl.UpdateDepartment(3);
        }

        private void btnRemoveDepDB_Click(object sender, EventArgs e)
        {

        }
        

    }
}
