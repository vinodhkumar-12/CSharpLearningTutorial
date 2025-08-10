using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    public async static Task Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("Main Thread starting...");

        Task t1 = p.GetDatabaseDetailAsync();

        await Task.WhenAll(t1);

        Console.WriteLine("Main Thread completed...");

        //Console.ReadKey();

    }

    public async Task GetDatabaseDetailAsync()
    {
        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is calling...");

        await Task.Delay(3000);

        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is completed...");

    }
}