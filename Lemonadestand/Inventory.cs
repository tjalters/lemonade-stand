using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Inventory
    {
        List<Lemons> lemons;
        List<Cups> cups;
        List<Sugar> sugar;
        List<Ice> ice;
 

        public Inventory()
        {
            lemons = new List<Lemons>();
            cups = new List<Cups>();
            sugar = new List<Sugar>();
            ice = new List<Ice>();
            //create list of each ingredient
        }

    }
}
