public class DerivedClass : BaseClass
{

    public static void Main(string[] args)
    {

        DerivedClass derivedClass = new DerivedClass();

        derivedClass.show();
        derivedClass.Name = "Foo";

        Console.WriteLine(derivedClass.Name);
    }

}

public class BaseClass 
{
    public string Name { get; set; }
   
    public void show()
    {
        Console.WriteLine("Hello World");
    }
}

