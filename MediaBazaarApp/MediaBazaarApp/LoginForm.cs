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

        DepartmentManagement departmentManagement;

        public LoginForm()
        {
            InitializeComponent();
        }
        public LoginForm(DepartmentManagement departmentManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
        }


        private int checkForEmployeeCredentials(string email, int employeeId)
        {
            int index = -1;

            // Fix bug if there is no employees at the moment(only the superuser is in the system)
            if(departmentManagement == null)
            {
                return index;
            }

            foreach (Department department in departmentManagement.GetAllDepartments())
            {
                List<Employee> allEmp = department.GetAllEmployees();
                foreach (Employee emp in allEmp)
                {
                    if(emp.Email == email && emp.Id == employeeId)
                    {
                        index = allEmp.IndexOf(emp);
                    }
                }
            }
            return index;        
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string email = tbxEmpEmail.Text;
            int empId = Convert.ToInt32(tbxEmpId.Text);

            if(email == superuserEmail && empId == superuserId)
            {
                SuperuserForm superuserForm = new SuperuserForm();
                superuserForm.Show();
                this.Hide();
            }
            else if(checkForEmployeeCredentials(email, empId) != -1)
            {
                AdministrationForm administrationForm = new AdministrationForm(departmentManagement);
                administrationForm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("The credentials you provide are incorrect!");
            }
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Close the whole application
            System.Windows.Forms.Application.Exit();
        }
    }
}
