using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Day
    {
        public List<Customers> customers;
        public Weather weather;
        public int day = 1;
        public string forcast;
        public int currentDay;
        public string randomForecast;
        public int randomWeather;
        public int realWeather;
        public int randomTemperature;
        public double demandLevel;
        public double temperature;
        public string weatherFactor;
        public double sunnyFactor = 1.0;
        public double realTemperature;
        public string realForecast;

      

        public Day()
        {
            customers = new List<Customers>();
            weather = new Weather();
            //myList = new List<string>();
        }
        public void DisplayDay()
        {
            Console.WriteLine("Day {0}", day++);
        }

        public void DisplayRandomDailyWeather()
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
            Console.WriteLine("The estimated forecast is " + this.randomForecast + "with an estimated temperature of " +this.randomTemperature);
            //Console.WriteLine("The estimated temperature for today is" + this.randomTemperature);
        }
        public void DisplayRealDailyWeather()
        {
            Random realForecast = new Random();
            int assignRealForecast = realForecast.Next(1, 4);
            if (realWeather == 1)
            {
                this.realForecast = "sunny";
            }
            else if (assignRealForecast == 2)
            {
                this.realForecast = "cloudy";
            }
            else if (assignRealForecast == 3)
            {
                this.realForecast = "rainy";
            }
            else
            {
                this.realForecast = "storming";
            }
            Random getRealTemperature = new Random();
            this.realTemperature = getRealTemperature.Next(60, 100);
            Console.WriteLine("The forecast is " + this.realForecast + "with a temperature of " + this.realTemperature);
        }
        public void DisplayInventoryEndOfDay()
        {
            //lemons in inventory before day - lemons in inventory after day = new lemons inventory number
            //number of cups sold/10 
            //pitchers used for day * lemons per pitcher
            //pitchers used for day * cups of sugar per pitcher
            //cups leftover from day keep in inventory
            //ice leftover from day == 0 ice
        }
        public void DisplayCupsSoldForDay()
        {

        }
        public void DisplayNetProfitForDay()
        {
            //cups sold * price per cup
        }
        public void DisplayRemainingBalance()
        {

        }
        public void GenerateCustomers()
        {
            GenerateHealthyCustomers();

        }
        public void GenerateHealthyCustomers()
        {
            for(int i = 0; i == 10; i++)
            {
                Healthy healthy = new Healthy();
                customers.Add(healthy);
            }
        }
        public void GenerateAthleteCustomers()
        {
            for(int i = 0; i == 10; i++)
            {
                Athletes athletes = new Athletes();
                customers.Add(athletes);
            }
        }
        public void GenerateAnytimerCustomers()
        {
            for(int i = 0; i == 10; i++)
            {
                Anytimers anytimers = new Anytimers();
                customers.Add(anytimers);
            }
        }
        public void GenerateSweetToothCustomers()
        {
            for(int i = 0; i == 10; i++)
            {
                SweetTooth sweetTooth = new SweetTooth();
                customers.Add(sweetTooth);
            }
        }
        public void GenerateSunnyCustomers()
        {
            for(int i = 0; i == 10; i++)
            {
                SunnyCustomer sunnyCustomer = new SunnyCustomer();
                customers.Add(sunnyCustomer);
            }
        }
        public void GenerateStingyCustomers()
        {
            for(int i = 0; i == 10; i++)
            {
                Stingy stingy = new Stingy();
                customers.Add(stingy);
            }
        }
        public void DetermineCustomerBuy(Player player)
        {
            foreach(Customers customer in customers)
            {
                customer.CheckIfWillBuy(player, weather.demandLevel);
            }
        }
        public void RunLemonadeStand()
        {

        }
    }
}
