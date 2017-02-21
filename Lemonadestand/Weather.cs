using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Weather
    {
        public double temperature;
        public string precipitation;
        public double sunnyFactor = 1.3;
        public double rainFactor = 0.5;
        public double stormFactor = 0.2;
        public double dailyDemand;

        public Weather()
        {
            Random oneInstance = new Random();
            this.temperature = oneInstance.Next(60, 100);
        }
    }
}
