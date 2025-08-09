using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        // Create a dictionary with <string, int>
        Dictionary<string, int> ages = new Dictionary<string, int>();

        // Adding elements
        ages.Add("Vinodh", 28);
        ages.Add("Vijay", 26);
        ages.Add("Harish", 28);

        // Accessing value by key
        Console.WriteLine("Vinodh's Age: " + ages["Vinodh"]);

        // Updating value
        ages["Vijay"] = 27;

        // Checking if key exists before adding
        if (!ages.ContainsKey("Vasanth"))
        {
            ages.Add("Vasanth", 27);
        }

        // Iterating through dictionary
        Console.WriteLine("\nAll entries:");
        foreach (KeyValuePair<string, int> entry in ages)
        {
            Console.WriteLine($"{entry.Key}   {entry.Value}");
        }

        // Removing a key-value pair
        ages.Remove("Harish");

        // TryGetValue example (safe lookup)
        if (ages.TryGetValue("Naresh", out int age))
        {
            Console.WriteLine($"Naresh's Age: {age}");
        }
        else
        {
            Console.WriteLine("Naresh not found.");
        }
    }
}
