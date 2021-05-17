using System;

namespace MediaBazaarApp
{
    class IntegerValueExpected : Exception
    {
        public IntegerValueExpected(string text) : base($"Please, make sure to enter an integer value.\nP{text} is not an integer, therefore can not be accepted.")
        {

        }
    }
}
