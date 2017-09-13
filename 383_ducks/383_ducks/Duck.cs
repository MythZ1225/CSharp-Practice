using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383_ducks
{
    class Duck : IComparable<Duck>
    {
        public int size;
        public KindsOfDuck Kind;

        public int CompareTo(Duck otherDucks)
        {
            if (this.size > otherDucks.size)
            {
                return 1;
            }
             else if (this.size < otherDucks.size)
            {
                return -1;
            }
            else
            {
                return 0;
            }

            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return Kind.ToString() + size.ToString();
        }
    }

    enum KindsOfDuck
    {
        B藍鴨,
        Gr灰鴨,
        G綠鴨,
        Br褐鴨,
    }
}
