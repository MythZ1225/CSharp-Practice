using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TypeTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            ErrorTest myTest = new ErrorTest();
            myTest.MyMethod(true);

            MessageBox.Show();

            /*
            int myInt=10;
            byte mybyte = (byte)myInt;
            double mydouble = (double)mybyte;
            bool myBool = (bool)mydouble;
            string myString = "false";
            myBool = (bool)myString;
            myString = (string)myInt;
            myString = myInt.ToString();
            myBool = (bool)mybyte;
            mybyte = (byte)myBool;
            short myShort = (short)myInt;
            char myChar = 'x';
            myString = (string)myChar;
            long myLong = (long)myInt;
            decimal myDecimal = (decimal)myLong;
            myString = myString + myInt + mybyte + myChar+mydouble;
             */

        }
    }
}
