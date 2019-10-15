using System;

namespace fundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 to 255
            for(int i = 1; i <= 255; i++)
                Console.WriteLine(i);
            // prints all values from 1-100 that are divisible by 3 or 5, but not both
            for(int j = 1; j <= 100; j++)
                if((j % 3 == 0 || j % 5 == 0) && j % 15 != 0) 
                    System.Console.WriteLine(j);
            // FizzBuzz
            int fBN = 1;
            while(fBN <= 100)
            {
                if(fBN % 15 == 0)
                    Console.WriteLine("FizzBuzz");
                else if (fBN % 3 == 0) 
                    Console.WriteLine("Fizz");
                else if (fBN % 5 == 0)
                    Console.WriteLine("Buzz");
                fBN++;
            }
        }
    }
}
