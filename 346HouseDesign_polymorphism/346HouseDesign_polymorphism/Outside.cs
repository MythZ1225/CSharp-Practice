using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _346HouseDesign_polymorphism
{
    class Outside : Location
    {
        private bool hot;
        public bool Hot { get { return hot; } }

        public Outside(string name, bool hot)
            : base(name)
        {
            this.hot = hot;
        }

        public override string Description // 繼承 Location 所以可以override Description
        {
            get
            {
                string NewDescription = base.Description;  //base.Description = Location的 Description
                if (hot)
                    NewDescription += " It’s very hot.";
                return NewDescription;
            }
        }
    }

    class OutsideWithDoor : Outside, IHasExteriorDoor
    {
        public OutsideWithDoor(string name, bool hot, string doorDescription)
            : base(name, hot)
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

        public override string Description
        {
            get
            {
                return base.Description + " 你可看到 " + doorDescription + ".";
            }
        }
    }
}
