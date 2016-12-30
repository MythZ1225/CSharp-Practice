using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinnerParty
{
    class DinnerParty
    {
        private int     NumOfPpl;
        public  decimal DrinkPricePerPerson;
        public  decimal CostOfCostume;
        public  decimal CostOfCostumeBase;
        public  decimal CostOfDrinkCost;
        public  decimal CostOfFoodCost;
        public  decimal CostOfHealthDiscount;
        const   int     CostOFFoodPerson = 25;

        public void SetPartyOptions(int ppl)
        {
            NumOfPpl = ppl;
            //CaculateCostumeCost(fancy);
        }

        public int GetNumberOfPpl()
        {
            return NumOfPpl;
        }

        public void SetHealthOption(bool healthOption)
        {
            if (healthOption == true)
            {
                DrinkPricePerPerson = 5.00M;
            }
            else DrinkPricePerPerson = 20.00M;
        }

        public decimal CostumeBaseCost(bool fancy) // 服裝基礎費用
        {
            if (NumOfPpl == 0)
            {
                CostOfCostumeBase = 0M ; 
            }
            else
            {
                if (fancy)
                {
                    CostOfCostumeBase = 50M ;
                }
                else
                {
                    CostOfCostumeBase = 30M ;
                }
            }

            return CostOfCostumeBase ;
        }

        public decimal CostumeCost(bool fancy) // 服裝每人費用總計
        {
            if (fancy)
            {
                CostOfCostume = 15M * NumOfPpl;
            }
            else
            {
                CostOfCostume = 7.5M * NumOfPpl;
            }
            return CostOfCostume;
        }

        public decimal CaculateDrinkCost(bool healthyDiscount) // 飲料每人費用總計
        {
            CostOfDrinkCost = DrinkPricePerPerson * NumOfPpl;

            return CostOfDrinkCost;
        }

        public decimal CaculateFoodCost(int ppl) // 食物每人費用總計
        {
            ppl = NumOfPpl;
            CostOfFoodCost = CostOFFoodPerson * ppl;
            return CostOfFoodCost;
        }

        public decimal HealthDiscount(bool healthyDiscount)// 健康折扣
        {
            decimal totalCost = CostOfFoodCost+ CostOfDrinkCost + CostOfCostumeBase + CostOfCostume;
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
