public class Program
{
    public static void Main(string[] args)
    {

        //Jump Break statment

        int a = 10;


        if (a == 10)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }


        Console.WriteLine("Loop terminates");

        Console.ReadLine();
    }
}