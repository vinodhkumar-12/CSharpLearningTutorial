using System;
using System.Text;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        program.Function1();
        program.Function2();
        program.Function3();

    }

    public void Function1()
    {
        Console.WriteLine("Function 1 method");
    }

    public void Function2()
    {
        Console.WriteLine("Function 2 method");
    }
}


public static class ProgramExtension
{
    public static void Function3(this Program p)
    {
        Console.WriteLine("This is my third function as extension method");
    }
}
