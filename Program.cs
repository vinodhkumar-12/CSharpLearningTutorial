using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    private static object _lock = new object();
    private static ManualResetEvent _mre = new ManualResetEvent(false);
    public static void Main(string[] args)
    {

        Program p = new Program();

        new Thread(p.Write).Start();

        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(p.Read);

            t.Start();
        }
    }


    public void Write()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Writing...");
        _mre.Reset();
        Thread.Sleep(3000);
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Writing is Completed...");
        _mre.Set();

    }

    public void Read()
    {
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} is Reading...");
        //Thread.Sleep(5000);
        _mre.WaitOne();
        Console.WriteLine($"Thread {Thread.CurrentThread.ManagedThreadId} Reading is Completed...");
    }
}