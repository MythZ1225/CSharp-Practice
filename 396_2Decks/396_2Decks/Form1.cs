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

namespace _396_2Decks
{
    public partial class Form1 : Form
    {
        Deck deck1;
        Deck deck2;
        Random random =new Random();
        private string name;

        public Form1()
        {
            InitializeComponent();
            resetDeck(1);
            resetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void resetDeck(int deckNum)
        {
            if (deckNum==1)
            {
                int numOfCards = random.Next(1,11);
                deck1 = new Deck(new Card[] { });
                for (int i = 0; i < numOfCards; i++)
                {
                    deck1.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
                }
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
            }
        }



        private void RedrawDeck(int DeckNum)
        {
            if (DeckNum ==1)
            {
                listBox1.Items.Clear();
                foreach (string cardName in deck1.GetCardName())
                {
                    listBox1.Items.Add(cardName);
                }
                label1.Text = "Deck #1(" + deck1.Count + "cards)";
            }
            if (DeckNum == 2)
            {
                listBox2.Items.Clear();
                foreach (string cardName in deck2.GetCardName())
                {
                    listBox2.Items.Add(cardName);
                }
                label2.Text = "Deck #2(" + deck2.Count + "cards)";
            }
        }

        private void ResetBtn1_Click(object sender, EventArgs e)
        {
            resetDeck(1);
            RedrawDeck(1);
        }

        private void ResetBtn2_Click(object sender, EventArgs e)
        {
            resetDeck(2);
            RedrawDeck(2);
        }

        private void ShuffleBtn1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void ShuffleBtn2_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(2);
        }

        private void toDeck1Btn_Click(object sender, EventArgs e)
        {
            if (listBox2.SelectedIndex >= 0)
            {
                if (deck2.Count>0)
                {
                    deck1.Add(deck2.Deal(listBox2.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void toDeck2Btn_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex >= 0)
            {
                if (deck1.Count > 0)
                {
                    deck2.Add(deck2.Deal(listBox1.SelectedIndex));
                }
            }
            RedrawDeck(1);
            RedrawDeck(2);
        }
        
  



    }

}
