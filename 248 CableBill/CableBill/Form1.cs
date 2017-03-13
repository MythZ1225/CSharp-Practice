using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CableBill
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            CableBill january = new CableBill(4);

            CableBill february = new CableBill(7);
            //february.payPerViewDiscount = 1;

            CableBill march = new CableBill(9);
            march.Discount = true;

            /*
            label1.Text = january.ToString();
            maskedTextBox1.Text= january.CaculateAmount(7).ToString();

            label4.Text = february.ToString();
            maskedTextBox2.Text = february.CaculateAmount(7).ToString();

            label6.Text = march.ToString();
            maskedTextBox3.Text = march.CaculateAmount(6).ToString();
            */
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CableBill jun = new CableBill(4);
            maskedTextBox1.Text = jun.CaculateAmount(7).ToString();
            label1.Text = "jun";

            CableBill feb = new CableBill(7);
            //feb.payPerViewDiscount = 1;
            maskedTextBox2.Text = feb.CaculateAmount(7).ToString();
            label4.Text = "feb";

            CableBill mar = new CableBill(9);
            mar.Discount = true;
            maskedTextBox3.Text = mar.CaculateAmount(6).ToString();
            label6.Text = "mar";
        }
    }
}
