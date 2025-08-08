public class Program
{
    public static void Main(string[] args)
    {

        //Multi - dimensional array

        int[,] array = new int[3, 4]
        {
            {11,22,33,44 },
            {55,66,77,88 },
            {99,11,22,33 }
        };

        //Console.WriteLine(array.GetLength(0));
        //Console.WriteLine(array.GetLength(1));

        //for(int i= 0; i < array.GetLength(0); i++)
        //{
        //    for(int j=0; j< array.GetLength(1);j++)
        //    {
        //        Console.Write(array[i, j] + " ");
        //    }

        //    Console.WriteLine();
        //}

        foreach (int i in array)
        {
            Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}