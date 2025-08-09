using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        // Create a StringBuilder
        StringBuilder sb = new StringBuilder("Hello");

        // --- PROPERTIES ---
        Console.WriteLine("Capacity: " + sb.Capacity); // Default is 16
        Console.WriteLine("Length: " + sb.Length);     // Current length
        Console.WriteLine("MaxCapacity: " + sb.MaxCapacity);

        // --- METHODS ---
        sb.Append(" World");       // Add text at the end
        sb.AppendLine("!");        // Add text + newline
        sb.Insert(0, "Say: ");     // Insert at position
        sb.Replace("World", "C#"); // Replace text
        sb.Remove(0, 5);           // Remove from index 0, length 5

        // Convert to string
        string result = sb.ToString();

        Console.WriteLine("\nFinal String: " + result);
        Console.WriteLine("Length Now: " + sb.Length);
        Console.WriteLine("Capacity Now: " + sb.Capacity);
    }
}
