using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _346HouseDesign_polymorphism
{
    // Location : 抽象 父類 
    abstract class Location
    {
        // 父類建構子 : 屬性 名字
        public Location(string name)
        {
            this.name = name;
        }

        // Location[] : 屬性 Exits
        public Location[] Exits;

        // Location : 私屬性 name
        private string name;
        // Location : 公屬性 Name ,取得並返回 私屬性 name
        public string Name { get { return name; } }

        // 虛擬 字串屬性 描述
        public virtual string Description 
        {
            get
            {
                //設立description = "你可以在"+ name + "這個地方看到出口"
                string description = "你可以在"+ name + "這個地方看到出口" ;

                //讓description = "你可以在"+ name + "這個地方看到出口" 
                //              + " " + Exits[i].Name 
                //                +Exits.Length!=0時  
                for (int i = 0; i < Exits.Length; i++)
                {
                    description += " " + Exits[i].Name;
                    if (i != Exits.Length-1)
                    {
                        description += ",";
                    }
                }
                description += ".";
                return description;
            }            
        }
    }




}
