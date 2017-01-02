using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerAndTheCow
{
    class Farmer
    {
        private         decimal numberOfCows;
        private         decimal feedMutiplier;
        //public const    decimal FeedMutiplier = 30; //每頭牛30袋飼料
        //public          decimal BagsOfFeed;

        public decimal FeedMutiplier
        { get
            {
                return feedMutiplier;
            }
            private set
            {
                feedMutiplier = value;
            }
        }
        public decimal BagsOfFeed    { get; private set; }

        public Farmer(decimal numberOfCows, decimal feedMutiplier)
        {
            this.feedMutiplier = feedMutiplier;
            NumberOfCows = numberOfCows;
        }

        public decimal GetNumberOfCows() //獲取牛的數目
        {
            return numberOfCows;
        }

        public void SetNumberOfCows(decimal newNumberOfCows)
        {
            numberOfCows    = newNumberOfCows;
            BagsOfFeed      = numberOfCows * FeedMutiplier;
        }

        public decimal NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows    = value;
                BagsOfFeed      = numberOfCows * FeedMutiplier;
            }
        }

        

    }
}
