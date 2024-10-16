// Jesse Harlan

using GroceryListExample;

Item toast = new Item();
toast.Name = "Yeah Toast";

Item peanutButter = new Item();
peanutButter.Name = "Peanut Butter Mayhem";

Item other = toast;
other.Name = "Other Toast";

Console.WriteLine("Other: " + other.Name);
Console.WriteLine("Toast: " + toast.Name);
Console.WriteLine("PeanutButter: " + peanutButter.Name);

