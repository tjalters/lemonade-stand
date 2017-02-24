using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Healthy : Customers
    {

        public Healthy()
        {

        }
       
        public override void CheckIfWillBuy(Player player, double demandLevel)
        {
            if (amountCupsSugarPerPitcher <= 3 && demandLevel >= 30 && pricePerCup <= 40 && realTemperature > 90)
            {
                willBuy = true;
                BuyCup(player);
            }
            else willBuy = false;
        }
    }
}
