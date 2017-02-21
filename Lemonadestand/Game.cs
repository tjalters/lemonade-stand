using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Game
    {



        public Game()
        {

        }
        public void RunGame()
        {
            DisplayWelcome();
            DisplayRules();
        }
        public void DisplayWelcome()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
        }
        public void DisplayRules()
        {
            Console.WriteLine("You have 7 days to make as much money as possible and your only option is to open a lemonade stand.");
            Console.WriteLine("You get to control how you want to make your lemonade and how much you want to charge per cup.");
            Console.WriteLine("You will have the option to change the price per cup and/or the lemonade recipe each day.");
            Console.WriteLine("You will start out with $20 and make sure you have enough ingredients at the beginning of each day so that you don't run out!");
        }
    }
}
