public class Program
{
    public static void Main(string[] args)
    {
        DateTime dt = DateTime.Now;

        Console.WriteLine(dt.ToString());
        Console.WriteLine("{0:d}",dt);
        Console.WriteLine("{0:D}", dt);
        Console.WriteLine("{0:f}", dt);
        Console.WriteLine("{0:F}", dt);
        Console.WriteLine("{0:g}", dt);

        Console.ReadLine();

    }
}