using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _282_JewelThief_Virtual_Override
{
    class Jewels
    {
        public string Sparkle()
        {
            return "Sparkle, Sparkle!";
        }
    }
    


    class Safe
    {
        private Jewels contents = new Jewels();
        private string safeCombination = "12345";
        public Jewels Open(string combination)
        {
            if (combination == safeCombination)
            {
                return contents;
            }
            else
            {
                return null;
            }
        }

        public void PickLock(Locksmith lockpicker)
        {
            lockpicker.WritDownCombination(safeCombination);
        }

    }

    class Owner
    {
        private Jewels returnContents;
        public void ReceiveConents(Jewels safeContents)
        {
            returnContents = safeContents;
            MessageBox.Show("感謝你還我珠寶" + safeContents.Sparkle());
        }

    }

    class Locksmith
    {

        public void OpenSafe(Safe safe, Owner owner)
        {
            safe.PickLock(this);
            Jewels safeContents = safe.Open(writDownCombination);

        }
        private string writDownCombination = null;
        public void WritDownCombination(string combination)
        {
            writDownCombination = combination;
        }

        public virtual void ReturnContents(Jewels safeContents, Owner owner)
        {
            owner.ReceiveConents(safeContents);
        }
    }

    class JewelThief : Locksmith
    {
        private Jewels stolenJewels = null;
        public override void ReturnContents(Jewels safeContents, Owner owner)
        {
            stolenJewels = safeContents;
            MessageBox.Show("我拿走了" + stolenJewels.Sparkle());
        }
    }

}
