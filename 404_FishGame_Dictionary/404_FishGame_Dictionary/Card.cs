using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _404_FishGame_Dictionary
{

        enum Suits {
            黑桃,
            梅花,
            紅心,
            鑽石,
        }

        enum Values {
            Ace = 1,
            Two = 2,
            Three = 3,
            Four = 4,
            Five = 5,
            Six = 6,
            Seven = 7,
            Eight = 8,
            Nine = 9,
            Ten = 10,
            J = 11,
            Q = 12,
            K = 13,
        }

    class Card
    {
        public Suits Suit { get; set; } 
        public Values Value { get; set; }

        public Card(Suits Suit, Values Value)
        {
            this.Suit = Suit;
            this.Value = Value;
        }

        public string Name
        {
            get { return Suit.ToString() + Value.ToString(); }
        }

        public static bool DoesCardMatch(Card cardToCheck, Values value)
        {
            if (cardToCheck.Value == value)
                return true;
            else
                return false;
        }

        public static bool DoesCardMatch(Card cardToCheck, Suits suit)
        {
            if (cardToCheck.Suit == suit)
                return true;
            else
                return false;
        }

        internal static bool DoesCardMatch()
        {
            throw new NotImplementedException();
        }

        public static string Plural(Values value)
        {
            if (value == Values.Six)
                return "一對六";
            else
                return value.ToString() + "對";
        }
    }
}
