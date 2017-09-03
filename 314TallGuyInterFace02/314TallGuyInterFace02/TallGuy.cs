using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _314TallGuyInterFace02
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public void TalkaAboutYouself()
        {
            MessageBox.Show("我是"+ Name + ", 我有" + Height + "公分");
        }

        public string FunnyThingIHave { get { return "大鞋"; } } //由IClown 繼承

        public void Honk()                                       //由IClown 繼承
        {
            MessageBox.Show("齁齁齁! 我有" + FunnyThingIHave);
        }

    }

    interface IClown
    {
        string FunnyThingIHave { get; }
        void Honk();
    }

    interface IScaryClown : IClown
    {
        string ScaryThingIHave { get; }
        void ScareLittleChileren();
    }

    class FunnyFunny : IClown
    {
        protected string funnyThingIHave;
        public string FunnyThingIHave
        {
            get { return "齁齁齁! 我有" + funnyThingIHave; }
        }

        public FunnyFunny(string funnyThingIHave)
        {
            this.funnyThingIHave = funnyThingIHave;
        }

        public void Honk()
        {
            MessageBox.Show(this.FunnyThingIHave);
        }
    }


    class ScaryScary :  FunnyFunny , IScaryClown 
    {
        private int numOfSacayThings;       
        public string ScaryThingIHave           //由IScaryClown 繼承
        {
            get {return "嘿嘿嘿! 我有" + numOfSacayThings + "隻蜘蛛"; }
        } 
        public void ScareLittleChileren()       //由IScaryClown 繼承
        {
            MessageBox.Show("你沒有我的" + base.funnyThingIHave);
        }

        public ScaryScary(string funnyThingIHave, int numOfSacayThings) : base (funnyThingIHave)
        {
            this.numOfSacayThings = numOfSacayThings;
        }
    }

}
