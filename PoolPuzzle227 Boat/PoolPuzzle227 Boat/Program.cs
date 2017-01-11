using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoolPuzzle227_Boat
{
    public class TestBoats
    {
        public static void Main(string[] args)
        {
            string xyz = "";
            Boat        b1 = new Boat();
            Sailboat    b2 = new Sailboat();
            RowBoat     b3 = new RowBoat();

            b2.setLength(32);
            xyz  = b1.move();
            xyz += b3.move();
            xyz += b2.move();

            System.Windows.Forms.MessageBox.Show(xyz);
        }


    }
}
