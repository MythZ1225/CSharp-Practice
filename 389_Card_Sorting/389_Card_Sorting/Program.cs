using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _389_Card_Sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Card> cards = new List<Card>();
            Random random = new Random();
            Card card1 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            Card card2 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            Card card3 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            Card card4 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            Card card5 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            Card card6 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            Card card7 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            Card card8 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            Card card9 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));
            Card card10 = new Card((Suits)random.Next(4), (Values)random.Next(1, 14));

            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);
            cards.Add(card6);
            cards.Add(card7);
            cards.Add(card8);
            cards.Add(card9);
            cards.Add(card10);

            CardComparer cardComparer = new CardComparer();

            PrintCards(cards);
            Console.ReadKey();

            cards.Sort(cardComparer);
            PrintCards(cards);
            Console.ReadKey();

            cardComparer.sorttype = SortType.ValueThanSuit;
            cards.Sort(cardComparer);
            PrintCards(cards);
            Console.ReadKey();


        }

        public static void PrintCards(List<Card> cards)
        {

            foreach (Card card in cards)
            {
                Console.WriteLine(card.CardName);
            }
            Console.WriteLine("\n");
        }
    }
}
