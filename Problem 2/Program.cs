using System;

namespace Problem_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumFibonacci = 0;
            int numA = 1, numB = 2, numC = 0;
            while(sumFibonacci <= 4000000)
            {
                numC = numA + numB;
                sumFibonacci += numA;
                numA = numB;
                numB = numC;
            }
            Console.Write(sumFibonacci);
            Console.ReadKey();
        }
    }
}
