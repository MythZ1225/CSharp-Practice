using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _314TallGuyInterFaceTest1
{
    class FunnyFunny:IClown
    {
        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        private string funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return "齁齁! 我會" + funnyThingIHave; }
        }

        public void Honk()
        {
            MessageBox.Show(this.FunnyThingIHave);
        }

    }
}
