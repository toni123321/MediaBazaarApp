using System;

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
        public Shift(int id, ShiftType type, DateTime date, int assignedBy, bool wfh, bool hasAttended, string noShowReason)
        {
            //idCounter++;
            this.ID = id;
            this.Type = type;
            this.Date = date;
            this.WFH = wfh;
            this.AssignedBy = assignedBy;
            this.HasAttended = hasAttended;
            this.NoShowReason = noShowReason;
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
            if (this.WFH == true && this.HasAttended == true)
            {
                return $"[WFH][{this.Type}] {this.Date.ToString("dd/MM/yyyy")} (Assigned by: {this.AssignedBy})";
            }
            else if (this.WFH == false && this.HasAttended == true)
            {
                return $"[{this.Type}] {this.Date.ToString("dd/MM/yyyy")} (Assigned by: {this.AssignedBy})";
            }
            else if (this.WFH == true && this.HasAttended == false)
            {
                return $"ABSENT: {this.NoShowReason} [WFH][{this.Type}] {this.Date.ToString("dd/MM/yyyy")} (Assigned by: {this.AssignedBy})";
            }
            else if (this.WFH == false && this.HasAttended == false)
            {
                return $"ABSENT: {this.NoShowReason} [{this.Type}] {this.Date.ToString("dd/MM/yyyy")} (Assigned by: {this.AssignedBy})";
            }

            return null;
        }

    }
}

