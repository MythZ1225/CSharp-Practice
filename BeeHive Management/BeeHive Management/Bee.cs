using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeeHive_Management
{
    public class Bee
    {
        public Bee(double weight)
        {
            this.weight = weight;
        }
        private double weight;

        public virtual int ShiftLeft
        {
            get { return 0; }
        }

        public virtual double GetHoneyConsuption()
        {
            double HoneyConsuption;
            if (ShiftLeft ==0)
            {
                HoneyConsuption = 7.5;
            }
            else
            {
                HoneyConsuption = ShiftLeft + 9;
            }
            if (weight>150)
            {
                HoneyConsuption *= 1.35;    
            }

            return HoneyConsuption;
        }

    }
}
