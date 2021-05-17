using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpCityException : Exception
    {
        public EmpCityException(string city) : base($"This city:{city} is in incorrect format!")
        {

        }
    }
}
