using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _272_Vertebrate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bird tweety = new bird();
            tweety.WingSpan = 7.5;
            tweety.fly();
            tweety.Eat();
            tweety.NumOfLegs = 2;


        }
    }
}
