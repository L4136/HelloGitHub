using System;
class Program
{
    static void Main()
    {
        int i;
        int[] points = new int[30];
        int n = 5;
        for (i = 1; i <= n; i++)
        {
            Console.Write("Enter the points:");
             
            points[i] = Convert.ToInt16(Console.ReadLine());
        }
        for (i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - 1; j++)
            {
                if (points[j] > points[j + 1])
                {
                    int temp = points[j];
                    points[j] = points[j + 1];
                    points[j + 1] = temp;
                }
            }
        }
        /* //Display the Ascending values one by one  
         Console.Write("Ascending Sort : ");
         for (i = 1; i <= n; i++)
         {
             Console.Write(points[i] + " ");
         }
         */
        Console.WriteLine("Total score is:" + (points[2] + points[3] + points[4]) + ".");
    }
}