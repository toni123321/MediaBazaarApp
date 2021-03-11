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
    public partial class SuperuserForm : Form
    {
        private DepartmentManagement departmentManagement;
        
        public SuperuserForm(DepartmentManagement departmentManagement)
        {
            this.departmentManagement = departmentManagement;
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
            EmploymentType empType;
            string position;
            int hourlyWages;
            Department department;

            if (!String.IsNullOrEmpty(tbxEmpFname.Text) && !String.IsNullOrEmpty(tbxEmpLname.Text) &&
                !String.IsNullOrEmpty(dtpEmpDateOfBirth.Text) && cbEmpGender.SelectedIndex != -1 &&
                !String.IsNullOrEmpty(tbxEmpEmail.Text) && !String.IsNullOrEmpty(tbxEmpPhone.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressStreet.Text) && !String.IsNullOrEmpty(tbxEmpAddressCity.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressCountry.Text) && !String.IsNullOrEmpty(tbxEmpAddressPostCode.Text) &&
                cbEmpEmploymentType.SelectedIndex != -1 && !String.IsNullOrEmpty(tbxEmpPosition.Text) &&
                cbEmpHourlyWages.SelectedIndex != -1 && cbEmpDepartment.SelectedIndex != -1)
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
                empType = (EmploymentType)(Enum.Parse(typeof(EmploymentType), cbEmpEmploymentType.SelectedItem.ToString()));
                position = tbxEmpPosition.Text;
                hourlyWages = Convert.ToInt32(cbEmpHourlyWages.SelectedItem);
                department = departmentManagement.GetDepartment(cbEmpDepartment.SelectedItem.ToString());

                //Department currentDep = departmentManagement.GetDepartment(department.Name);
                if (department.AddEmployee(fname, lname, dateOfBirth, gender, email, phone, street, city, country,
                        postcode, empType, position, hourlyWages, department))
                {
                    MessageBox.Show("You have successfully hired a new employee!");
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

        private void SuperuserForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(departmentManagement);
            loginForm.Show();
        }
    }
}
