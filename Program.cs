using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;

public class Program
{
    public static void Main(string[] args)
    {
        string FilePath = @"D:\MyFile.txt";

        Employee employee = new Employee() { Id = 1, Name = "Vinodh" };

        string jsonString = JsonSerializer.Serialize(employee);

        File.WriteAllText(FilePath, jsonString);

    }
}


[Serializable]
public class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }

}