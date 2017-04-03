using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _369Cards_Enum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();

            Card card = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            textBox1.Text = card.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
