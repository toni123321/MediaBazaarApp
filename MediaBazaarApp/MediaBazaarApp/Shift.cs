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
        public int AssignedBy { get; }
        public bool HasAttended { get; set; }
        public string NoShowReason { get; set; }

        //Constructor
        public Shift(int id, ShiftType type, DateTime date, int assignedBy, bool wfh)
        {
            //idCounter++;
            this.ID = id;
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

        public override string ToString()
        {
            if (this.WFH == true)
            {
                return $"[WFH][{this.Type}] {this.Date.ToString("dd/MM/yyyy")}";
            }
            else
            {
                return $"[{this.Type}] {this.Date.ToString("dd/MM/yyyy")}";
            }
            
        }

    }
}

