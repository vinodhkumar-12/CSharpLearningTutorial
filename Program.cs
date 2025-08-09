using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            Console.WriteLine("Enter the first number");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine("Sum of two number is {0}", result);

        }
        catch (Exception ex)
        {
            Console.WriteLine("Entered number is not integer type");
        }
        finally
        {
            Console.WriteLine("Finally Block execute every time");
        }
    }
}
