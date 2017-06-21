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

            IEnumerable<Bird> upcastDucks = ducks;//強制轉換成了 List<Duck>

            List<Bird> birds = new List<Bird>();

            birds.Add(new Bird() { Name = "毛毛" });
            birds.AddRange(upcastDucks);
            birds.Add(new Penguin() { Name = "企鵝" });

            foreach (Bird bird in birds)
            {
                Console.WriteLine(birds);
            }
            Console.ReadKey();

            Duck[] duckArray = new Duck[6];
            duckArray.GetEnumerator();
            // Array 跟 List都有 GetEnumerator 是因為 他們都用了 IEnumerable<T>的接口 接口包含了 GetEnumerator
            //都會返回一個 Enumerator 對象

            ducks.GetEnumerator();

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
                //Console.WriteLine(duck.Size.ToString()+"吋"+ duck.Kind.ToString() );
                //當 duck有 override string TOstring() 時
                // duck 就可以產生 XX吋XXXX的字串了 
                //利用這一點就可以改寫為下面的Code
                Console.WriteLine(duck);
            }
            /*
             上面的Code 用IEnumerable<T> 寫的話
            IEnumerable<Duck> enumerator = ducks.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Duck duck = enumerator.Current;
                Console.WriteLine(duck);
            }
            IDisposable disposable = enumerator as IDisposable;
            if (disposable != null)
                disposable.Dispose();
             */


            Console.WriteLine("沒了");
            Console.ReadKey();
            Console.WriteLine("\n");
        }

    }
}
