using System;
using System.Text;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string filepath = @"D:\MyFile.txt";

        using (FileStream fs = new FileStream(filepath, FileMode.Append, FileAccess.Write))
        {
            using (StreamWriter sw = new StreamWriter(fs, Encoding.UTF8))
            {
                sw.WriteLine("Learning Never ends");
            }

        }

        Console.WriteLine("Stream Write append done succesfully");

    }
}