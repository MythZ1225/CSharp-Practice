using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _151_Guy_Constructor
{
    [Serializable]
    class Guy
    {
        public string Name;
        public int Cash;

        public int GiveCash(int amount)
        {
            if (Cash >= amount && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show("我的錢沒有" + amount + "那麼多");
                return 0;
            }      
        }

        public int ReciveCash(int amount)
        {
            if (amount > 0 )
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show(Name + "說：這錢不夠" + amount);
                return 0;
            }
        }
    }
}
