using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _374Egg_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Egg> myCarton = new List<Egg>(); //創建Egg清單 myCarton

            Egg x = new Egg();  //創建Egg x
            myCarton.Add(x);    // 把x加到myCarton清單裡

            Egg y = new Egg();  //創建Egg y
            myCarton.Add(y);    // 把y加到myCarton清單裡

            Egg z = new Egg();  //創建Egg z

            int myCartonsize = myCarton.Count;  //查看myCarton目前清單大小
            MessageBox.Show("myCarton.Count = " + myCartonsize);

            bool Isin = myCarton.Contains(x);   //詢問查看myCarton目前是否有x
            if (Isin)
                MessageBox.Show("myCarton Contains(x)");
            else 
                MessageBox.Show("myCarton Don't Contains(x)");

            int idx = myCarton.IndexOf(y);
                MessageBox.Show("myCarton.y在"+ idx + "位置上");

            myCarton.Remove(y);
                MessageBox.Show("移除了myCarton.y");
            int myCartonsize2 = myCarton.Count;  //再次查看myCarton目前清單大小
                MessageBox.Show("myCarton.Count = " + myCartonsize2);

            
        }
    }
}
