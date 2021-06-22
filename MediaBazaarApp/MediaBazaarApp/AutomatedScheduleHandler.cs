using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace MediaBazaarApp
{
    public class AutomatedScheduleHandler
    {
        Dictionary<DateTime, int> weekDays = new Dictionary<DateTime, int>();
        

        public DepartmentManagement DepartmentManagement { get; set; }
        DBControl dbc;
        public AutomatedScheduleHandler(DepartmentManagement departmentManagement)
        {
            this.DepartmentManagement = departmentManagement;
            this.dbc = new DBControl();
                
        }

        public DateTime DateNeededShifts(Dictionary<DateTime, int> weekDays)
        {
            var orderedWeekDays = weekDays.OrderByDescending(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return orderedWeekDays.Keys.ElementAt(0);
        }

        public void AssignShifts(int week, int year, int assignedBy)
        {
            DBControl dbc = new DBControl();
            Random rand = new Random();
            HLRManager hlrManager = new HLRManager();

            var ordered = weekDays.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);

            //get all needed shifts (employees) and randomise it
            List<Employee> neededShifts = new List<Employee>();
            List<Shift> tempSchedule = new List<Shift>();

            foreach (Employee emp in DepartmentManagement.GetAllEmployees())
            {
                for (int i = 0; i < (int)emp.EmploymentType; i++)
                {
                    neededShifts.Add(emp);
                }
            }
            Employee[] randomNeededShifts = neededShifts.OrderBy(x => rand.Next()).ToArray();
            List<Employee> randomNeededShiftsList = new List<Employee>(randomNeededShifts);

            //finds out how many shifts per day and how many remaiming
            int shiftsPerDay = (int)neededShifts.Count / 7;
            int remainingShifts = neededShifts.Count % 7;
            DateTime firstDayOfTheWeek = FirstDateOfWeekISO8601(year, week);

            weekDays.Add(firstDayOfTheWeek, shiftsPerDay);
            weekDays.Add(firstDayOfTheWeek.AddDays(1), shiftsPerDay);
            weekDays.Add(firstDayOfTheWeek.AddDays(2), shiftsPerDay);
            weekDays.Add(firstDayOfTheWeek.AddDays(3), shiftsPerDay);
            weekDays.Add(firstDayOfTheWeek.AddDays(4), shiftsPerDay);
            weekDays.Add(firstDayOfTheWeek.AddDays(5), shiftsPerDay);
            weekDays.Add(firstDayOfTheWeek.AddDays(6), shiftsPerDay);

            List<int> remShifts = new List<int>();
            int number;

            for (int i = 0; i < remainingShifts; i++)
            {
                do
                {
                    number = rand.Next(0, 7);
                } while (remShifts.Contains(number));

                remShifts.Add(number);
            }

            for (int i = 0; i < 7; i++) // 0-6 == mon-sun
            {
                int totalShifts = shiftsPerDay;

                if (remShifts.Contains(i))
                {
                    weekDays[firstDayOfTheWeek.AddDays(i)]++;
                }
            }

            var rndEmps = DepartmentManagement.GetAllEmployees().OrderBy(a => Guid.NewGuid()).ToList();


            foreach (Employee emp in rndEmps)
            {
                DateTime shiftDate;
                ShiftType type;

                for (int i = 0; i < (int)emp.EmploymentType; i++)
                {
                    
                    shiftDate = DateNeededShifts(weekDays);
                    type = GetShiftType(tempSchedule, shiftDate);

                    //tempSchedule.Add(new Shift(-1, type, shiftDate, -1, false, false, null));
                    //dbc.AddShift(type, shiftDate, assignedBy, false, emp);
                    //weekDays[DateNeededShifts(weekDays)]--;

                    if (hlrManager.CheckForLeaveShiftPlanner(emp, DateNeededShifts(weekDays)) == false)
                    {
                        shiftDate.AddDays(1);
                    }
                    else
                    {
                        tempSchedule.Add(new Shift(-1, type, shiftDate, -1, false, false, null));
                        dbc.AddShift(type, shiftDate, assignedBy, false, emp);
                        weekDays[DateNeededShifts(weekDays)]--;
                    }

                }
            }

            weekDays.Clear();
        }

        public ShiftType GetShiftType(List<Shift> shifts, DateTime dt)
        {
            int m = 0;
            int a = 0;
            int e = 0;

            Dictionary<ShiftType, int> sType = new Dictionary<ShiftType, int>();

            foreach (Shift s in shifts)
            {
                if (s.Type == ShiftType.Morning && s.Date == dt)
                {
                    m++;
                }
                else if (s.Type == ShiftType.Afternoon && s.Date == dt)
                {
                    a++;
                }
                else if (s.Type == ShiftType.Evening && s.Date == dt)
                {
                    e++;
                }
            }

            sType.Add(ShiftType.Morning, m);
            sType.Add(ShiftType.Afternoon, a);
            sType.Add(ShiftType.Evening, e);

            var sTypesOrdered = sType.OrderBy(x => x.Value).ToDictionary(x => x.Key, x => x.Value);
            return sTypesOrdered.Keys.ElementAt(0);
        }

       
        public bool CheckForExistingShift(DateTime date, ShiftType type, Employee emp)
        {
            foreach (Shift s in emp.GetAllShifts())
            {
                if (s.Date == date && s.Type == type)
                {
                    return true;
                }
            }

            return false;
        }

        public int GetEmployeeShiftsPerDay(DateTime date, Employee emp)
        {
            int shiftCounter = 0;

            foreach (Shift s in emp.GetAllShifts())
            {
                if (s.Date == date)
                {
                    shiftCounter++;
                }
            }

            return shiftCounter;
        }

        public static DateTime FirstDateOfWeekISO8601(int year, int weekOfYear)
        {
            DateTime jan1 = new DateTime(year, 1, 1);
            int daysOffset = DayOfWeek.Thursday - jan1.DayOfWeek;

            // Use first Thursday in January to get first week of the year as
            // it will never be in Week 52/53
            DateTime firstThursday = jan1.AddDays(daysOffset);
            var cal = CultureInfo.CurrentCulture.Calendar;
            int firstWeek = cal.GetWeekOfYear(firstThursday, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);

            var weekNum = weekOfYear;
            // As we're adding days to a date in Week 1,
            // we need to subtract 1 in order to get the right date for week #1
            if (firstWeek == 1)
            {
                weekNum -= 1;
            }

            // Using the first Thursday as starting week ensures that we are starting in the right year
            // then we add number of weeks multiplied with days
            var result = firstThursday.AddDays(weekNum * 7);

            // Subtract 3 days from Thursday to get Monday, which is the first weekday in ISO8601
            return result.AddDays(-3);
        }

        public int FindNumberOfShiftsForGivenDatePerEmp(Employee emp, DateTime date)
        {
            int dailyShifts = 0;

            foreach (Shift shift in emp.GetAllShifts())
            {
                if(shift.Date == date)
                {
                    dailyShifts++;
                }
            }

            return dailyShifts;
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
