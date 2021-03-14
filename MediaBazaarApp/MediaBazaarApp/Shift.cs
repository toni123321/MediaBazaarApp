using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    public class Shift
    {
        private static int idCounter = 0;

        public int ID { get; }
        public DateTime Date { get; }
        public ShiftType Type { get; }
        public bool WFH { get; }
        public Employee AssignedBy { get; }
        public bool HasAttended { get; set; }
        public string NoShowReason { get; set; }

        //Constructor
        public Shift(ShiftType type, DateTime date, Employee assignedBy, bool wfh)
        {
            idCounter++;
            this.ID = idCounter;

            this.Type = type;
            this.Date = date;
            this.WFH = wfh;
            this.AssignedBy = assignedBy;
            this.HasAttended = true;
        }

        //Methods
        public void ChangeAttendance(char a, string reason)
        {
            if (a == 'y')
            {
                this.HasAttended = true;
                this.NoShowReason = reason;
            }
            else if (a == 'n')
            {
                this.HasAttended = false;
                this.NoShowReason = null;
            }
        }

    }
}

