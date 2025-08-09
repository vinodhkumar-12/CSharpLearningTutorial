using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {

        Program p = new Program();
        //p.AddNumbers(new int[4] { 1, 2, 3, 4 });

        Console.WriteLine("Sum of provided value is : " + p.AddNumbers(1, 2, 3, 4));
    }


    public int AddNumbers(params int[] numbers)
    {
        int sum = 0;

        foreach (int num in numbers)
        {
            sum += num;
        }

        return sum;
    }

}