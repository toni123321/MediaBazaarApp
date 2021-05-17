using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class LoginForm : Form
    {
        private DepartmentManagement departmentManagement;
        private StockManagement stockManagement;
        private Dictionary<string, bool> stockStorage;
        private SalesManagement salesManagement;
        private DBControl dbControl = new DBControl();

        public LoginForm()
        {
            InitializeComponent();

            departmentManagement = new DepartmentManagement();
            stockManagement = new StockManagement();
            salesManagement = new SalesManagement();

            this.stockManagement.startStorage();
            this.stockStorage = this.stockManagement.GetStorage();

            dbControl.GetDepartments(this.departmentManagement);
            dbControl.GetEmployees(this.departmentManagement);
            dbControl.SetDepartmentManagers(this.departmentManagement);
            dbControl.GetShifts(this.departmentManagement);
            dbControl.GetStocks(this.stockManagement);
            dbControl.GetShelfRestockRequests(this.salesManagement, this.stockManagement);

        }

        public LoginForm(DepartmentManagement departmentManagement, StockManagement stockManagement, SalesManagement salesManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.stockManagement = stockManagement;
            this.salesManagement = salesManagement;
            stockStorage = this.stockManagement.GetStorage();
        }



        private int checkForEmployeeCredentials(string email, int employeeId, string depName)
        {
            int index = -1;
            Department empDepartment = departmentManagement.GetDepartment(depName);

            if (empDepartment == null)
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
                        AdministrationForm administrationForm = new AdministrationForm(departmentManagement, currentEmp, salesManagement, stockManagement);

                        administrationForm.FillComboBoxDepartments();
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

    }
}
