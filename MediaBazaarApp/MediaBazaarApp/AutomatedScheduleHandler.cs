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
        private string[] weekDays = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        public DepartmentManagement DepartmentManagement { get; set; }
        DBControl dbc;
        public AutomatedScheduleHandler(DepartmentManagement departmentManagement)
        {
            this.DepartmentManagement = departmentManagement;
            this.dbc = new DBControl();
        }

        //clear any manual shifts for the chosen weeks if any
        //shuffle weekdays
        //go through each of the employees and start assigning shift (shift type - rnd) until they have enough shifts
        //show generated schedule
        //ask the user is he would like to apply it


        public void AssignShifts(int week, int year)
        {

            Random rand = new Random();

            foreach (Employee employee in DepartmentManagement.GetAllEmployees())
            {
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

                //finds out how many shifts per day and how many remaiming (modulo)
                int shiftsPerDay = (int)neededShifts.Count / 7;
                int remainingShifts = neededShifts.Count % 7;
                DateTime firstDayOfTheWeek = FirstDateOfWeekISO8601(year, week);
                int lastAssignedShiftType = 0; //0 - next shift is going to be morning, 1 - evening

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

                for (int i = 0; i < 6; i++) // 0-6 == mon-sun
                {
                    int totalShifts = shiftsPerDay;

                    if (remShifts.Contains(i))
                    {
                        totalShifts = shiftsPerDay + 1;
                    }

                    int noonShifts = (int)Math.Ceiling(totalShifts / 2.00);
                    int otherShifts = totalShifts - noonShifts;
                    DateTime weekDay = firstDayOfTheWeek.AddDays(i);

                    for (int j = 0; j < noonShifts; j++)
                    {
                        tempSchedule.Add(new Shift(-1, ShiftType.Afternoon, weekDay, -1, false, true, null));
                    }

                    for (int x = 0; x < otherShifts; x++)
                    {
                        if(lastAssignedShiftType == 0)
                        {
                            tempSchedule.Add(new Shift(-1, ShiftType.Morning, weekDay, -1, false, true, null));
                            lastAssignedShiftType = 1;
                        }
                        else if(lastAssignedShiftType == 1)
                        {
                            tempSchedule.Add(new Shift(-1, ShiftType.Evening, weekDay, -1, false, true, null));
                            lastAssignedShiftType = 0;
                        }
                    }
                }


                //assing shifts to employees


                for (int i = 0; i < randomNeededShifts.Length; i++)
                {

                }

                //check if the emp doesnt have more than 2/day
                //check if the emp doesnt have already a shift with the same type and date


                // check if the user wants to to save  and add it to db       

            }
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
