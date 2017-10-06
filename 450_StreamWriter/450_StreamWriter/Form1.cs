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

namespace _450_StreamWriter
{
    public partial class Form1 : Form
    {
        StreamReader sr = new StreamReader(@"L:\給超人的信2.txt");

        StreamWriter sw = new StreamWriter(@"L:\給超人的信3.txt");
        

        public Form1()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sw.WriteLine("如何打敗超人");
            sw.WriteLine("其他邪惡計畫");
            sw.Write("製作更多邪惡怪人");
            string Location = "購物城";
            for (int i = 0; i < 6; i++)
            {
                sw.WriteLine("複製人#{0} 攻擊{1}", i, Location);
                if (Location == "購物城")
                {
                    Location = "市中心";
                }
                else
                {
                    Location = "購物城";
                }
            }
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sw.WriteLine("給 超人");
            sw.WriteLine("來自 邪惡博士");
            sw.WriteLine("你阻擋不了我的!");
            sw.WriteLine();
            sw.WriteLine("我發現了大秘密!");
            while (!sr.EndOfStream)     
            {
                string lineFromThePlan = sr.ReadLine();
                sw.WriteLine("計畫→" + lineFromThePlan);
            }
            sw.WriteLine();
            sw.WriteLine("救命啊!");
            sw.Close();
            sr.Close();
        }
    }
}
