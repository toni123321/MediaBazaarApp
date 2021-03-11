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
        
        //Superuser
        string superuserEmail = "superuser@gmail.com";
        int superuserId = 0;

        private DepartmentManagement departmentManagement;

        public LoginForm()
        {
            InitializeComponent();

            departmentManagement = new DepartmentManagement();
            departmentManagement.AddDepartment("Administration");
            departmentManagement.AddDepartment("Management");
            departmentManagement.AddDepartment("Depot");
            departmentManagement.AddDepartment("Sales");
        }

        public LoginForm(DepartmentManagement departmentManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
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
            // TODO: Check if all the fields are filled

            string email;
            int empId;
            string userType;
            string depName;

            if (!String.IsNullOrEmpty(tbxEmpEmail.Text) && !String.IsNullOrEmpty(tbxEmpId.Text) 
                && !String.IsNullOrEmpty(cbUserType.Text))
            {
                email = tbxEmpEmail.Text;
                empId = Convert.ToInt32(tbxEmpId.Text);
                userType = cbUserType.Text;
                depName = getDepartmentName(userType);
                
                
                if (email == superuserEmail && empId == superuserId && userType == "superuser")
                {
                    SuperuserForm superuserForm = new SuperuserForm(departmentManagement);
                    superuserForm.Show();
                    this.Hide();
                }
                else if (userType != "superuser" && checkForEmployeeCredentials(email, empId, depName) != -1)
                {
                    int index = checkForEmployeeCredentials(email, empId, depName);
                    Employee currentEmp = departmentManagement.GetDepartment(depName).GetAllEmployees()[index];
                    
                    // TODO: Add id to form sending
                    if (currentEmp.Department.Name == "Administration")
                    {
                        AdministrationForm administrationForm = new AdministrationForm(departmentManagement, currentEmp);
                        administrationForm.Show();
                        this.Hide();
                    }
                    else if (currentEmp.Department.Name == "Management")
                    {
                        ManagementForm managementForm = new ManagementForm(departmentManagement, currentEmp);
                        managementForm.Show();
                        this.Hide();
                    }
                    else if (currentEmp.Department.Name == "Sales")
                    {
                        SalesForm salesForm = new SalesForm(departmentManagement, currentEmp);
                        salesForm.Show();
                        this.Hide();
                    }
                    else
                    {
                        DepotWorkersForm depotWorkersForm = new DepotWorkersForm(departmentManagement, currentEmp);
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
