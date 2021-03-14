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
        Employee emp;
        public AssignWorkShiftsManuallyForm(DepartmentManagement departmentManagement, Employee emp)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.emp = emp;

        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int empID;
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
                type = ShiftType.MORNING;
            }
            else if(cbShiftType.SelectedIndex == 1)
            {
                type = ShiftType.AFTERNOON;
            }
            else if (cbShiftType.SelectedIndex == 2)
            {
                type = ShiftType.EVENING;
            }

            emp.AddShift(type, date, emp, wfh);
        }

        private void AssignWorkShiftsManuallyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdministrationForm adminForm = new AdministrationForm(departmentManagement, emp);
            adminForm.Show();
        }

    }
}
