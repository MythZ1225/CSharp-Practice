using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _401_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dictionary<string, string> wordDefinition = new Dictionary<string, string>();

            wordDefinition.Add("Dictionary","依據字母表列出的字的意思");
            wordDefinition.Add("Key", "用來提供某個特殊意義的字眼");
            wordDefinition.Add("Value", "依據Key得到的某個量化的值");

            if (wordDefinition.ContainsKey("Key"))
                MessageBox.Show(wordDefinition["Key"]);
        }
    }
}
