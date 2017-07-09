using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404_FishGame_Dictionary
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>(); //Deck 是Card的 List
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

        public Card Deal(int index)         //交換輸入的卡索引號的卡
        {
            Card CardToDeal = cards[index]; //要交換的卡的索引號
            cards.RemoveAt(index);          //移除該卡
            return CardToDeal;              // 返回該卡
        }

        public Card Deal() //假使沒有傳入任何參數，就回傳第一張
        {
            return Deal(0); 
        }

        public void Shuffle()            //洗牌後返回隨機順序
        {

            List<Card> NewCards = new List<Card>();
            while (cards.Count >0)
            {
                int CardToMove = random.Next(cards.Count);  //紀錄要移動的卡片隨機索引值
                NewCards.Add(cards[CardToMove]);            //建立新卡並加入cards的該隨機索引值卡片
                cards.RemoveAt(CardToMove);                 //把卡片由cards移除
            }                                               //直到卡片數量為0
            cards = NewCards;                               //再用NewCards 取代 cards Deck
        }

        public IEnumerable<string> GetCardNames()
        {
            //返回 包含卡片名的 字串 Array
            string[] CardNames = new string[cards.Count];   //先建立容器
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

        public Card Peek(int cardNum)
        {
            return cards[cardNum];
        }



        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards) 
            {
                if (card.Value == value)
                {
                    return true;
                }                
            }
            return false;
        }

        public Deck PullOutValues(Values value)
        {
            Deck deckToReturn = new Deck(new Card[] { });

            for (int i = cards.Count-1; i >=0; i--)
            {
                if (cards[i].Value == value)
                {
                    deckToReturn.Add(Deal(i));
                }
            }
            return deckToReturn;
        }

        public bool HasBook(Values value)   //檢查是否有一整套牌
        {
            int NumOfCards = 0; //計分初始化
            foreach (Card card in cards)
            {
                if (card.Value == value)
                {
                    NumOfCards++;   //每個配對牌 +1點
                }
            }
            if (NumOfCards == 4)    //有4張則回傳True
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void SortByValue()
        {
            cards.Sort(new CardComparer_ByValue()); //呼叫CardComparer_ByValue 幫忙排序
        }


    }
}
