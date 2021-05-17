using System;

namespace MediaBazaarApp
{
    class NotAllFieldFilled : Exception
    {
        public NotAllFieldFilled() : base($"Please, make sure to choose/enter value for each field that is required.")
        {

        }

    }
}
