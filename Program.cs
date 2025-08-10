using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    public static void Main(string[] args)
    {
        //Console.BackgroundColor = ConsoleColor.Green;
        //Console.ForegroundColor = ConsoleColor.Blue;
        //Console.WriteLine(Days.Sunday);

        //Days day = Days.Sunday;

        Days day = (Days)1;

        int value = (int)day;

        Console.WriteLine(day + " " + value);

        Console.ReadLine();
    }

}

public enum Days
{
    Sunday,
    Monday,
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday
}
