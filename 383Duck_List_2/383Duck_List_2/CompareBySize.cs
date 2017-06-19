using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383Duck_List_2
{
    class CompareBySize : IComparer<Duck>
    {
        public int Compare(Duck x, Duck y)
        {
            if (x.Size > y.Size)
                return -1;
            if (x.Size < y.Size)
                return 1;
            else
                return 0;
        }
    }
}
