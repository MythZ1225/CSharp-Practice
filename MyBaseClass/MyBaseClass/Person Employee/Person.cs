using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyBaseClass
{
    public class Person
    {
        protected string ssn = "444-555-666";
        protected string name = "JM";

        public virtual void GetInfo()
        {
            MessageBox.Show(String.Format("Name : {0}", name));
            MessageBox.Show(String.Format("ssn : {0}", ssn));

        }

    }    
}
