public class Program
{
    public static void Main(string[] args)
    {
        int i = 0;

        do
        {
            Console.WriteLine(i);
            i++;
        } while (i < 10);

        Console.WriteLine("Loop terminates");

        Console.ReadLine();
    }
}