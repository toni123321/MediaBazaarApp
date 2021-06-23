using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class InputFieldException: Exception
    {
        public InputFieldException(string msg): base(msg)
        {
            
        }

    }
}
