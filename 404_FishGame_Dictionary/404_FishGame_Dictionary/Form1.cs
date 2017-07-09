using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _404_FishGame_Dictionary
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Game game; 

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text))
            {
                MessageBox.Show("請輸入姓名","尚無法開始");
                return;
            }

            game = new Game(textName.Text, new List<string> { "Joe", "Bob" }, textProgress);
            btnStart.Enabled = false;
            textName.Enabled = false;
            btnAsk.Enabled = true;
            updateForm();

        }

        private void updateForm()
        {
            listHand.Items.Clear();
            foreach (String cardName in game.GetPlayerCardNames())
            {
                listHand.Items.Add(cardName);
            }
            textBooks.Text = game.DescribeBooks();
            textProgress.Text += game.DescribePlayerHands();
            textProgress.SelectionStart = textProgress.Text.Length;
            textProgress.ScrollToCaret();

        }

        private void btnAsk_Click(object sender, EventArgs e)
        {
            textProgress.Text = ""; //先清掉textProgress.Text
            if (listHand.SelectedIndex < 0) 
            {
                MessageBox.Show("請選牌"); //沒選牌的話
                return;
            }
            if (game.PlayOneRound(listHand.SelectedIndex))
            {
                textProgress.Text += "贏家是" + game.GetWinnerName();
                textBooks.Text = game.DescribeBooks();
                btnAsk.Enabled = false;
            }
            else
            {
                updateForm();
            }
        }
    }
}
