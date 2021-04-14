using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpCityException:Exception
    {
        public EmpCityException(string city) : base($"This city:{city} is in incorrect format!")
        {

        }
    }
}
