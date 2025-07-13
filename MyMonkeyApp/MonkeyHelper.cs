using System;
using System.Collections.Generic;
using System.Linq;

namespace MyMonkeyApp;

public static class MonkeyHelper
{
    private static readonly List<Monkey> monkeys = new()
    {
        new Monkey { Name = "Baboon", Location = "Africa & Asia", Details = "Baboons are African and Arabian Old World monkeys belonging to the genus Papio, part of the subfamily Cercopithecinae.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/baboon.jpg", Population = 10000, Latitude = -8.783195, Longitude = 34.508523 },
        new Monkey { Name = "Capuchin Monkey", Location = "Central & South America", Details = "The capuchin monkeys are New World monkeys of the subfamily Cebinae. Prior to 2011, the subfamily contained only a single genus, Cebus.", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/capuchin.jpg", Population = 23000, Latitude = 12.769013, Longitude = -85.602364 },
        new Monkey { Name = "Blue Monkey", Location = "Central and East Africa", Details = "The blue monkey or diademed monkey is a species of Old World monkey native to Central and East Africa, ranging from the upper Congo River basin east to the East African Rift and south to northern Angola and Zambia", Image = "https://raw.githubusercontent.com/jamesmontemagno/app-monkeys/master/bluemonkey.jpg", Population = 12000, Latitude = 1.957709, Longitude = 37.297204 }
        // Add more monkeys from MCP server as needed
    };

    private static readonly Dictionary<string, int> accessCounts = new(StringComparer.OrdinalIgnoreCase);
    private static readonly Random random = new();

    public static IReadOnlyList<Monkey> GetMonkeys()
    {
        return monkeys;
    }

    public static Monkey GetRandomMonkey()
    {
        if (monkeys.Count == 0)
            throw new InvalidOperationException("No monkeys available.");
        var index = random.Next(monkeys.Count);
        var monkey = monkeys[index];
        TrackAccess(monkey.Name);
        return monkey;
    }

    public static Monkey? GetMonkeyByName(string name)
    {
        var monkey = monkeys.FirstOrDefault(m => string.Equals(m.Name, name, StringComparison.OrdinalIgnoreCase));
        if (monkey != null)
        {
            TrackAccess(monkey.Name);
        }
        return monkey;
    }

    public static int GetAccessCount(string name)
    {
        return accessCounts.TryGetValue(name, out var count) ? count : 0;
    }

    private static void TrackAccess(string name)
    {
        if (accessCounts.ContainsKey(name))
        {
            accessCounts[name]++;
        }
        else
        {
            accessCounts[name] = 1;
        }
    }
}
