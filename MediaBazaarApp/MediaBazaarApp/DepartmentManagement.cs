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

        public DepartmentManagement()
        {

        }
        //Methods
        public bool AddDepartment(string name)
        {
            if (GetDepartment(name) == null)
            {
                Department newDepartment = new Department(name);
                departments.Add(newDepartment);
                return true;
            }
            return false;
        }

        public bool AddDepartment(string name, Employee manager)
        {
            if (GetDepartment(name) == null)
            {
                Department newDepartment = new Department(name, manager);
                departments.Add(newDepartment);
                return true;
            }
            return false;
        }
        

        public bool RemoveDepartment(string name)
        {
            if(GetDepartment(name) != null)
            {
                departments.Remove(GetDepartment(name));
                return true;
            }
            return false;
        }

        public Department GetDepartment(string name)
        {
            foreach (Department dep in departments)
            {
                if(dep.Name == name)
                {
                    return dep;
                }
            }
            return null;
        }

        public List<Department> GetAllDepartments()
        {
            return departments;
        }
    }
}
