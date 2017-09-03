using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _314TallGuyInterFace02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TallGuy tallGuy = new TallGuy() { Name = "鳩尼" , Height = 198};
            tallGuy.TalkaAboutYouself();
            tallGuy.Honk();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScaryScary Clown1 = new ScaryScary("大鞋",14);
            FunnyFunny funnyClown = Clown1;
            IScaryClown Clown2 = funnyClown as ScaryScary;

            Clown2.Honk();
        }
    }
}
