using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroceryListExample
{
    public static class ConsoleToolbox
    {
        public static string Prompt(string message)
        {
            string answer = "";

            Console.WriteLine(message);
            answer = Console.ReadLine();

            return answer;
        }

        // we want a way to print a menu with numeric options
        public static void PrintMenu(List<string> options)
        {
            Console.WriteLine("Main Menu");
            Console.WriteLine("------------------");

            // process the list
            // loop over the array
                // for each item, print an option and the number

            Console.WriteLine("0. Exit");
        }
    }
}
