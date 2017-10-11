using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _487_BinaryWriterReader
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 48769414;
            string sValue = "Hello!";
            byte[] bValue = { 47, 129, 0, 116 };
            float fValue = 491.695F;
            char CValue = 'E';

            using (FileStream output = File.Create("binaryData.dat"))
            using (BinaryWriter BW = new BinaryWriter(output))
            {
                BW.Write(intValue);
                BW.Write(sValue);
                BW.Write(bValue);
                BW.Write(fValue);
                BW.Write(CValue);
            }

            byte[] dataWritter = File.ReadAllBytes("binaryData.dat");
            foreach (byte b in dataWritter)
            {
                Console.Write("{0:x2}", b);
            }
            Console.WriteLine(" - {0} bytes", dataWritter.Length);
            Console.ReadKey();

            using (FileStream inpute = File.OpenRead("binaryData.dat"))
            using (BinaryReader BR = new BinaryReader(inpute))
            {
                int intRead = BR.ReadInt32();
                string sRead = BR.ReadString();
                byte[] bRead = BR.ReadBytes(4);
                float fRead = BR.ReadSingle();
                char cRead = BR.ReadChar();

                Console.Write("int : {0}    string : {1}   \n bytes :", intRead, sRead);
                foreach (byte b in bRead)
                {
                    Console.Write("{0} ", b);
                }
                Console.Write(" float : {0}    char : {1}", fRead, cRead);
            }
            Console.ReadKey();


        }
    }
}
