using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class StatisticsEmployee
    {
        
        public List<Employee> GetAllEmployees(List<Employee> employees)
        {
            return employees;
        }
        
        public string EmpPerDepToString(List<Department> departments)
        {
            foreach (Department d in departments)
            {
                return ($"{d.Name} has {d.GetAllEmployees().Count} employees");
            }
            return null;
        }
        public int CalculateNrOfEmployees(List<Employee> employees)
        {
            return employees.Count;
        }
        public double AveregeWagePerDepartmenr(Department department, List<Employee> employees)
        {
            int nrOfEmployees = employees.Count;
            double wagesSum = employees.Sum(wgs => wgs.HourlyWages);
            return wagesSum / nrOfEmployees;
        }
     
        

        

}
}
