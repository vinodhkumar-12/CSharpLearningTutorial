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
                string data = reader.ReadToEnd();

                Console.WriteLine(data);

            }

        }

        Console.WriteLine("Stream Read append done succesfully");

    }
}