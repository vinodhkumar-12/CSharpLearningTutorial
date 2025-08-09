using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Queue queue = new Queue();

        queue.Enqueue("vinodh");
        queue.Enqueue("22");
        queue.Enqueue("kumar");
        queue.Enqueue(1);


        foreach(var item in queue)
        {
            Console.WriteLine(item);
        }

        queue.Dequeue();

        Console.WriteLine("After Dequeue the values are");

        foreach (var item in queue)
        {
            Console.WriteLine(item);
        }

        Console.WriteLine("Current peek value is " + queue.Peek());

    }
}