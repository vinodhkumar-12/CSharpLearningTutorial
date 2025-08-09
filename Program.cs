public delegate void showNumberDelegateMessage(int a);

public class Program
{

    public void MyMethod(showNumberDelegateMessage showNumberDel, int a)
    {
        a += 10;
        showNumberDel.Invoke(a);
    }
    public static void Main(string[] args)
    {
        Program p = new Program();

        p.MyMethod(delegate (int b) { b = b + 10; Console.Write(b); }, 5);
    }
}

