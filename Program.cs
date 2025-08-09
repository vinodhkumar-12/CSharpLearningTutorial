using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

public class Program
{

    public static void Main(string[] args)
    {
        StringBuilder s = new StringBuilder();
        
        Stopwatch sw = new Stopwatch();

        sw.Start();
        for(int i=0;i<10000;i++)
        {
            s.Append(i);
        }

        sw.Stop();

        Console.WriteLine("Time taken to complete the string construction is : " + sw.ElapsedMilliseconds);

        Console.WriteLine(s);
    }

}