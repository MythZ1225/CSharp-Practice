using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElephantSays
{
    class Elephant
    {
        public string Name;
        public int EarSize;
        
        public void TellMe(string message, Elephant whoSaidThat)
        {
            MessageBox.Show(whoSaidThat.Name + " says: " + message);
        }
        public void speakTo(Elephant talkTo, string message)
        {
            talkTo.TellMe(message,this);
        }


    }
}
