using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Ingredients
    {
        public Lemons lemons;
        public Cups cups;
        public Sugar sugar;
        public Ice ice;

        public int choice;
        public string amountOfIngredient;




        public Ingredients()
        {
            lemons = new Lemons();
            cups = new Cups();
            sugar = new Sugar();
            ice = new Ice();
        }

        public virtual void PurchaseIngredient()
        {

        }

        public void GetIngredients()
        {
            Console.WriteLine("Now it is time to select how much you want to spend on each ingredient.");
        }
    }
}
