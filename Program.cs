using System;
using System.Text;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string filepath = @"D:\MyFile.txt";

        using (FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read))
        {

            byte[] bytes = new byte[fs.Length];

            fs.Read(bytes, 0, bytes.Length);

            string content = Encoding.UTF8.GetString(bytes);

            Console.WriteLine(content);

        }

        Console.WriteLine("File Stream Read done succesfully");

    }
}