using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _275ISringPartol
{
    public class Bee : IStiingPatrol
    {
        public int AlterLevel { get; }
        public int StingLength { get; }

        public bool LookForEnemy() { return true; }
        public int ShapenStinger(int length) { return 123; }

    }
}
