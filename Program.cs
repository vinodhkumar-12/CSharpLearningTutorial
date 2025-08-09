using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        Employee p = new Employee();
        p.Name = "Vinodh";
        p.Age = 28;

        Console.WriteLine("Name is : " + p.GetEmployeeName());
        Console.WriteLine("Age is : " + p.GetAge());
    }
}



public partial class Employee
{
    private string _name;
    private int _age;
}


public partial class Employee
{
    public string Name { get { return this._name; } set { this._name = value; } }
    public int Age { get { return this._age; } set { this._age = value; } }

    public string GetEmployeeName()
    {
        return this._name;
    }

    public int GetAge()
    {
        return this._age;
    }
}