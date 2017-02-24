using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Customers
    {
        public double demandLevel;
        public int amountOfIceCubesPerPitcher;
        public int amountCupsSugarPerPitcher;
        public string purchase;
        public bool willBuy;
        public int pricePerCup;
        public string realForecast;
        public double realTemperature;


        public Customers()
        {
            //can I use
        } 
       
            //public bool AthletesBuy(int dailyDemand)
            // {
            //if ice cubes in pitcher >= 30, then athletes buy
            //if dailyDemand >45, then athletes buy
            //if dailyDemand =<45, then athletes don't buy
            //if price =<25 cents, then athletes buy
            //if(public int amountOfIceCubesPerPitcher >= 30);
            //}
        public void BuyCup(Player player)
        {
            player.wallet.balance += pricePerCup;
            player.inventory.cups.RemoveAt(0);
        }
        public virtual void CheckIfWillBuy(Player player, double demandLevel)
        {

        }



        //create "class Anyimers" = buys 100% anytime
    }   //create "class athletes" = will buy 100% if 30 ice cubes or more // temp * (sunny factor, cloudy factor, rainy factor, storming factor) = daily demand or "did these customers from this pool buy?" true or false == total number of customers in this pool
        //create "class healthy"                                                                                                                  //if daily demand level > 45 customers from this pool will buy
}
