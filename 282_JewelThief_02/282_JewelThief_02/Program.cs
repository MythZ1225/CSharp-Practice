using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _282_JewelThief_02
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            
            Locksimth lockSmith = new Locksimth();
            lockSmith.OpenSafe(safe, owner);

            JewelThief CatEye = new JewelThief();
            CatEye.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }

    class Jewels
    {
        public string sparkle()
        {
            return "亮晶晶";
        }             
    }

    class Safe
    {
        private Jewels contents = new Jewels();
        private string safePassword = "1234";
        public Jewels Open(string Password)
        {
            if (Password == safePassword)
            {
                return contents;
            }
            else
            {
                return null;
            }
        }

        public void PickLock(Locksimth lockpicker)
        {
            lockpicker.WriteDownPW(safePassword);
        }
    }

    class Locksimth
    {
        private string writeDownPW = null;
        public void WriteDownPW(string PW)
        {
            writeDownPW = PW;
        }


        public void OpenSafe(Safe safe, Owner owener)
        {
            safe.PickLock(this);
            Jewels Safecontents = safe.Open(writeDownPW);
            ReturnContents(Safecontents, owener);
        }

        virtual public void  ReturnContents(Jewels Safecontents, Owner owener)
        {
            owener.RecevieContents(Safecontents);
        }
    }

    class JewelThief : Locksimth
    {
        private Jewels stolenJewel = null;
        override public void  ReturnContents(Jewels Safecontents, Owner owener)
        {
            stolenJewel = Safecontents;
            Console.WriteLine("我偷了寶石" + Safecontents.sparkle());
        }

    }

    class Owner
    {
        private Jewels returnedContents;
        public void RecevieContents(Jewels safeContent)
        {
            returnedContents = safeContent;
            Console.WriteLine("感謝歸還" + safeContent.sparkle());
        }
    }


}
