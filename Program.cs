using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = @"D:\MyFile.txt";

        // Deserialize JSON back to Employee object
        string jsonString = File.ReadAllText(filePath);
        Employee deserializedEmployee = JsonSerializer.Deserialize<Employee>(jsonString);

        Console.WriteLine("Employee object deserialized successfully.");
        Console.WriteLine($"Id: {deserializedEmployee.Id}, Name: {deserializedEmployee.Name}");
    }
}


[Serializable]
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

}