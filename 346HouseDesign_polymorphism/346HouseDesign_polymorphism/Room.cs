using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _346HouseDesign_polymorphism
{
    class Room : Location
       {
        //Room 特有的 屬性 decoration
        private string decoration;

        //Room 的建構子 
        public Room(string name, string decoration)
            : base(name)
        {
            this.decoration = decoration;
        }

        public override string Description
        {
            get
            {
                return base.Description + " 你可以看到 " + decoration + ".";
            }
        }
    }



    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public RoomWithDoor(string name, string decoration, string doorDescription)
            : base(name, decoration)
        {
            this.doorDescription = doorDescription;
        }

        // IHasExteriorDoor 參數
        private string doorDescription;
        public string DoorDescription
        {
            get { return doorDescription; }
        }

        private Location doorLocation;
        public Location DoorLocation
        {
            get { return doorLocation; }
            set { doorLocation = value; }
        }
    }
}
