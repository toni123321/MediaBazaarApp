using System;

namespace MediaBazaarApp.Custom_exceptions
{
    public class DepNameException : Exception
    {
        public DepNameException(string name) : base($"The chosen name:{name} for department is in incorrect format!")
        {

        }
    }
}
