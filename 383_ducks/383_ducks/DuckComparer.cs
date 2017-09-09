using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383_ducks
{
    class DuckComparer : IComparer<Duck>
    {
        public SortType SortBy = SortType.SizeThanKind;

        public int Compare(Duck x , Duck y)
        {
            if (SortBy == SortType.SizeThanKind)
            {
                if (x.size > y.size)
                    return 1;
                else if (x.size < y.size)
                    return -1;
                else
                {
                    if (x.Kind > y.Kind)
                        return 1;
                    else if (x.Kind < y.Kind)
                        return -1;
                    else
                        return 0;
                }                
            }
            else
            {
                if (x.Kind > y.Kind)
                    return 1;
                else if (x.Kind < y.Kind)
                    return -1;
                else
                {
                    if (x.size > y.size)
                        return 1;
                    else if (x.size < y.size)
                        return -1;
                    else
                        return 0;
                }
            }

            throw new NotImplementedException();
        }
    }

    enum SortType
    {
        SizeThanKind,
        KindThanSize,
    }
}
