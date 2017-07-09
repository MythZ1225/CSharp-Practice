using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _404_FishGame_Dictionary
{
    class Player
    {
        private string name;
        public string Name{ get { return name; } }

        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;

        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            this.cards = new Deck(new Card[] { });
            textBoxOnForm.Text += name + "加入了遊戲" + Environment.NewLine;

        }

        public IEnumerable<Values> PullOutBooK() //抽掉成套的牌
        {
            List<Values> books = new List<Values>();
            for (int i = 0; i < 13; i++)        //一個值一個值檢查1~13
            {
                Values value = (Values)i;
                int howMany = 0;                //歸零
                for (int card = 0; card < cards.Count; card++) //
                {
                    if (cards.Peek(card).Value == value )   //當檢察值與手牌的卡的質相同時
                    {
                        howMany++;                          //howMany+1
                    }
                }
                if (howMany ==4)                            //當howMany=4 時成套
                {
                    books.Add(value);                       //成套的值 book+value 點數
                    for (int card = cards.Count-1; card >=0 ; card--)   
                    {
                        cards.Deal(card);                   //抽掉成套的牌
                    }
                }               
            }
            return books;
        }

        public Values GetRandomValue()
        {
            Card randomCard = cards.Peek(random.Next(cards.Count)); //隨機選一個card
            return randomCard.Value;
        }

        internal void AskForACard()
        {
            throw new NotImplementedException();
        }

        public Deck DoYouHaveAny(Values value)
        {
            Deck cardsIHave = cards.PullOutValues(value);
            textBoxOnForm.Text += Name + "已經有" + cardsIHave.Count + " " + Card.Plural(value) + Environment.NewLine;

            return cardsIHave;
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock)
        {
            Values randomValue = GetRandomValue();
            AskForACard(players, myIndex,stock, randomValue);
        }

        public void AskForACard(List<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += Name + "問 : 有沒有人有" + value + Environment.NewLine;

            int totalCardsGiven = 0;
            for (int i = 0; i < players.Count; i++)
            {
                if (i !=  myIndex)
                {
                    Player player = players[i];
                    Deck CardsGiven = player.DoYouHaveAny(value);
                    totalCardsGiven += CardsGiven.Count;
                    while (CardsGiven.Count >0)
                    {
                        cards.Add(CardsGiven.Deal()); //CardsGiven.Deal()假使沒有傳入任何參數，就回傳Deck的第一張
                    }
                }
            }
            if (totalCardsGiven == 0)
            {
                textBoxOnForm.Text += Name + "須由牌堆抽牌" + Environment.NewLine;
                cards.Add(stock.Deal());
            }
        }

        public int CardCount { get { return cards.Count; } } //回傳自己的手牌數

        public void TakeCard(Card card)
        {
            cards.Add(card);
        }

        public IEnumerable<string> GetCardNames() { return cards.GetCardNames(); }

        public Card Peek(int cardNumber) { return cards.Peek(cardNumber); }

        public void SortHand() { cards.SortByValue(); } //手牌順一下值

    }
}
