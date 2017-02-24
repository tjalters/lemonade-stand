using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Stingy : Customers
    {

        public Stingy()
        {

        }
        public override void CheckIfWillBuy(Player player, double demandLevel)
        {
            if (realTemperature > 85 && pricePerCup < 25 || demandLevel >= 65 && pricePerCup < 25 || pricePerCup <= 15)
            {
                willBuy = true;
                BuyCup(player);
            }
            else willBuy = false;
        }

        
    }
}
