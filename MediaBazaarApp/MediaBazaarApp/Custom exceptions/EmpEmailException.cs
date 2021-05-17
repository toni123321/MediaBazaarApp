using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpEmailException:Exception
    {
        public EmpEmailException(string email):base($"This email:{email} has invalid format!")
        {

        }
    }
}
