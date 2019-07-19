using System;
using System.Collections.Generic;

namespace Bakery.Models
{
    class Bread
    {
        public int Quantity { get; set; }
        public int Cost { get; set; }
        
        public Bread()
        {
            Quantity = 0;
            Cost = 0;
        }

        public void GetCost()
        { 
            int numThrees = Quantity / 3;
        }
    }

    class Pastry
    {
        public int Quantity { get; set; }
        public int Cost { get; set; }
        
        public Pastry()
        {
            Quantity = 0;
            Cost = 0;
        }
    }
}
