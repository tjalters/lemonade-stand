using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Anytimers : Customers
    {


        public Anytimers()
        {

        }
        public override void CheckIfWillBuy(Player player, double demandLevel)
        {
            if (demandLevel >= 1)
            {
                willBuy = true;
                BuyCup(player);
            }
            else willBuy = false;
        }
    }
}
