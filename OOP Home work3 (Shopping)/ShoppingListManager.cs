using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
namespace OOP_Home_work3__Shopping_
{
    public class ShoppingListManager
    {
        private List<ShoppingList> shoppingLists;

        public ShoppingListManager()
        {
            shoppingLists = new List<ShoppingList>();
        }

        public void CreateNewList(string name)
        {
            ShoppingList newList = new ShoppingList(name);
            shoppingLists.Add(newList);
            Console.WriteLine($"Создан новый список покупок с именем: {name}");
        }

        public void AddItemsFromList(string name, List<string> items)
        {
            ShoppingList list = shoppingLists.Find(x => x.Name == name);
            if (list != null)
            {
                list.Items.AddRange(items);
                Console.WriteLine($"Добавлены элементы в список покупок: {string.Join(", ", items)}");
            }
            else
            {
                Console.WriteLine($"Список покупок с именем {name} не найден");
            }
        }

        public void PrintList(string name)
        {
            ShoppingList list = shoppingLists.Find(x => x.Name == name);
            if (list != null)
            {
                Console.WriteLine($"Список покупок {list.Name}:");
                foreach (string item in list.Items)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine($"Список покупок с именем {name} не найден");
            }
        }

        public void SaveListsToJson()
        {
            string json = JsonConvert.SerializeObject(shoppingLists, Formatting.Indented);
            File.WriteAllText("shoppingLists.json", json);
            Console.WriteLine("Списки покупок сохранены в файле shoppingLists.json");
        }

        public void LoadListsFromJson()
        {
            if (File.Exists("shoppingLists.json"))
            {
                string json = File.ReadAllText("shoppingLists.json");
                shoppingLists = JsonConvert.DeserializeObject<List<ShoppingList>>(json);
                Console.WriteLine("Списки покупок загружены из файла shoppingLists.json");
            }
            else
            {
                Console.WriteLine("Файл shoppingLists.json не найден");
            }
        }
    }

}