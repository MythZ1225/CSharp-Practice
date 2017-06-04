using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _314TallGuyInterFaceTest1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TallGuy tallGuy = new TallGuy() { Name = "強尼" , Height = 188 };
            tallGuy.TalkAboutYourself();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ScaryScary FingersTheClown = new ScaryScary("大鼻子", 14);
            FunnyFunny SomeFunnyClown = FingersTheClown;
            IScaryClown SomeScaeyClown = SomeFunnyClown as ScaryScary;
            /*  IScaryClown SomeScaeyClown 引用了 SomeFunnyClown (FunnyFunny) 但無法確認
             *  SomeFunnyClown 是否是 ScaryScary 所以要用 as   
             */
            SomeScaeyClown.Honk();
        }
    }
}
