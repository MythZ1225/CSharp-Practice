using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _346Birds_polymorphism
{

    /// <summary>
    /// 老鷹 : 子類, IFlyable 接口
    /// </summary> 
    public class Eagle : Bird,IFlyable
    {
        /// <summary>
        /// 重寫父類Eat() 方法
        /// </summary> 
        public override void Eat()
        {
            MessageBox.Show("我是隻老鷹，我喜歡吃肉");
        }

        /// <summary>
        /// 實現IFlyable接口方法
        /// </summary> 
        public void Fly()
        {
            MessageBox.Show("我是隻老鷹，我會飛");
        }
    }
}
