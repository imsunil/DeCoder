using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Party_Estimator
{
    class DinnerParty
    {
        public int NumberOfPeople;
        public bool HealthyOption;
        public bool FancyDecorations;

        public decimal CostOfDecoration;
        public decimal CostOfDrinks;
        //public decimal CostOfFood;
        public decimal DiscountMultiplier = 1;
        public decimal Fees = 0M;


        public const int CostOfFood = 25;
        
        public const int CostOfNonAlcoholicDrinks = 5;
        public const int CostOfAlcoholicDrinks = 20; 
        
        public const decimal CostOfFancyDecoration = 15;
        public const decimal CostOfNotFancyDecoration = 7.50M;
        
        public const decimal HealthyOptionDiscount = 0.95M;
        public const decimal NoHealthyOptionDiscount = 1.00M;

        public const int FeeOfFancyDecoration = 50;
        public const int FeeOfNotFancyDecoration = 30;


        public void SetHealthyOption(bool p)
        {
            HealthyOption = p;
            if(HealthyOption)
            {
                CostOfDrinks = CostOfNonAlcoholicDrinks;
                DiscountMultiplier = HealthyOptionDiscount;
            }
            else
            {
                CostOfDrinks = CostOfAlcoholicDrinks;
                DiscountMultiplier = NoHealthyOptionDiscount;
            }
        }

        public void CalculateCostOfDecorations(bool p)
        {
            throw new NotImplementedException();
        }



       public void SetDecorationType(bool p)
        {
            FancyDecorations = p;
            
           if (FancyDecorations)
           {
               CostOfDecoration = CostOfFancyDecoration;
               Fees = FeeOfFancyDecoration;
            }
            else
            {
                CostOfDecoration = CostOfNotFancyDecoration;
                Fees = FeeOfNotFancyDecoration;
            }
        }

       public decimal CalculateCosts()
       {
           return (((NumberOfPeople*(CostOfFood + CostOfDrinks + CostOfDecoration)) + Fees)*DiscountMultiplier);
       }
    }
}
