// Jesse Harlan

using GroceryListExample;

Register register = new Register();

Item toast = new Item("Toast", 1.1, 0.1);
Item tacos = new Item("Taco", 2.0, 0.1);
Item bigtoast = new Item("BIG Toast", 1.0, 0.1);

register.AddItem(tacos);
register.AddItem(bigtoast);
register.AddItem(toast);

register.GenerateReceipt();

Console.WriteLine("Removing Toast from the receipt");

register.RemoveItemByName("toast");

register.GenerateReceipt();





















