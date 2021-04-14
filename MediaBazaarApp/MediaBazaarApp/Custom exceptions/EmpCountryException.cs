using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpCountryException:Exception
    {
        public EmpCountryException(string country) : base($"This country:{country} is in incorrect format!")
        {

        }
    }
}
