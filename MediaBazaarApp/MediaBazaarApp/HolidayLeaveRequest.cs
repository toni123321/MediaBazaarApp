using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class HolidayLeaveRequest
    {
        private int id;
        private int employeeId;
        private DateTime startDate;
        private DateTime endDate;
        private int totalDays;
        private string status;
        private string comments;
        private DateTime requestDate;


        public int Id { get; set; }
        public int EmployeeId { get;  set; }
        public DateTime StartDate { get;  set; }
        public DateTime EndDate { get;  set; }
        public int TotalDays { get;  set; }
        public string Status { get;  set; }
        public string Comments { get;  set; }

        public DateTime RequestDate { get; set; }



        public HolidayLeaveRequest(int id, int employeeId, DateTime st, DateTime et, int totalDays, string status, string comments, DateTime requestDate)
        {
            this.Id = id;
            this.EmployeeId = employeeId;
            this.StartDate = st;
            this.EndDate = et;
            this.TotalDays = totalDays;
            this.Status = status;
            this.Comments = comments;
            this.RequestDate = requestDate;
        }
    }
}
