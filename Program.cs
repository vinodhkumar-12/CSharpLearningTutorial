using System;
using System.Text;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string path = @"D:\My Directory";
        string path2 = @"D:\My Directory 2";

        DirectoryInfo dir = new DirectoryInfo(path2);


        //dir.Create();
        //dir.CreateSubdirectory("Another Directory");
        //dir.MoveTo(path2);

        dir.Delete(true);

        Console.WriteLine("Directory Deleted");

    }


}