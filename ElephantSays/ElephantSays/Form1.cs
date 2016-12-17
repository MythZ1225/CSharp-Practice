using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantSays
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Elephant lloyd = new Elephant() {Name = "Lloyd",EarSize = 40 };
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
            lucinda.TellMe("Hi", lucinda);
            lucinda.speakTo(lloyd,"Hello");     
                   
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Elephant[] elephonts = new Elephant[7];
            elephonts[0] = new Elephant() { Name = "Lloyd", EarSize = 40 };
            elephonts[1] = new Elephant() { Name = "Lucinda", EarSize = 33 };
            elephonts[2] = new Elephant() { Name = "Layrry", EarSize = 42 };
            elephonts[3] = new Elephant() { Name = "Lucio", EarSize = 32 };
            elephonts[4] = new Elephant() { Name = "Lurara", EarSize = 41 };
            elephonts[5] = new Elephant() { Name = "Lopa", EarSize = 42 };
            elephonts[6] = new Elephant() { Name = "Ludica", EarSize = 35 };

            Elephant biggestEar = elephonts[0];
            for (int i = 0; i < elephonts.Length; i++)
            {
                if (elephonts[i].EarSize > biggestEar.EarSize)
                {
                    biggestEar = elephonts[i];
                }
            }

            MessageBox.Show("the Biggest Ear Elephant is "+biggestEar.Name + " Ear Size is " + biggestEar.EarSize.ToString());
        }
    }
}
