using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    public static void Main(string[] args)
    {

        Console.WriteLine("Main Program Executing...");

        Program p = new Program();

        Task<int> t1 = Task.Run(() => p.GetDatabaseDetail());
        Task<int> t2 = Task.Run(() => p.GetDatabaseDetail());

        Task.WaitAll(t1, t2);

        int result1 = t1.Result;
        int result2 = t2.Result;

        Console.WriteLine("Main Program Completed");

        Console.WriteLine("Task 1 Result is {0}", result1);
        Console.WriteLine("Task 2 Result is {0}", result2);
    }

    public int GetDatabaseDetail()
    {

        int i = 5;
        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is calling...");

        Thread.Sleep(2000);

        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is completed...");

        return i;
    }
}