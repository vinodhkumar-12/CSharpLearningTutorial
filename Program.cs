using System;
using System.Text;

public class Program
{
    public static void Main()
    {
        Program p = new Program();
        //p.function1();
        //p.function2();
        //p.function3();

        Thread t1 = new Thread(p.function1);
        Thread t2 = new Thread(p.function2);
        Thread t3 = new Thread(p.function3);

        t1.Start();
        t2.Start();
        t3.Start();

    }

    public void function1()
    {
        for (int i = 0; i < 50; i++)
        {
            Console.WriteLine(i);
            if (i == 25)
            {
                Console.WriteLine("Thread is sleeping for 8 seconds");
                Thread.Sleep(8000);

            }

        }
    }

    public void function2()
    {
        for (int i = 50; i < 100; i++)
        {
            Console.WriteLine(i);

        }

    }

    public void function3()
    {
        for (int i = 100; i < 150; i++)
        {
            Console.WriteLine(i);

        }
    }

}
