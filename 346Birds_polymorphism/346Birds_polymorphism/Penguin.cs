using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _346Birds_polymorphism
{
    /// <summary>
    /// 企鵝 : 子類, 不會飛所以不用IFlyable 接口
    /// </summary> 
    public class Penguin : Bird
    {
        /// <summary>
        /// 重寫父類Eat() 方法
        /// </summary> 
        public override void Eat()
        {
            MessageBox.Show("我是隻企鵝，我喜歡吃魚");
        }
    }    
}
