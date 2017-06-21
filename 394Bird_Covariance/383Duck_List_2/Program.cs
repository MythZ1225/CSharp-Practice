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

            foreach (Bird bird in birds) //把birds中的所有Bird列出來
            {
                Console.WriteLine(bird);
            }
            Console.ReadKey();
        }

    }
}
