using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _403_JersryNumbers
{
    class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearUsed { get; private set; }

        public JerseyNumber(string player, int numberRetired)
        {
            Player = player;
            YearUsed = numberRetired;
        }
    }
}
