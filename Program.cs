using System.Collections;

public class Program
{
    public static void Main(string[] args)
    {

        List<Employee> employees = new List<Employee>()
        {
            new Employee() { FirstName = "Vinodh", LastName = "Kumar", Age = 28 },
            new Employee() {  FirstName = "Vijay", LastName = "Kumar", Age = 26 },
             new Employee() {  FirstName = "Harish", LastName = "Lakshmanan", Age = 28 },
              new Employee() {  FirstName = "Vasanth", LastName = "Kumar", Age = 27 },
               new Employee() {  FirstName = "Naresh", LastName = "Pandi", Age = 28 }
        };

        //Employee hari_employee = employees.Where(x => x.FirstName == "Harish").FirstOrDefault();

        //employees.Remove(hari_employee);

        //employees.RemoveAt(1);

        //employees.RemoveRange(1, 2);

        employees.RemoveAll(x => x.Age == 28);

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