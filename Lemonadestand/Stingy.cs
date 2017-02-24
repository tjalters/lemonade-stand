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
        public void buyInstanceOneStingy()
        {
            if (realTemperature >85)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void buyInstanceTwoStingy()
        {
            if (demandLevel >= 65)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void buyInstanceThreeStingy()
        {
            if (realForecast == "sunny" && realTemperature > 85)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void buyInstanceFourStingy()
        {
            if (pricePerCup < 25)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        
    }
}
