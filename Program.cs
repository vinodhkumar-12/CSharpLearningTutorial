using System;
using System.Text;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text.Json;


public class Program
{
    public static void Main(string[] args)
    {
        string[] members = Enum.GetNames(typeof(Days));

        foreach (string member in members)
        {
            Console.WriteLine(member);
        }

        int[] values = (int[])Enum.GetValues(typeof(Days));

        foreach (int value in values)
        {
            Console.WriteLine(value);
        }

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
