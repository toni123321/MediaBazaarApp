using System;
using System.Windows.Forms;

namespace MediaBazaarApp
{
    public partial class AssignWorkShiftsManuallyForm : Form
    {
        DepartmentManagement departmentManagement;
        StockManagement stockManagement;
        Employee currentEmp;
        Employee selectedEmp;
        SalesManagement salesManagement;
        DBControl dbc;

        public AssignWorkShiftsManuallyForm(DepartmentManagement departmentManagement, Employee currentEmp, Employee selectedEmp, SalesManagement salesManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.selectedEmp = selectedEmp;
            this.salesManagement = salesManagement;
            dbc = new DBControl();

            lbEmpInfo.Text = $"Adding shifts for {selectedEmp.FirstName} {selectedEmp.LastName} (ID: {selectedEmp.Id})";

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
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
        }

        private void AssignWorkShiftsManuallyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdministrationForm adminForm = new AdministrationForm(departmentManagement, currentEmp, salesManagement, stockManagement);
            adminForm.Show();
        }


    }
}
