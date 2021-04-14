using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpPostcodeException:Exception
    {
        public EmpPostcodeException(string postcode) : base($"This postcode:{postcode} is in incorrect format!")
        {

        }
    }
}
