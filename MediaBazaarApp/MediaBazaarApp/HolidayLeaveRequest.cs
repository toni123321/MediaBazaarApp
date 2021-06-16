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

        
        public Employee Employee { get; private set; }
        public DateTime StartDate { get; private set; }
        public DateTime EndDate { get; private set; }
        public int TotalDays { get; private set; }
        public string Status { get; private set; }
        public string Comments { get; private set; }

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
