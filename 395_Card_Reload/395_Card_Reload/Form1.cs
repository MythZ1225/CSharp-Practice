using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _395_Card_Reload
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card cardToCheck = new Card(Suits.梅花, Values.Ten);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.紅心);
            MessageBox.Show(doesItMatch.ToString());            
        }
    }
}
