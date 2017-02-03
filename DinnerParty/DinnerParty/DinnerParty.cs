using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty : Party
    {
        public  decimal DrinkPricePerPerson;
        public  decimal CostOfDrinkCost;
        public  decimal CostOfHealthDiscount;

        public DinnerParty(int ppl, bool fancy ) :base(int Num)

        public override int SetPartyOptions 
        {
            get { return NumOfPpl; }
            set
            {
                NumOfPpl = value;
            }

        }


        public decimal CaculateDrinkCost(bool healthyDiscount) // 飲料每人費用總計
        {
            
            CostOfDrinkCost = DrinkPricePerPerson * NumOfPpl;

            return CostOfDrinkCost;
        }
        
        public void SetHealthOption(bool healthOption)
        {
            if (healthOption == true)
            {
                DrinkPricePerPerson = 5.00M;
            }
            else DrinkPricePerPerson = 20.00M;
        }
     
        public decimal HealthDiscount(bool healthyDiscount)// 健康折扣
        {
           
            if (NumOfPpl == 0)
            {
                return CostOfHealthDiscount = 0; 
            }
            else
            {
                if (healthyDiscount)
                {
                    return totalCost * -0.05M;
                }
                else
                {
                    return CostOfHealthDiscount = 0;
                }
                
            }  


        }

    }
}
