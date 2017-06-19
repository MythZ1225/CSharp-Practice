using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383Duck_List_2
{
    enum SortType
    {
        SizeThenKind,
        KindThenSize,
    }

    class DuckComparer : IComparer<Duck>
    {
        public SortType SortBy = SortType.SizeThenKind;

        public int Compare(Duck x, Duck y)
        {
            if (SortBy == SortType.SizeThenKind)
            {
                if (x.Size < y.Size)
                    return 1;
                if (x.Size > y.Size)
                    return -1;
                else
                    return 0;
            }
            else
            {
                if (x.Kind < y.Kind)
                    return 1;
                if (x.Kind > y.Kind)
                    return -1;
                else
                    return 0;
            }
        }


    }
}
