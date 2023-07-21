using OOP_Home_work3__Shopping_;
using System.Text.Json;

ShoppingListManager manager = new ShoppingListManager();

int choice = 0;
do
{
    Console.WriteLine("Меню:");
    Console.WriteLine("1. Создать новый список покупок");
    Console.WriteLine("2. Добавить элементы из другого списка");
    Console.WriteLine("3. Вывести список покупок");
    Console.WriteLine("4. Сохранить списки покупок в файл");
    Console.WriteLine("5. Загрузить списки покупок из файла");
    Console.WriteLine("6. Выход");

    Console.Write("Выберите действие: ");
    choice = Convert.ToInt32(Console.ReadLine());

    switch (choice)
    {
        case 1:
            Console.Write("Введите имя нового списка покупок: ");
            string newListName = Console.ReadLine();
            manager.CreateNewList(newListName);
            break;
        case 2:
            Console.Write("Введите имя списка покупок, в который нужно добавить элементы: ");
            string listName = Console.ReadLine();
            Console.Write("Введите элементы для добавления (через запятую): ");
            List<string> items = new List<string>(Console.ReadLine().Split(','));
            manager.AddItemsFromList(listName, items);
            break;
        case 3:
            Console.Write("Введите имя списка покупок для вывода: ");
            string printListName = Console.ReadLine();
            manager.PrintList(printListName);
            break;
        case 4:
            manager.SaveListsToJson();
            break;
        case 5:
            manager.LoadListsFromJson();
            break;
        case 6:
            Console.WriteLine("Выход из программы");
            break;
        default:
            Console.WriteLine("Неверный выбор");
            break;
    }

    Console.WriteLine();
} while (choice != 6);
    
