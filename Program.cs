public class DerivedClass : BaseClass
{

    public sealed override void show()
    {
        Console.WriteLine("Hello World from Derived Class itself!!!");
    }

}

public class SubDerivedClass : DerivedClass
{
    //public override void show()
    //{
    //    Console.WriteLine("Hello World from Sub Derived Class itself!!!");
    //}
}

public class BaseClass
{

    public virtual void show()
    {
        Console.WriteLine("Hello World from Base Class");
    }
}


public class Progran
{
    public static void Main(string[] args)
    {
        BaseClass baseClass = new SubDerivedClass();
        baseClass.show();
    }
}

