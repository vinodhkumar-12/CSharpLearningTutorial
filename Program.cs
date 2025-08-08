public class Program
{
    public static void Main(string[] args)
    {

        string[] names = new string[4];

        names[0] = "vinodh";
        names[1] = "kumar";
        names[2] = "vijay";
        names[3] = "balakrishnan";

        //for (int i = 0; i < name.Length; i++)
        //{
        //    Console.WriteLine(name[i]);
        //}

        foreach(var name in names)
        {
            Console.WriteLine(name);
        }

        Console.ReadLine();
    }
}