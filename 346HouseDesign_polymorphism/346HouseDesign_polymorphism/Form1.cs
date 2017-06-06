using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _346HouseDesign_polymorphism
{
    public partial class Form1 : Form
    {
        Location 目前位置; //用來在窗體顯示用的字段

        Room 餐廳;
        RoomWithDoor 客廳;
        RoomWithDoor 廚房;

        OutsideWithDoor 前庭;
        OutsideWithDoor 後院;
        Outside 花圃;
        
        public Form1()
        {
            InitializeComponent();

            CreateObj();
            MoveToANewLocation(客廳);
        }

        private void CreateObj()
        {
            //創建物件先將對象實例化，再把各類的構造函數傳進去
            // public Room(string name, string decoration): base(name)
            餐廳 = new Room("餐廳", "水晶燈");
            
            //public RoomWithDoor(string name, string decoration, string doorDescription)
            //: base(name, decoration)
            客廳 = new RoomWithDoor("客廳","骨董","有亮把手的橡木門");
            廚房 = new RoomWithDoor("廚房", "不鏽鋼廚具", "珠鍊門");

            // public Outside(string name, bool hot)
            //: base(name)
            花圃 = new Outside("花圃", false);
                    
            //public OutsideWithDoor(string name, bool hot, string doorDescription)
            //: base(name, hot)
            前庭 = new OutsideWithDoor("前庭", false, "有亮把手的橡木門");
            後院 = new OutsideWithDoor("後院", true, "珠鍊門");

            //創建各對象的 .Exits[]
            //Location[] : 屬性 Exits
            //public Location[] Exits;
            餐廳.Exits = new Location[] { 客廳, 廚房 };
               
            客廳.Exits = new Location[] { 餐廳 }; 
            廚房.Exits = new Location[] { 餐廳 }; 

            前庭.Exits = new Location[] { 後院, 花圃 }; 
            後院.Exits = new Location[] { 前庭, 花圃 }; 
            花圃.Exits = new Location[] { 前庭, 後院 };

            //創建各IHasExteriorDoor 對象的 .DoorLocation
            //public Location DoorLocation
            客廳.DoorLocation = 前庭;
            前庭.DoorLocation = 客廳;

            廚房.DoorLocation = 後院;
            後院.DoorLocation = 廚房;
        }


        private void MoveToANewLocation(Location 新位置)
        {
            目前位置 = 新位置;

            //ComboBox exits 清空
            exits.Items.Clear();
            for (int i = 0; i < 目前位置.Exits.Length; i++)
            {
                //當 目前位置.Exits 沒輪完前 
                //每個 ComboBox exits  項目 加上 目前位置.Exits[i].Name
                exits.Items.Add(目前位置.Exits[i].Name);
                exits.SelectedIndex = 0;

                //TextBox 的 description 字串 = 目前位置.Description;
                description.Text = 目前位置.Description;

                if (目前位置 is IHasExteriorDoor)
                    //Button goThroughTheDoor 的開關判定
                    goThroughTheDoor.Visible = true;
                else
                    goThroughTheDoor.Visible = false;
            }
        }

        //到這邊按鈕, 用戶點擊 到這邊按鈕 時 會移到組合框選中的位置
        private void goHere_Click(object sender, EventArgs e)
        {
            MoveToANewLocation(目前位置.Exits[exits.SelectedIndex]);
        }



        private void goThroughTheDoor_Click(object sender, EventArgs e)
        {
            IHasExteriorDoor 有門 = 目前位置 as IHasExteriorDoor;
            //用 as 關鍵字 將 目前位置 強制向下轉換為 IHasExteriorDoor,
            //以方便訪問 DoorLocation 字串
            MoveToANewLocation(有門.DoorLocation);
        }

    }
}
