using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383Duck_List_2
{
    class Penguin : Bird
    {
        public void Fly()
        {
            Console.WriteLine("企鵝不會飛");
        }

        public override string ToString()
        {
            return "一隻名為" + base.Name + "的企鵝。";
        }
    }
}
