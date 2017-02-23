using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Player
    {
        public Wallet wallet;
        public Inventory inventory;
        public Store store;
        public int number;
        public int numberOfLemons;
        public int numberOfCups;
        public int cupsOfSugar;
        public int iceCubes;
        public int getNumberOfLemons;
        public int storedLemons;
        public int lemons;
        public int amountLemonsPerPitcher;



        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();
            store = new Store();
        }

        public void DisplayLemonsBought()
        {
            if (store.numberOfLemons == 10)
            {
                wallet.SubtractFromBalance(1);
                inventory.AddLemonsToInventory(store.numberOfLemons);
            }
            if (store.numberOfLemons == 25)
            {
                wallet.SubtractFromBalance(2);
            }
            if (store.numberOfLemons == 50)
            {
                wallet.SubtractFromBalance(3);
            }
            if (store.numberOfLemons == 80)
            {
                wallet.SubtractFromBalance(4);
            }          
       
        }
        public void DisplayRemainingBalanceWallet()
        {
            Console.WriteLine("Remaining balance is " + wallet.balance);
        }
        public void DisplayCupsBought()
        {
            if (store.numberOfCups == 30)
            {
                wallet.SubtractFromBalance(1);
            }
            if (store.numberOfCups == 60)
            {
                wallet.SubtractFromBalance(2);
            }
            if (store.numberOfCups == 100)
            {
                wallet.SubtractFromBalance(3);
            }
            if (store.numberOfCups == 150)
            {
                wallet.SubtractFromBalance(4);
            }
         }
        public void DisplayCupsOfSugarBought()
        {
            if (store.cupsOfSugar == 15)
            {
                wallet.SubtractFromBalance(1);
            }
            if (store.cupsOfSugar == 30)
            {
                wallet.SubtractFromBalance(2);
            }
            if (store.cupsOfSugar == 50)
            {
                wallet.SubtractFromBalance(3);
            }
            if (store.cupsOfSugar == 80)
            {
                wallet.SubtractFromBalance(4);
            }

        }
        public void DisplayIceCubesBought()
        {
            if (store.iceCubes == 100)
            {
                wallet.SubtractFromBalance(1);
            }
            if (store.iceCubes == 200)
            {
                wallet.SubtractFromBalance(2);
            }
            if (store.iceCubes == 300)
            {
                wallet.SubtractFromBalance(3);
            }
            if (store.iceCubes == 400)
            {
                wallet.SubtractFromBalance(4);
            }
        }

        public void TellPlayerToPickIngredients()
        {
            Console.WriteLine("Now that you have purchased your ingredients, it is time to chose how you want to make your lemonade.");
            Console.WriteLine("For reference, a normal amount of each ingredient per pitcher is 4 lemons, 4 cups of sugar, and 20 ice cubes.");
            Console.WriteLine("It's your lemonade stand though, so you can choose how many of each ingredient that you want per pitcher.");
            Console.WriteLine("Remember that too much or too little of each ingredient could turn off certain customers from buying a cup of lemonade.");
        }
      
        
        public void AddCupsSugarToPitcher()
        {
            Console.WriteLine("How many cups of sugar would you like to put in each pitcher?");
        }
        public void AddIceToPitcher()
        {
            Console.WriteLine("How many ice cubes would you like to put in each pitcher?");
        }
    }
}
