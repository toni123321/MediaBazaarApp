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
        private static int id = 1;
        private string deptId;
        private string name;
        private Employee manager;
        private List<Employee> employees;

        //Properties
        public int Id
        {
            get { return id; }
        }

        public string DeptId
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

        //Constructors
        public Department(string name)
        {
            this.name = name;
            employees = new List<Employee>();

            string firstLetters = this.name.Substring(0, 2);
            //dept id
            deptId = $"{firstLetters}{id}";

            //static id
            id++;
        }
        public Department(string name, Employee manager)
        {
            this.name = name;
            this.manager = manager;
            employees = new List<Employee>();

            string firstLetters = this.name.Substring(0, 2);
            //dept id
            deptId = $"{firstLetters}{id}";

            //static id
            id++;
        }

        //Methods
        public Employee GetEmployeeById(int id)
        {
            foreach (Employee emp in employees)
            {
                if (emp.Id == id)
                {
                    return emp;
                }
            }
            return null;
        }

        public Employee GetEmployeeByEmail(string email)
        {
            foreach (Employee emp in employees)
            {
                if(emp.Email == email)
                {
                    return emp;
                }
            }
            return null;
        }
        

        public bool AddEmployee(string firstName, string lastName, DateTime dateOfBirth, Gender gender, string email, 
            string phoneNumber, string street, string city, string country, string postcode, string bsn,
            string emConName, EmergencyContactRelation emConRelation, string emConEmail, string emConPhoneNum,
            EmploymentType employmentType, double hourlyWages, Department department)
        {
            if (GetEmployeeByEmail(email) == null)
            {
                Employee newEmp = new Employee(firstName, lastName, dateOfBirth, gender, email, phoneNumber,
                    street, city, country, postcode, bsn, emConName, emConRelation, emConEmail, emConPhoneNum, 
                    employmentType, hourlyWages, department);
                employees.Add(newEmp);
                return true;
            }
            return false;
        }

        public bool RemoveEmployee(string email)
        {
            Employee currEmp = GetEmployeeByEmail(email);
            if (currEmp != null)
            {
                employees.Remove(currEmp);
                return true;
            }
            return false;
        }

        public List<Employee> GetAllEmployees()
        {
            return employees;
        }

        public override string ToString()
        {
            // TODO
            return this.name;
        }


    }
}
