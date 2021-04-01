using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpStreetException:Exception
    {
        public EmpStreetException(string street) : base($"This street:{street} is in incorrect format!")
        {

        }
    }
}
