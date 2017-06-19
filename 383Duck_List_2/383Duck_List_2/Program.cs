using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383Duck_List_2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck() {Size = 17 , Kind =KindOfDuck.Mallard  },
                new Duck() {Size = 12 , Kind =KindOfDuck.Muscovy  },
                new Duck() {Size = 14 , Kind =KindOfDuck.Decoy  },
                new Duck() {Size = 13 , Kind =KindOfDuck.Decoy  },
                new Duck() {Size = 16 , Kind =KindOfDuck.Muscovy  },
            };

            PrintDucks(ducks); //無排序

            ducks.Sort(); // Icomparable > CompareTo() 小到大排序
            PrintDucks(ducks);

            CompareBySize DuckCompareBySize = new CompareBySize();
            ducks.Sort(DuckCompareBySize); // Icomparer > Compare()  大到小排序
            PrintDucks(ducks);

            CompareByKind DuckCompareByKind = new CompareByKind();
            ducks.Sort(DuckCompareByKind); // Icomparer > Compare()  種類小到大排序
            PrintDucks(ducks);

            DuckComparer comaparer = new DuckComparer(); // 用一個DuckComparer 協助排序
            comaparer.SortBy = SortType.KindThenSize;
            ducks.Sort(comaparer); 
            PrintDucks(ducks);

            comaparer.SortBy = SortType.SizeThenKind;
            ducks.Sort(comaparer);
            PrintDucks(ducks);

        }
        public static void PrintDucks(List<Duck> ducks)
        {
            foreach (Duck duck in ducks)
            {
                Console.WriteLine(duck.Size.ToString()+"吋"+ duck.Kind.ToString() );
            }
            Console.WriteLine("沒了");
            Console.ReadKey();
            Console.WriteLine("\n");
        }


        
    }
}
