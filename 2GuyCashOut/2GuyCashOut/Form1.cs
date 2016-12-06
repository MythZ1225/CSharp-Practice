using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2GuyCashOut
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;
       

        public Form1()
        {
            InitializeComponent();
            //Initialize joe and bob here
            /*
            bob = new Guy();
            bob.Name = "Bob";
            bob.Cash = 100;

            joe = new Guy();
            joe.Name = "Joe";
            joe.Cash = 50;
            */
            bob = new Guy() { Name = "Bob", Cash = 100 };
            joe = new Guy() { Name = "Joe", Cash = 50 };

            UpdateForm();
        }

        public void UpdateForm()
        {
            JoeCash.Text = joe.Name + " has $" + joe.Cash;
            BobCash.Text = bob.Name + " has $" + bob.Cash;
            BankCash.Text = "the bank has $" + bank;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReciveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show("the bank is out of Money"); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGiveToBobBtn_Click(object sender, EventArgs e)
        {
            bob.ReciveCash(joe.GiveCash(10));
            UpdateForm();
        }

        private void bobGiveToJoeBtn_Click(object sender, EventArgs e)
        {
            joe.ReciveCash(bob.GiveCash(5));
            UpdateForm();
        }
    }
}

