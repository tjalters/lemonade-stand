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
        public void BuyInstanceOneHealthy()
        {
            if (amountCupsSugarPerPitcher < 3)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void BuyInstanceTwoHealthy()
        {
            if (amountCupsSugarPerPitcher <= 3 && demandLevel >= 30 && pricePerCup <= 40)
            {
                willBuy = true;
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
