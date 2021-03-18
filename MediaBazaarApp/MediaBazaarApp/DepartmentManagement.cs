using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class DepartmentManagement
    {
        //Fields
        List<Department> departments = new List<Department>();
        Department d;
        List<string> EmployeesPerDepartment = new List<string>();
        //Methods
        public bool AddDepartment(string name, Employee manager)
        {
            return true;
        }

        public bool RemoveDepartment(string depID)
        {
            return true;
        }

        public Department GetDepartment(string depID)
        {
            return null;
        }

        public List<Department> GetAllDepartments()
        {
            return departments;
        }
    }
}
