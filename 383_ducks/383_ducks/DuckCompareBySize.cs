using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383_ducks
{
    class DuckCompareBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.size < y.size)
                return 1;
            else if (x.size > y.size)
                return -1;
            else
                return 0;
        }
    }

    class DuckCompareByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind > y.Kind)
                return 1;
            else if (x.Kind < y.Kind)
                return -1;
            else
                return 0;
        }
    }
}
