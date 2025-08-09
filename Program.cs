public delegate int squareNumberDelegateMessage(int a);

public class Program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Enter the number to make it squaree");

        int num = Convert.ToInt32(Console.ReadLine());

        //squareNumberDelegateMessage sqdel = delegate (int a)
        //{
        //    a = a * a;
        //    return a;
        //};

        squareNumberDelegateMessage sqdel = (a) =>
        {
            a = a * a;
            return a;
        };

        int sqlnumberseult = sqdel.Invoke(num);

        Console.WriteLine("Square of entered number is : " + sqlnumberseult);

    }
}

