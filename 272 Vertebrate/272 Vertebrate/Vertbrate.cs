using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _272_Vertebrate
{
    public class Food
    {
    }

    class Vertbrate
    {
        public int NumOfLegs;        
        public virtual void Eat(Food Morsel)
        {
            Swallow(Morsel);
            Digest();
        }
        public void Swallow(Food Morsel) { }
        public void Digest() { }
    }

    class bird : Vertbrate
    {
        public double WingSpan;
        public void fly()
        {
            //code to fly
        }
    }

    class Chameleon : Vertbrate
    {
        public override void Eat(Food Morsel)
        {
            catchWithTongue(Morsel);
            base.Eat(Morsel);
        }
        private void catchWithTongue(Food Morsel ) { }
        
    }


}
