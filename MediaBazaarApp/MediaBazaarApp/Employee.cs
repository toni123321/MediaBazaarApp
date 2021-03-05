using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class Employee
    {
        //Fields
        private static int id;
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private Gender gender;

        private string email;
        private string phoneNumber;
        private string street;
        private string city;
        private string country;
        private string postcode;
        private EmploymentType employmentType;
        private double hourlyWages;
        private string position;
        private Department department;

        private int remainingHolidayDays;

        private List<Shift> shifts;

        //Properties
        public int Id
        {
            get { return this.Id; }
        }
        public string FirstName
        {
            get { return this.firstName; }
            set { this.firstName = value; }
        }
        public string LastName
        {
            get { return this.lastName; }
            set { this.lastName = value; }
        }
        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set { this.dateOfBirth = value; }
        }
        public Gender Gender
        {
            get { return this.gender; }
            set { this.gender = value; }
        }
        public string Email
        {
            get { return this.email; }
            set { this.email = value; }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set { this.phoneNumber = value; }
        }
        public string Street
        {
            get { return this.street; }
            set { this.street = value; }
        }
        public string City
        {
            get { return this.city; }
            set { this.city = value; }
        }
        public string Country
        {
            get { return this.country; }
            set { this.country = value; }
        }
        public string Postcode
        {
            get { return this.postcode; }
            set { this.postcode = value; }
        }
        public EmploymentType EmploymentType
        {
            get { return this.employmentType; }
            set { this.employmentType = value; }
        }
        public double HourlyWages
        {
            get { return this.hourlyWages; }
            set { this.hourlyWages = value; }
        }
        public string Position
        {
            get { return this.position; }
            set { this.position = value; }
        }
        public Department Department
        {
            get { return this.department; }
            set { this.department = value; }
        }
        public int RemainingHolidayDays
        {
            get { return this.remainingHolidayDays; }
            set { this.remainingHolidayDays = value; }
        }

        //Constructor
        public Employee(string firstName, string lastName, DateTime dateOfBirth, Gender gender, string email,
            string phoneNumber, string street, string city, string country, string postcode, EmploymentType employmentType,
            string position, double hourlyWages, Department department)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;

            this.email = email;
            this.phoneNumber = phoneNumber;
            this.street = street;
            this.city = city;
            this.country = country;
            this.postcode = postcode;

            this.employmentType = employmentType;
            this.position = position;
            this.hourlyWages = hourlyWages;
            this.department = department;

            shifts = new List<Shift>();

            //static id
        }

        //Methods
        public override string ToString()
        {
            //TODO
            return base.ToString();
        }
        public int Attendance(int days)
        {
            return 0;
        }
        public bool AddShift(ShiftType type , DateTime date, Employee assignedBy)
        {
            return true;
        }
        public bool RemoveShift(int id)
        {
            return true;
        }

        public Shift GetShift(int id)
        {
            return null;
        }

        public List<Shift> GetAllShifts()
        {
            return shifts;
        } 


    }
}
