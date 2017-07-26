using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _419_BreakfastForLumberjack
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            Flapjack food;
            if (Crispy.Checked == true)
                food = Flapjack.Crispy;
            else if (Soggy.Checked == true)
                food = Flapjack.Soggy;
            else if (Browned.Checked == true)
                food = Flapjack.Browned;
            else
                food = Flapjack.Banana;

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);
        }

        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            breakfastLine.Enqueue(new Lumberjack(nameText.Text));
            nameText.Text = "";
            RedrawList();
        }

        private void RedrawList()
        {
            int number = 1;
            Line.Items.Clear();
            foreach (Lumberjack lumberjack in breakfastLine)
            {
                Line.Items.Add(number + ". " + lumberjack.Name);
                number++;
            }
            if (breakfastLine.Count == 0)
            {
                groupBox1.Enabled = false;
                nextInLine.Text = "";
            }
            else
            {
                groupBox1.Enabled = true;
                Lumberjack currentLumberjack = breakfastLine.Peek();
                nextInLine.Text = currentLumberjack.Name + "得到了" + currentLumberjack.FlapjackCount + "flapjacks";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();
            nextInLine.Text = "";
            RedrawList();
        }
    }
}
