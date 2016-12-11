using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _145ArraySloppyJoe
{
    class MenuMaker
    {
        public Random Randomizer;
        string[] Meats = {"烤牛肉","沙拉","火腿","火雞肉" };
        string[] Condiments = { "芥末", "番茄醬", "蜂蜜", "美乃滋" };
        string[] Breads = { "白麵包", "燕麥麵包", "胚芽麵包", "黑麵包" };

        public string GetMenuItem()
        {
            string randomMeat = Meats[Randomizer.Next(Meats.Length)];
            string randomCondiments = Condiments[Randomizer.Next(Condiments.Length)];
            string randomBreads = Breads[Randomizer.Next(Breads.Length)];
            return randomMeat+ randomCondiments+ randomBreads;
        }

    }



}
