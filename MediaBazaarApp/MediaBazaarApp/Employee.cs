using MediaBazaarApp.Custom_exceptions;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MediaBazaarApp
{
    public class Employee
    {
        //Fields
        private int id;
        //private static int idCounter = 1;

        //Personal Information
        private string firstName;
        private string lastName;
        private DateTime dateOfBirth;
        private string nationality;
        private Gender gender;

        //Contact details
        private string email;
        private string phoneNumber;
        private string street;
        private string city;
        private string country;
        private string postcode;
        private string bsn;

        //Emergency contact detials
        private string emConName;
        private EmergencyContactRelation emConRelation;
        private string emConEmail;
        private string emConPhoneNum;


        // Job specifications
        private EmploymentType employmentType;
        private double hourlyWages;

        //Contract specifications
        private DateTime startDate;
        private DateTime endDate;
        private Department department;

        private int remainingHolidayDays;

        private List<Shift> shifts;

        //Properties
        public int Id
        {
            set { this.id = value; }
            get { return this.id; }
        }

        // Personal information
        public string FirstName
        {
            get { return this.firstName; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Z]{1}[a-z]+(?:[ ][A-Z]{1}[a-z]+){0,}$");
                if (isValid)
                {
                    this.firstName = value;
                }
                else
                {
                    //Throw exception
                    throw new InputFieldException("First name is not in the correct format!");
                }
            }
        }
        public string LastName
        {
            get { return this.lastName; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Z]{1}[a-z]+(?:[ |-][A-Z]{1}[a-z]+){0,}$");
                if (isValid)
                {
                    this.lastName = value;
                }
                else
                {
                    //Throw exception
                    throw new InputFieldException("Last name is not in the correct format!");
                }
            }
        }
        public DateTime DateOfBirth
        {
            get { return this.dateOfBirth; }
            set
            {
                DateTime currDate = DateTime.Today;
                DateTime birthday = value;

                int age = currDate.Year - birthday.Year;

                if (currDate.Month < birthday.Month || (currDate.Month == birthday.Month && currDate.Day < birthday.Day)) //not had bday this year yet
                {
                    age--;
                }

                if (age >= 18)
                {
                    this.dateOfBirth = value;
                }
                else
                {
                    // throw age exception
                    throw new InputFieldException($"Invalid birth date({value.ToString("dd/MM/yyyy")}), your age should be at least 18");
                }
            }
        }

        public string Nationality
        {
            get
            {
                return this.nationality;
            }
            
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Z][a-z]+$");
                if (isValid)
                {
                    this.nationality = value;
                }
                else
                {
                    throw new InputFieldException($"Invalid format for Nationality. Your input: {value}");
                }
            }
        }

        public Gender Gender
        {
            get { return this.gender; }
            set
            {
                bool isValid = Regex.IsMatch(value.ToString(), @"^(MALE|FEMALE|OTHER)$");
                if (isValid)
                {
                    this.gender = value;
                }
                else
                {
                    throw new InputFieldException($"Invalid input({value}) for Gender. Possible: MALE, FEMALE, OTHER");
                }
                
            }
        }


        //Contact details
        public string Email
        {
            get { return this.email; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Za-z0-9]+[^A-Za-z0-9]?[A-Za-z0-9]*@[A-z-]+.[a-z]+$");
                if (isValid)
                {
                    this.email = value;
                }
                else
                {
                    throw new InputFieldException($"This email:{value} has invalid format!");
                }

            }
        }
        public string PhoneNumber
        {
            get { return this.phoneNumber; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^(\+|00){1}[0-9]{2,3}([ |\-|/|]?[0-9]{3}){3}$");
                if (isValid)
                {
                    this.phoneNumber = value;
                }
                else
                {
                    //Throw exception
                    throw new InputFieldException($"This phone:{value} is in incorrect format!");
                }

            }
        }
        public string Street
        {
            get { return this.street; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Z]{1}[a-z]+(?:[ |-]([A-Za-z]+|[0-9]{1,4})){0,}$");
                if (isValid)
                {
                    this.street = value;
                }
                else
                {
                    //Throw exception
                    throw new InputFieldException($"This street:{value} is in incorrect format!");
                }

            }
        }
        public string City
        {
            get { return this.city; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Z]{1}[a-z]+(?:[ |-][A-Za-z]+){0,}$");
                if (isValid)
                {
                    this.city = value;
                }
                else
                {
                    //Throw exception
                    throw new InputFieldException($"This city:{value} is in incorrect format!");
                }
            }
        }
        public string Country
        {
            get { return this.country; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Z]{1}[a-z]+(?:[ ][A-Za-z]+){0,}$");
                if (isValid)
                {
                    this.country = value;
                }
                else
                {
                    //Throw exception
                    throw new InputFieldException($"This country:{value} is in incorrect format!");
                }
            }
        }
        public string Postcode
        {
            get { return this.postcode; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[0-9]{4}[A-Z]{2}$");
                if (isValid)
                {
                    this.postcode = value;
                }
                else
                {
                    //Throw exception
                    throw new InputFieldException($"This postcode:{value} is in incorrect format!");
                }

            }
        }

        public string Bsn
        {
            get { return this.bsn; }
            set
            {
                if (value != "")
                {
                    bool isValid = Regex.IsMatch(value, @"^[0-9]{9}$");
                    if (isValid)
                    {
                        this.bsn = value;
                    }
                    else
                    {
                        //Throw exception
                        throw new InputFieldException($"This bsn:{value} is in incorrect format!");
                    }
                }
                else
                {
                    this.bsn = "999999990";
                }

            }
        }

        //Emergency contact details
        public string EmConName
        {
            get { return this.emConName; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Z]{1}[a-z]+(?:[ |-][A-Z]{1}[a-z]+){0,}$");
                if (isValid)
                {
                    this.emConName = value;
                }
                else
                {
                    //Throw exception
                    throw new InputFieldException($"This name:{value} is invalid!");
                }

            }
        }

        public EmergencyContactRelation EmConRelation
        {
            get { return this.emConRelation; }
            set { this.emConRelation = value; }
        }

        public string EmConEmail
        {
            get { return this.emConEmail; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^[A-Za-z0-9]+[^A-Za-z0-9]?[A-Za-z0-9]*@[A-z-]+.[a-z]+$");
                if (isValid)
                {
                    //Check if the emergency contact email differs from the employee's email
                    if (value == this.Email)
                    {
                        throw new InputFieldException($"This email:{value} has invalid format!");
                    }
                    else
                    {
                        this.emConEmail = value;
                    }
                }
                else
                {
                    //Throw exception
                    throw new EmpEmailException(value);
                }

            }
        }

        public string EmConPhoneNum
        {
            get { return this.emConPhoneNum; }
            set
            {
                bool isValid = Regex.IsMatch(value, @"^(\+|00){1}[0-9]{2,3}([ |-|/]{1}[0-9]{3}){3}$");
                if (isValid)
                {
                    this.emConPhoneNum = value;
                }
                else
                {
                    //Throw exception
                    throw new InputFieldException($"This phone:{value} is in incorrect format!");
                }

            }
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
            set
            {
                if (value >= 1 && value <= 20)
                {
                    this.hourlyWages = value;
                }
                else
                {
                    throw new InputFieldException($"The chosen hourlyWages:{value} are out of the limit(1 - 20)");
                }
            }
        }

        public DateTime StartDate
        {
            get { return this.startDate; }
            set
            {
                this.startDate = value;
            }
        }

        public DateTime EndDate
        {
            get { return this.endDate; }
            
            set
            {
                this.endDate = value;
                if (value > this.StartDate)
                {
                    this.endDate = value;
                }
                else
                {
                    throw new InputFieldException($"End date must be a date after start date!");
                }
            }
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
        public Employee(string firstName, string lastName, DateTime dateOfBirth, string nationality,Gender gender, string email,
            string phoneNumber, string street, string city, string country, string postcode, string bsn, string emConName,
            EmergencyContactRelation emConRelation, string emConEmail, string emConPhoneNum, EmploymentType employmentType,
            double hourlyWages, DateTime startDate, DateTime endDate, Department department)
        {
            //this.id = id;
            //Personal information
            this.FirstName = firstName;
            this.LastName = lastName;
            this.DateOfBirth = dateOfBirth;
            this.Nationality = nationality;
            this.Gender = gender;

            // Contact details
            this.Email = email;
            this.PhoneNumber = phoneNumber;
            this.Street = street;
            this.City = city;
            this.Country = country;
            this.Postcode = postcode;

            this.Bsn = bsn;


            //Emergency contact details
            this.EmConName = emConName;
            this.EmConRelation = emConRelation;
            this.EmConEmail = emConEmail;
            this.EmConPhoneNum = emConPhoneNum;

            //Job specification
            this.EmploymentType = employmentType;
            this.HourlyWages = Math.Round(hourlyWages, 2);
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Department = department;

            this.shifts = new List<Shift>();
        }

        public List<Shift> Shifts
        {
            get { return this.shifts; }
            set { this.shifts = value; }
        }

        //Methods
        public override string ToString()
        {
            return $"Id:{this.Id} - {this.firstName} {this.lastName}";
        }
        public int Attendance(int days)
        {
            return 0;
        }

        public bool AddShift(int id, ShiftType type, DateTime date, int assignedBy, bool wfh, bool hasAttended, string noShowReason)
        {
            int totalShiftsPerWeek = 0;

            foreach (Shift s in shifts)
            {
                if (GetIso8601WeekOfYear(s.Date) == GetIso8601WeekOfYear(date) && s.HasAttended == true)
                {
                    totalShiftsPerWeek++;
                }
            }

            if (totalShiftsPerWeek <= (int)this.employmentType)
            {
                shifts.Add(new Shift(id, type, date, assignedBy, wfh, hasAttended, noShowReason));
                return true;
            }
            else
            {
                return false;
            }
        }

        public void AddExistingShift(Shift s)
        {
            this.shifts.Add(s);
        }

        public bool RemoveShift(int id)
        {
            foreach (Shift s in shifts)
            {
                if (s.ID == id)
                {
                    shifts.Remove(s);
                    return true;
                }
            }

            return false;
        }

        public void RemoveSpecificShift(Shift s)
        {
            if (this.shifts.Contains(s))
            {
                this.shifts.Remove(s);
            }
        }

        public bool ManageAttendance(int id, char a, string reason)
        {
            Shift shift = GetShift(id);

            if (a == 'y' || a == 'n')
            {
                shift.ChangeAttendance(a, reason);
                return true;
            }
            else
            {
                return false;
            }

        }

        public Shift GetShift(int id)
        {
            foreach (Shift s in shifts)
            {
                if (s.ID == id)
                {
                    return s;
                }
            }

            return null;
        }

        public List<Shift> GetAllShifts()
        {
            return shifts;
        }

        public static int GetIso8601WeekOfYear(DateTime time)
        {
            DayOfWeek day = CultureInfo.InvariantCulture.Calendar.GetDayOfWeek(time);
            if (day >= DayOfWeek.Monday && day <= DayOfWeek.Wednesday)
            {
                time = time.AddDays(3);
            }

            return CultureInfo.InvariantCulture.Calendar.GetWeekOfYear(time, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
        }


    }
}
