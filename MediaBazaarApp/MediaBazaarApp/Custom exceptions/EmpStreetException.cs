using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpStreetException : Exception
    {
        public EmpStreetException(string street) : base($"This street:{street} is in incorrect format!")
        {

        }
    }
}
