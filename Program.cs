using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    public static void Main(string[] args)
    {
        Program p = new Program();
        Console.WriteLine("Main Thread starting...");

        Task t1 = Task.Run(p.GetDatabaseDetail);
        Task t2 = Task.Run(p.GetDatabaseDetail);
        Task t3 = Task.Run(p.GetDatabaseDetail);

        Task.WaitAll(t1, t2, t3);

        Console.WriteLine("Main Thread completed...");

        Console.ReadKey();

    }

    public void GetDatabaseDetail()
    {
        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is calling...");

        Thread.Sleep(5000);

        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is completed...");
    }

}