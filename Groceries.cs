using System;
using System.Collections.Generic;

namespace Choose_Your_Class
{
    class Groceries
    {

        public List<string> GroceryList = new List<string>();

        public Groceries()
        {
            GroceryList = new List<string>();
        }
        public void AddItem(string item)
        {
            GroceryList.Add(item);
        }
        public void AddItem()
        {
            
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
                   //Console.WriteLine("Press enter to add another item");
                   //Console.WriteLine("Type back to return to main menu");
                   //Console.Read();
                }
            }
        }

        public void RemoveItem()
        {
            for (int i = 1; i < GroceryList.Count; i++)
            {

                Console.WriteLine(i + ".  " + GroceryList[i-1]);
            }
            Console.Write("What item number would you like to remove?");
            int itemToRemove = Convert.ToInt32(Console.ReadLine());
            GroceryList.RemoveAt(itemToRemove-1);
            Console.Write("Press enter to return to the Main Menu");
            Console.ReadKey();
        }

        public void RemoveItem(string item)
        {
            GroceryList.Remove(item);
        }
        public string SelectGroceryListItem()
        {

            for (int i = 1; i <= GroceryList.Count; i++)
            {
                Console.WriteLine(i + ".  " + GroceryList[i - 1]);
            }
            Console.Write("What item number would you like to transfer to your kitchen?");
            int indexSelected = Convert.ToInt32(Console.ReadLine());

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();

            return GroceryList[indexSelected - 1];
        }
        public void PrintGroceryList()
        {         

            for(int i = 1; i <= GroceryList.Count; i++)
            {
                Console.WriteLine(i + ".  " + GroceryList[i-1]);
            }

            Console.Write("Press enter to return to the Main Menu");
            Console.ReadLine();
        }
    }
}