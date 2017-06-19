using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383Duck_List_2
{
    class CompareByKind : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Kind > y.Kind)
                return -1;
            if (x.Kind < y.Kind)
                return 1;
            else
                return 0;
        }

    }
}
