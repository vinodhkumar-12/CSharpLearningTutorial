public class Program
{

    public static void Main(string[] args)
    {
        Person person = new Person();

        person.SetId(1);
        person.SetName("Vinodh");


        Console.WriteLine(person.GetId() + " " + person.GetName());

    }


}

public class Person
{
    private int Id;
    private string Name;

    public int GetId()
    {
        return this.Id;
    }

    public string GetName()
    { 
        return this.Name; 
    }

    public void SetId(int Id)
    {
        this.Id = Id;
    }

    public void SetName(string name)
    {
        this.Name = name;
    }

}