public class Program
{
   
    public static void Main(string[] args)
    {
        Person vinodh_detail = new Person("Vinodh", 28);
        Console.WriteLine("Entered name is {0}", vinodh_detail.GetName());
        Console.WriteLine("Entered Age is {0}", vinodh_detail.GetAge());
        Console.WriteLine("-----------------------");

        Person vijay_detail = new Person("Vijay", 26);
        Console.WriteLine("Entered name is {0}", vijay_detail.GetName());
        Console.WriteLine("Entered Age is {0}", vijay_detail.GetAge());
    }

    
}

public class Person
{
    private string Name { get; set; }
    private int Age { get; set; }

    public Person(string name, int age)
    {
        this.Name = name;
        this.Age = age;
    }

    public string GetName()
    {
        return this.Name;
    }

    public int GetAge()
    {
        return this.Age;
    }

    ~Person()
    {
        Console.WriteLine("Destructor Invoked");
    }

}