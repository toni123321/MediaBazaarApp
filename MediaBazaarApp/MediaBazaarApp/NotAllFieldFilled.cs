using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp
{
    class NotAllFieldFilled : Exception
    {
        public NotAllFieldFilled() : base($"Please, make sure to choose/enter value for each field that is required.")
        {

        }

    }
}
