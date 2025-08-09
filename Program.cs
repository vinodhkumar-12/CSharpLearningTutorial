public delegate void showDelegateMessage();
public delegate int AddDelegateMessage(int num1, int num2);
public delegate void showNumberDelegateMessage(int a);

public class Program
{
    public void show()
    {
        Console.WriteLine("Hello World!");
    }

    public void ShowNumber(int a)
    {
        a += 10;
        Console.WriteLine(a);
    }

    public static void ShowStaticNumber(int a)
    {
        a += 10;
        Console.WriteLine(a);
    }

    public int AddNumber(int num1, int num2)
    {
        return num1 + num2;
    }
    public static void Main(string[] args)
    {
        Program program = new Program();

        //showDelegateMessage showdel= program.show;

        //showdel();

        //AddDelegateMessage addDelegateMessage = program.AddNumber;

        //int result = addDelegateMessage(1, 2);

        //Console.WriteLine(result);

        showNumberDelegateMessage showNumberDelegateMessage = program.ShowNumber;

        showNumberDelegateMessage(1);
    }
}

