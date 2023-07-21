using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace OOP_Home_work3__Shopping_
{
    public class ShoppingList
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