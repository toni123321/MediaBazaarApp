using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class HLRManager
    {
        private List<HolidayLeaveRequest> hlrs = new List<HolidayLeaveRequest>();

        public HLRManager()
        {
            hlrs = new List<HolidayLeaveRequest>();
        }

        public bool SendEmailToNotifyEmployee(string firstname, string email, bool isRequestAccepted)
        {
            return true;
        }

        public void AcceptHLR(HolidayLeaveRequest request)
        {
            // Accept - call update from db control
            // Load requests
            // Send email - proper msg
        }

        public void DeclineHLR(HolidayLeaveRequest request)
        {
            // Decline - call update from db control
            // Load requests
            // Send email - proper msg
        }



    }
}
