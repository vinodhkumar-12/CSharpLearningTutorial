public class Program
{
    public static void Main(string[] args)
    {

        int num1 = 0;
        int num2 = 0;

        int result = 0;

        Console.WriteLine("Enter the number 1");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the number 2");
        num2 = Convert.ToInt32(Console.ReadLine());

        result = num1 + num2;

        Console.WriteLine("Sum of two number is {0}", result);

        Console.ReadLine();
    }
}