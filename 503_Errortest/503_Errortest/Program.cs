using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _503_Errortest
{
    class Program
    {
        static void Main(string[] args)
        {
            BeeProcessor();

        }

        public static void BeeProcessor()
        {
            object myBee = new HoneyBee(36.5, "Zipper");
            float howManyHoney = (float)myBee;
            //Error 無法轉換 obj to float

            HoneyBee anotherBee = new HoneyBee((float)12.5, "Buzzy");
            double beeName = double.Parse(anotherBee.Name);
            //Prase 需要提供一個特定格式的Stream, 這邊他不知道麼轉換，會跑出FormatException

            double totalHoney = 36.5 + 12.5;
            string beeWeCanFeed = "";          
            for (int i = 0; i < (int)totalHoney; i++)
            {
                beeWeCanFeed += i.ToString();
            }
            float f = float.Parse(beeWeCanFeed);
            //for loop 創建出的Stream可能會大於60位數，這邊float f 可能沒辦法容納這麼多位數，會跑出overflowException;


            int drones = 4;
            int queens = 0;
            int dronesPerQueen = drones / queens;
            // 任何數除以0都會出錯 ，所以除之前要先檢查queens是否為0 (DevideByZeroExpetion)


            anotherBee = null;
            if (dronesPerQueen <10)
            {
                anotherBee.DoMyJob();
            }
            // 前置量為 null 他不只向任何東西，所以甚麼都沒有，會跳出 NullReferenceException告訴你沒對象可以調用
        }

       
    }

    class HoneyBee
    {
        private double size;
        private string name;
        public double Size;
        public string Name;
        
        public HoneyBee(double size, string name)
        {
            this.size = size;
            this.name = name;
        }

        public void DoMyJob() { }
    }
}
