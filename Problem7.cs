using System;

namespace Problem7
{
    class Programm
    {
        static void Main(string[] args)
        {
        	Console.WriteLine("Prime number: ");
        	int placeInt = Convert.ToInt32(Console.ReadLine());
        	int count = 0;
        	int place = 0;
        	int final = 0;
        	for(int i = 1; place < placeInt; i++)
        	{
        		for(int i2 = 1; i2 <= i; i2++)
        		{	
        			if(i % i2 == 0)
        			{
        				count++;
        				if (count == 2 & i == i2){
        					final = i;
        					count = 0;
        					place++;
        				}
        			}
        		}
        		count = 0;
        	}
        	Console.WriteLine(placeInt+"st prime number: " + final);
        }
    }
}