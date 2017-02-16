using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flashy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int c = 0;
            while (Visible)
            {
                for (c = 0; c < 256 && Visible; c++ )
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);

                    System.Threading.Thread.Sleep(3);
                    Application.DoEvents();
                }
                for (c = 254; c > 0 && Visible; c--)
                {
                    this.BackColor = Color.FromArgb(c, 255 - c, c);

                    System.Threading.Thread.Sleep(3);
                    Application.DoEvents();

                }
            }
           
        }
    }
}
