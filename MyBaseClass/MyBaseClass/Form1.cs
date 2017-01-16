using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBaseClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
             
    }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            A a = new A();
            B b = new B();
            C c = new C();
            A a2 = new A();
            string q = "";

            q += "BCA : "+b.m1();
            q += c.m2();
            q += a.m3();

            q += ". CCC : " + c.m1();
            q += c.m2();
            q += c.m3();
            
            System.Windows.Forms.MessageBox.Show(q);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Employee E = new Employee();
            E.GetInfo();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mySubClass md = new mySubClass();
            mySubClass md1 = new mySubClass(1);
            mySubClass md3 = new mySubClass("my sub class",33 );

        }
    }
}
