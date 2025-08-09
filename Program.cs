public delegate int showNumberDelegateMessage(int a);

public static class Program
{
    public static void show()
    {
        Console.WriteLine("Hello World!");
    }

    public static void ShowNumber(int a)
    {
        a += 10;
        Console.WriteLine(a);
    }

    public static void Main(string[] args)
    {
        //showNumberDelegateMessage showNumberDelegateMessage = Program.ShowNumber;
        //showNumberDelegateMessage(5);

        showNumberDelegateMessage showNumberDelegateMessage = delegate (int a)
        {
            a += 10;
            return a;
            //Console.WriteLine(a);
        };

        int result = showNumberDelegateMessage.Invoke(5);

        Console.WriteLine(result);
    }
}

