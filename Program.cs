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

        Task t1 = p.GetDatabaseDetail();

        Task.WaitAll(t1);

        Console.WriteLine("Main Thread completed...");

        //Console.ReadKey();

    }

    public Task GetDatabaseDetail()
    {

        return Task.Run(() =>
        {

            Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is calling...");

            Thread.Sleep(5000);

            Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is completed...");
        });

    }
}