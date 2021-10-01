using System;
using System.Collections.Generic;

namespace Choose_Your_Class
{
    class Program
    {
        //
        static Groceries Groceries = new Groceries();
        static Kitchen Kitchen = new Kitchen(Groceries);
        static void Main(string[] args)
        {
            bool keepLooping = true;
            while (keepLooping)
            {
                Console.Clear();
                Console.WriteLine("Recipe Book");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1. Grocery list");
                Console.WriteLine("2. Add Item To grocery shopping List");
                Console.WriteLine("3. Remove Item from the grocery shopping List"); 
                Console.WriteLine("4. Food at home"); 
                Console.WriteLine("5. Add item to the food at home List");
                Console.WriteLine("6. Remove Item from the food at home List");
                Console.WriteLine("Press Q to quit");

                //Does this need any sort of conversion to work 
                string userChoice = Console.ReadLine().ToLower();

                switch (userChoice)
                {
                    case "1":
                        Groceries.PrintGroceryList();
                        break;

                    case "2":
                        Groceries.AddItem();
                        break;

                    case "3":
                        Groceries.RemoveItem();
                        break;

                    case "4":
                        Kitchen.ItemsAtHome.PrintGroceryList();
                        break;

                    case "5":
                        Kitchen.Transfer();
                        break;

                    case "6":
                        Kitchen.ItemsAtHome.RemoveItem();
                        break;

                    case "q":
                        keepLooping = false;
                        Console.WriteLine("Good bye!");
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
