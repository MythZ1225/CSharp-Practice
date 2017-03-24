using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _346Birds_polymorphism
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // 創建Bird Array,添加Bird對象,magpie對象,Eagle對象,Penguin對象
            Bird[] birds = {
                // new Bird(), //使用抽象Birds時，Bird實體沒辦法被創建，所以需要隱藏
                new magpie(),
                new Eagle(),
                new Penguin(),
            };
            
            //跑一下每個birds的輸出
            foreach (Bird bird in birds)
            {
                bird.Eat();
            }
            /*
            輸出結果 
            虛擬                         抽象
            我是隻小小鳥，我喜歡吃蟲子
            我是隻喜鵲，我喜歡吃蟲子       我是隻喜鵲，我喜歡吃蟲子 
            我是隻老鷹，我喜歡吃肉         我是隻老鷹，我喜歡吃肉
            我是隻企鵝，我喜歡吃魚         我是隻企鵝，我喜歡吃魚
            
            由此可見，子類Magpie，Eagle，Penguin對像可以賦值給父類對像
            也就是說父類類型指針可以指向子類類型對像，這裡體現了裡氏替換原則。
            父類對像調用自己的Eat()方法
            實際上顯示的是父類類型指針指向的子類類型對像重寫父類Eat後的方法。這就是多態。
            其實多態的作用就是把不同的子類對像都當作父類來看，
            可以屏蔽不同子類對像之間的差異，寫出通用的代碼，做出通用的編程，
            以適應需求的不斷變化。

            選擇使用虛方法實現多態還是抽像類抽像方法實現多態，
            取決於我們是否需要使用基類實例化的對像.
             */

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // 創建IFlyable array,添加magpie對象,Eagle對象,Penguin對象
            IFlyable[] Flybirds = {
                // new Bird(), //使用抽象Birds時，Bird實體沒辦法被創建，所以需要隱藏
                new magpie(),
                new Eagle(),
                new AirPlane(),
            };

            //跑一下每個birds的輸出
            foreach (IFlyable fly in Flybirds)
            {
                fly.Fly();
            }
        }

        /*
         輸出結果 
         我是隻喜鵲，我會飛 
         我是隻老鷹，我會飛  
         我是飛機，我也會飛         
         
        由此，可以看出用接口實現多態程序的擴展性得到了大大提升，
        以後不管是再擴展一個蝴蝶（Butterfly），還是鳥人（Birder）創建一個類，
        實現這個接口，在主函數中添加該對像就可以了。
        也不需要查看源代碼是如何實現的，體現了開放封閉原則！
        接口充分體現了多態的魅力~~
         */
    }
}
