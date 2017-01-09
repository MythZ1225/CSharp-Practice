using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBaseClass
{
    public class A
    {
        public int ivar = 7;
        public virtual string m1()
        {
            return "A's m1, ";
        }

        public string m2()
        {
            return "A's m2, ";
        }

        public virtual string m3()
        {
            return "A's m3, ";
        }
    }
}
