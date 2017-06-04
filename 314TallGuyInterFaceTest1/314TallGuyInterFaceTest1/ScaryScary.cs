using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _314TallGuyInterFaceTest1
{
    class ScaryScary : FunnyFunny, IScaryClown
    {
        public ScaryScary(string funnyThingIHave, int numOfScaryThingIhave):base(funnyThingIHave)
        /*FunnyFunny 有建構子 所以得用 base(funnyThingIHave) 同時就不用重寫
         * this.funnyThingIHave = funnyThingIHave 
         * 跟 private string funnyThingIHave 
         */
        {
            this.numOfScaryThingIhave = numOfScaryThingIhave;
        }

        private int numOfScaryThingIhave;

        public string ScaryThingIhave
        {
            get { return "齁齁! 我有" + numOfScaryThingIhave + "個嚇人的小東西"; }
        }

        public void ScareLittleChildren()
        {
            MessageBox.Show(this.ScaryThingIhave);
        }

    }
}
