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

namespace _451_StreamWriterTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Flobbo f = new Flobbo("藍黃");
            StreamWriter sw = f.Snobbo();
            f.Bolbbo(f.Bolbbo(f.Bolbbo(sw), sw),sw);
        }
    }

    class Flobbo
    {
        private string Zap;

        public Flobbo(String Zap)
        {
            this.Zap = Zap;
        }

        public StreamWriter Snobbo()
        {
            return new StreamWriter(@"L:\macaw.txt");
        }

        public bool Bolbbo(StreamWriter sw)
        {
            sw.WriteLine(Zap);
            Zap = "綠紫";
            return false;
        }

        public bool Bolbbo(bool Aready, StreamWriter sw)
        {
            if (Aready)
            {
                sw.WriteLine(Zap);
                sw.Close();
                return false;
            }
            else
            {
                sw.WriteLine(Zap);
                Zap = "橘紅";
                return true;
            }
        }
    } 
}
