using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpPhoneException:Exception
    {
        public EmpPhoneException(string phone) : base($"This phone:{phone} is in incorrect format!")
        {

        }
    }
}
