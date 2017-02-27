using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Game
    {
        public Player player;
        public Store store;
        public Day currentDay;
        public Wallet wallet;
        public Customers customers;


        public int numberOfLemons;
        public int number;
        public int numberOfCups;
        public int cupsOfSugar;
        public int iceCubes;
        public int numberOfCupsSugar;
        public int numberOfIceCubes;
        public int amountOfIceCubesPerPitcher;
        public int pricePerCup;
        public decimal pitchersAvailable;


        public Game()
        {
            player = new Player();
            store = new Store();
            currentDay = new Day();

            //wallet = new Wallet();
            //inventory = new Inventory;

            //customers = new Customers();



        }
        public void RunGame()
        {
            DisplayWelcome();
            DisplayRules();
            while (currentDay.day < 8)
            {
                currentDay.DisplayDay();
                currentDay.DisplayRandomDailyWeather();
                GetIngredients();
                AddIngredientsToPitcher();
                player.ChoosePricePerCup();
                currentDay.DisplayRealDailyWeather();
                //currentDay.MakePitcher(inventory);
                MakePitcher();
                GetCustomers();

                // currentDay.DisplayCupsSoldForDay();


                //for loop i < customers.count, i++


                //store amount lemons/sugar/ice cubes in inventory
                //generate customers

                //play lemonade stand for that day
                //display how many cups sold 
                //display money won/lost
                //display how many lemons/sugar left


            }
        }
        public void BuyCupGame()
        {
            for (int i = 0; i < 0; i++)
            {

            }
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
            Console.WriteLine("Each pitcher of lemonade contains 10 cups of lemonade.");
        }
        public void PullFromInventory()
        {
            for (int i = 0; i <= 0; i++)
            {
                player.inventory.lemon.RemoveAt(0);
                player.inventory.sugar.RemoveAt(0);
                player.inventory.ice.RemoveAt(0);
            }


        }
        public void BuyCup(Player player)
        {
            currentDay.customers = new List<Customers>();
            player.wallet.balance += pricePerCup;
            player.inventory.cups.RemoveAt(0);
        }
     
        public void PourPitcher(Player player)
        {
            
        }
   

        public void MakePitcher()
        {
            if (player.inventory.ice.Count >= player.store.iceCubes && player.inventory.lemon.Count >= player.store.numberOfLemons && player.inventory.sugar.Count >= player.store.cupsOfSugar)
            {
                for(int i = 0; i < player.store.iceCubes; i++)
                {
                    player.inventory.ice.RemoveAt(0);
                }
                for(int i = 0; i < player.store.numberOfLemons; i++)
                {
                    player.inventory.lemon.RemoveAt(0);
                }
                for (int i = 0; i < player.store.cupsOfSugar; i++)
                {
                    player.inventory.sugar.RemoveAt(0);
                }
            }


            
            
        }

        public void SellServing()
        {
            pitchersAvailable -= 1;
            player.inventory.cups.RemoveAt(0);
            wallet.balance += player.priceInCents;
        }
        public void GetIngredients()
        {
            GetLemons();
            GetCups();
            GetSugar();
            GetIce();
        }
        public void GetLemons()
        {
            store.BuyLemons();
            player.PurchaseLemons(store);
            player.DisplayRemainingBalanceWallet();
            player.inventory.AddLemonsToInventory(numberOfLemons);
        }
        public void GetCups()
        {
            store.BuyCups();
            player.PurchaseCups(store);
            player.DisplayRemainingBalanceWallet();
            player.inventory.AddCupsToInventory(numberOfCups);
        }
        public void GetSugar()
        {
            store.BuySugar();
            player.PurchaseSugar(store);
            player.DisplayRemainingBalanceWallet();
            player.inventory.AddCupsSugarToInventory(cupsOfSugar);
        }
        public void GetIce()
        {
            store.BuyIce();
            player.PurchaseIce(store);
            player.DisplayRemainingBalanceWallet();
            player.inventory.AddIceToInventory(iceCubes);
        }
        public void AddIngredientsToPitcher()
        {
            player.TellPlayerToPickIngredients();
            player.AddLemonsToPitcher();
            player.AddCupsSugarToPitcher();
            player.AddIceToPitcher();
        }
        public void GetCustomers()
        {
            currentDay.GenerateCustomers();
            currentDay.DetermineCustomerBuy(player);
            BuyCup(player);
            player.SellOneCup();
        }
        
      


        //public void RunStand(Player player)

        //NotifyOfStandOpening();
        //for(i = 0; i < customers; i++)

        //if (CheckSaleCriteria(customer, player))
        //
        // confirmtransaction(player)
        public void RunStand(Player player)
        {
            NotifyOfStandOpening();
            
        }
        public void NotifyOfStandOpening()
        {
            Console.WriteLine("Lemonade Stand is now open for the day!");
        }

    }
}

