using MediaBazaarApp.Custom_exceptions;
using System;
using System.Drawing;
using System.Globalization;
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

        private void ManageEndDateViewFields()
        {
            // Points for date time picker
            
            
            // Points for text box
            Point locationEndDateLabelDTP = new Point(835, 394);
            Point locationEndDateDateTimePicker = new Point(933, 389);

            Point locationEndDateLabelTBX = new Point(796, 442);
            Point locationEndDateTextBox = new Point(934, 439);


            if (currEmp.EndDate == DateTime.MaxValue)
            {
                tbxEmpEndDate.Visible = true;
                dtpEmpEndDate.Visible = true;
                lbEmpNewEndDate.Visible = true;
                cbxEmpIndefiniteContract.Visible = false;

                tbxEmpEndDate.Location = locationEndDateDateTimePicker;
                tbxEmpEndDate.Text = "Indefinite";
                
                dtpEmpEndDate.Location = locationEndDateTextBox;

            }
            else
            {
                tbxEmpEndDate.Visible = false;
                dtpEmpEndDate.Visible = true;
                lbEmpNewEndDate.Visible = false;
                cbxEmpIndefiniteContract.Visible = true;

                dtpEmpEndDate.Location = locationEndDateDateTimePicker;
                dtpEmpEndDate.Value = currEmp.EndDate;
                cbxEmpIndefiniteContract.Location = locationEndDateTextBox;
            }
        }

        private void ShowDetailsFilled()
        {
            //Personal information
            tbxEmpFname.Text = currEmp.FirstName;
            tbxEmpLname.Text = currEmp.LastName;
            dtpEmpDateOfBirth.Value = currEmp.DateOfBirth;
            cbEmpGender.Text = currEmp.Gender.ToString();
            tbxEmpNationality.Text = currEmp.Nationality;

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
            nudEmpHourlyWages.Text = currEmp.HourlyWages.ToString(CultureInfo.InvariantCulture);
            cbEmpDepartment.Text = currEmp.Department.Name;
            previousDepartment = currEmp.Department;
            dtpEmpStartDate.Value = currEmp.StartDate;

            ManageEndDateViewFields();
        }

        private void EditEmployeeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Refresh the employee list after edit

            this.administrationForm.RefreshEmployeesList();
        }

        private bool CheckInputs()
        {
            bool isInputValid = !String.IsNullOrEmpty(tbxEmpFname.Text) && !String.IsNullOrEmpty(tbxEmpLname.Text) &&
                                !String.IsNullOrEmpty(dtpEmpDateOfBirth.Text) && cbEmpGender.Items.Contains(cbEmpGender.Text) &&
                                !String.IsNullOrEmpty(tbxEmpNationality.Text) &&
                                !String.IsNullOrEmpty(tbxEmpEmail.Text) && !String.IsNullOrEmpty(tbxEmpPhone.Text) &&
                                !String.IsNullOrEmpty(tbxEmpAddressStreet.Text) && !String.IsNullOrEmpty(tbxEmpAddressCity.Text) &&
                                !String.IsNullOrEmpty(tbxEmpAddressCountry.Text) && !String.IsNullOrEmpty(tbxEmpAddressPostCode.Text) &&
                                !String.IsNullOrEmpty(tbxEmConName.Text) && cbEmConRelation.Items.Contains(cbEmConRelation.Text) &&
                                !String.IsNullOrEmpty(tbxEmConEmail.Text) && !String.IsNullOrEmpty(tbxEmConPhone.Text) &&
                                !String.IsNullOrEmpty(dtpEmpStartDate.Text) && !String.IsNullOrEmpty(dtpEmpEndDate.Text) &&
                                cbEmpEmploymentType.Items.Contains(cbEmpEmploymentType.Text) && cbEmpDepartment.Items.Contains(cbEmpDepartment.Text);
            return isInputValid;
        }

        private void btnEditEmpoyee_Click(object sender, EventArgs e)
        {
            if (CheckInputs())
            {
                try
                {
                    //Personal information
                    currEmp.FirstName = tbxEmpFname.Text;
                    currEmp.LastName = tbxEmpLname.Text;
                    currEmp.DateOfBirth = dtpEmpDateOfBirth.Value;
                    currEmp.Gender = (Gender) (Enum.Parse(typeof(Gender), cbEmpGender.SelectedItem.ToString()));
                    currEmp.Nationality = tbxEmpNationality.Text;

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
                    currEmp.EmConRelation = (EmergencyContactRelation) Enum.Parse(typeof(EmergencyContactRelation),
                        cbEmConRelation.Text.ToString());
                    currEmp.EmConEmail = tbxEmConEmail.Text;
                    currEmp.EmConPhoneNum = tbxEmConPhone.Text;

                    //Job specifications
                    currEmp.EmploymentType = (EmploymentType) (Enum.Parse(typeof(EmploymentType),
                        cbEmpEmploymentType.SelectedItem.ToString()));
                    currEmp.HourlyWages = Convert.ToInt32(nudEmpHourlyWages.Text);
                    currEmp.Department = departmentManagement.GetDepartment(cbEmpDepartment.Text);
                    currEmp.StartDate = dtpEmpStartDate.Value;
                    currEmp.EndDate = dtpEmpEndDate.Value;

                    if (cbxEmpIndefiniteContract.Checked)
                    {
                        currEmp.EndDate = DateTime.MaxValue;
                    }

                    DBControl dbControl = new DBControl();
                    dbControl.EditEmployee(currEmp);
                    this.departmentManagement.GetDepartment(previousDepartment.Name).RemoveEmployee(currEmp.Email);

                    MessageBox.Show("You have successfully apply the new changes for this profile!");
                }
                catch (InputFieldException ex)
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
                MessageBox.Show("Please, fill all the fields in order to apply changes!");
            }

        }
    }
}
