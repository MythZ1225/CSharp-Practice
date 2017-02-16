using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MileageCaculator2
{
    public partial class Form1 : Form
    {
        int startMile;
        int endMile;
        double mileTraveled;
        double reimburseRate = 0.39 ;
        double monryReturn;

        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            startMile =(int) numericUpDown1.Value ;
            if (endMile > startMile)
            {
                countMileTravel();
                countmonryReturn();
            }
            else
            {
                label4.Text = "起始里程大於結束里程，請重新設定";
            }

        }

        private double countMileTravel()
        {
                mileTraveled = endMile - startMile;
                label4.Text = mileTraveled.ToString()+ "英里";
                return mileTraveled;            
        }

        private void countmonryReturn()
        {
            monryReturn = mileTraveled * reimburseRate;
            label6.Text = monryReturn.ToString() + "元";
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            endMile = (int)numericUpDown2.Value;
            if (endMile > startMile)
            {
                countMileTravel();
                countmonryReturn();
            }
            else
            {
                label4.Text = "起始里程大於結束里程，請重新設定";
            }
        }
    }
}
