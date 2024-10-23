using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListExample
{
    public class Register
    {
        // Properties
        public List<Item> GroceryList { get; set; }

        public Register()
        {
            GroceryList = new List<Item>();
        }


        // Methods
        public void AddItem(string name, double cost, double price)
        {
            GroceryList.Add(new Item(name, price, cost));
        }

        public void AddItem(Item item)
        {
            // add it to the list
            GroceryList.Add(item);
        }


        // a way to remove an item from the list
        public void RemoveItem(Item item)
        {
            GroceryList.Remove(item);
        }
        


        // it should generate a price tag of all groceries
        public void GenerateReceipt()
        {
            Console.WriteLine("Generating Receipt...");

            double subtotal = 0;

            for (int i = 0; i < GroceryList.Count; i++)
            {
                Console.WriteLine(GroceryList[i].Name + "\t\t\t" + GroceryList[i].Price);
                subtotal += GroceryList[i].Price;
            }

            Console.WriteLine("----------------------------");
            Console.WriteLine("Subtotal:\t\t\t" + subtotal);
        }



        public string Prompt(string message)
        {
            string answer = "";

            Console.WriteLine(message);
            answer = Console.ReadLine();

            return answer;
        }

        public void RemoveItemByName(string name)
        {
            int index = -1;

            for (int i = 0; i < GroceryList.Count; i++)
            {
                if (GroceryList[i].Name.ToLower() == name.ToLower())
                {
                    index = i;
                    break;
                }
            }
            
            if (index == -1)
            {
                return;
            }

            GroceryList.RemoveAt(index);
        }
    }
}
