using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DinnerParty
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.SetHealthOption(true);
            //dinnerParty.CaculateCostumeCost(true);
            DisplayCost();
        }

        private void DisplayCost()
        {
            //decimal cost = dinnerParty.CaculateCost(checkBox2.Checked);
            dinnerParty.SetHealthOption(checkBox2.Checked);

            decimal DrinkPrice      = dinnerParty.CaculateDrinkCost(checkBox2.Checked);
            decimal FoodPrice       = dinnerParty.CaculateFoodCost((int)numericUpDown1.Value);
            decimal DecoPrice       = dinnerParty.CostumeCost(checkBox1.Checked);
            decimal DecoExPrice     = dinnerParty.CostumeBaseCost(checkBox1.Checked);
            decimal RawTotalPrice   = DrinkPrice + FoodPrice + DecoPrice + DecoExPrice;
            decimal DisCountPrice   = dinnerParty.HealthDiscount(checkBox2.Checked);
            decimal FinalTotalPrice = DrinkPrice + FoodPrice + DecoPrice + DecoExPrice + DisCountPrice;

            DrinkTextBox.Text   = DrinkPrice.ToString();
            FoodTextBox.Text    = FoodPrice.ToString();
            DecoTextBox.Text    = DecoPrice.ToString();
            DecoExTextBox.Text  = DecoExPrice.ToString();
            TotalTextBox1.Text  = RawTotalPrice.ToString();
            DisCounTextBox.Text = DisCountPrice.ToString();
            
            CostTextBox.Text = FinalTotalPrice.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOptions((int)numericUpDown1.Value);
            DisplayCost();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            DisplayCost();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            DisplayCost();
        }
    }
}
