public class Program
{
    public static void Main(string[] args)
    {

        //Jagged array

        int[][] array = new int[3][];

        array[0] = new int[] { 1, 2, 3, 4 };
        array[1] = new int[] { 4, 5, 6, 7 };
        array[2] = new int[] { 8, 9, 0, 1 };

        for(int i=0; i<array.GetLength(0);i++)
        {
            for (int j = 0; j < array[i].Length;j++)
            {
                Console.Write(array[i][j] + " ");
            }

            Console.WriteLine();
        }

        

        Console.ReadLine();
    }
}