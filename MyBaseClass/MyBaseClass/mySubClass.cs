using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBaseClass
{
    class mySubClass : myBaseClass
    {
        public mySubClass() : base()
        {

        }
        public mySubClass(int i) : base(i)
        {

        }

        public mySubClass(string baseClassNeedThis, int anotherValue) : base(baseClassNeedThis)
        {
            MessageBox.Show("This is the sub class: " + baseClassNeedThis + " and "+ anotherValue);
        }
    }
}
