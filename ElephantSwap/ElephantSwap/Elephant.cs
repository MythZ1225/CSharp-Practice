using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantSwap
{
    class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI()
        {
            MessageBox.Show("My ears are " + EarSize + " inches tall.", Name+" Says...");
        }

    }
}
