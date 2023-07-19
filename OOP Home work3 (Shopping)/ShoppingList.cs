using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Home_work3__Shopping_
{
    class ShoppingList
    {
        public string Name { get; set; }
        public List<string> Items { get; set; }

        public ShoppingList(string name)
        {
            Name = name;
            Items = new List<string>();
        }
    }
}
