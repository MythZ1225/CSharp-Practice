using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace _151_Guy_Constructor
{

    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        Guy bank;

        public Form1()
        {
            InitializeComponent();
            joe = new Guy { Name = "Joe", Cash = 100 };
            bob = new Guy { Name = "Bob", Cash = 50 };
            bank = new Guy { Name = "Bank", Cash = 100 };
            UpdateForm();

        }

        public void UpdateForm()
        {
            label1.Text = joe.Name + "有 $" + joe.Cash;
            label4.Text = bob.Name + "有 $" + bob.Cash;
            label7.Text = bank.Name + "有 $" + bank.Cash;
        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (bank.Cash >= 10)
            {
                bank.Cash -= 10;
                joe.ReciveCash(10);
                UpdateForm();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
                bank.Cash += 5;
                bob.GiveCash(5);
            UpdateForm();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            joe.Cash -= joe.GiveCash(10);
            bob.Cash += bob.ReciveCash(10);
            UpdateForm();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bob.Cash -= bob.GiveCash(5);
            joe.Cash += joe.ReciveCash(5);
            UpdateForm();
        }

        private void SaveJoeBtn_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Guy_File.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, joe);
                formatter.Serialize(output, bob);
                formatter.Serialize(output, bank);
            }
        }



        private void LoadJoeBtn_Click(object sender, EventArgs e)
        {
            using (Stream Input = File.OpenRead("Guy_File.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(Input);
                bob = (Guy)formatter.Deserialize(Input);
                bank = (Guy)formatter.Deserialize(Input);
            }
            UpdateForm();
        }
    }
}
