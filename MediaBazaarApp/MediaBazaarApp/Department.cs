using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class Department
    {
        //Fields
        private static int id;
        private int deptId;
        private string name;
        private Employee manager;
        private List<Employee> employees;

        //Properties
        public int Id
        {
            get { return this.Id; }
        }

        public int DeptId
        {
            get { return this.deptId; }
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public Employee Manager
        {
            get { return this.manager; }
            set { this.manager = value; }
        }

        //Constructor
        public Department(string name, Employee manager)
        {
            this.name = name;
            this.manager = manager;
            employees = new List<Employee>();

            //static id

            //dept id

        }

        //Methods
        public Employee GetEmployee(int id)
        {
            return null;
        }

        public bool AddEmployee(string firstName, string lastName, DateTime dateOfBirth, Gender gender, string email, 
            string phoneNumber, string street, string city, string country, string postcode, EmploymentType employmentType, 
            string position, double hourlyWages, Department department)
        {
            return true;
        }

        public bool RemoveEmployee(int id)
        {
            return true;
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public override string ToString()
        {
            // TODO
            return base.ToString();
        }


    }
}
