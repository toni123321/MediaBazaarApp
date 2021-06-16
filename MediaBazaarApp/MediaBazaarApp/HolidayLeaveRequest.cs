using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class HolidayLeaveRequest
    {
        private Employee employee;
        private DateTime startDate;
        private DateTime endDate;
        private int totalDays;
        private string status;
        private string comments;
        private DateTime requestDate;

        
        public Employee Employee { get;  set; }
        public DateTime StartDate { get;  set; }
        public DateTime EndDate { get;  set; }
        public int TotalDays { get;  set; }
        public string Status { get;  set; }
        public string Comments { get;  set; }

        public DateTime RequestDate { get; set; }



        public HolidayLeaveRequest(Employee emp, DateTime st, DateTime et, int totalDays, string status, string comments)
        {
            this.employee = emp;
            this.startDate = st;
            this.endDate = et;
            this.totalDays = totalDays;
            this.status = status;
            this.comments = comments;
        }
    }
}
