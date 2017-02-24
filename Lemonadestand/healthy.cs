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
        public void BuyInstanceOneHealthy(Player player)
        {
            if (amountCupsSugarPerPitcher < 3)
            {
                willBuy = true;
                BuyCup(player);
            }
            else willBuy = false;
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
        public void BuyInstanceThreeHealthy()
        {
            if (amountCupsSugarPerPitcher <= 4 && realTemperature > 90 && pricePerCup <= 25)
            {
                willBuy = true;
            }
            else willBuy = false;
                
        }
        public void BuyInstanceFourHealthy()
        {
            if (demandLevel >= 60 && pricePerCup <= 30)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
    }
}
