using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace _463_SaveAndLoad
{
    public partial class 簡易字串編輯器 : Form
    {
        private string name;

        public 簡易字串編輯器()
        {
            InitializeComponent();
            
        }

        private void OpenBtn_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Text Files(*.txt)|*.txt";
            openFileDialog1.InitialDirectory = "L:\\temp";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = openFileDialog1.FileName;
                textBox1.Clear();
                textBox1.Text = File.ReadAllText(name);
            }
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text Files(*.txt)|*.txt | all files (*.*)|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                name = saveFileDialog1.FileName;
                
                File.WriteAllText(name, textBox1.Text);
            }
        }
    }
}
