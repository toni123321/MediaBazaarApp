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
    public partial class AssignWorkShiftsManuallyForm : Form
    {
        DepartmentManagement departmentManagement;
        StockManagement stockManagement;
        Employee currentEmp;
        Employee selectedEmp;
        public AssignWorkShiftsManuallyForm(DepartmentManagement departmentManagement, Employee currentEmp, Employee selectedEmp)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
            this.selectedEmp = selectedEmp;

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
            else if(cbShiftType.SelectedIndex == 1)
            {
                type = ShiftType.Afternoon;
            }
            else if (cbShiftType.SelectedIndex == 2)
            {
                type = ShiftType.Evening;
            }

            DBControl dbc = new DBControl();
            dbc.AddShift(new Shift(type, date, currentEmp.Id, wfh), selectedEmp);
            dbc.GetShifts(departmentManagement);
        }

        private void AssignWorkShiftsManuallyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdministrationForm adminForm = new AdministrationForm(departmentManagement ,stockManagement, currentEmp);
            adminForm.Show();
        }

       
    }
}
