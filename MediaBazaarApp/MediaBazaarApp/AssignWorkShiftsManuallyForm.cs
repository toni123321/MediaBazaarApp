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

        private void AssignWorkShiftsManuallyForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            AdministrationForm adminForm = new AdministrationForm(departmentManagement);
            adminForm.Show();
        }
    }
}
