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

        Task t1 = p.GetDatabaseDetail();

        Task.WaitAll(t1);

        Console.WriteLine("Main Program Completed");
    }

    public Task GetDatabaseDetail()
    {
        return Task.Run(() =>
        {
            Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is calling...");

            Thread.Sleep(2000);

            Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is completed...");
        });
    }
}