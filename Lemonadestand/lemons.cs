using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Lemons : Ingredients
    {


        public Lemons()
        {

        }

        public override void PurchaseIngredient()
        {
            base.PurchaseIngredient();
            Console.WriteLine("How many lemons do you want to buy? Type 0 to purchase none, 1 to purchase 10 for $1, 2 to purchase 25 for $2, 3 to purchase 50 for $3, or 4 to purhase 80 for $4.");
            choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    Console.WriteLine("Selected 0 lemons for $0");
                    amountOfIngredient = "0 lemons";
                    break;
                case 1:
                    Console.WriteLine("selected 10 lemons for $1");
                    //amountOfIngredient = 10;
                    break;
                case 2:
                    Console.WriteLine("selected 25 lemons for $2");
                    amountOfIngredient = "25 lemons";
                    break;
                case 3:
                    Console.WriteLine("selected 50 lemons for $3");
                    amountOfIngredient = "50 lemons";
                    break;
                case 4:
                    Console.WriteLine("selected 80 lemons for $4");
                    amountOfIngredient = "80 lemons";
                    break;
                default:
                    Console.WriteLine("Not a valid choice.");
                    break;
                
            }
        }
    }
}
