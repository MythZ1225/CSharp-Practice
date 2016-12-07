using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeTest
{
    class ErrorTest
    {
        public int MyMethod(bool YesNo)
        {
            if (YesNo)
            {
                return 45;
            }
            else
            {
                return 61;
            }
        }
    }
}
