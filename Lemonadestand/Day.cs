using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Day
    {
        public Customers customers;
        public Weather weather;
        //public List<string> myList;
        public int day = 1;
        public string forcast;
        public int currentDay;
        public string randomForecast;
        public int randomWeather;
        public int randomTemperature;
      

        public Day()
        {
            customers = new Customers();
            weather = new Weather();
            //myList = new List<string>();
        }
        public void DisplayDay()
        {
            Console.WriteLine("Day {0}", day++);
        }

        public void DisplayRandomDailyForcast()
        {
            //List<string> myList = new List<string> { "sunny", "cloudy", "rainy", "storming" };

            //foreach (string forcast in myList.Randomize(myList))
            //{
            //Console.WriteLine("Today's forecast is" +myList);
            //}
            //base.DisplayRandomDailyForecast();
            //Random random = new Random(forecast);
            //forecast = random.Next(0, 5);
            //Console.WriteLine($"Computer chose {forecast}");
            Random dailyForecast = new Random();
            int assignRandomForecast = dailyForecast.Next(1, 4);
            if (randomWeather == 1)
            {
                this.randomForecast = "sunny";
            }
            else if (assignRandomForecast == 2)
            {
                this.randomForecast = "cloudy";
            }
            else if (assignRandomForecast == 3)
            {
                this.randomForecast = "rainy";
            }
            else
            {
                this.randomForecast = "storming";
            }
            Random getRandomTemp = new Random();
            this.randomTemperature = getRandomTemp.Next(60, 100);
            Console.WriteLine("The forecast is" + this.randomForecast);
            Console.WriteLine("The estimated temperature for today is" + this.randomTemperature);
        }
    }
}
