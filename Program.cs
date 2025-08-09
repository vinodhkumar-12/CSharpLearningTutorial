using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {


        Employee hari_employee = new Employee() { Age = 28, FirstName = "Harish", LastName = "Laskhmanan" };


        List<Employee> employees = new List<Employee>()
        {
            new Employee() { FirstName = "Vinodh", LastName = "Kumar", Age = 28 },
            new Employee() {  FirstName = "Vijay", LastName = "Kumar", Age = 26 }
        };

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.FirstName + " " + employee.LastName);
        }

        Console.WriteLine("Capacity is : " + employees.Capacity);
        Console.WriteLine("Count is : " + employees.Count);


        List<Employee> newemployees = new List<Employee>()
        {
            new Employee() { FirstName = "Vasanth", LastName = "Kumar", Age = 26 },
            new Employee() {FirstName = "Hari", LastName = "Vishal", Age = 26 },
            new Employee() { FirstName = "Soumya", LastName = "Prakash", Age = 26 }
        };

        Console.WriteLine("After new employees Added");

        employees.InsertRange(0, newemployees);


        employees.Insert(2, hari_employee);

        foreach (Employee employee in employees)
        {
            Console.WriteLine(employee.FirstName + " " + employee.LastName);
        }

    }
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
}