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
        public Store store;
        public int storedLemons;
        private int number;
        public int amountLemonsPerPitcher;

        List<Lemon> lemon;
        List<Cups> cups;
        List<Sugar> sugar;
        List<Ice> ice;



        public Inventory()
        {
            ingredients = new Ingredients();
            //store = new Store();
            

            lemon = new List<Lemon>();
            cups = new List<Cups>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            //create list of each ingredient
            //to get recipe = player.inventory.ingredients
            //create list that stores each ingredient
            //Display- Ex: "you have 50 lemons, 45 cups of sugar, and 30 cups left"

            //List<Lemon> lemon = new List<Lemon>();
            //lemon.Add(0);
            //lemon.Remove(0);

            //foreach (int number in numbers)
            //{
              // Console.WriteLine(number);
            //}

        }

        //public double TotalLemonsInInventory(int storedLemons, int numberOfLemons)
        //{
            //lemons = storedLemons;
            //addedLemons = numberofLemons;
            //result = lemons + addedLemons;
            //return result;

        //}

        
        public void AddLemonsToInventory(int numberOfLemons)
        {
            for (int i = 0; i < numberOfLemons; i++)
            {
                List<Lemon> lemon = new List<Lemon>();
               
            }
        }
        public void AddCupsToInventory()
        {

        }
        public void AddCupsSugarToInventory()
        {

        }
        public void AddIceToInventory()
        {

        }
        public void RemoveLemonsFromInventory()
        {

        }
        public void RemoveCupsFromInventory()
        {

        }
        public void AddLemonsToPitcher()
        {
            Console.WriteLine("How many lemons would you like to put in each pitcher? You must use at least 2 lemons and you can not use more than 6 lemons.");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 2:
                    Console.WriteLine("Selected 2 lemons.");
                    amountLemonsPerPitcher = 2;
                    break;
                case 3:
                    Console.WriteLine("Selected 3 lemons.");
                    amountLemonsPerPitcher = 3;
                    break;
                case 4:
                    Console.WriteLine("Selected 4 lemons.");
                    amountLemonsPerPitcher = 4;
                    break;
                case 5:
                    Console.WriteLine("Selected 5 lemons.");
                    amountLemonsPerPitcher = 5;
                    break;
                case 6:
                    Console.WriteLine("Selected 6 lemons.");
                    amountLemonsPerPitcher = 6;
                    break;
                default:
                    Console.WriteLine("Not a valid entry");
                    break;


            }
            

            //int amountLemons = int.Parse(Console.ReadLine());
        }

    }
}
