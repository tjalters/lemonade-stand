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




        public Player()
        {
            wallet = new Wallet();
            inventory = new Inventory();
        }
    }
}
