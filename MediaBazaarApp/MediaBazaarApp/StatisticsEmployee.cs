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
        
        public List<string> EmpPerDepToString(List<Department> departments)
        {

            List<string> results = new List<string>();

            foreach (Department d in departments)
            {
                results.Add($"{d.Name} has {d.GetAllEmployees().Count} employees");
            }
            return results;
        }
        public int CalculateNrOfEmployees(List<Employee> employees)
        {
            return employees.Count;
        }
        public double AveregeWageOfEmployee(List<Employee> employees)
        {
            int nrOfEmployees = employees.Count;
            //   double wagesSum = employees.Sum(wgs => wgs.HourlyWages);
            double wagesum = 0;
            for (int q = 0; q < employees.Count; q++)
            {
                wagesum += employees[q].HourlyWages;
            }
            return wagesum / nrOfEmployees;
        }


        public List<string> AveregeWagePerDepartmenr(List<Department> departments, List<Employee> employees)
        {
            List<string> results = new List<string>();

            foreach (Department d in departments)
            {
                results.Add($"Department: {d.Name} / Averege wage = €{AveregeWageOfEmployee(d.GetAllEmployees())}");
            }

            return results;
        }


    }
}
