using System;

namespace Fibonacci
{
    class Program
    {
        static int fibo(int n)
        {
            if ( n <= 1)
            {
                return n;
            }
            else {
                return fibo(n-1) + fibo (n-2);
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.WriteLine("index - " + i + "\t value = " + fibo(i));
            }
        }
    }
}