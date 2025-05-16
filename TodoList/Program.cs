
using System;

var todos = new List<string>();

Console.WriteLine("Hello");

bool shallExit = false;
while (!shallExit)
{

    Console.WriteLine("What do you want to do?");
    Console.WriteLine("[S]ee all todos");
    Console.WriteLine("[A]dd a todo");
    Console.WriteLine("[R]emove a todo");
    Console.WriteLine("[E]xit");

    var userChoice = Console.ReadLine();

    switch (userChoice)
    {
        case "s":
        case "S":
            SeeAllTodos();
            Console.WriteLine("See all todos");
            break;
        case "a":
        case "A":
            AddTodo();
            break;
        case "r":
        case "R":
            RemoveATodo();
            break;
        case "e":
        case "E":
            shallExit = true;
            break;
        default:
            Console.WriteLine("Invalid choice. Please enter S, A, R, or E.");
            break;
    }
}

Console.ReadLine();
void SeeAllTodos()
{
    if (todos.Count == 0)
    {
        ShowNoTodosFound();
        return;
    }
    else
    {
        for (int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todos[i]}");
        }
    }
}

void AddTodo()
{
    string description;
    do
    {
        Console.WriteLine("Enter a todo description:");
        description = Console.ReadLine();

    } while (!IsDescriptionValid(description));
    todos.Add(description);
}

bool IsDescriptionValid(string description)
{
    if (description == "")
    {
        Console.WriteLine("Todo's desc can't be empty.");
        return false;
    }
    if (todos.Contains(description))
    {
        Console.WriteLine("Todo already exists.");
        return false;
    }
    return true;
}

void RemoveATodo()
{
    if (todos.Count == 0)
    {
        ShowNoTodosFound();
        return;
    }
    int index;
    do
    {
        Console.WriteLine("Enter the number of the todo you want to remove:");
        SeeAllTodos();
    } while (!TryReadIndex(out index));
    RemoveTodoAtIndex(index - 1);
}

void RemoveTodoAtIndex(int index)
{
    var todoToRemove = todos[index];
    todos.RemoveAt(index);
    Console.WriteLine($"Todo '{todoToRemove}' has been removed.");
}

bool TryReadIndex(out int index)
{
    var userInput = Console.ReadLine();
    if (userInput == "")
    {
        index = 0;
        Console.WriteLine("Selected index cannot be empty.");
        return false;
    }
    if (int.TryParse(userInput, out index) && index >= 1 && index <= todos.Count)
    {
        return true;
    }
    Console.WriteLine("Invalid number. Please enter a valid todo number.");
    return false;
}

static void ShowNoTodosFound()
{
    Console.WriteLine("No todos found.");
}
