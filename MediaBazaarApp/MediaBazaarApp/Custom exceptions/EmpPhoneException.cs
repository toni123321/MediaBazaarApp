using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpPhoneException : Exception
    {
        public EmpPhoneException(string phone) : base($"This phone:{phone} is in incorrect format!")
        {

        }
    }
}
