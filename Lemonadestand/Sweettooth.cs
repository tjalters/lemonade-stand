using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class SweetTooth : Customers
    {
        public SweetTooth()
        {

        }
        public void BuyInstanceOneSweetTooth()
        {
            if (amountCupsSugarPerPitcher > 4 && pricePerCup <=35)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void BuyInstanceTwoSweetTooth()
        {
            if (demandLevel > 50 && pricePerCup <= 25)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void BuyInstanceThreeSweetTooth()
        {
            if (realTemperature > 75)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void BuyInstanceFourSweetTooth()
        {
            if (pricePerCup <= 25)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void BuyInstanceFiveSweeth()
        {
            if (amountCupsSugarPerPitcher > 5 && pricePerCup < 60)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
    
    }
}
