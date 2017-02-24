using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class SunnyCustomer : Customers
    {

        public SunnyCustomer()
        {

        }
        public override void CheckIfWillBuy(Player player, double demandLevel)
        {
            if (realForecast == "Sunny" && pricePerCup <= 45 || realTemperature > 85 && pricePerCup <= 25 || demandLevel >= 55 && realForecast == "sunny") 
            {
                willBuy = true;
                BuyCup(player);
            } 
            else willBuy = false;
        }
        
    }
}
