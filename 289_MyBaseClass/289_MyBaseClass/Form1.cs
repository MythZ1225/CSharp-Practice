using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _289_MyBaseClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            myBassClass mB = new myBassClass("GG");
            childClass cB = new childClass("CB", 12);
            
        }
    }
    m
    class myBassClass
    {
        public myBassClass(string baseClassUseIt) 
        {
            MessageBox.Show("這是BaseClass" + baseClassUseIt);
        }
    }

    class childClass: myBassClass
    {
        public childClass(string baseClassUseIt, int otherValue) : base(baseClassUseIt)
        //用 :base(baseClassUseIt) 調用 myBassClass的 baseClassUseIt
        {
            MessageBox.Show("這邊是ChildClass" + baseClassUseIt + "且 Int = " + otherValue);
        }
    }
}
