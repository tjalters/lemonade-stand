using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Inventory
    {
        public Ingredients ingredients;

        List<Lemon> lemon;
        List<Cups> cups;
        List<Sugar> sugar;
        List<Ice> ice;



        public Inventory()
        {
            ingredients = new Ingredients();

            lemon = new List<Lemon>();
            cups = new List<Cups>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            //create list of each ingredient
            //to get recipe = player.inventory.ingredients
            //create list that stores each ingredient

            List<int> lemons = new List<int>() { 0, 10, 25, 50, 80 };

            foreach (int number in lemons)
            {
                Console.WriteLine(number + " lemons selected");
            }

        }
    }
}
