using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpPostcodeException : Exception
    {
        public EmpPostcodeException(string postcode) : base($"This postcode:{postcode} is in incorrect format!")
        {

        }
    }
}
