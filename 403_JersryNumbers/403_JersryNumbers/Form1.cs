using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _403_JersryNumbers
{
    public partial class Form1 : Form
    {
        Dictionary<int, JerseyNumber> retiredNums = new Dictionary<int, JerseyNumber>()
        {
            {3, new JerseyNumber("把餔", 1948) },
            {4, new JerseyNumber("路易", 1939) },
            {5, new JerseyNumber("瑪莉喔", 1952) },
            {7, new JerseyNumber("桃子", 1969) },
            {8, new JerseyNumber("蘑菇人", 1972) },
            {10, new JerseyNumber("庫巴", 1985) },
            {23, new JerseyNumber("耀熙", 1997) },
            {42, new JerseyNumber("烏龜", 1993) },
            {44, new JerseyNumber("香菇人", 1993) },

        };

        public Form1()
        {
            InitializeComponent();
            foreach (int key in retiredNums.Keys)
            {
                comboBox1.Items.Add(key);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            JerseyNumber jerseyNum = retiredNums[(int)comboBox1.SelectedItem] as JerseyNumber;
            nameText.Text = jerseyNum.Player;
            YearText.Text = jerseyNum.YearUsed.ToString();
        }
    }
}
