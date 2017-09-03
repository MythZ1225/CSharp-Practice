﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _314TallGuyInterFaceTest1
{
    class TallGuy : IClown
    {
        public string Name;
        public int Height;

        public void TalkAboutYourself()
        {
            MessageBox.Show("我叫" + Name + " 我身高" + Height + "公分");
        }

        public string FunnyThingIHave   //由IClown 繼承
        {
            get { return "大鞋"; }
        }

        public void Honk()              //由IClown 繼承
        {
            MessageBox.Show("齁齁");
           }

    }
}
