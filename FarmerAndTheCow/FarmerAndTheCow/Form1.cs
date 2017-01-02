using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmerAndTheCow
{
    public partial class Form1 : Form
    {
        Farmer myFarmer  ;
        
        public Form1()
        {
            InitializeComponent();
            myFarmer = new Farmer(15, 30);
            numericUpDown1.Value = myFarmer.NumberOfCows;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            myFarmer.NumberOfCows= numericUpDown1.Value;
            decimal howMayBags = myFarmer.BagsOfFeed;

            feedMutiplierTextBox.Text = myFarmer.FeedMutiplier.ToString();

            BagsOfFeedTextBox.Text = howMayBags.ToString();
            Console.WriteLine("I need {0} bags of feed for {1} cows", myFarmer.BagsOfFeed, myFarmer.NumberOfCows );
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //myFarmer.BagsOfFeed = 5;
        }
    }
}
