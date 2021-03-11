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
        DepartmentManagement departmentManagement;
        public AdministrationForm(DepartmentManagement departmentManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
        }

        private void btnAssignShiftsManually_Click(object sender, EventArgs e)
        {
            //find employee obj

            //AssignWorkShiftsManuallyForm manualSchedule = new AssignWorkShiftsManuallyForm(departmentManagement, emp);
            //this.Close();
        }
    }
}
