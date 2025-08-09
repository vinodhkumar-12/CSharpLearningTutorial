public class Person
{
    public void show1()
    {
        Console.WriteLine("Person Class");
    }

}


public interface Employee
{
    public void show2();
}


public class Teacher : Person, Employee
{
    public void show3()
    {
        Console.WriteLine("Teacher Class");
    }

    public void show2()
    {
        Console.WriteLine("Employee Class");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Teacher teacher = new Teacher();
        teacher.show3();
        teacher.show1();
        teacher.show2();
    }
}




