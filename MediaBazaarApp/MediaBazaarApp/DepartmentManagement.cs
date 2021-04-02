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

        public Department GetDepartment(int id)
        {
            foreach (Department dep in departments)
            {
                if (dep.Id == id)
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

        public List<Employee> GetAllEmployees()
        {
            List<Employee> allEmployees = new List<Employee>();
            foreach (Department department in departments)
            {
                allEmployees.AddRange(department.GetAllEmployees());
            }
            return allEmployees;
        }

        public List<Employee> GetEmployeesByDepartment(string depName)
        {
            return GetDepartment(depName).GetAllEmployees();
        }
    }
}
