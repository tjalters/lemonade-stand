using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Store
    {
        public Inventory inventory;
        private int number;
        public int numberOfLemons;
        public int numberOfCups;
        public int cupsOfSugar;
        public int iceCubes;
        public int lemons;
        public int cups;
        public int sugar;
        public int ice;
        public int lemonsAddedToInventory;
        public Store()
        {
            
        }
        //public int getNumberOfLemons()
        //{
          //  Console.WriteLine("How many lemons?");

            //int lemonsAmount = int.Parse(Console.ReadLine());

            //if (Player.Wallet.amount > 0)

              //  return lemonsAmount;
        //}

       
        public void BuyLemons()
        {
            Console.WriteLine("How many lemons do you want to buy? Type 0 to purchase none, 1 to purchase 10 for $1, 2 to purchase 25 for $2, 3 to purchase 50 for $3, or 4 to purhase 80 for $4.");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("Selected 0 lemons for $0");
                    numberOfLemons = 0;
                    break;
                case 1:
                    Console.WriteLine("selected 10 lemons for $1");
                    numberOfLemons = 10;
                    break;
                case 2:
                    Console.WriteLine("selected 25 lemons for $2");
                    numberOfLemons = 25;
                    break;
                case 3:
                    Console.WriteLine("selected 50 lemons for $3");
                    numberOfLemons = 50;
                    break;
                case 4:
                    Console.WriteLine("selected 80 lemons for $4");
                    numberOfLemons = 80;
                    break;
                default:
                    Console.WriteLine("Not a valid choice.");
                    break;

            }
        }
        public void BuyCups()
        {
            Console.WriteLine("How many cups do you want to buy? Type 0 to purchase none, 1 to purchase 30 for $1, 2 to purchase 60 for $2, 3 to purchase 100 for $3, or 4 to purhase 150 for $4.");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("Selected 0 cups for $0");
                    numberOfCups = 0;
                    break;
                case 1:
                    Console.WriteLine("selected 30 cups for $1");
                    numberOfCups = 30;
                    break;
                case 2:
                    Console.WriteLine("selected 60 cups for $2");
                    numberOfCups = 60;
                    break;
                case 3:
                    Console.WriteLine("selected 100 cups for $3");
                    numberOfCups = 100;
                    break;
                case 4:
                    Console.WriteLine("selected 150 cups for $4");
                    numberOfCups = 150;
                    break;
                default:
                    Console.WriteLine("Not a valid choice.");
                    break;

            }
        }                
        public void BuySugar()
        {
            Console.WriteLine("How many cups of sugar do you want to buy? Type 0 to purchase none, 1 to purchase 15 for $1, 2 to purchase 30 for $2, 3 to purchase 50 for $3, or 4 to purhase 75 for $4.");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("Selected 0 cups of sugar for $0");
                    cupsOfSugar = 0;
                    break;
                case 1:
                    Console.WriteLine("selected 15 cups of sugar for $1");
                    cupsOfSugar = 15;
                    break;
                case 2:
                    Console.WriteLine("selected 30 cups of sugar $2");
                    cupsOfSugar = 30;
                    break;
                case 3:
                    Console.WriteLine("selected 50 cups of sugar for $3");
                    cupsOfSugar = 50;
                    break;
                case 4:
                    Console.WriteLine("selected 75 cups of sugar for $4");
                    cupsOfSugar = 75;
                    break;
                default:
                    Console.WriteLine("Not a valid choice.");
                    break;

            }
        }                                                          
        public void BuyIce()
        {
            Console.WriteLine("How many ice cubes do you want to buy? Type 0 to purchase none, 1 to purchase 100 for $1, 2 to purchase 200 for $2, 3 to purchase 300 for $3, or 4 to purhase 400 for $4.");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 0:
                    Console.WriteLine("Selected 0 ice cubes for $0");
                    iceCubes = 0;
                    break;
                case 1:
                    Console.WriteLine("selected 100 ice cubes for $1");
                    iceCubes = 100;
                    break;
                case 2:
                    Console.WriteLine("selected 200 ice cubes for $2");
                    iceCubes = 200;
                    break;
                case 3:
                    Console.WriteLine("selected 300 ice cubes for $3");
                    iceCubes = 300;
                    break;
                case 4:
                    Console.WriteLine("selected 400 ice cubes for $4");
                    iceCubes = 400;
                    break;
                default:
                    Console.WriteLine("Not a valid choice.");
                    break;

            }
        }
    }
}
