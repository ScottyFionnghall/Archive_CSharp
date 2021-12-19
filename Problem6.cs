using System;

namespace Problem6
{
    class Programm
    {
        static void Main(string[] args)
        {
            int sumsqr = 0,sqrsum = 0;
            for(int i = 0; i <= 100; i++){
                sumsqr += i;
            } 
            Console.WriteLine(sumsqr);
            sumsqr = sumsqr * sumsqr;
            for (int i = 0; i <= 100;i++){
                sqrsum += i*i;
            }
            Console.WriteLine(sumsqr);
            Console.WriteLine(sqrsum);
            Console.WriteLine(sumsqr - sqrsum);
        }
    }
}