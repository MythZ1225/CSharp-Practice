using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _314TallGuyInterFaceTest1
{
    interface IScaryClown : IClown
    {
        string ScaryThingIhave { get; }

        void ScareLittleChildren();
    }
    /* IScaryClown 繼承了 IClown 
     所以 IScaryClown 有 
    string ScaryThingIhave { get; }
    void ScareLittleChildren();
    跟
    string FunnyThingIHave { get;  }
    void Honk();
    */
}
