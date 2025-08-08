public class Program
{
    public static void Main(string[] args)
    {

        int num1 = 0;
        Console.WriteLine("Enter the number 1");
        num1 = Convert.ToInt32(Console.ReadLine());

        int num2 = 0;
        Console.WriteLine("Enter the number 2");
        num2 = Convert.ToInt32(Console.ReadLine());

        Program p = new Program();
        
        int result = p.AddNumbers(num1, num2);

        Console.WriteLine("Sum of Two Number is : {0}", result);

    }

    public int AddNumbers(int num1, int num2)
    {
        return num1 + num2;
    }
}