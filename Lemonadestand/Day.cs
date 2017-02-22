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
        public List<string> myList;
        public int day = 1;
        public string forcast;
      

        public Day()
        {
            customers = new Customers();
            weather = new Weather();
            myList = new List<string>();
        }
        public void DisplayDay()
        {
            Console.WriteLine("Day {0}", day++);
        }

        public void DisplayRandomDailyForcast()
        {
            List<string> myList = new List<string> { "sunny", "cloudy", "rainy", "storming" };

            foreach (string forcast in myList.Randomize(myList))
            {
                Console.WriteLine("Today's forecast is" +myList);
            }
        }
    }
}
