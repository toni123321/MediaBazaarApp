using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpAgeException:Exception
    {
        public EmpAgeException(DateTime date):base($"Invalid birth date({date.ToString("dd/MM/yyyy")}), your age should be at least 18")
        {

        }
    }
}
