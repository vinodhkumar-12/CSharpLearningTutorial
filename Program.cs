public class Program
{

    public static void Main(string[] args)
    {

        Person obj_first_name = new Person();

        obj_first_name.Name = "Vinodh";


        Person obj_last_name = new Person();

        obj_last_name.Name = "Kumar";

        Person obj_full_name = new Person();

        obj_full_name = obj_first_name + obj_last_name;

        Console.WriteLine("Full name is {0}", obj_full_name.Name);
    }

}

public class Person
{
    public string Name { get; set; }

    public static Person operator +(Person obj_first_name, Person obj_last_name)
    {
        Person obj_full_name = new Person();

        obj_full_name.Name = obj_first_name.Name + " " + obj_last_name.Name;

        return obj_full_name;
    }
}

