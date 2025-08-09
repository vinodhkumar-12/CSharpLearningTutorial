public class Program
{

    public static void Main(string[] args)
    {

        //Method Overloading
        Program p = new Program();

        int result_sum_of_two_numbers =  p.AddNumber(1, 2);
        int result_sum_of_three_numbers =  p.AddNumber(2, 3,4);

        Console.WriteLine(result_sum_of_two_numbers);
        Console.WriteLine(result_sum_of_three_numbers);

    }

    public int AddNumber(int num1, int num2)
    {
        return num1 + num2;
    }

    public int AddNumber(int num1, int num2, int num3)
    {
        return (num1 + num2) + num3;
    }

}

