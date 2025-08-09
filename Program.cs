using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Stack stack = new Stack();

        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push("vinodh");
        stack.Push(null);
        stack.Push(1.000);

        foreach(var item in stack)
        {
            Console.WriteLine(item);
        }


        stack.Pop();

        Console.WriteLine("After Pop done");

        foreach(var item in stack)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Peek Value is : ");

        Console.WriteLine(stack.Peek());
    }
}