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
        public void BuyInstanceOneSunny()
        {
            if (realForecast == "Sunny" && pricePerCup <= 45)
            {
                willBuy = true;
            }
            else willBuy = false;

        }
        public void BuyInstanceTwoSunny()
        {
            if (realTemperature > 85 && pricePerCup <= 25)
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        public void BuyInstanceThreeSunny()
        {
            if (demandLevel >= 55 && realForecast == "sunny" || realForecast == "cloudy")
            {
                willBuy = true;
            }
            else willBuy = false;
        }
        
    }
}
