using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383Duck_List_2
{
    class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;
            
        public void Quack() { }
        public void Swim() { }
        public void Eat() { }
        public void Walk() { }

        public int CompareTo(Duck other)
        {
            if (this.Size> other.Size)
                return 1;
            if (this.Size < other.Size)
                return -1;
            else return 0;
        }
    }

    enum KindOfDuck
    {
        Mallard,
        Muscovy,
        Decoy,
    }
}
