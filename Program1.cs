using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            int sum = 0;
            for (i = 1; i < 1000; i++)
            {
                if (i % 3 == 0)
                {
                    Console.WriteLine(i);
                    sum += i;
                } else if (i % 5 == 0)
                {
                    sum += i;
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine(sum);
        }
    }
}