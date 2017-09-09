using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383_ducks
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Kind = KindsOfDuck.Br褐鴨 ,size = 13 },
                new Duck() {Kind = KindsOfDuck.B藍鴨 ,size = 14 },
                new Duck() {Kind = KindsOfDuck.Gr灰鴨 ,size = 16 },
                new Duck() {Kind = KindsOfDuck.G綠鴨 ,size = 17 },
                new Duck() {Kind = KindsOfDuck.Br褐鴨 ,size = 15 },
                new Duck() {Kind = KindsOfDuck.Gr灰鴨 ,size = 13 },
            };

            DuckCompareBySize sizeCompare = new DuckCompareBySize();
            DuckCompareByKind KindCompare = new DuckCompareByKind();
            DuckComparer SortCompare = new DuckComparer();

            PrintDucks(ducks);  // 原始
            Console.ReadKey();
            
            ducks.Sort();       // 大小排序 ICompareable 接口方法 
            PrintDucks(ducks);
            Console.ReadKey();

            ducks.Sort(sizeCompare); // 大小排序 IComparer<Dick> 類方法
            PrintDucks(ducks);
            Console.ReadKey();

            ducks.Sort(KindCompare); // 種類排序
            PrintDucks(ducks);
            Console.ReadKey();

            ducks.Sort(SortCompare); //用SortCompare先大小再種類
            PrintDucks(ducks);
            Console.ReadKey();

            SortCompare.SortBy = SortType.KindThanSize; //用SortCompare先種類再大小
            ducks.Sort(SortCompare);
            PrintDucks(ducks);
            Console.ReadKey();

        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Kind.ToString() + " " + duck.size.ToString() + "公分");
            }
            Console.WriteLine("\n");
        }
    }
    
}
