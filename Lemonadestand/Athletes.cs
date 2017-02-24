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
        public override void CheckIfWillBuy(Player player, double demandLevel)
        {
            if (amountOfIceCubesPerPitcher >= 30 || demandLevel > 45 && pricePerCup <= 30 || realForecast == "sunny" && pricePerCup <= 35)
            {
                willBuy = true;
                BuyCup(player);
            }
            else willBuy = false; //(amountOfIceCubesPerPitcher < 30)
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
