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

public class BaseClass  //if class is mentioned sealed then it cannot be inherited by the Derived class or any other classes, since compiler will generate an error
{
    public string Name { get; set; }
   
    public void show()
    {
        Console.WriteLine("Hello World");
    }
}

