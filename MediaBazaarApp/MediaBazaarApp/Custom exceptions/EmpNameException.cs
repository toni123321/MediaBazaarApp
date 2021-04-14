using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarApp.Custom_exceptions
{
    public class EmpNameException:Exception
    {
        public EmpNameException(string name) : base($"This name:{name} is invalid!")
        {

        }
    }
}
