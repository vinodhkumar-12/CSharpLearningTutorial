using System.Collections;

public class Program
{
    public static void Main()
    {
        ArrayList list = new ArrayList();
        int prevCapacity = list.Capacity;

        Console.WriteLine($"Initially Capacity = {prevCapacity}");

        for (int i = 0; i < 20; i++)
        {
            list.Add(i);
            if (list.Capacity != prevCapacity)
            {
                prevCapacity = list.Capacity;
                Console.WriteLine($"After adding {i + 1} elements Capacity = {list.Capacity}");
            }
        }
    }
}