using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _450_Swindler_StreamWiter
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter(@"L:\secret_plan.txt");

            sw.WriteLine("如何打敗超人");
            sw.WriteLine("我另一個絕妙的計畫");  //WriteLine 會換行
            sw.Write("我會創造一群複製人大軍且");      //Write 不會換行
            sw.WriteLine("放出他們到城裡作亂");

            string location = "商場";

            for (int i = 0; i <= 6; i++)
            {
                sw.WriteLine("複製人{0}號 攻擊{1}", i, location);

                if (location == "商場")
                {
                    location = "市中心";
                }
                else
                {
                    location = "商場";
                }
            }

            sw.Close();
        }
    }
}
