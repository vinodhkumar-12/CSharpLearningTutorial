public class Program
{
    public static void Main(string[] args)
    {
        int week_number = 10;

        switch(week_number)
        {
            case 0:
                Console.WriteLine("Week Day is Sunday");
                break;
            case 1:
                Console.WriteLine("Week Day is Monday");
                break;
            case 2:
                Console.WriteLine("Week Day is Tuesday");
                break;
            case 3:
                Console.WriteLine("Week Day is Wednesday");
                break;
            case 4:
                Console.WriteLine("Week Day is Thursday");
                break;
            case 5:
                Console.WriteLine("Week Day is Friday");
                break;
            case 6:
                Console.WriteLine("Week Day is Saturday");
                break;
            default:
                Console.WriteLine("No Week Day exists for the mentioned week number");
                break;
        }

    }
}