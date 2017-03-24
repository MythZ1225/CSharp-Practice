using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _346Birds_polymorphism
{
    /// <summary>
    /// 鳥類 : 父類
    /// </summary>
    public abstract class Bird
    {
        /// <summary>
        /// 吃 : 抽象方法
        /// 沒有方法體
        /// </summary>  
        public abstract void Eat();


        /*
        /// <summary>
        /// 吃 : 虛擬方法
        /// </summary>  
        public virtual void Eat()
        {
            MessageBox.Show("我是隻小小鳥，我喜歡吃蟲子");
        }
        */
    }
}
