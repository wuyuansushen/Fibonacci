using System;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int input = Convert.ToInt32(Console.ReadLine());
            int Result=FibonacciSum(input);
            Console.WriteLine($"{Result}");
        }

        static int FibonacciSum(int i)
        {
            if (i == 1)
                return 1;
            else if (i == 0)
                return 0;
            else
                return FibonacciSum(i - 1)+FibonacciSum(i-2);
        }
    }
}
