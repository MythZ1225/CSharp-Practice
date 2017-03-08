using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TallGuy_InterfaceTest
{
    public interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();
    }

    public interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScarLittleChildren();
    }

    public class FunnyFunny : IClown
    {
        protected string funnyThingIHave;
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public string FunnyThingIHave
        {
            get { return "齁齁! 我會" + funnyThingIHave; }
        }

        public void Honk()
        {
            MessageBox.Show(this.funnyThingIHave);
        }
    }

    public class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numberOfScaryThings) : base(funnyThingIHave)
        {
            this.numberOfScaryThings = numberOfScaryThings;

        }
        private int numberOfScaryThings;

        public string ScaryThingIHave
        {
            get { return "我有" + numberOfScaryThings + "蜘蛛"; }
        }

        public void ScarLittleChildren()
        {
            MessageBox.Show("Boo! 嚇到你了!" + base.funnyThingIHave);
        }

    }
}
