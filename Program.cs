using System;
using System.Text;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        Program program = new Program();
        string path = @"D:\Project\API\C#\test.txt";
        string path2 = @"D:\Project\API\C#\test1.txt";
        string text = "";

        if (File.Exists(path))
        {
            Console.WriteLine("File Exists");
            text = File.ReadAllText(path);
            Console.WriteLine(text);

            File.Copy(path, path2, true);
        }
        else
        {
            Console.WriteLine("File Not exists");
        }
    }


}