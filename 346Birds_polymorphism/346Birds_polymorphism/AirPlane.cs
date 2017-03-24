using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _346Birds_polymorphism
{
    /// <summary>
    /// 飛機也會飛，但不是鳥類，所以只接IFlyable 接口
    /// </summary>
    public class AirPlane : IFlyable
    {
        /// <summary>
        /// 實現IFlyable接口方法
        /// </summary> 
        public void Fly()
        {
            MessageBox.Show("我是隻飛機，我也會飛");
        }

    }
}
