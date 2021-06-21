using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class EmployeesExpiredContractManager
    {
        private IList<Employee> employees;
        private DBControl storage;
        private DepartmentManagement departmentManagement;
        public EmployeesExpiredContractManager(DepartmentManagement departmentManagement)
        {
            employees = new List<Employee>();
            storage = new DBControl();
            this.departmentManagement = departmentManagement;
            LoadDataFromStorage();
        }


        public Employee GetEmployeeById(int empId)
        {
            foreach (Employee emp in employees)
            {
                if(emp.Id == empId)
                {
                    return emp;
                }
            }
            return null;
        }


        public void LoadDataFromStorage()
        {
            employees = storage.GetEmployeesWithExpiringContracts(departmentManagement);
        }

        public void RenewEmployeeContract(Employee emp)
        {
            // TODO: Calls employee update method from dbControl
            storage.EditEmployee(emp);
            departmentManagement.GetAllEmployees();
            LoadDataFromStorage();
        }

        public IList<Employee> GetEmployeesWithExpiredContract()
        {
            LoadDataFromStorage();
            return employees;
        }
    }
}
