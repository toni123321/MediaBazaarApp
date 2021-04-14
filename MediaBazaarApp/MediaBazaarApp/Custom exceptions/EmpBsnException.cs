using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpBsnException:Exception
    {
        public EmpBsnException(string bsn) : base($"This bsn:{bsn} is in incorrect format!")
        {

        }
    }

}
