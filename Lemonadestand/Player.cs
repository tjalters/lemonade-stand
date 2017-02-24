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
        public int amountCupsSugarPerPitcher;
        public int amountOfIceCubesPerPitcher;
        public int priceInCents;



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
                inventory.AddLemonsToInventory(store.numberOfLemons);
            }
            if (store.numberOfLemons == 50)
            {
                wallet.SubtractFromBalance(3);
                inventory.AddLemonsToInventory(store.numberOfLemons);
            }
            if (store.numberOfLemons == 80)
            {
                wallet.SubtractFromBalance(4);
                inventory.AddLemonsToInventory(store.numberOfLemons);
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
                inventory.AddCupsToInventory(store.numberOfCups);
            }
            if (store.numberOfCups == 60)
            {
                wallet.SubtractFromBalance(2);
                inventory.AddCupsToInventory(store.numberOfCups);
            }
            if (store.numberOfCups == 100)
            {
                wallet.SubtractFromBalance(3);
                inventory.AddCupsToInventory(store.numberOfCups);
            }
            if (store.numberOfCups == 150)
            {
                wallet.SubtractFromBalance(4);
                inventory.AddCupsToInventory(store.numberOfCups);
            }
         }
        public void DisplayCupsOfSugarBought()
        {
            if (store.cupsOfSugar == 15)
            {
                wallet.SubtractFromBalance(1);
                inventory.AddCupsSugarToInventory(store.cupsOfSugar);
            }
            if (store.cupsOfSugar == 30)
            {
                wallet.SubtractFromBalance(2);
                inventory.AddCupsSugarToInventory(store.cupsOfSugar);
            }
            if (store.cupsOfSugar == 50)
            {
                wallet.SubtractFromBalance(3);
                inventory.AddCupsSugarToInventory(store.cupsOfSugar);
            }
            if (store.cupsOfSugar == 80)
            {
                wallet.SubtractFromBalance(4);
                inventory.AddCupsSugarToInventory(store.cupsOfSugar);
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
            Console.WriteLine("Now that you have purchased your ingredients, it is time to chose how you want to make your lemonade for today.");
            Console.WriteLine("For reference, a normal amount of each ingredient per pitcher is 4 lemons, 4 cups of sugar, and 20 ice cubes.");
            Console.WriteLine("It's your lemonade stand though, so you can choose how many of each ingredient that you want per pitcher.");
            Console.WriteLine("Remember that too much or too little of each ingredient could turn off certain customers from buying a cup of lemonade.");
        }

        public void AddIceToInventory()
        {

        }
    
        public void AddLemonsToPitcher()
        {
            Console.WriteLine("How many lemons would you like to put in each pitcher? You must use at least 2 lemons and you can not use more than 6 lemons.");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Selected {0} lemons.", number);
                    amountLemonsPerPitcher = number;
                    break;
                default:
                    Console.WriteLine("Not a valid entry");
                    AddLemonsToPitcher();
                    break;
            }


        }
        public void AddCupsSugarToPitcher()
        {
            Console.WriteLine("How many cups of sugar would you like to put in each pitcher? You must use at least 2 cups of sugar and you can not use more than 6 cups of sugar.");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    Console.WriteLine("Selected {0} cups of sugar.", number);
                    amountCupsSugarPerPitcher = number;
                    break;
                default:
                    Console.WriteLine("Not a valid entry");
                    AddCupsSugarToPitcher();
                    break;
            }


            //int amountLemons = int.Parse(Console.ReadLine());
        }

        public void AddIceToPitcher()
        {
            Console.WriteLine("How many ice cubes would you like to put in each pitcher? You must use at least 10 ice cubes per pitcher and you can't use more than 40 ice cubes per pitcher. You must selected either 10, 15, 20, 25, 30, 35, 04 40.");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                case 15:
                case 20:
                case 25:
                case 30:
                case 35:
                case 40:
                    Console.WriteLine("Selected {0} ice cubes.", number);
                    amountOfIceCubesPerPitcher = number;
                    break;
                default:
                    Console.WriteLine("Not a valid entry");
                    AddIceToPitcher();
                    break;

            }
        }
      //  public void DisplayPitcher()
        //{
          //  Console.WriteLine("Your pitcher contains:");
            //Console.WriteLine("{0} lemons", number);
            //Console.WriteLine("{0} cups of sugar", number);
            //Console.WriteLine("{0} ice cubes", number);


        //}
        public void ChoosePricePerCup()
        {
            Console.WriteLine("Choose how much you want to charge your customers per cup(in cents). 10 cents is the minimum, 60 cents is the maximum. Choose in increments of 5(10, 15, 20, etc.) For context, the average amount per cup is 25 cents.");
            number = int.Parse(Console.ReadLine());

            switch (number)
            {
                case 10:
                case 15:
                case 20:
                case 25:
                case 30:
                case 35:
                case 40:
                case 45:
                case 50:
                case 55:
                case 60:
                    Console.WriteLine("Selected {0} cents", number);
                    priceInCents = number;
                    break;
                default:
                    Console.WriteLine("Invalid Entry.");
                    ChoosePricePerCup();
                    break;
            }
        }

     }
}
