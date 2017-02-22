using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Store
    {

        public Store()
        {

        }
        public int GetNumberOfLemons()
        {
            Console.WriteLine("How many lemons?");

            int lemonsAmount = int.Parse(Console.ReadLine());

            if (Player.Wallet.amount > 0)

                return lemonsAmount;
        }

        public void SetLemonsInInventory(Player player, int lemons)
        {
            for (int i = 0; i < lemonsAmount: i++)
            {
                Lemon lemon = new Lemon;
                player.inventory.lemons.Add(lemons);
            }
        }
                            
                                                                  

    }
}
