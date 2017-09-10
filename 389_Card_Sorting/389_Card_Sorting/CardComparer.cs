using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _389_Card_Sorting
{
    class CardComparer : IComparer<Card>
    {
        public SortType sorttype = SortType.SuitThanValue;

        public int Compare(Card x, Card y)
        {

            if (sorttype == SortType.SuitThanValue)
            {
                if (x.suit > y.suit)
                    return 1;
                else if (x.suit < y.suit)
                    return -1;
                else
                {
                    if (x.value > y.value)
                        return 1;
                    else if (x.value < y.value)
                        return -1;
                    else
                        return 0;
                }
            }
            else 
            {
                if (x.value > y.value)
                    return 1;
                else if (x.value < y.value)
                    return -1;
                else
                {
                    if (x.suit > y.suit)
                        return 1;
                    else if (x.suit < y.suit)
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
        SuitThanValue,
        ValueThanSuit,
    }
}
