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
        // $5 for 1 loaf, $10 for 3 loaves
        public void GetCost()
        { 
            int numThrees = Quantity / 3;
            int numSingles = Quantity % 3;

            Cost = 10 * numThrees + 5 * numSingles;
        }
    }

    class Pastry : BakedGood
    {
        // $2 for 1 pastry, $5 for 3 pastries
        public void GetCost()
        { 
            int numThrees = Quantity / 3;
            int numSingles = Quantity % 3;

            Cost = 5 * numThrees + 2 * numSingles;
        }
    }
}
