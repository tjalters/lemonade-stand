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
        public void buyInstanceOneAnytimers()
        {
            if (demandLevel >= 1)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
    }
}
