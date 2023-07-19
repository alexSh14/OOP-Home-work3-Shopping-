using OOP_Home_work3__Shopping_;
using System.Text.Json;

var manager = new ShoppingListManager();

// Создаем новый список покупок
manager.AddList("Список покупок на неделю");

// Добавляем элементы в список покупок
manager.AddItem("Список покупок на неделю", "Хлеб");
manager.AddItem("Список покупок на неделю", "Молоко");
manager.AddItem("Список покупок на неделю", "Яйца");

// Получаем список покупок
var items = manager.GetItems("Список покупок на неделю");
foreach (var item in items)
{
    Console.WriteLine(item);
}
var shoppingList = new ShoppingList ("Список покупок на неделю")
{
    Name = "Список покупок на неделю",
    Items = new List<string> { "Хлеб", "Молоко", "Яйца" }
};

var options = new JsonSerializerOptions
{
    WriteIndented = true
};

string jsonString = JsonSerializer.Serialize(shoppingList, options);

File.WriteAllText("shoppingList.json", jsonString);