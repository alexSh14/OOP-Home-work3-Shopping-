using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Home_work3__Shopping_
{
    class ShoppingListManager
    {
        private List<ShoppingList> shoppingLists;

        public ShoppingListManager()
        {
            shoppingLists = new List<ShoppingList>();
        }

        public void AddList(string name)
        {
            shoppingLists.Add(new ShoppingList(name));
        }

        public void AddItem(string listName, string item)
        {
            var shoppingList = shoppingLists.FirstOrDefault(sl => sl.Name == listName);
            if (shoppingList != null)
            {
                shoppingList.Items.Add(item);
            }
        }

        public List<string> GetItems(string listName)
        {
            var shoppingList = shoppingLists.FirstOrDefault(sl => sl.Name == listName);
            return shoppingList?.Items;
        }
    }
}
