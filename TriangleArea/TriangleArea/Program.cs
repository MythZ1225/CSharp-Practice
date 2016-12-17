using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriangleArea
{
    class Triangle
    {
        double area;
        int height;
        int length;
        public static void Main(String[] args)
        {
            string result = "";
            int x = 0;
            Triangle[] ta = new Triangle[4];

            while (x < 4)
            {
                ta[x] = new Triangle();
                ta[x].height = (x + 1) * 2;
                ta[x].length = (x + 1) * 2;
                ta[x].setArea();
                result += "triangle " + x + ", area";
                result += " = " + ta[x].area + "\n";
                x = x + 1;
            }
            int y = x;
            x = 27;
            Triangle t5 = ta[2];
            ta[2].area = 343;
            result += "y = " + y;
            MessageBox.Show(result + ", t5 area = " + t5.area);
        }
        void setArea()
        {
            area = (height * length) / 2;
        }
    }
    /*
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }*/
}
