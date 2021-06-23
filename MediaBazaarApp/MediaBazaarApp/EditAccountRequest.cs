using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class EditAccountRequest
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public string Email  { get; set; }
        public string PhoneNumber { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string Postcode { get; set; }

        public string EmConName { get; set; }
        public EmergencyContactRelation EmConRelation { get; set; }
        public string EmConEmail { get; set; }
        public string EmConPhone { get; set; }
        public string Status { get; set; }
        public DateTime RequestDate { get; set; }

        public EditAccountRequest(int id, int employeeId, string email, string phoneNumber, string street, string city, string country, string postcode, string emergencyContactName, EmergencyContactRelation emergencyContactRelation, string emergencyContactEmail, string emergencyContactPhone, string status, DateTime requestDate)
        {
            Id = id;
            EmployeeID = employeeId;
            Email = email;
            PhoneNumber = phoneNumber;
            Street = street;
            City = city;
            Country = country;
            Postcode = postcode;
            EmConName = emergencyContactName;
            EmConRelation = emergencyContactRelation;
            EmConEmail = emergencyContactEmail;
            EmConPhone = emergencyContactPhone;
            Status = status;
            RequestDate = requestDate;
        }
    }
}
