using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ch2PoolPuzzle
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            int x = 0;
            String Poem = "";
            while (x<4)
            {
                Poem = Poem + "a";
                if (x<1)
                {
                    Poem = Poem + " ";                 
                }
                Poem = Poem + "n";

                if (x>1)
                {
                    Poem = Poem + " oyster";
                    x = x +2;
                }

                if (x == 1)
                {
                    Poem = Poem + "noys ";
                }
                if (x<1)
                {
                    Poem = Poem + "oise ";
                }
                x = x + 1;
            }
            MessageBox.Show(Poem);




            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
