using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBaseClass
{
    public class C : B
    {
        public override string m3()
        {
            return "C's M3, " + (ivar + 6);
        }

    }
}
