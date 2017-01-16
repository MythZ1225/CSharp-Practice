using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBaseClass
{
    public class myBaseClass
    {
        int num;

        public myBaseClass()
        {
            MessageBox.Show("in BaseClass");
        }

        public myBaseClass(int i)
        {
            num = i;
            MessageBox.Show("in BaseClass(int i)");
        }

        public int GetNum()
        {
            return num;
        }

        public myBaseClass(string baseClassNeedThis)
        {
            MessageBox.Show("This is the base class: "+ baseClassNeedThis);
        }
    }
}
