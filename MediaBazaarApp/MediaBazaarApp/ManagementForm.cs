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
    public partial class ManagementForm : Form
    {
        DepartmentManagement departmentManagement;
        
        public ManagementForm(DepartmentManagement departmentManagement)
        {
            InitializeComponent();
            this.departmentManagement = departmentManagement;
        }

        private void ManagementForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm loginForm = new LoginForm(departmentManagement);
            loginForm.Show();
        }
    }
}
