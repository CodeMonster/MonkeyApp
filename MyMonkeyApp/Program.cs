namespace MyMonkeyApp;

using System;

internal static class Program
{
    private static void Main()
    {
        PrintAsciiArt();
        while (true)
        {
            Console.WriteLine("\nMonkey App Menu:");
            Console.WriteLine("1. List all monkeys");
            Console.WriteLine("2. Get details for a specific monkey by name");
            Console.WriteLine("3. Get a random monkey");
            Console.WriteLine("4. Exit app");
            Console.Write("Select an option (1-4): ");

            string? input = Console.ReadLine();
            Console.WriteLine();
            switch (input)
            {
                case "1":
                    ListAllMonkeys();
                    break;
                case "2":
                    GetMonkeyDetailsByName();
                    break;
                case "3":
                    ShowRandomMonkey();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    return;
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }

    private static void PrintAsciiArt()
    {
        Console.WriteLine(@"  __,.__      ");
        Console.WriteLine(@" ( o o )     Monkey App!");
        Console.WriteLine(@"/  . .  \    ");
        Console.WriteLine(@"\  ---  /    ");
        Console.WriteLine(@" `-----'     ");
        Console.WriteLine();
    }

    private static void ListAllMonkeys()
    {
        var monkeys = MonkeyHelper.GetMonkeys();
        Console.WriteLine("All Monkeys:");
        foreach (var monkey in monkeys)
        {
            Console.WriteLine($"- {monkey.Name}");
        }
    }

    private static void GetMonkeyDetailsByName()
    {
        Console.Write("Enter monkey name: ");
        string? name = Console.ReadLine();
        if (string.IsNullOrWhiteSpace(name))
        {
            Console.WriteLine("Name cannot be empty.");
            return;
        }
        var monkey = MonkeyHelper.GetMonkeyByName(name);
        if (monkey == null)
        {
            Console.WriteLine($"Monkey '{name}' not found.");
        }
        else
        {
            PrintMonkeyDetails(monkey);
        }
    }

    private static void ShowRandomMonkey()
    {
        var monkey = MonkeyHelper.GetRandomMonkey();
        Console.WriteLine("Random Monkey:");
        PrintMonkeyDetails(monkey);
    }

    private static void PrintMonkeyDetails(Monkey monkey)
    {
        Console.WriteLine($"Name: {monkey.Name}");
        Console.WriteLine($"Location: {monkey.Location}");
        Console.WriteLine($"Population: {monkey.Population}");
        Console.WriteLine($"Details: {monkey.Details}");
        Console.WriteLine($"Image: {monkey.Image}");
        Console.WriteLine($"Coordinates: {monkey.Latitude}, {monkey.Longitude}");
        Console.WriteLine($"Accessed: {MonkeyHelper.GetAccessCount(monkey.Name)} times");
    }
}
