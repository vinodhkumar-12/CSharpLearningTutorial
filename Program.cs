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
            using (StreamReader reader = new StreamReader(fs))
            {
                string line = reader.ReadLine();
                Console.WriteLine(line);
            }

        }

        Console.WriteLine("Stream Write append done succesfully");

    }
}