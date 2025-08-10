using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    public async static Task Main(string[] args)
    {

        Console.WriteLine("Main Program Executing...");

        Program p = new Program();

        Task<int> t1 = p.GetDatabaseDetail();

        Task<int> t2 = p.GetDatabaseDetail();

        int[] results = await Task.WhenAll(t1, t2);

        Console.WriteLine("Main Program Completed");

        Console.WriteLine("Result of Task 1 is : {0}", results[0]);
        Console.WriteLine("Result of Task 2 is : {0}", results[1]);
    }

    public async Task<int> GetDatabaseDetail()
    {

        int i = 5;
        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is calling...");

        await Task.Delay(2000);

        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is completed...");

        return i;
    }
}