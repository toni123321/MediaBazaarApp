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
    public partial class AdministrationForm : Form
    {
        private bool openOtherForm = false;
        private DepartmentManagement departmentManagement;
        private Employee currentEmp;

        public AdministrationForm(DepartmentManagement departmentManagement, Employee currentEmp)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
        }

        public AdministrationForm()
        {
            InitializeComponent();

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
                LoginForm loginForm = new LoginForm(departmentManagement);
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
                if (department.AddEmployee(fname, lname, dateOfBirth, gender, email, phone, street, city, country,
                  postcode, bsn, emConName, emConRelation, emConEmail, emConPhone, empType, hourlyWages, department))
                {
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
            // Show emp by department
            // All
            // Administration
            // Management
            // Sales 
            // Depot

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
                if (departmentManagement.GetDepartment(selectedEmp.Department.Name).RemoveEmployee(selectedEmp.Email))
                {
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
    }
}
