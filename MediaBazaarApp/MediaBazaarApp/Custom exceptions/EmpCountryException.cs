using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpCountryException : Exception
    {
        public EmpCountryException(string country) : base($"This country:{country} is in incorrect format!")
        {

        }
    }
}
