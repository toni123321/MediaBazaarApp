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
    public partial class SalesForm : Form
    {
        private DepartmentManagement departmentManagement;
        private Employee currentEmp;
        public SalesForm(DepartmentManagement departmentManagement, Employee currentEmp)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
            this.currentEmp = currentEmp;
        }

        private void SalesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(departmentManagement);
            loginForm.Show();
        }
    }
}
