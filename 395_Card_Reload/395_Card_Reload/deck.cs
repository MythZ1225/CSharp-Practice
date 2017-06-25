using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _395_Card_Reload
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();
            for (int suit = 0; suit <= 3; suit++) //增加4個花色
            {
                for (int value = 1; value < 14; value++) //每花色13張牌
                {
                    cards.Add(new Card((Suits)suit, (Values)value)); //加入 cards = new List<Card>()裡
                }
            }
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card cardToAdd)
        {
            cards.Add(cardToAdd);
        }

        public Card Deal(int index)
        {
            Card CardToDeal = cards[index]; //要交換的卡的索引號
            cards.RemoveAt(index); //移除該卡
            return CardToDeal; // 返回該卡
        }

        public void Shuffle()
        {
            //返回隨機順序
            List<Card> NewCards = new List<Card>();
            while (cards.Count >0)
            {
                int CardToMove = random.Next(cards.Count); //紀錄要移動的卡片隨機索引值
                NewCards.Add(cards[CardToMove]);    //建立新卡並加入cards的該隨機索引值卡片
                cards.RemoveAt(CardToMove);         //把卡片由cards移除
            }                                       //直到卡片數量為0
            cards = NewCards;                       //再用NewCards 取代 cards
        }
        public IEnumerable<String> GetCardNames()
        {
            //返回 包含卡片名的 字串 Array
            String[] CardNames = new String[cards.Count];   //先建立容器
            for (int i = 0; i < cards.Count; i++)
            {
                CardNames[i] = cards[i].Name;               //取出每張牌的 Name
            }
            return CardNames;                               //回傳CardNames
        }
        public void Sort()
        {
            cards.Sort(new CardComparer_BySuit());
        }


    }
}
