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
    public partial class EditEmployeeForm : Form
    {
        private DepartmentManagement departmentManagement;
        private Employee currEmp;
        private Department previousDepartment;
        private AdministrationForm administrationForm;

        public EditEmployeeForm(AdministrationForm administrationForm, DepartmentManagement departmentManagement, Employee currEmp)
        {
            InitializeComponent();
            this.administrationForm = administrationForm;
            this.departmentManagement = departmentManagement;
            this.currEmp = currEmp;
            ShowDetailsFilled();

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

        private void ShowDetailsFilled()
        {
            //Personal information
            tbxEmpFname.Text = currEmp.FirstName;
            tbxEmpLname.Text = currEmp.LastName;
            dtpEmpDateOfBirth.Value = currEmp.DateOfBirth;
            cbEmpGender.Text = currEmp.Gender.ToString();
            
            //Contact details
            tbxEmpEmail.Text = currEmp.Email;
            tbxEmpPhone.Text = currEmp.PhoneNumber;
            tbxEmpAddressStreet.Text = currEmp.Street;
            tbxEmpAddressCity.Text = currEmp.City;
            tbxEmpAddressCountry.Text = currEmp.Country;
            tbxEmpAddressPostCode.Text = currEmp.Postcode;
            tbxEmpBsn.Text = currEmp.Bsn;
            
            //Emergency contact details
            tbxEmConName.Text = currEmp.EmConName;
            cbEmConRelation.Text = currEmp.EmConRelation.ToString();
            tbxEmConEmail.Text = currEmp.EmConEmail;
            tbxEmConPhone.Text = currEmp.EmConPhoneNum;

            //Job specifications
            cbEmpEmploymentType.Text = currEmp.EmploymentType.ToString();
            nudEmpHourlyWages.Text = currEmp.HourlyWages.ToString();
            cbEmpDepartment.Text = currEmp.Department.Name;
            previousDepartment = currEmp.Department;

        }

        private void EditEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Refresh the employee list after edit

            this.administrationForm.RefreshEmployeesList();
        }

        private void btnEditEmpoyee_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(tbxEmpFname.Text) && !String.IsNullOrEmpty(tbxEmpLname.Text) &&
                !String.IsNullOrEmpty(dtpEmpDateOfBirth.Text) && cbEmpGender.Items.Contains(cbEmpGender.Text) &&
                !String.IsNullOrEmpty(tbxEmpEmail.Text) && !String.IsNullOrEmpty(tbxEmpPhone.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressStreet.Text) && !String.IsNullOrEmpty(tbxEmpAddressCity.Text) &&
                !String.IsNullOrEmpty(tbxEmpAddressCountry.Text) && !String.IsNullOrEmpty(tbxEmpAddressPostCode.Text) &&
                !String.IsNullOrEmpty(tbxEmConName.Text) && cbEmConRelation.Items.Contains(cbEmConRelation.Text) &&
                !String.IsNullOrEmpty(tbxEmConEmail.Text) && !String.IsNullOrEmpty(tbxEmConPhone.Text) &&
                cbEmpEmploymentType.Items.Contains(cbEmpEmploymentType.Text) && cbEmpDepartment.Items.Contains(cbEmpDepartment.Text))
            {
                //Personal information
                currEmp.FirstName = tbxEmpFname.Text;
                currEmp.LastName = tbxEmpLname.Text;
                currEmp.DateOfBirth = dtpEmpDateOfBirth.Value;
                currEmp.Gender = (Gender)(Enum.Parse(typeof(Gender), cbEmpGender.SelectedItem.ToString()));

                //Contact details
                currEmp.Email = tbxEmpEmail.Text;
                currEmp.PhoneNumber = tbxEmpPhone.Text;
                currEmp.Street = tbxEmpAddressStreet.Text;
                currEmp.City = tbxEmpAddressCity.Text;
                currEmp.Country = tbxEmpAddressCountry.Text;
                currEmp.Postcode = tbxEmpAddressPostCode.Text;
                currEmp.Bsn = tbxEmpBsn.Text;

                //Emergency contact details
                currEmp.EmConName = tbxEmConName.Text;
                currEmp.EmConRelation = (EmergencyContactRelation)Enum.Parse(typeof(EmergencyContactRelation), cbEmConRelation.Text.ToString());
                currEmp.EmConEmail = tbxEmConEmail.Text;
                currEmp.EmConPhoneNum = tbxEmConPhone.Text;

                //Job specifications
                currEmp.EmploymentType = (EmploymentType)(Enum.Parse(typeof(EmploymentType), cbEmpEmploymentType.SelectedItem.ToString()));
                currEmp.HourlyWages = Convert.ToInt32(nudEmpHourlyWages.Text);
                currEmp.Department = departmentManagement.GetDepartment(cbEmpDepartment.Text);

                DBControl dbControl = new DBControl();
                dbControl.EditEmployee(currEmp);
                this.departmentManagement.GetDepartment(previousDepartment.Name).RemoveEmployee(currEmp.Email);
                MessageBox.Show("You have successfully apply the new changes for this profile!");
            }
            else
            {
                MessageBox.Show("Please, fill all the fields in order to apply changes!");
            }

        }
    }
}
