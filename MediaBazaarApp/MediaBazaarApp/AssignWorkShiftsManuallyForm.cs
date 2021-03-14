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
        public AssignWorkShiftsManuallyForm()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            int empID;
            bool wfh;
            ShiftType type;
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

            //emp.AddShift(type, date, Employee assignedBy, wfh);
        }
    }
}
