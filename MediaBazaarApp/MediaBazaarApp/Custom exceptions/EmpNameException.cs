using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpNameException : Exception
    {
        public EmpNameException(string name) : base($"This name:{name} is invalid!")
        {

        }
    }
}
