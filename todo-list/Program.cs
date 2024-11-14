using System.Data;

string userOption;
char letter = ' ';
List<string> todoList = new List<string>();

Console.WriteLine("Your Todo List Application");

do
{
    displayMenu();

    userOption = Console.ReadLine();

    if (userOption.Length == 1)
    {
        letter = Char.ToUpper(userOption[0]);

        Console.WriteLine();

        switch (letter)
        {
            case 'S':
                viewList();
                break;
            case 'A':
                addItemToList();
                break;
            case 'R':
                removeItemFromList();
                break;
            case 'E':
                Console.WriteLine("Have a nice day!~");
                break;
            default:
                Console.WriteLine("Invalid option.");
                break;
        }
    }
}
while (letter != 'E');

// Console.ReadKey();

void displayMenu()
{
    Console.WriteLine();
    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd todo");
    Console.WriteLine("[R]emove todo");
    Console.WriteLine("[E]xit");
}

void viewList()
{
    if (todoList.Count > 0)
    {
        Console.WriteLine("Your Current Todo List:");

        for (int i = 0; i < todoList.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todoList[i]}");
        }
    }
    else
    {
        Console.WriteLine("Your todo list is currently empty.");
    }
}

void addItemToList()
{
    Console.WriteLine("Enter todo description:");
    string newItem = Console.ReadLine();
    if (newItem.Length > 0)
    {
        if (todoList.Contains(newItem))
        {
            Console.WriteLine();
            Console.WriteLine($"'{newItem}' is already on your todo list.");
        }
        else
        {
            todoList.Add(newItem);

            Console.WriteLine();
            Console.WriteLine($"Added: {todoList[^1]}");
        }
    }
    else
    {
        Console.WriteLine("Invalid entry.  No item added.");
    }
}

void removeItemFromList()
{
    viewList();

    if (todoList.Count > 0)
    {
        int itemNumber;

        Console.WriteLine();
        Console.WriteLine("Select the index of the todo you want to remove:");
        string userInput = Console.ReadLine();

        bool isParsingSuccessful = int.TryParse(userInput, out itemNumber);

        if (isParsingSuccessful && itemNumber <= todoList.Count && itemNumber > 0)
        {
            string itemName = todoList[itemNumber - 1];

            todoList.RemoveAt(itemNumber - 1);

            Console.WriteLine();
            Console.WriteLine($"Removed: '{itemName}'");
        }
        else
        {
            Console.WriteLine();
            Console.WriteLine("Invalid input. No items removed.");
        }
    }
}