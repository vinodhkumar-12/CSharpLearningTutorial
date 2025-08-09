using System;
using System.Text;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string path = @"D:\Study Material";

        DirectoryInfo dir = new DirectoryInfo(path);

        DirectoryInfo[] directories_info = dir.GetDirectories();


        foreach (var directory_info in directories_info)
        {
            Console.WriteLine(directory_info.Name);
        }


    }
}