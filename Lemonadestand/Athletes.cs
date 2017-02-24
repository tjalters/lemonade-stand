using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Athletes : Customers
    {
        public Athletes()
        {

        }
        public void BuyInstanceOneAthlete()
        {
            if (amountOfIceCubesPerPitcher >= 30)
            {
                willBuy = true;
            }
            else willBuy = false; //(amountOfIceCubesPerPitcher < 30)
        }
        public void BuyInstanceTwoAthlete()
        {
            if (demandLevel > 45)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void BuyInstanceThreeAthlete()
        {
            if (pricePerCup <= 30)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void BuyInstanceFourAthlete()
        {
            if (realForecast == "sunny" && pricePerCup <= 30)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
               // willBuy = false;
            //}
       
        //public bool AthletesBuy(int dailyDemand)
       // {
            //if ice cubes in pitcher >= 30, then athletes buy
            //if dailyDemand >45, then athletes buy
            //if dailyDemand =<45, then athletes don't buy
            //if price =<25 cents, then athletes buy
            //if(public int amountOfIceCubesPerPitcher >= 30);
        //}
    }
}
