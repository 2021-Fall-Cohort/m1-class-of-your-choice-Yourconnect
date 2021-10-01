using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Choose_Your_Class
{
    class Kitchen
    {
        public Groceries ShoppingList = new Groceries();
        public Groceries ItemsAtHome = new Groceries();

        public Kitchen()
        {
            ShoppingList = new Groceries();
            ItemsAtHome = new Groceries();
        }

        public Kitchen(Groceries shoppingList)
        {
            ShoppingList = shoppingList;
            ItemsAtHome = new Groceries();
        }

        public void Transfer()
        {
            string item1 = ShoppingList.SelectGroceryListItem();
            ItemsAtHome.AddItem(item1);
            ShoppingList.RemoveItem(item1);
        }
    }
}
