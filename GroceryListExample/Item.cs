namespace GroceryListExample
{
    public class Item
    {
        // attributes or properties - things we know
        public string Name;
        public double Price;
        private double Cost;

        public Item()
        {
        
        }

        // method (functions) - things we can do
        public void calculateCost()
        {
            Console.WriteLine("Calculating Cost");
        }

        public double getCost()
        {
            return Cost;
        }
    }
}
