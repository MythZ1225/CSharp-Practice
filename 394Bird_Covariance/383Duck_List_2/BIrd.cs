using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _383Duck_List_2
{
    class Bird
    {
        public string Name { get; set; }
        public void Fly()
        {
            Console.WriteLine("飛飛飛");
        }

        public override string ToString()
        {
            return "一隻名為" + Name + "的鳥。";
        }
    }
}
