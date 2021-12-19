using System;

namespace Test2
{
    class Programm
    {
        static void Main(string[] args)
        {
            int final = 0, number;
            bool checking = false;
            string numberStr;
            for (int count = 1; count <= 999; count++)
            {
                for (int count2 = 1; count2 <= 999; count2++)
                {
                    number = count * count2;
                    numberStr = number.ToString();
                    int length = numberStr.Length - 1;
                    for (int i = 0; length - i >= i; i++)
                    {
                        if (numberStr[i] == numberStr[length - i])
                        {
                            checking = true;
                        }
                        else
                        {
                            checking = false;
                            break;
                        }
                    }
                    final = number;
                }
                if (checking)
                {
                    Console.WriteLine(final + " " + count + ":" + count2);
                }
            }
        }
    }
}
