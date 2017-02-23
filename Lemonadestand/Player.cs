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
    }
}
