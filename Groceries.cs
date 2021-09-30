using System;
using System.Collections.Generic;

namespace Choose_Your_Class
{
    class Groceries
    {

        public List<string> GroceryList = new List<string>();

        public void AddItem()
        {
            //Create a while loop that keeps letting the user add items
            bool keepAdding = true;
            while (keepAdding)
            {
                Console.WriteLine("Add an item to your grocery list");
                Console.WriteLine("Type back to return to main menu");
                string itemToAdd = Console.ReadLine();
                if (itemToAdd == "back")
                {
                    keepAdding = false;
                   
                }
                else
                {
                    GroceryList.Add(itemToAdd);
                    Console.Clear();
                    Console.WriteLine("Press enter to add another item");
                    Console.WriteLine("Type back to return to main menu");
                    Console.ReadLine().ToLower();
                }
            }
        }

        public void RemoveItem()
        {
            for (int i = 0; i < GroceryList.Count; i++)
            {
                // 0: Apple
                Console.WriteLine(i + ": " + GroceryList[i]);
            }
            Console.Write("What item number would you like to remove?");
            int itemToRemove = Convert.ToInt32(Console.ReadLine());
            GroceryList.RemoveAt(itemToRemove);
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }

        public void PrintGroceryList()
        {
            // GroceryList
            // apple, banana, orange, cabbage
            // 0    ,   1,       2  ,    3 , ...
            // GroceryList[0] => apple

            for(int i = 0; i < GroceryList.Count; i++)
            {
                Console.WriteLine(i + ": " + GroceryList[i]);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}