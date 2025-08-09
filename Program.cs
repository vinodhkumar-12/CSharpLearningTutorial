public delegate void showNumberDelegateMessage(int a);

public static class Program
{
    public static void show()
    {
        Console.WriteLine("Hello World!");
    }

    public static void ShowNumber1(int a)
    {
        a += 10;
        Console.WriteLine(a);
    }

    public static void ShowNumber2(int a)
    {
        a += 15;
        Console.WriteLine(a);
    }

    public static int AddNumber(int num1, int num2)
    {
        return num1 + num2;
    }
    public static void Main(string[] args)
    {
        showNumberDelegateMessage showNumberDelegateMessage = Program.ShowNumber1;
        showNumberDelegateMessage += Program.ShowNumber2;
        showNumberDelegateMessage(5);
    }
}

