using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantSwap
{
    public partial class Swap : Form
    {
        Elephant Lucinda;
        Elephant Lloyd;
        Elephant TempElphant;

        public Swap()
        {
            InitializeComponent();
             Lucinda = new Elephant() {Name = "Lucinda", EarSize =33 };
             Lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
        }

        private void LucindaBtn_Click(object sender, EventArgs e)
        {
            Lucinda.WhoAmI();
        }

        private void LloydBtn_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void SwapBtn_Click(object sender, EventArgs e)
        {
            TempElphant = Lucinda;
            Lucinda = Lloyd;
            Lloyd = TempElphant;
            MessageBox.Show("Swap!", "Swap");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lloyd = Lucinda;
            Lloyd.EarSize = 4321;
            Lloyd.WhoAmI();
        }
    }
}
