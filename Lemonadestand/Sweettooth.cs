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
        public override void CheckIfWillBuy(Player player, double demandLevel)
        {
            if (amountCupsSugarPerPitcher > 4 && pricePerCup <=35 || demandLevel > 50 && pricePerCup <= 25 || amountCupsSugarPerPitcher > 5 && pricePerCup < 60)
            {
                willBuy = true;
                BuyCup(player);
            }
            else willBuy = false;
        }
        
    
    }
}
