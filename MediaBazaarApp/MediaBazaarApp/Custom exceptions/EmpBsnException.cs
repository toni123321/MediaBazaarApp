using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpBsnException : Exception
    {
        public EmpBsnException(string bsn) : base($"This bsn:{bsn} is in incorrect format!")
        {

        }
    }

}
