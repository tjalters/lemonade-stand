using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lemonadestand
{
    public class Day
    {
        public Customers customers;
        public Weather weather;

        public Day()
        {
            customers = new Customers();
            weather = new Weather();
        }
    }
}
