using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("X value = ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Y value = ");
            y = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int[,] matrix = new int[x, y];
            for (int i = 0; i < x; i++)
            {
                for (int i2 = 0; i2< y; i2++) 
                {
                    matrix[i, i2] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for ( int i = 0; i < x; i++)
            {
                for(int i2 = 0; i2 < y; i2++)
                {
                    if (matrix[i,i2] == 0)
                    {
                        for(int i3 = 0; i3 < x; i3++)
                        {
                            matrix[i3, i2] = 0;
                        }
                    } else if (matrix[i,i2] != 0)
                    {
                        sum += matrix[i, i2];
                    }
                }
            }
            Console.WriteLine(sum);
        }   

    }
}