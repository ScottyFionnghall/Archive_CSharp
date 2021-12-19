using System;

namespace test
{
    class TestofTest
    {
        static void Main(string[] args)
        {   
            long n = 600851475143; 
            int factor = 0;
            double maxfactor = 0;
            int lastFactor = 0;
            if (n % 2 == 0){
                lastFactor = 2;
                n = n / 2;
                while(n % 2 == 0)
                {
                    n = n % 2;
                } 
            } else {
                lastFactor = 1;
            } 
            factor = 3;
            maxfactor = Math.Sqrt(n);
            while (n > 1 & factor <= maxfactor){
                if(n % factor == 0){
                    n = n / factor;
                    lastFactor = factor;
                    while(n % factor == 0)
                    {
                        n = n / factor;
                    } maxfactor = Math.Sqrt(n);
                } factor = factor + 2;
            }
            if (n == 1)
            {
                Console.WriteLine(lastFactor);
            } else {
                Console.WriteLine(n);
            }
        }   
    }
}
