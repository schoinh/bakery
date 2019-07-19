namespace Bakery.Models
{
    class BakedGood
    {
        public int Quantity { get; set; }
        public int Cost { get; set; }
        
        public BakedGood()
        {
            Quantity = 0;
            Cost = 0;
        }
    }

    class Bread : BakedGood
    {
        public void GetCost()
        { 
            int numThrees = Quantity / 3;
            int numSingles = Quantity % 3;

            Cost = 10 * numThrees + 5 * numSingles;
        }
    }

    class Pastry : BakedGood
    {
        public void GetCost()
        { 
            int numThrees = Quantity / 3;
            int numSingles = Quantity % 3;

            Cost = 5 * numThrees + 2 * numSingles;
        }
    }
}
