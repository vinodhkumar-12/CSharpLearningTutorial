using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    private static object _lock = new object();
    //private static Semaphore _semaphore = new Semaphore(1, 1);

    private static Semaphore _semaphore = new Semaphore(2, 2);
    public static void Main(string[] args)
    {

        Program p = new Program();

        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(p.Write);

            t.Start();
        }

        //Thread.Sleep(2000);
        //_mre.Set();
    }


    public void Write()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Waiting...");
        _semaphore.WaitOne();
        Thread.Sleep(3000);
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing is Completed...");
        _semaphore.Release();
    }

}