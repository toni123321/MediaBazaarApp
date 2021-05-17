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
        public DepartmentManagement DepartmentManagement { get; set; }
        DBControl dbc;
        public AutomatedScheduleHandler(DepartmentManagement departmentManagement)
        {
            this.DepartmentManagement = departmentManagement;
            this.dbc = new DBControl();
        }

        public void AssignShifts(int week, int year)
        {

            Random rand = new Random();

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
            int lastAssignedShiftType = 0; //0 - next shift is going to be morning, 1 - evening
            int noonShifts = (int)Math.Ceiling(shiftsPerDay / 2.00);

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
                    totalShifts = shiftsPerDay + 1;
                }

                noonShifts = (int)Math.Ceiling(totalShifts / 2.00);
                int otherShifts = totalShifts - noonShifts;
                DateTime weekDay = firstDayOfTheWeek.AddDays(i);

                for (int j = 0; j < noonShifts; j++)
                {
                    tempSchedule.Add(new Shift(-1, ShiftType.Afternoon, weekDay, -1, false, true, null));
                }

                for (int x = 0; x < otherShifts; x++)
                {
                    if (lastAssignedShiftType == 0)
                    {
                        tempSchedule.Add(new Shift(-1, ShiftType.Morning, weekDay, -1, false, true, null));
                        lastAssignedShiftType = 1;
                    }
                    else if (lastAssignedShiftType == 1)
                    {
                        tempSchedule.Add(new Shift(-1, ShiftType.Evening, weekDay, -1, false, true, null));
                        lastAssignedShiftType = 0;
                    }
                }
            }

            //check if the emp doesnt have more than 2/day
            //check if the emp doesnt have already a shift with the same type and date
            //assing shifts to employees

            //while (tempSchedule.Count > 0)
            //{
            //    foreach (Employee emp in DepartmentManagement.GetAllEmployees())
            //    {

            //        int employeeMaxShifts = (int)emp.EmploymentType;
            //        int shiftsCounter = 0;

            //        foreach (Shift s in tempSchedule.ToList())
            //        {

            //            if (CheckForExistingShift(s.Date, s.Type, emp) == false && GetEmployeeShiftsPerDay(s.Date, emp) < 2 && shiftsCounter < employeeMaxShifts)
            //            {
            //                emp.AddExistingShift(s);
            //                tempSchedule.Remove(s);

            //                shiftsCounter++;
            //            }
            //        }
            //    }
            //}

            while (tempSchedule.Count > 0)
            {
                foreach (Employee emp in DepartmentManagement.GetAllEmployees())
                {

                    int employeeMaxShifts = (int)emp.EmploymentType;
                    int shiftsCounter = 0;

                   Shift selectedShift = null;

                    if(shiftsCounter < employeeMaxShifts)
                    {
                        foreach (Shift s in tempSchedule.ToList())
                        {

                            if (CheckForExistingShift(s.Date, s.Type, emp) == false && GetEmployeeShiftsPerDay(s.Date, emp) < 2)
                            {
                                selectedShift = s;
                            }
                        }

                        if (selectedShift != null)
                        {
                            emp.AddExistingShift(selectedShift);
                            tempSchedule.Remove(selectedShift);

                            shiftsCounter++;
                        }
                    }
                }
            }
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
