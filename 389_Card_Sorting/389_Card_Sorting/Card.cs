using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _389_Card_Sorting
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
        public Suits suit{get;set;}
        public Values value { get; set; }

        public Random random = new Random();

        public Card(Suits suit, Values value)
        {
            this.suit = suit;
            this.value = value;
        }
        public string CardName
        {
           get { return suit.ToString() + value.ToString(); }
        }

        public override string ToString()
        {
            return CardName;
        }
    }
}
