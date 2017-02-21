using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Cups : Ingredients
    {


        public Cups()
        {

        }

        public override void PurchaseIngredient()
        {
            base.PurchaseIngredient();
            Console.WriteLine("How many plastic cups do you want to buy? Type 0 to purchase none, 1 to purchase 30 for $1, 2 to purchase 60 for $2, 3 to purchase 100 for $3, or 4 to purhase 150 for $4.");
            choice = int.Parse(Console.ReadLine());


            switch (choice)
            {
                case 0:
                    Console.WriteLine("Selected 0 cups for $0");
                    amountOfIngredient = "0 cups";
                    break;
                case 1:
                    Console.WriteLine("selected 30 cups for $1");
                    amountOfIngredient = "30 cups";
                    break;
                case 2:
                    Console.WriteLine("selected 60 cups for $2");
                    amountOfIngredient = "60 cups";
                    break;
                case 3:
                    Console.WriteLine("selected 100 cups for $3");
                    amountOfIngredient = "100 cups";
                    break;
                case 4:
                    Console.WriteLine("selected 150 cups for $4");
                    amountOfIngredient = "150 cups";
                    break;
                default:
                    Console.WriteLine("Not a valid choice.");
                    break;
            }
         }
      }
}
