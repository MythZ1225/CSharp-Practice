using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _451_StreamWriter磁條
{
    class Flobbo
    {
        private string Zap;

        public Flobbo(string Zap)
        {
            this.Zap = Zap;
        }

        public StreamWriter Snobbo()
        {
            return new StreamWriter(@"C:\macaw.txt");
        }

        public bool Blobbo(StreamWriter sw)
        {
            sw.WriteLine(Zap);
            Zap = "綠紫";
            return false;

        }

        public bool Blobbo(bool Already, StreamWriter sw)
        {
            if (Already)
            {
                sw.WriteLine(Zap);
                sw.Close();
                return false;

            }
            else
            {
                sw.WriteLine(Zap);
                Zap = "紅橘";
                return true;
            }
        }

    }
}
