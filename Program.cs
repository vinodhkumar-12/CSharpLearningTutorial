using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    private static object _lock = new object();
    public static void Main(string[] args)
    {

        Program p = new Program();

        //new Thread(p.Function).Start();

        //Thread t1 = new Thread(p.Function);
        //Thread t2 = new Thread(p.Function);
        //Thread t3 = new Thread(p.Function);
        //Thread t4 = new Thread(p.Function);
        //Thread t5 = new Thread(p.Function);

        //t1.Start();
        //t2.Start();
        //t3.Start();
        //t4.Start();
        //t5.Start();

        for (int i = 0; i < 5; i++)
        {
            Thread t = new Thread(p.Function);

            t.Start();
        }
    }


    public void Function()
    {
        lock (_lock)
        {
            Console.WriteLine("Thread Id is : {0}", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Thread Id is {0} is Sleeping", Thread.CurrentThread.ManagedThreadId);
            Thread.Sleep(5000);
            Console.WriteLine("Thread Id is {0} is Completed", Thread.CurrentThread.ManagedThreadId);
        }
    }
}