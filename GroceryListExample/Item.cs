namespace GroceryListExample
{
    public class Item
    {
        // attributes or properties - things we know
        public string Name { get; set; }
        public double Price { get; set; }
        private double Cost { get; set; }

        public string Description { get; set; }

        // ctrl + . (gives you the refactoring menu)
        // prop (then tab) will give you a new property
        // ctor will give you a new constructor

        //// constructor - helps set up our object for first use
        public Item()
        {
            Name = "item";
            Price = 0.50;
            Cost = 1;
        }

        public Item(string name, double price = 0, double cost = 0)
        {
            Name = name;
            Price = price;
            Cost = cost;
        }

        // method (functions) - things we can do
        public void calculateCost()
        {
            Console.WriteLine("Calculating Cost");
        }

        public double divideThis(int amount1, int amount2)
        {
            return amount1 / amount2;
        }

        public double divideThis(double amount1, double amount2)
        {
            return amount1 / amount2;
        }
    }
}
