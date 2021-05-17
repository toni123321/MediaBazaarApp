using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpHourlyWagesException : Exception
    {
        public EmpHourlyWagesException(int hourlyWages) : base($"The chosen hourlyWages:{hourlyWages} are out of the limit(1 - 20)")
        {

        }
    }
}
