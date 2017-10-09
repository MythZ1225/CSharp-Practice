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
using System.Runtime.Serialization.Formatters.Binary;

namespace _482_SerializationCards
{
    public partial class Form1 : Form
    {
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }


        private Deck randomDeck(int num)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < num; i++)
            {
                myDeck.Add(new Card((Suits)random.Next(4), (Values)random.Next(1, 14)));
            }
            return myDeck;
        }

        private void dealCards(Deck deckToDeal, string title)
        {
            label1.Text = title;
            listBox1.Items.Clear();
            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal(0);
                listBox1.Items.Add(nextCard.CardName);
                
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = randomDeck(5);
            using (Stream output = File.Create("Deck1.dat"))
            {
                BinaryFormatter BF = new BinaryFormatter();
                BF.Serialize(output, deckToWrite);
            }
            dealCards(deckToWrite, "我剛寫入檔案");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Stream Input = File.OpenRead("Deck1.dat"))
            {
                BinaryFormatter BF = new BinaryFormatter();
                Deck deckFromFile = (Deck)BF.Deserialize(Input);
                dealCards(deckFromFile, "我剛讀取檔案");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Deck2.dat"))
            {
                BinaryFormatter BF = new BinaryFormatter();
                for (int i = 0; i <= 5; i++)
                {
                    Deck deckToWrite = randomDeck(random.Next(1, 10));
                    BF.Serialize(output, deckToWrite);
                    dealCards(deckToWrite, "Deck #" + i + "寫入");
                }             
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Stream Input = File.OpenRead("Deck2.dat"))
            {
                BinaryFormatter BF = new BinaryFormatter();
                for (int i = 0; i <= 5; i++)
                {
                    Deck DeckToRead = (Deck)BF.Deserialize(Input);
                    dealCards(DeckToRead, "Deck #" + i + "載入");
                }

            }
        }
    }
}
