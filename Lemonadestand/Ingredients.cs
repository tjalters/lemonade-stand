using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Ingredients
    {
        public Lemon lemons;
        public Cups cups;
        public Sugar sugar;
        public Ice ice;

        public int choice;
        public int numberOfLemons;
      




        public Ingredients()
        {
            //lemons = new Lemons();
            //cups = new Cups();
            //sugar = new Sugar();
            //ice = new Ice();
        }

        //public virtual void PurchaseIngredient()
        //{

        //}

        public void GetIngredients()
        {
            Console.WriteLine("Now it is time to select how much you want to spend on each ingredient.");
        }
        public void AddLemonsToPitcher()
        {
            Console.WriteLine("How many lemons would you like to put in each pitcher today?");
        }
       // int lemonsAdded = int.Parse(Console.ReadLine());
    }
}
