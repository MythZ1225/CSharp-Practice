using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCalculator
{
    public partial class Form1 : Form
    {
        int statingMileage, endingMileage;
        double mileTraveled;
        double reimburseRate = 0.39F;
        double amountOwed = 0D;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label5.Text = 0 + " miles";
            label4.Text = "$" + 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            statingMileage = (int)StartingMileageNum.Value;
            endingMileage = (int)EndingMileageNum.Value;
            if (endingMileage >= statingMileage)
            {
                mileTraveled = endingMileage - statingMileage;
                amountOwed = mileTraveled * reimburseRate;
                label4.Text = "$" + amountOwed.ToString("0.00");
                label5.Text = mileTraveled + " miles";
            }
            else
            {
                MessageBox.Show("結束里程需大於開始里程", "無法計算");
            }
            
        }
       
    }
}
