using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Party_Estimator
{
    class DinnerParty
    {
        private int NumberOfPeople;
        private bool HealthyOption;
        private bool FancyDecorations;

        private decimal CostOfDecoration;
        private decimal CostOfDrinks;
        //public decimal CostOfFood;
        private decimal DiscountMultiplier = 1;
        private decimal Fees = 0M;


        private const int CostOfFood = 25;

        private const int CostOfNonAlcoholicDrinks = 5;
        private const int CostOfAlcoholicDrinks = 20;

        private const decimal CostOfFancyDecoration = 15;
        private const decimal CostOfNotFancyDecoration = 7.50M;

        private const decimal HealthyOptionDiscount = 0.95M;
        public const decimal NoHealthyOptionDiscount = 1.00M;

        private const int FeeOfFancyDecoration = 50;
        private const int FeeOfNotFancyDecoration = 30;
        private int p;

        public DinnerParty(int p)
        {
            // TODO: Complete member initialization
            this.NumberOfPeople = p;
        }


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

      public void SetNumberOfPeople(int p)
       {
           this.NumberOfPeople=p;
       }
    }
}
