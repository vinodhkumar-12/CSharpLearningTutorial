using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {
        Hashtable hashtable = new Hashtable();
        hashtable.Add("Id", 1);
        hashtable.Add("FirstName", "Vinodh");
        hashtable.Add("LastName", "Kumar");
        hashtable.Add("Age", 28);
        // hashtable.Add("Age", 28); same key should not be mentioned more than one in hash table


        hashtable.Remove("Age");

        bool isLastNameExists = hashtable.Contains("LastName");

        foreach (string key in hashtable.Keys)
        {
            Console.WriteLine(key + " " + hashtable[key]);
        }


        Console.WriteLine(isLastNameExists);
        Console.WriteLine(hashtable.GetHashCode());


    }
}




