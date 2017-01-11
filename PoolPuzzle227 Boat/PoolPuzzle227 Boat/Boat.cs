using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoolPuzzle227_Boat
{
    public class Boat
    {
        private int length;
        public void setLength(int  len)
        {
            length = len;
        }

        public int getLength()
        {
            return length;
        }

        public virtual string move()
        {
            return "drift ";
        }


    }
}
