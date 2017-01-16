using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBaseClass
{
    public class Employee : Person
    {
        public string id = "ABC567EFG";
        public override void GetInfo()
        {
            base.GetInfo();
            MessageBox.Show(String.Format("Employee ID:{0}", id));
        }

    }


}
