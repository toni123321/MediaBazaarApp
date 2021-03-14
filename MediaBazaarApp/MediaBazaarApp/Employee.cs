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
        private int id;
        private static int idCounter = 1;

        //Personal Information
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private Gender gender;

        //Contact details
        private string email;
        private string phoneNumber;
        private string street;
        private string city;
        private string country;
        private string postcode;
        private string bsn = "999999990";
        
        //Emergency contact detials
        private string emConName;
        private EmergencyContactRelation emConRelation;
        private string emConEmail;
        private string emConPhoneNum;


        // Job specifications
        private EmploymentType employmentType;
        private double hourlyWages;
        private Department department;

        private int remainingHolidayDays;

        private List<Shift> shifts;

        //Properties
        public int Id
        {
            get { return this.id; }
        }

        // Personal information
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

        //Contact details
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

        public string Bsn
        {
            get { return this.bsn; }
            set { this.bsn = value; }
        }

        //Emergency contact details
        public string EmConName
        {
            get { return this.emConName; }
            set { this.emConName = value; }
        }

        public EmergencyContactRelation EmConRelation
        {
            get { return this.emConRelation; }
            set { this.emConRelation = value; }
        }

        public string EmConEmail
        {
            get { return this.emConEmail; }
            set { this.emConEmail = value; }
        }

        public string EmConPhoneNum
        {
            get { return this.emConPhoneNum; }
            set { this.emConPhoneNum = value; }
        }

        //Job specifications
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
            string phoneNumber, string street, string city, string country, string postcode, string bsn, string emConName, 
            EmergencyContactRelation emConRelation, string emConEmail, string emConPhoneNum, EmploymentType employmentType,
            double hourlyWages, Department department)
        {
            //Personal information
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;

            // Contact details
            this.email = email;
            this.phoneNumber = phoneNumber;
            this.street = street;
            this.city = city;
            this.country = country;
            this.postcode = postcode;
            
            if (bsn != "")
            {
                this.bsn = bsn;
            }

            //Emergency contact details
            this.emConName = emConName;
            this.emConRelation = emConRelation;
            this.emConEmail = emConEmail;
            this.emConPhoneNum = emConPhoneNum;

            //Job specification
            this.employmentType = employmentType;
            this.hourlyWages = hourlyWages;
            this.department = department;

            shifts = new List<Shift>();

            // id 
            id = idCounter;
            idCounter++;

        }

        //Methods
        public override string ToString()
        {
            //TODO
            return $"Id:{this.Id} - {this.firstName} {this.lastName}";
        }
        public int Attendance(int days)
        {
            return 0;
        }
<<<<<<< Updated upstream
        public bool AddShift(ShiftType type , DateTime date, Employee assignedBy)
=======
        public bool AddShift(ShiftType type, DateTime date, Employee assignedBy, bool wfh)
>>>>>>> Stashed changes
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
