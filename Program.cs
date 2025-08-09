using System;
using System.Text;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string filepath = @"D:\MyFile.txt";

        using (FileStream fs = new FileStream(filepath, FileMode.Create, FileAccess.Write))
        {
            string content = "Hello World!";

            byte[] bytes = Encoding.UTF8.GetBytes(content);

            fs.Write(bytes, 0, bytes.Length);

        }

        Console.WriteLine("File Stream Write done succesfully");

    }
}