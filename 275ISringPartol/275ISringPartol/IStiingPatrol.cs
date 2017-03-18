using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _275ISringPartol
{
    interface IStiingPatrol 
    {
        int AlterLevel { get; }
        int StingLength { get; }
        bool LookForEnemy();
        int ShapenStinger(int length);
    }
}
