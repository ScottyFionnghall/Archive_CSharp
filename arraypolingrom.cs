using System;

namespace arraypolingrom
{
    class Programm
    {
        static void Main(string[] args)
        {
            string number = "9000009";
            int length = number.Length - 1;
            for (int i = 0; length - i >= i; i++)
            {   
                Console.WriteLine(i + " " + (length-i));
                if(number[i] == number[length-i]){
                    Console.WriteLine("Good");
                } else {
                    Console.WriteLine("Not Good");
                    break;
                }
            }
        }
    }
}