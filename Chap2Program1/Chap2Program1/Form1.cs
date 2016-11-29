using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chap2Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("name is " + name + "\nx is " + x + "\nd is " + d);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int x = 5;
            if (x==10)
            {
                MessageBox.Show("X must be 10");
            }
            else
            {
                MessageBox.Show("X isn't 10");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int someValue = 4;
            String name = "Bobbo Jr.";
            if ((someValue == 3)&&(name.Equals("Joe")))
            {
                MessageBox.Show("x is 3 and the name is Joe");
            }
            MessageBox.Show("this Line Runs No matter what");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int count = 0;
            while (count<10 )
            {
                count = count++;
            }
            for (int i = 0; i < 5; i++)
            {
                count = count--;
            }
            MessageBox.Show("the Answer is "+ count);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String Result = "";
            int X = 3;

            while (X>0)
            {

                if (X > 2)
                {
                    Result = Result + "a";
                }

                X = X - 1;
                Result = Result + "-";

                if (X == 2)
                {
                    Result = Result + "b c";                    
                }

                if (X==1)
                {
                    Result = Result + "d";
                    X = X - 1;
                }


            }




            MessageBox.Show(Result);
        }
    }
}
