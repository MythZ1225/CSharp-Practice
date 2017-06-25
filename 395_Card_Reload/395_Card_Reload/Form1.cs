using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _395_Card_Reload
{
    public partial class Form1 : Form
    {
        Deck deck1, deck2;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            resetDeck(1);   //初始化兩副牌
            resetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void resetDeck(int DeckNum)
        {
            if (DeckNum == 1)
            {
                int numberOfCards = random.Next(1, 11); //隨機增加1~11張牌
                Card[] NewDeckCards = new Card[] { };   //創一個容器
                deck1 = new Deck(NewDeckCards);         //讓Card[]變成Deck List<Card>的內容

                for (int i = 0; i < numberOfCards; i++)
                {
                    deck1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                }
                deck1.Sort();
            }
            else
                deck2 = new Deck();
        }

        private void RedrawDeck(int DeckNumber) //重新刷新繪製牌的名字
        {
            if (DeckNumber == 1)
            {
                listBox1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                {
                    listBox1.Items.Add(cardName);
                }
                label1.Text = "牌堆1(" + deck1.Count + "張)";
            }
            else
            {
                listBox2.Items.Clear();
                foreach (string cardName in deck2.GetCardNames())
                {
                    listBox2.Items.Add(cardName);
                }
                label2.Text = "牌堆2(" + deck2.Count + "張)";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Card cardToCheck = new Card(Suits.梅花, Values.Ten);
            bool doesItMatch = Card.DoesCardMatch(cardToCheck, Suits.紅心);
            MessageBox.Show(doesItMatch.ToString());            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset1_Click(object sender, EventArgs e)
        {
            resetDeck(1);
            RedrawDeck(1);
        }

        private void reset2_Click(object sender, EventArgs e)
        {
            resetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex>=0)
            {
                if (deck2.Count>0)
                {
                    deck1.Add(deck2.Deal(listBox2.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (deck1.Count > 0)
                {
                    deck2.Add(deck1.Deal(listBox1.SelectedIndex));
                    //SelectedIndex是listBox1裡的控制元件，可以知道玩家選擇哪張牌
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
