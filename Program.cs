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

        p.GetDatabaseDetail();
        p.CallRespectiveDatabase();

        Console.WriteLine("Main Thread completed...");

    }

    public void GetDatabaseDetail()
    {
        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is calling...");

        Thread.Sleep(2000);

        Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is completed...");
    }

    public void CallRespectiveDatabase()
    {
        Console.WriteLine($"Function Name CallRespectiveDatabase from {Thread.CurrentThread.ManagedThreadId} is calling...");

        Thread.Sleep(2000);

        Console.WriteLine($"Function Name CallRespectiveDatabase from {Thread.CurrentThread.ManagedThreadId} is completed...");
    }

}