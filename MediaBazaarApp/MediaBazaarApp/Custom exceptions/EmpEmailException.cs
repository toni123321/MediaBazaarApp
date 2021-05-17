using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpEmailException : Exception
    {
        public EmpEmailException(string email) : base($"This email:{email} has invalid format!")
        {

        }
    }
}
