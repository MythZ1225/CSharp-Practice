using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _377ShoeCloset_List
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Shoe> shoeCloset = new List<Shoe>(); //建立清單與項目
            /*
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "黑" });
            shoeCloset.Add(new Shoe() { Style = Style.Clogs, Color = "棕" });
            shoeCloset.Add(new Shoe() { Style = Style.WingTips, Color = "黑" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "白" });
            shoeCloset.Add(new Shoe() { Style = Style.Loafers, Color = "紅" });
            shoeCloset.Add(new Shoe() { Style = Style.Sneakers, Color = "綠" });
            */
            //使用集合初始化方法重寫代碼 collection initializer 
            new Shoe() { Style = Style.Sneakers, Color = "黑" };
            new Shoe() { Style = Style.Clogs, Color = "棕" };
            new Shoe() { Style = Style.WingTips, Color = "黑" };
            new Shoe() { Style = Style.Loafers, Color = "白" };
            new Shoe() { Style = Style.Loafers, Color = "紅" };
            new Shoe() { Style = Style.Sneakers, Color = "綠" };


            int numOFShoes = shoeCloset.Count; //設立參數好查詢數量

            MessageBox.Show("shoeCloset[4] 是 " + shoeCloset[4].Style.ToString() + shoeCloset[4].Color +
                " shoeCloset 大小是 " + shoeCloset.Count);
            MessageBox.Show("移除 shoeCloset[4]");
            shoeCloset.RemoveAt(4);
            MessageBox.Show("shoeCloset[4] 現在是 " + shoeCloset[4].Style.ToString() + shoeCloset[4].Color+
                 " shoeCloset 大小是 " + shoeCloset.Count);

            MessageBox.Show("統整每雙鞋讓他都變一樣");
            foreach (Shoe shoe in shoeCloset) //統整每雙鞋讓他都變一樣
            {
                shoe.Style = Style.FlipFlops;
                shoe.Color = "橘";
            }
            MessageBox.Show("shoeCloset[4] 現在是 " + shoeCloset[4].Style.ToString() + shoeCloset[4].Color +
            " shoeCloset 大小是 " + shoeCloset.Count);

            Shoe thirdShoe = shoeCloset[3];
            Shoe SecondShoe = shoeCloset[2];
            shoeCloset.Clear();　
            MessageBox.Show("shoeCloset.Clear() 清空列表");
            MessageBox.Show("shoeCloset 大小是 " + shoeCloset.Count);


            shoeCloset.Add(thirdShoe);
            MessageBox.Show("shoeCloset.Add(thirdShoe);");
            MessageBox.Show("shoeCloset 大小是 " + shoeCloset.Count);

        }
    }
}
