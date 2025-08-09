public class DerivedClass : BaseClass
{

    public static void Main(string[] args)
    {

        //DerivedClass derivedClass = new DerivedClass();
        //derivedClass.show();

        //BaseClass baseClass = new BaseClass();
        //baseClass.show();

        BaseClass baseClass1 = new DerivedClass();
        baseClass1.show();
    }

    public override void show()
    {
        Console.WriteLine("Hello World from Derived Class itself!!!");
    }

}

public class BaseClass
{

    public virtual void show()
    {
        Console.WriteLine("Hello World from Base Class");
    }
}

