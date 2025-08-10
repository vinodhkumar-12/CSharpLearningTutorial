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

        //Task<int> t1 = p.GetDatabaseDetail();

        //int result1 = t1.Result;

        int result1 = p.GetDatabaseDetail().Result;

        Console.WriteLine("Main Program Completed");

        Console.WriteLine("Task 1 Result is {0}", result1);
    }

    public Task<int> GetDatabaseDetail()
    {
        return Task.Run(() =>
        {
            int i = 5;

            Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is calling...");

            Thread.Sleep(2000);

            Console.WriteLine($"Function Name GetDatabaseDetail from {Thread.CurrentThread.ManagedThreadId} is completed...");

            return i;

        });
    }
}